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
    public partial class F_InfoBienvenida : Form
    {
        F_MenuPrincipal menuPrincipal;
        public F_InfoBienvenida(F_MenuPrincipal menuPrincipal)
        {
            this.menuPrincipal = menuPrincipal;
            InitializeComponent();
        }
    }
}
