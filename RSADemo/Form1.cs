
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSADemo
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(2048);
        }

        private void btnLoadPlainText_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt";
                ofd.Title = "選擇純文字檔作為明文";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                        txtInput.Text = content;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("讀取檔案失敗：" + ex.Message);
                    }
                }
            }
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(txtInput.Text);
                byte[] encrypted = rsa.Encrypt(dataToEncrypt, false);
                txtEncrypted.Text = Convert.ToBase64String(encrypted);
            }
            catch (Exception ex)
            {
                MessageBox.Show("加密失敗：" + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dataToDecrypt = Convert.FromBase64String(txtEncrypted.Text);
                byte[] decrypted = rsa.Decrypt(dataToDecrypt, false);
                txtDecrypted.Text = Encoding.UTF8.GetString(decrypted);
            }
            catch (Exception ex)
            {
                MessageBox.Show("解密失敗：" + ex.Message);
            }
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText("publicKey.xml", rsa.ToXmlString(false));
            File.WriteAllText("privateKey.xml", rsa.ToXmlString(true));
            MessageBox.Show("金鑰已儲存");
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            if (File.Exists("privateKey.xml"))
            {
                rsa.FromXmlString(File.ReadAllText("privateKey.xml"));
                MessageBox.Show("私鑰已載入");
            }
            else
            {
                MessageBox.Show("找不到私鑰檔案");
            }
        }

        private void btnSaveEncrypted_Click(object sender, EventArgs e)
        {
            File.WriteAllText("encrypted.txt", txtEncrypted.Text);
            MessageBox.Show("加密訊息已儲存");
        }

        private void btnShowKeys_Click(object sender, EventArgs e)
        {
            txtPublicKey.Text = rsa.ToXmlString(false);
            txtPrivateKey.Text = rsa.ToXmlString(true);
        }
    }
}
