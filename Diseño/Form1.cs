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

namespace Diseño
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
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
            openChildForm(new F_CapacidadIntelectual());
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
            _p1.Controls.Add(childForm);
            _p1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDatosNino_Click(object sender, EventArgs e)
        {
            openChildForm(new F_DatosNino());
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
                       TopColor, BottomColor, LinearGradientMode.Vertical))
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
