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
    public partial class F_TestCI : Form
    {
        Consulta consulta = new Consulta();
        List<Pregunta> preguntas;
        List<Alternativas> alternativas;
        int id;
        bool state;
        public F_TestCI()
        {
            InitializeComponent();
            SetPregunta(0);
            state = false;
            SetAlternativas(0);
        }
        private void SetPregunta(int idPregunta)
        {
            if (!state)
            {
                preguntas = consulta.addPreguntas();
                state = true;
            }
            lblPregunta.Text = preguntas[idPregunta].pregunta;
            if (preguntas[idPregunta].image != " " && preguntas[idPregunta].image != "")
            {
                pbImagen.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resources\" + 
                    preguntas[idPregunta].image + ".jpg");
            } else
            {
                pbImagen.Image = null;
            }
        }
        private void SetAlternativas(int idPregunta)
        {
            this.id = idPregunta;
            lblPreguntas.Text = "Pregunta: " + (idPregunta + 1) + "/" + preguntas.Count;
            if (!state)
            {
                alternativas = consulta.addAlternativas();
                state = true;
            }
            a.Text = alternativas[idPregunta].a;
            b.Text = alternativas[idPregunta].b;
            c.Text = alternativas[idPregunta].c;
            d.Text = alternativas[idPregunta].d;
            e.Text = alternativas[idPregunta].e;
            f.Text = alternativas[idPregunta].f;
            g.Text = alternativas[idPregunta].g;
            h.Text = alternativas[idPregunta].h;

            if (d.Text == " ") d.Visible = false; else d.Visible = true;
            if (e.Text == " ") e.Visible = false; else e.Visible = true;
            if (f.Text == " ") f.Visible = false; else f.Visible = true;
            if (g.Text == " ") g.Visible = false; else g.Visible = true;
            if (h.Text == " ") h.Visible = false; else h.Visible = true;

            if (this.id == 0) btnAnterior.Enabled = false; else btnAnterior.Enabled = true;
            if (this.id == preguntas.Count - 1) btnSiguiente.Enabled = false; else btnSiguiente.Enabled = true;

            uncheckEverything();

            switch (alternativas[idPregunta].seleccionada)
            {
                case "a":
                    a.Checked = true;
                    break;
                case "b":
                    b.Checked = true;
                    break;
                case "c":
                    c.Checked = true;
                    break;
                case "d":
                    d.Checked = true;
                    break;
                case "e":
                    e.Checked = true;
                    break;
                case "f":
                    f.Checked = true;
                    break;
                case "g":
                    g.Checked = true;
                    break;
                case "h":
                    h.Checked = true;
                    break;
                default:
                    uncheckEverything();
                    break;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs ev)
        {
            if (this.id > 0)
            {
                if (a.Checked || b.Checked || c.Checked || d.Checked || e.Checked || f.Checked || g.Checked || h.Checked)
                {
                    alternativas[this.id].seleccionada = gbAlternativas.Controls.
                        OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                }
                SetPregunta(this.id - 1);
                SetAlternativas(this.id - 1);
            }
        }
        private void uncheckEverything()
        {
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            e.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs ev)
        {
            if (this.id <= preguntas.Count)
            {
                if (a.Checked || b.Checked || c.Checked || d.Checked || e.Checked || f.Checked || g.Checked || h.Checked)
                {
                    alternativas[this.id].seleccionada = gbAlternativas.Controls.
                        OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                }
                SetPregunta(this.id + 1);
                SetAlternativas(this.id + 1);
            }
        }
    }
}
