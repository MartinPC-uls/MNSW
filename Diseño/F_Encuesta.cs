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
    public partial class F_Encuesta : Form
    {
        Consulta consulta = new Consulta();
        public F_Encuesta()
        {
            InitializeComponent();
            agregarSintomas(cbSintoma1);

        }
        public void agregarSintomas(ComboBox cb)
        {
            List<string> sintomas = new List<string>();
            consulta.addSintomas(sintomas);
            foreach (string element in sintomas)
            {
                cb.Items.Add(element);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSintoma2.Visible == false)
            {
                lblSintoma2.Visible = true;
                cbSintoma2.Visible = true;
                agregarSintomas(cbSintoma2);
            }
        }

        private void cbSintoma2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSintoma3.Visible == false)
            {
                lblSintoma3.Visible = true;
                cbSintoma3.Visible = true;
                agregarSintomas(cbSintoma3);
            }
        }

        private void cbSintoma3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSintoma4.Visible == false)
            {
                lblSintoma4.Visible = true;
                cbSintoma4.Visible = true;
                agregarSintomas(cbSintoma4);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // DO SOMETHING
        }
    }
}
