using Diseño.Conexion;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Diseño
{
    public partial class Form2 : Form
    {

        Consulta consulta = new Consulta();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (consulta.comprobarUsuario(txtUser.Text, txtPassword.Text))
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0)
            {
                barUser.BackColor = Color.Red;
            } else
            {
                barUser.BackColor = Color.Green;
            }
        }
    }
}
