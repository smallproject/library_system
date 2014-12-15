using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system.User_controls
{
    public partial class login : UserControl
    {
        
        public login()
        {
            InitializeComponent();
            OnInit();
        }

        private void OnInit()
        {
            //labels
            lbllogin.Text = "Log-In";
            lblusername.Text = "Username";
            lblpassword.Text = "Password";

            //other controls
            txtbusername.Clear();
            txtbpassword.Clear();
            btnlogin.Text = "login";
            btncancel.Text = "cancel";
        }

        internal string username = "";
        internal string password = "";

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            username = txtbusername.Text;
            password = txtbpassword.Text;
        }
    }
}
