using System;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int edad = int.Parse(tbEdad.Text);
                if (Arreglo.pos < 10)
                {
                    Arreglo.edades[Arreglo.pos++] = edad;
                    llenarListado();
                    MostrarCalculos();

                }
                else
                {
                    MessageBox.Show("Solo se pueden agregar 10"
                    , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
            }
        }

        public void llenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edades;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.pos;
            tbEdad.Text = "";
            tbEdad.Focus();
        }

        public void MostrarCalculos()
        {
            lblPromedio.Text = "Promedio: " + Arreglo.GetPromedioI();
            lblEdadMaxima.Text = "Edad Maxima: " + Arreglo.GetEdadMaxima();
            lblEdadMinima.Text = "Edad Minima: " + Arreglo.GetEdadMinima();
            lblMayoresEdad.Text = "Mayores de edad: " + Arreglo.GetCantidadMayores();
            lblMenoresEdad.Text = "Menores de edad: " + Arreglo.GetCantidadMenores();
            

        }
        private void FrmArreglo_Load(object sender, EventArgs e)
        {

        }
    }
}
