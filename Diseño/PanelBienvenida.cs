using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class PanelBienvenida : Form
    {
        private F_MenuPrincipal menuPrincipal;
        public PanelBienvenida(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
            bienvenido.Parent = foto;
            bienvenido.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Utils.changePanel(new R_Datos_Nino(this.menuPrincipal), menuPrincipal);
        }
    }
}
