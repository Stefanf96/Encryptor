
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
            this.Title = new System.Windows.Forms.Label();
            this.OpenDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDocument
            // 
            this.CreateDocument.Location = new System.Drawing.Point(232, 452);
            this.CreateDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateDocument.Name = "CreateDocument";
            this.CreateDocument.Size = new System.Drawing.Size(175, 83);
            this.CreateDocument.TabIndex = 0;
            this.CreateDocument.Text = "Create Document";
            this.CreateDocument.UseVisualStyleBackColor = true;
            this.CreateDocument.Click += new System.EventHandler(this.CreateDocument_Click);
            // 
            // Encrypted
            // 
            this.Encrypted.AutoSize = true;
            this.Encrypted.Location = new System.Drawing.Point(171, 405);
            this.Encrypted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(97, 24);
            this.Encrypted.TabIndex = 1;
            this.Encrypted.Text = "Encrypted";
            this.Encrypted.UseVisualStyleBackColor = true;
            // 
            // ContentDocument
            // 
            this.ContentDocument.Location = new System.Drawing.Point(167, 200);
            this.ContentDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentDocument.Multiline = true;
            this.ContentDocument.Name = "ContentDocument";
            this.ContentDocument.Size = new System.Drawing.Size(540, 181);
            this.ContentDocument.TabIndex = 2;
            // 
            // DocumentNameBox
            // 
            this.DocumentNameBox.Location = new System.Drawing.Point(167, 121);
            this.DocumentNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocumentNameBox.Name = "DocumentNameBox";
            this.DocumentNameBox.Size = new System.Drawing.Size(540, 27);
            this.DocumentNameBox.TabIndex = 3;
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.Location = new System.Drawing.Point(161, 168);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(46, 28);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "Text";
            // 
            // DocumentNameLabel
            // 
            this.DocumentNameLabel.AutoSize = true;
            this.DocumentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentNameLabel.Location = new System.Drawing.Point(161, 84);
            this.DocumentNameLabel.Name = "DocumentNameLabel";
            this.DocumentNameLabel.Size = new System.Drawing.Size(160, 28);
            this.DocumentNameLabel.TabIndex = 5;
            this.DocumentNameLabel.Text = "Document Name";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(160, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(162, 36);
            this.Title.TabIndex = 6;
            this.Title.Text = "Encryptor";
            // 
            // OpenDocument
            // 
            this.OpenDocument.Location = new System.Drawing.Point(483, 452);
            this.OpenDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenDocument.Name = "OpenDocument";
            this.OpenDocument.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenDocument.Size = new System.Drawing.Size(175, 83);
            this.OpenDocument.TabIndex = 8;
            this.OpenDocument.Text = "Open Documents";
            this.OpenDocument.UseVisualStyleBackColor = true;
            this.OpenDocument.Click += new System.EventHandler(this.OpenDocument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.OpenDocument);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DocumentNameLabel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.DocumentNameBox);
            this.Controls.Add(this.ContentDocument);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.CreateDocument);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button OpenDocument;
    }
}

