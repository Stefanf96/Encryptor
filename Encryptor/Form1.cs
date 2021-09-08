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
        private bool IsEncrypted;
        private string SaveLocation = @"D:\Documenten\Visual Studio\Test Files\";
        private string dataType = ".txt";

        private static string documentName;
        private static string documentContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = SaveLocation;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Encryption.DecryptFile(fileDialog.FileName);
            }
        }

        private void CreateDocument_Click(object sender, EventArgs e)
        {
            documentName = DocumentNameBox.Text;
            IsEncrypted = Encrypted.Checked;
            if (IsEncrypted)
            {
                documentContent = Encryption.Encrypt(ContentDocument.Text);
            }
            else
            {
                documentContent = ContentDocument.Text;
            }

            Encryption.TextCreator(SaveLocation, documentName, dataType, documentContent);
        }
    }
}