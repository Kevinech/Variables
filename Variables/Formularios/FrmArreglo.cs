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
                    MostrarPromedio();
                    MostrarEdadMaxima();
                    MostrarEdadMinima();
                    MostrarCantidadMayores();
                    MostrarCantidadMenores();
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
            gbEdades.Text = "Edades: " +
                Arreglo.edades.Length;
            tbEdad.Text = "";
            tbEdad.Focus();
        }

        public void MostrarPromedio()
        {
            lblPromedio.Text = "Promedio:" + Arreglo.GetPromedioI();
        }

        public void MostrarEdadMaxima()
        {
            lblEdadMaxima.Text = "Edad Maxima:" + Arreglo.GetEdadMaxima();
        }

        public void MostrarEdadMinima()
        {
            lblEdadMinima.Text = "Edad Minima: " + Arreglo.GetEdadMinima();
        }
        public void MostrarCantidadMayores()
        {
            lblMayoresEdad.Text = "Cantidad de mayores de edad: " + Arreglo.GetCantidadMenores();
        }

        public void MostrarCantidadMenores()
        {
            lblMenoresEdad.Text = "Cantidad de menores de edad: " + Arreglo.GetCantidadMenores();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {

        }
    }
}
