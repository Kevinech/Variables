using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FrmMcuadrada : Form
    {
        Mcuadrada mc = new Mcuadrada();

        public FrmMcuadrada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dato = 0;

            try
            {
                dato = int.Parse(tbNumero.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("TIENE QUE SER UN NÚMERO ENTERO, IMBÉCIL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (mc.Agregar(dato))
            {
                dgvMatriz.DataSource = null;
                dgvMatriz.DataSource = mc.getMatrizC();
                dgvMatriz.Refresh();
                MessageBox.Show("Agregado");

            }
        }
    }
}
