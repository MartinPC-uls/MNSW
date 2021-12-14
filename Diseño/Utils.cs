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
        public static string nombre_nino = "";
        public static string sexo_nino = "";
        public static int edad_nino = 0;
        public static int peso_nino = 0;
        public static int altura_nino = 0;
        public static int int_lm = 0;
        public static int int_es = 0;
        public static int int_em = 0;
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
