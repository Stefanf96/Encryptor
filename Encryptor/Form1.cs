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
        private bool isEncrypted;
        private string saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string documentName;
        private static string documentContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = saveLocation;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Encryption.DecryptFile(fileDialog.FileName);
            }
        }

        private void SaveDocument_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = DocumentNameBox.Text;
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Encryption.SaveFile(saveFileDialog.FileName, ContentDocument.Text, Encrypted.Checked);
            }
        }
    }
}