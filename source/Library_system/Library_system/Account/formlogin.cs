using System.Windows.Forms;

namespace Library_system.Account
{
    public partial class formlogin : Form
    {
        public formlogin()
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

            //links
            lblcreate.Text = "create-account";
        }

        private void lblcreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formregister form = new formregister();
            this.Hide();
            form.ShowDialog();
            this.Show();
            //var test = form.ShowDialog();

            //MessageBox.Show(test.ToString());
            //this.Show();
        }

        private void btnlogin_Click(object sender, System.EventArgs e)
        {

        }
    }
}
