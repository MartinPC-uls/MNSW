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
    public partial class F_DatosUsuario : Form
    {
        private F_MenuPrincipal menuPrincipal;
        Consulta consulta = new Consulta();
        public F_DatosUsuario(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
            txtNombre.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            SetDatosUsuario();
        }
        
        private void SetDatosUsuario()
        {
            txtNombre.Text = consulta.getNombreUsuario(Utils.user);
            txtEdad.Text = Convert.ToString(consulta.getEdadUsuario(Utils.user));
            txtEmail.Text = Utils.user;
            // la password no se muestra.
        }

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            if (!txtNombre.ReadOnly)
            {
                consulta.updtNombreUsuario(txtNombre.Text);
                txtNombre.ReadOnly = true;
                btnCambiarNombre.Text = "Modificar";
            }
            else
            {
                btnCambiarNombre.Text = "Aplicar cambios";
                txtNombre.ReadOnly = false;
            }
        }

        private void btnCambiarEdad_Click(object sender, EventArgs e)
        {
            if (!txtEdad.ReadOnly)
            {
                consulta.updtEdadUsuario(Convert.ToInt16(txtEdad.Text));
                txtEdad.ReadOnly = true;
                btnCambiarEdad.Text = "Modificar";
            }
            else
            {
                btnCambiarEdad.Text = "Aplicar cambios";
                txtEdad.ReadOnly = false;
            }
        }

        private void btnCambiarEmail_Click(object sender, EventArgs e)
        {
            if (!txtEmail.ReadOnly)
            {
                consulta.updtEmailUsuario(txtEmail.Text);
                txtEmail.ReadOnly = true;
                btnCambiarEmail.Text = "Modificar";
            }
            else
            {
                btnCambiarEmail.Text = "Aplicar cambios";
                txtEmail.ReadOnly = false;
            }
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            if (!txtPassword.ReadOnly)
            {
                consulta.updtPasswordUsuario(txtPassword.Text);
                txtEmail.ReadOnly = true;
                btnCambiarPassword.Text = "Modificar";
            }
            else
            {
                btnCambiarPassword.Text = "Aplicar cambios";
                txtPassword.ReadOnly = false;
            }
        }
    }
}
