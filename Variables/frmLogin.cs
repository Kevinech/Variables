using System;

using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int contador = 0;

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
                
                this.DialogResult = DialogResult.OK;
                this.Close();

                //new FormPrincipal().Show();
                //this.Hide();
            }
            else
            {
                 contador++;
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
                

            if (contador == 3)
            {
                MessageBox.Show("Solo tienes 3 intentos para poder ingresar la contraseña o el usuario"
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
    
        }

        private Boolean Login(String user, String password)
        {
            return user.Equals("admin") && password.Equals("admin");
        }   


    }
}
