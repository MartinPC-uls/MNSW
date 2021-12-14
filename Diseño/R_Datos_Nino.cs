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
            setDatos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            int altura = int.Parse(txtAltura.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            int peso = int.Parse(txtPeso.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            string sexo = txtSexo.Text;

            int state = consulta.addNino(Utils.user, nombre, edad, altura, peso, sexo);
            if (state == 1)
            { // se añadió un niño por primera vez
                consulta.addUsuarioTablaTestsRealizados();
                consulta.addFechaInicioRecomendacionSemanal();
            }

            Utils.nombre_nino = nombre;
            Utils.edad_nino = edad;
            Utils.altura_nino = altura;
            Utils.peso_nino = peso;
            Utils.sexo_nino = sexo;

            consulta.updtFechaInicioCambiarDatos(); // establece la fecha en 30 días para realizar cambios nuevamente.

            if (state == 1)
                Utils.changePanel(new F_InfoBienvenida(this.menuPrincipal), this.menuPrincipal);
            else if (state == 2) // en caso que los datos sean de actualizar
                Utils.changePanel(new F_Informacion(), this.menuPrincipal);
            
        }
        public void setDatos()
        {
            try
            {
                txtNombre.Text = Utils.nombre_nino;
                txtEdad.Text = Convert.ToString(Utils.edad_nino);
                txtAltura.Text = Convert.ToString(Utils.altura_nino);
                txtPeso.Text = Convert.ToString(Utils.peso_nino);
                if (Utils.sexo_nino == "f")
                    txtSexo.Text = "f";
                else if (Utils.sexo_nino == "m")
                    txtSexo.Text = "m";
            }
            catch (Exception e) { }
        }
    }
}
