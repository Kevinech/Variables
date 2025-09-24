using System;

using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {

                new Form1().Show();

                //Form1 frm = new Form1();
                //frm.Show();

                this.Hide();

            }
        }

        private Boolean Login(String user, String password)
        {
            return user.Equals("admin") && password.Equals("admin");
        }   


    }
}
