using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPTD5
{
    public partial class MainForm : Form
    {

        private DSAParameters _privateKey;
        private DSAParameters _publicKey;
        public string Message { get; set; }

        private byte[] hash;
        private byte[] signedHash;
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = openFileDialog.FileName;
            Message = System.IO.File.ReadAllText(filePath);
            MessageTextBox.Text = Message;
        }


        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            using (var dsa = new DSACryptoServiceProvider())
            {
                _privateKey = dsa.ExportParameters(true);
                _publicKey = dsa.ExportParameters(false);
            }
            Message = MessageTextBox.Text;
            byte[] byteMessage = Encoding.UTF8.GetBytes(Message);
            hash = (new SHA1Managed()).ComputeHash(byteMessage);
            signedHash = DsaSignHash(hash, _privateKey, "SHA1");
            var stringBuilder = new StringBuilder();
            foreach (byte t in signedHash)
            {
                stringBuilder.Append(t.ToString("x2"));
            }

            SignatureTextBox.Text = stringBuilder.ToString();


        }

        private byte[] DsaSignHash(byte[] hash, DSAParameters dsaKey, string hashAlg)
        {
            byte[] signature = null;

            try
            {
                using (var dsa = new DSACryptoServiceProvider())
                {
                    dsa.ImportParameters(dsaKey);
                    var dsaFormatter = new DSASignatureFormatter(dsa);
                    dsaFormatter.SetHashAlgorithm(hashAlg);
                    signature = dsaFormatter.CreateSignature(hash);
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
            }

            return signature;
        }

        private void VerifySignButton_Click(object sender, EventArgs e)
        {
            Message = MessageTextBox.Text;
            byte[] byteMessage = Encoding.UTF8.GetBytes(Message);
            hash = (new SHA1Managed()).ComputeHash(byteMessage);
            string currentSignature = SignatureTextBox.Text;
            byte[] currentSignatureByte = StringToByteArray(currentSignature);
            
            var verified = DsaVerifyHash(hash, currentSignatureByte, _publicKey, "SHA1");
            MessageBox.Show(verified ? "Підпис дійсний!" : "Підпис недійсний!");
        }

        private bool DsaVerifyHash(byte[] hashValue, byte[] signedHashValue, DSAParameters dsaKey, string hashAlg)
        {
            var verified = false;
            try
            {
                using (var dsa = new DSACryptoServiceProvider())
                {
                    dsa.ImportParameters(dsaKey);
                    var dsaDeformatter = new DSASignatureDeformatter(dsa);
                    dsaDeformatter.SetHashAlgorithm(hashAlg);
                    verified = dsaDeformatter.VerifySignature(hashValue, signedHashValue);
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
            }
            return verified;
        }

        private byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void SaveSignatureToFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            var filePath = saveFileDialog.FileName;

            try
            {
                string currentSignature = SignatureTextBox.Text;
                byte[] currentSignatureByte = StringToByteArray(currentSignature);
                //var publicKEY_Dialog = new SaveFileDialog { FileName = _fileName };
                File.WriteAllBytes(filePath, currentSignatureByte);
            }
            catch
            {
                MessageBox.Show(@"Помилка при записы в файл", @"Можливо файл використовуэться системою", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadKey_Click(object sender, EventArgs e)
        {
            string filePath = "";
            var loadFileDialog = new OpenFileDialog();
            loadFileDialog.ShowDialog();
            if (loadFileDialog.FileName != null)
            {
                filePath = loadFileDialog.FileName;
            }
            signedHash = File.ReadAllBytes(filePath);
            var sBuilder = new StringBuilder();
            foreach (byte t in signedHash)
            {
                sBuilder.Append(t.ToString("x2"));
            }

            SignatureTextBox.Text = sBuilder.ToString();
        }
    }
}
