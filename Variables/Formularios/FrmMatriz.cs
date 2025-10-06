using System;

using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    
    public partial class FrmMatriz : Form
    {
        Matriz mc = new Matriz();
        public FrmMatriz()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(tbNumero.Text);
            mc.Agregar(dato);

            dgvMatriz.DataSource = null;
            dgvMatriz.DataSource = mc.getMatrizC();
            dgvMatriz.Refresh();

        }
    }
}
