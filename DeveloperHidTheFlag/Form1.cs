using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperHidTheFlag
{
    public partial class Form1 : Form
    {
        private object txtUsername;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncheckUnPw_Click(object sender, EventArgs e)
        {
            if (this.txtusername.Text == "RaMBo")
            {
                string pwField = EncryptDecrypt(txtpassword.Text, szEncryptionKey: 7);

                if (pwField == "trwbuXtbdubsXwfttphuc")
                {
                    MessageBox.Show(text: ("The flag is :" + EncryptDecrypt(szPlainText: "kbstXb\u007fwkhns|0O6tX6#X~hrUXaK31z", szEncryptionKey: 7)));
                }
                else
                {
                    MessageBox.Show(text: ("Correct Username but Wrong Answer!!!"));
                }
            }
            else
            {
                MessageBox.Show(text: "Incorrect Username!! Try Again!!");
            }
        }
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
    }
}
