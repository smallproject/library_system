﻿using Library_system.Database;
using Library_system.Database.Repositories;
using Library_system.Database.UnitOfWork;
using System;
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

        void OnInit()
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

            IAccountRepository repository = new AccountRepository();
            IAccountUow accountUow = new AccountUow();

            //needs to evaluate if necessary
            //uow.Account = repository.Register(varfirstname, varlastname,
            //    varbirthdate, vargender, varmobilenumber, varemail, varusername, varpassword);

            //MessageBox.Show(repository.GetNewId("nca"));

            //return;
            accountUow.Account = new Database.Account()
            {
                Id = repository.GetNewId("nca"),
                BirthDate = varbirthdate,
                Email = varemail,
                FirstName = varfirstname,
                Gender = vargender,
                LastName = varlastname,
                MobileNumber = varmobilenumber
            };

            //uow.ReadVarAccount();

            //creates Account
            if (accountUow.Create())
            {
                IUserUow userUow = new UserUow();
                userUow.User = new User()
                {
                    Id = repository.GetNewId("nca"),
                    Username = varusername,
                    Password = varpassword,
                    Created = DateTime.Now,
                };

                //creates user account
                if (userUow.Create())
                {
                    //increments current code index
                    IIndexUow uowIndex = new IndexUow();
                    uowIndex.IncrementCurrentIndex("nca");
                }
            }
        }

        private bool confirmed(string password, string confirm)
        {
            return password.Equals(confirm);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Dispose();
        }


        //Declarations
        private string varfirstname;
        private string varlastname;
        private DateTime varbirthdate;
        private string vargender;
        private string varmobilenumber;
        private string varemail;
        private string varusername;
        private string varpassword;
    }
}
