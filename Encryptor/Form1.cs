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
    public partial class Form1 : Form
    {
        StreamWriter file;
        private string documentName;
        private string documentContent;
        private bool IsEncrypted;
        private string key = @"sblw-3hn8-sqoy19";
        private string SaveLocation = @"D:\Documenten\Test Files\";
        private string dataType = '.txt';-
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDocument_Click(object sender, EventArgs e)
        {
            documentName = DocumentNameBox.Text;
            IsEncrypted = Encrypted.Checked;
            if (IsEncrypted)
            {
                MessageBox.Show(IsEncrypted.ToString());
                documentContent = Encrypt(ContentDocument.Text, key);
            }
            else
            {
                documentContent = ContentDocument.Text;
            }
            
             TextCreator(documentName, documentContent);
        }
        private void TextCreator(string name, string content) {
            try
            {
                string fullPath = SaveLocation+name+dataType;
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
            catch(Exception e) {
                MessageBox.Show("Exception: " + e.Message);
            }
            

        }
        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
