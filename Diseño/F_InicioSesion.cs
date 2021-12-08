using Diseño.Conexion;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Diseño
{
    public partial class F_InicioSesion : Form
    {

        Consulta consulta = new Consulta();

        public F_InicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (consulta.comprobarUsuario(txtUser.Text, txtPassword.Text))
            {
                this.Hide();
                string user = txtUser.Text;
                Utils.user = user;
                F_MenuPrincipal form1 = new F_MenuPrincipal(user);
                form1.ShowDialog();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Contains("@") && txtUser.Text.Contains(".com") || txtUser.Text.Contains(".cl"))
            {
                barUser.BackColor = Color.Green;
                if (barPassword.BackColor == Color.Green)
                {
                    healthIcon_green.Show();
                    healthIcon_red.Hide();
                }
            } else
            {
                healthIcon_red.Show();
                healthIcon_green.Hide();
                barUser.BackColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                healthIcon_red.Show();
                healthIcon_green.Hide();
                barPassword.BackColor = Color.Red;
            }
            else
            {
                barPassword.BackColor = Color.Green;
                if (barUser.BackColor == Color.Green)
                {
                    healthIcon_green.Show();
                    healthIcon_red.Hide();
                }
            }
        }
    }
}
