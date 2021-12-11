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
    public partial class PanelRecomendaciones : Form
    {
        Consulta consulta = new Consulta();

        public PanelRecomendaciones()
        {
            InitializeComponent();
            crearRecomendaciones();
        }

        private void crearRecomendaciones()
        {
            // al final, las recomendaciones estarán almacenadas en una base de datos
            // y serán leidas desde ahi para almacenarlas en un List<>.
            List<Recomendacion> recomendaciones = consulta.getRecomendaciones(Utils.user);

            foreach (Recomendacion recomendacion in recomendaciones)
            {
                Panel panel = new Panel();

                void modPanel(object sender, EventArgs e) {
                    if (panel.Visible == true)
                    {
                        panel.Visible = false;
                    } else
                    {
                        panel.Visible = true;
                    }
                }

                Button button = new Button();
                button.Text = recomendacion.tituloRecomendacion;
                button.Size = new Size(465, 51);
                button.Dock = DockStyle.Top;
                button.Font = new Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                button.Click += new EventHandler(modPanel);
                flPanel.Controls.Add(button);

                panel.Dock = DockStyle.Top;
                panel.Size = new Size(465, 123);
                flPanel.Controls.Add(panel);

                Label label = new Label();
                label.Font = new Font("Roboto Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label.Size = new Size(465,123);
                label.Text = recomendacion.textoRecomendacion;
                panel.Controls.Add(label);

                panel.Visible = false;

            }
        }
    }
}
