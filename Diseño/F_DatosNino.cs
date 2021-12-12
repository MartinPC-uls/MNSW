using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML;
using ML.Data;
using Diseño.Conexion;

namespace Diseño
{
    public partial class F_DatosNino : Form
    {

        Form ventanaPrincipal;

        public F_DatosNino(Form ventanaPrincipal)
        {
            this.ventanaPrincipal = ventanaPrincipal;
            InitializeComponent();
            SetDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.Hide();
            F_TestCI test_ci = new F_TestCI();
            test_ci.ShowDialog();

        }
        private void SetDatos()
        {
            Consulta consulta = new Consulta();
            // Datos físicos
            lblNombre.Text = consulta.getNombreNino();
            lblEdad.Text = Convert.ToString(consulta.getEdadNino()) + " Años";

            string altura = Convert.ToString(consulta.getAlturaNino());
            string peso = Convert.ToString(consulta.getPesoNino());
            string sexo = consulta.getSexoNino();

            if (sexo == "m")
            {
                sexo = "Masculino";
            } else if (sexo == "f")
            {
                sexo = "Femenino";
            }
            lblDatosFisicos.Text = "Altura: " + altura + "  Peso: " + peso + "  Sexo: " + sexo;

            // Datos cognitivos
            lblIntLM.Text = "Inteligencia Lógico-Matemática: " + Convert.ToString(consulta.getIntLM()) + "%";
            lblIntES.Text = "Inteligencia Espacial: " + Convert.ToString(consulta.getIntES()) + "%";
            lblIntEM.Text = "Inteligencia Emocional: " + Convert.ToString(consulta.getIntEM()) + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
