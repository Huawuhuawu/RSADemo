namespace RSADemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelEncrypted;
        private System.Windows.Forms.Label labelDecrypted;
        private System.Windows.Forms.Label labelPubKey;
        private System.Windows.Forms.Label labelPrivKey;

        private System.Windows.Forms.Button btnLoadPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.Button btnSaveEncrypted;
        private System.Windows.Forms.Button btnShowKeys;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.labelEncrypted = new System.Windows.Forms.Label();
            this.labelDecrypted = new System.Windows.Forms.Label();
            this.labelPubKey = new System.Windows.Forms.Label();
            this.labelPrivKey = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.btnSaveEncrypted = new System.Windows.Forms.Button();
            this.btnShowKeys = new System.Windows.Forms.Button();
            this.btnLoadPlainText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.Location = new System.Drawing.Point(20, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(120, 20);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "原始輸入文字";
            // 
            // labelEncrypted
            // 
            this.labelEncrypted.Location = new System.Drawing.Point(20, 60);
            this.labelEncrypted.Name = "labelEncrypted";
            this.labelEncrypted.Size = new System.Drawing.Size(150, 20);
            this.labelEncrypted.TabIndex = 2;
            this.labelEncrypted.Text = "加密結果 (Base64)";
            // 
            // labelDecrypted
            // 
            this.labelDecrypted.Location = new System.Drawing.Point(20, 130);
            this.labelDecrypted.Name = "labelDecrypted";
            this.labelDecrypted.Size = new System.Drawing.Size(120, 20);
            this.labelDecrypted.TabIndex = 4;
            this.labelDecrypted.Text = "解密後的文字";
            // 
            // labelPubKey
            // 
            this.labelPubKey.Location = new System.Drawing.Point(20, 210);
            this.labelPubKey.Name = "labelPubKey";
            this.labelPubKey.Size = new System.Drawing.Size(150, 20);
            this.labelPubKey.TabIndex = 6;
            this.labelPubKey.Text = "公開金鑰 (XML)";
            // 
            // labelPrivKey
            // 
            this.labelPrivKey.Location = new System.Drawing.Point(20, 300);
            this.labelPrivKey.Name = "labelPrivKey";
            this.labelPrivKey.Size = new System.Drawing.Size(150, 20);
            this.labelPrivKey.TabIndex = 8;
            this.labelPrivKey.Text = "私密金鑰 (XML)";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 40);
            this.txtInput.TabIndex = 1;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(20, 80);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(400, 40);
            this.txtEncrypted.TabIndex = 3;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(20, 150);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(400, 40);
            this.txtDecrypted.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(20, 230);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(400, 60);
            this.txtPublicKey.TabIndex = 7;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(20, 320);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(400, 60);
            this.txtPrivateKey.TabIndex = 9;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(440, 109);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(525, 109);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(440, 267);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(75, 23);
            this.btnSaveKey.TabIndex = 12;
            this.btnSaveKey.Text = "儲存金鑰";
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(525, 267);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(75, 23);
            this.btnLoadKey.TabIndex = 13;
            this.btnLoadKey.Text = "載入金鑰";
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // btnSaveEncrypted
            // 
            this.btnSaveEncrypted.Location = new System.Drawing.Point(440, 300);
            this.btnSaveEncrypted.Name = "btnSaveEncrypted";
            this.btnSaveEncrypted.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEncrypted.TabIndex = 14;
            this.btnSaveEncrypted.Text = "儲存加密";
            this.btnSaveEncrypted.Click += new System.EventHandler(this.btnSaveEncrypted_Click);
            // 
            // btnShowKeys
            // 
            this.btnShowKeys.Location = new System.Drawing.Point(525, 300);
            this.btnShowKeys.Name = "btnShowKeys";
            this.btnShowKeys.Size = new System.Drawing.Size(75, 23);
            this.btnShowKeys.TabIndex = 15;
            this.btnShowKeys.Text = "顯示金鑰";
            this.btnShowKeys.Click += new System.EventHandler(this.btnShowKeys_Click);
            // 
            // btnLoadPlainText
            // 
            this.btnLoadPlainText.Location = new System.Drawing.Point(459, 20);
            this.btnLoadPlainText.Name = "btnLoadPlainText";
            this.btnLoadPlainText.Size = new System.Drawing.Size(120, 30);
            this.btnLoadPlainText.TabIndex = 16;
            this.btnLoadPlainText.Text = "讀取文字檔";
            this.btnLoadPlainText.Click += new System.EventHandler(this.btnLoadPlainText_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelEncrypted);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.labelDecrypted);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.labelPubKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.labelPrivKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.btnLoadKey);
            this.Controls.Add(this.btnSaveEncrypted);
            this.Controls.Add(this.btnShowKeys);
            this.Controls.Add(this.btnLoadPlainText);
            this.Name = "Form1";
            this.Text = "RSA 加解密 WinForm Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
