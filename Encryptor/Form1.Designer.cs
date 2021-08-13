
namespace Encryptor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDocument = new System.Windows.Forms.Button();
            this.Encrypted = new System.Windows.Forms.CheckBox();
            this.ContentDocument = new System.Windows.Forms.TextBox();
            this.DocumentNameBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.Label();
            this.DocumentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateDocument
            // 
            this.CreateDocument.Location = new System.Drawing.Point(306, 339);
            this.CreateDocument.Name = "CreateDocument";
            this.CreateDocument.Size = new System.Drawing.Size(153, 62);
            this.CreateDocument.TabIndex = 0;
            this.CreateDocument.Text = "Create Document";
            this.CreateDocument.UseVisualStyleBackColor = true;
            this.CreateDocument.Click += new System.EventHandler(this.CreateDocument_Click);
            // 
            // Encrypted
            // 
            this.Encrypted.AutoSize = true;
            this.Encrypted.Location = new System.Drawing.Point(150, 304);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(79, 19);
            this.Encrypted.TabIndex = 1;
            this.Encrypted.Text = "Encrypted";
            this.Encrypted.UseVisualStyleBackColor = true;
            // 
            // ContentDocument
            // 
            this.ContentDocument.Location = new System.Drawing.Point(146, 150);
            this.ContentDocument.Multiline = true;
            this.ContentDocument.Name = "ContentDocument";
            this.ContentDocument.Size = new System.Drawing.Size(473, 137);
            this.ContentDocument.TabIndex = 2;
            // 
            // DocumentNameBox
            // 
            this.DocumentNameBox.Location = new System.Drawing.Point(146, 91);
            this.DocumentNameBox.Name = "DocumentNameBox";
            this.DocumentNameBox.Size = new System.Drawing.Size(473, 23);
            this.DocumentNameBox.TabIndex = 3;
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.Location = new System.Drawing.Point(141, 126);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(36, 21);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "Text";
            // 
            // DocumentName
            // 
            this.DocumentNameLabel.AutoSize = true;
            this.DocumentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentNameLabel.Location = new System.Drawing.Point(141, 63);
            this.DocumentNameLabel.Name = "DocumentName";
            this.DocumentNameLabel.Size = new System.Drawing.Size(128, 21);
            this.DocumentNameLabel.TabIndex = 5;
            this.DocumentNameLabel.Text = "Document Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encryptor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentNameLabel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.DocumentNameBox);
            this.Controls.Add(this.ContentDocument);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.CreateDocument);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDocument;
        private System.Windows.Forms.CheckBox Encrypted;
        private System.Windows.Forms.TextBox ContentDocument;
        private System.Windows.Forms.TextBox DocumentNameBox;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Label DocumentNameLabel;
        private System.Windows.Forms.Label label1;
    }
}

