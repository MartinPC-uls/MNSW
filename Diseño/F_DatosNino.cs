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
            F_Test test_ci = new F_Test();
            test_ci.ShowDialog();

        }
        private void SetDatos()
        {
            Consulta consulta = new Consulta();

            // verificar la disponibilidad del test
            bool status = false;
            if (consulta.getTestStatus()) {
                btnRealizarTest.Visible = false;
                status = true;
            }

            // Datos físicos
            lblNombre.Text = Utils.nombre_nino;
            lblEdad.Text = Convert.ToString(Utils.edad_nino) + " Años";

            string altura = Convert.ToString(Utils.altura_nino + " cm");
            string peso = Convert.ToString(Utils.peso_nino + " kg");

            lblDatosFisicos.Text = "Altura: " + altura + "  Peso: " + peso;

            // Datos cognitivos
            lblIntLM.Text = "Inteligencia Lógico-Matemática: " + Convert.ToString(Utils.int_lm) + "%";
            lblIntES.Text = "Inteligencia Espacial: " + Convert.ToString(Utils.int_es) + "%";
            lblIntEM.Text = "Inteligencia Emocional: " + Convert.ToString(Utils.int_em) + "%";

            if (status)
            {
                string today = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                string end = consulta.getTestDate("ed");
                DateTime _today = DateTime.Parse(today);
                DateTime _end = DateTime.Parse(end);
                string dias = (_end - _today).TotalDays.ToString();
                if (Convert.ToInt32(dias) > 0)
                    lblDiasRestantes.Text = "Faltan " + dias + " para poder volver a realizar el test cognitivo.";
                else
                    lblDiasRestantes.Text = "";
            }
        }
    }
}
