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

namespace Diseño
{
    public partial class F_DatosNino : Form
    {

        Form ventanaPrincipal;
        private Label salida;

        public F_DatosNino(Form ventanaPrincipal)
        {
            this.ventanaPrincipal = ventanaPrincipal;
            InitializeComponent();
            salida = lblSalida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.Hide();
            F_TestCI test_ci = new F_TestCI();
            test_ci.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ML.ML.execute(ref salida, "Anemia", "Diarrea", "null", "null");
        }
    }
}
