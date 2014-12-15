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
    public partial class register : UserControl
    {
        //register_background background = new register_background();
        public register()
        {
            InitializeComponent();
            
            OnInit();
        }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthdate { get; set; }

        internal void OnInit()
        {
            //labels
            lblregister.Text = "Registration";
            lblfirstname.Text = "First name:";
            lbllastname.Text = "Last name:";
            lblgender.Text = "Gender:";
            lblbirthdate.Text = "Birth date:";
            lblmobilenumber.Text = "Mobile number:";
            lblemail.Text = "E-mail:";
            lblusername.Text = "Username:";
            lblpassword.Text = "Password:";
            lblconfirm.Text = "Confirm password:";


            //other controls
            txtbfirstname.Clear();
            txtblastname.Clear();
            cbgender.ResetText();
            txtbmobilenumber.Clear();
            txtbemail.Clear();
            txtbusername.Clear();
            txtbpassword.Clear();
            txtbconfirm.Clear();
            btnregister.Text = "register";
            btncancel.Text = "cancel";

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (!confirmed(txtbpassword.Text, txtbconfirm.Text))
                return;
                    
            varfirstname = txtbfirstname.Text;
            varlastname = txtblastname.Text;
            varbirthdate = dTPbirthdate.Value;
            vargender = cbgender.Text;
            varmobilenumber = txtbmobilenumber.Text;
            varemail = txtbemail.Text;
            varusername = txtbusername.Text;
            varpassword = txtbpassword.Text;
        }

        private bool confirmed(string password, string confirm)
        {
            if (password.Equals(confirm))
                return true;

            return false;
        }

        internal string varfirstname;
        internal string varlastname;
        internal DateTime varbirthdate;
        internal string vargender;
        internal string varmobilenumber;
        internal string varemail;
        internal string varusername;
        internal string varpassword;

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
