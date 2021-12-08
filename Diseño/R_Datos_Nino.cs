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
using System.Globalization;

namespace Diseño
{
    public partial class R_Datos_Nino : Form
    {

        F_MenuPrincipal menuPrincipal;
        Consulta consulta = new Consulta();

        public R_Datos_Nino(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            int altura = int.Parse(txtAltura.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            int peso = int.Parse(txtPeso.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            string sexo = txtSexo.Text;

            consulta.addNino(Utils.user, nombre, edad, altura, peso, sexo);
            Utils.changePanel(new F_InfoBienvenida(this.menuPrincipal), this.menuPrincipal);
            
        }
    }
}
