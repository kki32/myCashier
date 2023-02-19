using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_SAHAKORN
{
    public partial class Authentication : Form
    {
        private string type;
        public Authentication(string type)
        {
            InitializeComponent();
            this.type = type;
        }



        private void authenticate_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text.Equals(InfoManager.PASSWORD) || passwordTextbox.Text.Equals(InfoManager.PASSWORD_CAT))
            {
                if(type == "signbookPage")
                {
                    InfoManager.authenticateSignbook = true;
                } else if(type == "cashbookPage")
                {
                    InfoManager.authenticateCashbook = true;
                }
                else
                {
                    InfoManager.authenticate = true;
                }
              
                this.Close();
            }
            else
            {
                MessageBox.Show("password ไม่ถูกต้อง", "invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }
    }
}
