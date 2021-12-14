using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Diseño.Conexion;
using System.Threading;

namespace Diseño
{
    public partial class F_MenuPrincipal : Form
    {

        public string user;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static int numRecomendaciones;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public F_MenuPrincipal(string user)
        {
            this.user = user;
            InitializeComponent();
            

            deshabilitarBotones();

            setAll();

            
        }
        private void setAll()
        {
            establecerRecomendacionesSemanales();
            setNumRecomendaciones();
            comprobarFecha();
            openChildForm(new PanelBienvenida(this));
            comprobarFechaActualizacionDatos();
        }
        private void comprobarFechaActualizacionDatos()
        {
            try
            {
                Consulta consulta = new Consulta();
                string today = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DateTime _today = DateTime.Parse(today);
                string fechaActualizarDatos = consulta.getFechaRecordatorioCambiarDatos();
                DateTime _fechaActualizarDatos = DateTime.Parse(fechaActualizarDatos);
                if (DateTime.Compare(_today, _fechaActualizarDatos) >= 0)
                {
                    openChildForm(new F_Informacion());
                }
            }
            catch (Exception e) { }
        }

        private void establecerRecomendacionesSemanales()
        {
            Consulta consulta = new Consulta();
            string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            DateTime today = DateTime.Parse(todays_date);
            string date_ultimaRecomendacion = consulta.getFechaRecomendacionSemanal();
            if (date_ultimaRecomendacion != null && date_ultimaRecomendacion != DBNull.Value.ToString() && date_ultimaRecomendacion != "")
            {
                DateTime ultimaRecomendacion = DateTime.Parse(date_ultimaRecomendacion);
                Console.WriteLine("Comparando " + todays_date + " y " + date_ultimaRecomendacion);
                if (DateTime.Compare(today, ultimaRecomendacion) >= 0)
                {
                    consulta.updtFechaInicioRecomendacionSemanal();
                    string recomendacionSemanal = consulta.getRecomendacionSemanal(); // recomendación aleatoria
                    /*
                    int peso = consulta.getPesoNino();
                    int altura = consulta.getAlturaNino();*/
                    int imc = Utils.peso_nino / (Utils.altura_nino ^ 2);
                    if (imc >= 25 && imc < 30)
                        imc = 1; // sobrepeso
                    else if (imc >= 30)
                        imc = 2; // obesidad

                    if (imc == 1 || imc == 2)
                    {
                        string recomendacionSemanal_RelacionIMC = consulta.getRecomendacionSemanal_RelacionIMC(imc);
                        consulta.addRecomendacion(Utils.user, recomendacionSemanal_RelacionIMC);
                    }

                    consulta.addRecomendacion(Utils.user, recomendacionSemanal);
                }
            }
        }
        private void comprobarFecha()
        {
            Consulta consulta = new Consulta();
            string todays_date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            DateTime today = DateTime.Parse(todays_date);
            string ends_date = consulta.getTestDate("ed");
            if (ends_date != null && ends_date != "" && ends_date != DBNull.Value.ToString())
            {
                DateTime end = DateTime.Parse(ends_date);
                int result = DateTime.Compare(today, end);
                if (result >= 0)
                {
                    consulta.updtTestRealizado();
                }
            }
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            openChildForm(new F_Informacion());
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void BtnCapacidadIntelectual_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DatosNino(this));
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void deshabilitarBotones() {
            Consulta consulta = new Consulta();
            if (!consulta.verificarNinoRegistrado())
            {
                btnDatosNino.Visible = false;
                //btnDatosNino_.Visible = false;
                btnConsultarSintomas.Visible = false;
                btnDatosUsuario.Visible = false;
            }
        }

        private void BtnDatosNino_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DatosNino(this));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utils.user = "";
            F_InicioSesion inicioSesion = new F_InicioSesion();
            inicioSesion.ShowDialog();
        }
        
        private void lblBenvenido()
        {
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void _p1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new PanelBienvenida(this));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new F_Consulta(this));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openChildForm(new PanelRecomendaciones());
        }

        private void btnDatosUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DatosUsuario(this));
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void setNumRecomendaciones()
        {
            Consulta consulta = new Consulta();
            List<Recomendacion> recomendaciones = consulta.getRecomendaciones(Utils.user);
            numRecomendaciones = recomendaciones.Count;
            if (!(numRecomendaciones == 0))
            {
                lblNumRecomendaciones.Visible = true;
                lblNumRecomendaciones.Text = Convert.ToString(numRecomendaciones);
            } else
            {
                lblNumRecomendaciones.Text = "0";
                lblNumRecomendaciones.Visible = false;
            }
        }
    }

    public class GradientPanel : Panel
    {

        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        public GradientPanel()
        {
            this.ResizeRedraw = true;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                       TopColor, BottomColor, LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }
    }
}
