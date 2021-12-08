using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    class Utils
    {
        public static string user = "";
        public static void changePanel(Form next, F_MenuPrincipal menuPrincipal)
        {
            Form activeForm = null;
            if (activeForm != null)
                activeForm.Close();
            activeForm = next;
            next.TopLevel = false;
            next.FormBorderStyle = FormBorderStyle.None;
            next.Dock = DockStyle.Fill;
            menuPrincipal.panelPrincipal.Controls.Add(next);
            menuPrincipal.panelPrincipal.Tag = next;
            next.BringToFront();
            next.Show();
        }
    }
}
