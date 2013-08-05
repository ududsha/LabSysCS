using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LabSysCS.DataAccess;

namespace LabSysCS.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxSubmit_Click(object sender, EventArgs e)
        {
            string UserNameDb = null;

            string UserName = textBoxUserName.Text;
            string Password = textBoxPassword.Text;

            DataSet dataSet1 = User.IsUserNameExist(UserName,Password);

            foreach (DataRow row in dataSet1.Tables["UserName"].Rows)
            {
                UserNameDb = string.Format("{0}", row["UserName"]);
            }

            if (UserNameDb != null)
            {
                Form1 frm1 = new Form1();
                frm1.PassValue = textBoxUserName.Text;
                this.Visible = false;
                frm1.Show();
                
                               
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "UserName or Password is Incorrect";
            }

        }
    }
}
