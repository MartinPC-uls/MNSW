using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.Conexion;

namespace Diseño
{
    public partial class F_Consulta : Form
    {
        Consulta consulta = new Consulta();
        List<string> sintomas = new List<string>();
        F_MenuPrincipal menuPrincipal;
        public F_Consulta(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
            consulta.addSintomas(sintomas);
            agregarSintomas(cbSintoma1);
        }
        public void agregarSintomas(ComboBox cb, string excepcion1 = "", string excepcion2 = "", string excepcion3 = "")
        {
            Console.WriteLine("a ignorar: " + excepcion1 + " " + excepcion2 + " " + excepcion3);
            foreach (string element in sintomas)
            {
                if (excepcion1 != element && excepcion2 != element && excepcion3 != element)
                    cb.Items.Add(element);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sintoma1 = "null", sintoma2 = "null", sintoma3 = "null", sintoma4 = "null";
            if (!(cbSintoma1.Text == "" || cbSintoma1.Text == null))
                sintoma1 = cbSintoma1.Text;

            if (!(cbSintoma2.Text == "" || cbSintoma2.Text == null))
                sintoma2 = cbSintoma2.Text;

            if (!(cbSintoma3.Text == "" || cbSintoma3.Text == null))
                sintoma3 = cbSintoma3.Text;

            if (!(cbSintoma4.Text == "" || cbSintoma4.Text == null))
                sintoma4 = cbSintoma4.Text;

            ML.ML.execute(ref lblRecomendacion, sintoma1, sintoma2, sintoma3, sintoma4);
        }

        private void cbSintoma1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSintoma2.Visible == false)
            {
                lblSintoma2.Visible = true;
                cbSintoma2.Visible = true;
                agregarSintomas(cbSintoma2, cbSintoma1.Text);
            }
        }

        private void cbSintoma2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSintoma3.Visible == false)
            {
                lblSintoma3.Visible = true;
                cbSintoma3.Visible = true;
                agregarSintomas(cbSintoma3, cbSintoma1.Text, cbSintoma2.Text);
            }
        }

        private void cbSintoma3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSintoma4.Visible == false)
            {
                lblSintoma4.Visible = true;
                cbSintoma4.Visible = true;
                agregarSintomas(cbSintoma4, cbSintoma1.Text, cbSintoma2.Text, cbSintoma3.Text);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Utils.changePanel(new F_Consulta(this.menuPrincipal), this.menuPrincipal);
        }
    }
}
