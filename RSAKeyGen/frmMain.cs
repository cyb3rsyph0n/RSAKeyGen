using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace RSAKeyGen
{
    public partial class frmMain : Form
    {
        private BackgroundWorker tmpWorker = null;

        public frmMain()
        {
            InitializeComponent();

            tmpWorker = new BackgroundWorker();
            tmpWorker.DoWork += new DoWorkEventHandler(tmpWorker_DoWork);
            tmpWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(tmpWorker_RunWorkerCompleted);
        }

        private void TestFunc()
        {
            RSACryptoServiceProvider tmpEnc = new RSACryptoServiceProvider();
            RSACryptoServiceProvider tmpDec = new RSACryptoServiceProvider();

            //IMPORT THE PUBLIC AND PRIVATE KEY
            tmpEnc.ImportCspBlob(System.Convert.FromBase64String(txtPublic.Text));
            tmpDec.ImportCspBlob(System.Convert.FromBase64String(txtPrivate.Text));

            //ENCRYPTE THE TEXT AND DECRYPT IT USING PUBLIC AND PRIVATE KEY
            string original = txtSample.Text;
            string encrypted = System.Convert.ToBase64String(tmpEnc.Encrypt(System.Text.ASCIIEncoding.ASCII.GetBytes(original), false));
            string decrypted = System.Text.ASCIIEncoding.ASCII.GetString(tmpDec.Decrypt(System.Convert.FromBase64String(encrypted), false));

            //DISPLAY THE OUTPUT TO THE USER
            txtTest.Text = string.Format("Original: {0}\n\nEncrypted: {1}\n\nDecrypted: {2}", original, encrypted, decrypted);
        }

        private void TestFunc2()
        {
            RSACryptoServiceProvider tmpSign = new RSACryptoServiceProvider();
            RSACryptoServiceProvider tmpVerify = new RSACryptoServiceProvider();
            SHA1 tmpSHA = SHA1.Create();

            //IMPORT THE PUBLIC AND PRIVATE KEY
            tmpSign.ImportCspBlob(System.Convert.FromBase64String(txtPrivate.Text));
            tmpVerify.ImportCspBlob(System.Convert.FromBase64String(txtPublic.Text));

            //VERIFY THE SIGNATURE OF THE DATA USING THE KEYS
            string original = txtSample.Text;
            string signature = System.Convert.ToBase64String(tmpSign.SignData(System.Text.ASCIIEncoding.ASCII.GetBytes(original), tmpSHA));
            bool verified = tmpVerify.VerifyData(System.Text.ASCIIEncoding.ASCII.GetBytes(original), tmpSHA, System.Convert.FromBase64String(signature));

            //DISPLAY THE OUTPUT TO THE USER
            txtTest.Text += string.Format("\n\nSignature: {0}\n\nVerified: {1}", signature, verified.ToString());
        }

        private void txtSample_KeyUp(object sender, KeyEventArgs e)
        {
            //IF THERE IS TEXT THEN UPDATE THE PREVIEW PANE
            if (!String.IsNullOrEmpty(txtPublic.Text))
            {
                TestFunc();
                TestFunc2();
            }
        }

        private void lstKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LOCK THE GUI SO THE USER CAN NOT CHANGE ANYTHING
            lstKeySize.Enabled = false;
            txtSample.Enabled = false;
            progressWorker.Visible = true;
            lblStatus.Visible = true;

            //START GENERATING AN RSA KEY
            tmpWorker.RunWorkerAsync(lstKeySize.Text);
        }

        void tmpWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //GENERATE A NEW RSA KEY USING THE SIZE PASSED IN
            RSACryptoServiceProvider tmpRSA = new RSACryptoServiceProvider(int.Parse((string)e.Argument));

            //RETURN THE RESULT TO THE COMPLETED CALL
            e.Result = tmpRSA;
        }

        void tmpWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RSACryptoServiceProvider tmpRSA = (RSACryptoServiceProvider)e.Result;
            
            //CONVERT THE PASSED IN RSA INTO A CSP BLOB FORMATTED IN BASE 64 SO WE CAN USE THE KEY
            txtPublic.Text = System.Convert.ToBase64String(tmpRSA.ExportCspBlob(false));
            txtPrivate.Text = System.Convert.ToBase64String(tmpRSA.ExportCspBlob(true));

            //REACTIVATE THE GUI
            lstKeySize.Enabled = true;
            txtSample.Enabled = true;
            progressWorker.Visible = false;
            lblStatus.Visible = false;

            //CALL THE TEST FUNCTIONS SO THE USER CAN SEE THE SIZE OF DATA GENERATED FROM THE KEY
            TestFunc();
            TestFunc2();
        }
    }
}