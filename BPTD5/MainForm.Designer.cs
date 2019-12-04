namespace BPTD5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.SignatureTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadKey = new System.Windows.Forms.Button();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.SaveSignatureToFile = new System.Windows.Forms.Button();
            this.VerifySignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 67);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(576, 358);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть текст або";
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(203, 34);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(192, 28);
            this.LoadFromFileButton.TabIndex = 2;
            this.LoadFromFileButton.Text = "Завантажити з файлу";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
            // 
            // SignatureTextBox
            // 
            this.SignatureTextBox.Location = new System.Drawing.Point(669, 68);
            this.SignatureTextBox.Name = "SignatureTextBox";
            this.SignatureTextBox.Size = new System.Drawing.Size(431, 96);
            this.SignatureTextBox.TabIndex = 3;
            this.SignatureTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(664, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Підпис";
            // 
            // LoadKey
            // 
            this.LoadKey.Location = new System.Drawing.Point(744, 31);
            this.LoadKey.Name = "LoadKey";
            this.LoadKey.Size = new System.Drawing.Size(184, 31);
            this.LoadKey.TabIndex = 5;
            this.LoadKey.Text = "Завантажити з файлу";
            this.LoadKey.UseVisualStyleBackColor = true;
            this.LoadKey.Click += new System.EventHandler(this.LoadKey_Click);
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Location = new System.Drawing.Point(430, 33);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(158, 28);
            this.GenerateKeyButton.TabIndex = 6;
            this.GenerateKeyButton.Text = "Згенерувати підпис";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // SaveSignatureToFile
            // 
            this.SaveSignatureToFile.Location = new System.Drawing.Point(934, 31);
            this.SaveSignatureToFile.Name = "SaveSignatureToFile";
            this.SaveSignatureToFile.Size = new System.Drawing.Size(166, 31);
            this.SaveSignatureToFile.TabIndex = 7;
            this.SaveSignatureToFile.Text = "Зберегти в файл";
            this.SaveSignatureToFile.UseVisualStyleBackColor = true;
            this.SaveSignatureToFile.Click += new System.EventHandler(this.SaveSignatureToFile_Click);
            // 
            // VerifySignButton
            // 
            this.VerifySignButton.Location = new System.Drawing.Point(193, 431);
            this.VerifySignButton.Name = "VerifySignButton";
            this.VerifySignButton.Size = new System.Drawing.Size(192, 73);
            this.VerifySignButton.TabIndex = 8;
            this.VerifySignButton.Text = "Перевірити підпис";
            this.VerifySignButton.UseVisualStyleBackColor = true;
            this.VerifySignButton.Click += new System.EventHandler(this.VerifySignButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 515);
            this.Controls.Add(this.VerifySignButton);
            this.Controls.Add(this.SaveSignatureToFile);
            this.Controls.Add(this.GenerateKeyButton);
            this.Controls.Add(this.LoadKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignatureTextBox);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "MainForm";
            this.Text = "DSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.RichTextBox SignatureTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadKey;
        private System.Windows.Forms.Button GenerateKeyButton;
        private System.Windows.Forms.Button SaveSignatureToFile;
        private System.Windows.Forms.Button VerifySignButton;
    }
}

