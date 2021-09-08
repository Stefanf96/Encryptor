using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Encryptor
{
    public class Encryption
    {
        private static readonly string securityKey = @"sblw-3hn8-sqoy19";

        public static void TextCreator(string savelocation, string filename, string datatype, string content)
        {
            try
            {
                string fullPath = savelocation + filename + datatype;
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    // Add some text to file
                    writer.WriteLine(content);
                }
                if (File.Exists(fullPath))
                {
                    var process = Process.Start("notepad.exe", fullPath);
                    process.WaitForInputIdle();
                    var handle = process.MainWindowHandle;

                    // if the window is still in the foreground
                    SendKeys.SendWait("^(s)"); // Ctrl+S
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        public static void DecryptFile(string fullpath)
        {
            try
            {
                string text = File.ReadAllText(fullpath);
                string decryptedContent = Encryption.Decrypt(text);
                using (StreamWriter writer = new StreamWriter(fullpath))
                {
                    // Add some text to file
                    writer.WriteLine(decryptedContent);
                }
                if (File.Exists(fullpath))
                {
                    var process = Process.Start("notepad.exe", fullpath);
                    process.WaitForInputIdle();
                    var handle = process.MainWindowHandle;

                    // if the window is still in the foreground
                    SendKeys.SendWait("^(s)"); // Ctrl+S
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        public static string Encrypt(string input)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(securityKey);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string textInput)
        {
            byte[] inputArray = Convert.FromBase64String(textInput);
            var TripleDESCryptoService = new TripleDESCryptoServiceProvider();
            TripleDESCryptoService.Key = UTF8Encoding.UTF8.GetBytes(securityKey);
            TripleDESCryptoService.Mode = CipherMode.ECB;
            TripleDESCryptoService.Padding = PaddingMode.PKCS7;
            var CrytpoTransform = TripleDESCryptoService.CreateDecryptor();
            byte[] resultArray = CrytpoTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            TripleDESCryptoService.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}