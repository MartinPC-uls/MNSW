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
    public partial class F_Registro : Form
    {
        Consulta consulta = new Consulta();
        public F_Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                barPassword.BackColor = Color.Green;
                barPassword2.BackColor = Color.Green;
                if (!consulta.verificarUsuario(txtUser.Text))
                {
                    consulta.agregarUsuario(txtUser.Text, txtPassword.Text);
                    this.Hide();
                    string user = txtUser.Text;
                    Utils.user = user;
                    F_MenuPrincipal form1 = new F_MenuPrincipal(user);
                    form1.ShowDialog();
                }
                else
                {
                    barUser.BackColor = Color.Red;
                }
            }
            else
            {
                barPassword.BackColor = Color.Red;
                barPassword2.BackColor = Color.Red;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains(".com") || txtUser.Text.Contains(".cl"))
                barUser.BackColor = Color.Green;
            else
                barUser.BackColor = Color.Red;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword2.Text)
            {
                barPassword.BackColor = Color.Red;
                barPassword2.BackColor = Color.Red;
            } else
            {
                barPassword.BackColor = Color.Green;
                barPassword2.BackColor = Color.Green;
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword2.Text)
            {
                barPassword.BackColor = Color.Red;
                barPassword2.BackColor = Color.Red;
            }
            else
            {
                barPassword.BackColor = Color.Green;
                barPassword2.BackColor = Color.Green;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_InicioSesion inicioSesion = new F_InicioSesion();
            inicioSesion.ShowDialog();
        }
    }
}
