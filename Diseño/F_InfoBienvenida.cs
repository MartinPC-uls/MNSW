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
    public partial class F_InfoBienvenida : Form
    {
        F_MenuPrincipal menuPrincipal;
        Consulta consulta = new Consulta();
        public F_InfoBienvenida(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
            string sexo = consulta.getSexoNino();
            string nombre = consulta.getNombreNino();
            if (sexo == "m")
                lblBienvenida.Text = "Bienvenido " + nombre;
            else if (sexo == "f")
                lblBienvenida.Text = "Bienvenida " + nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Utils.changePanel(new F_Informacion(), menuPrincipal);
            menuPrincipal.btnDatosNino.Visible = true;
            menuPrincipal.btnDatosNino_.Visible = true;
            menuPrincipal.btnConsultarSintomas.Visible = true;
            menuPrincipal.btnDatosUsuario.Visible = true;
        }
    }
}
