namespace Crypto
{
    partial class CryptoCyphers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encrypt = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Encrypted = new System.Windows.Forms.TextBox();
            this.Decrypted = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CyphersBox = new System.Windows.Forms.ComboBox();
            this.Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(99, 126);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(24, 51);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(247, 69);
            this.Message.TabIndex = 1;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(292, 51);
            this.Key.Multiline = true;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(223, 31);
            this.Key.TabIndex = 2;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(24, 155);
            this.Encrypted.Multiline = true;
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(247, 69);
            this.Encrypted.TabIndex = 3;
            this.Encrypted.TextChanged += new System.EventHandler(this.Encrypted_TextChanged);
            // 
            // Decrypted
            // 
            this.Decrypted.Location = new System.Drawing.Point(24, 304);
            this.Decrypted.Multiline = true;
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(491, 136);
            this.Decrypted.TabIndex = 4;
            this.Decrypted.TextChanged += new System.EventHandler(this.Decrypted_TextChanged);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(51, 237);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 5;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(440, 155);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(440, 201);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(366, 114);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CyphersBox
            // 
            this.CyphersBox.FormattingEnabled = true;
            this.CyphersBox.Items.AddRange(new object[] {
            "Caesar",
            "Vizhener"});
            this.CyphersBox.Location = new System.Drawing.Point(86, 12);
            this.CyphersBox.Name = "CyphersBox";
            this.CyphersBox.Size = new System.Drawing.Size(135, 21);
            this.CyphersBox.TabIndex = 9;
            this.CyphersBox.SelectedIndexChanged += new System.EventHandler(this.CyphersBox_SelectedIndexChanged);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(173, 237);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(75, 23);
            this.Decode.TabIndex = 10;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // CryptoCyphers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 452);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.CyphersBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Decrypted);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Encrypt);
            this.Name = "CryptoCyphers";
            this.Text = "Cyphers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox Encrypted;
        private System.Windows.Forms.TextBox Decrypted;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox CyphersBox;
        private System.Windows.Forms.Button Decode;
    }
}

