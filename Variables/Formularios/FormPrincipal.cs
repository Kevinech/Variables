using System;

using System.Windows.Forms;
using Variables.Formularios;
using Variables.Modelos;

namespace Variables
{
    public partial class FormPrincipal : Form
    {

        


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArreglo frm = new FrmArreglo();
            frm.ShowDialog();
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatriz frm = new FrmMatriz();
            frm.ShowDialog();
        }
    }
}
