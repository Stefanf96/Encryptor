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


namespace Encryptor
{
    public partial class Form1 : Form
    {
        private string documentName;
        private string documentContent;
        private bool IsEncrypted;
        private string key = "sblw-3hn8-sqoy19";
   /*     private string SaveLocation = "C:\\Users\\Stefan\\Desktop";*/

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDocument_Click(object sender, EventArgs e)
        {
            documentName = DocumentNameBox.Text;
            Encrypted.Checked = IsEncrypted;
            if (IsEncrypted)
            {
                documentContent = Encrypt(ContentDocument.Text, key);
            }
            else
            {
                documentContent = ContentDocument.Text;
            }
            
            TextCreator(documentName, documentContent);
        }
        public static async Task TextCreator(string name,  string content) {
            await File.WriteAllTextAsync(name + ".txt", content);
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
