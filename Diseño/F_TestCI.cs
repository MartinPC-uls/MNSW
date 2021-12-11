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
        private void revisarTest()
        {
            if (a.Checked || b.Checked || c.Checked || d.Checked || e.Checked || f.Checked || g.Checked || h.Checked)
            {
                alternativas[this.id].seleccionada = gbAlternativas.Controls.
                    OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            }

            List<RespuestasCorrectas> respuestasCorrectas = consulta.addRespuestasCorrectas();
            int puntaje_lm = 0;
            int puntaje_es = 0;
            int puntaje_em = 0;
            int i = 0;
            foreach (Alternativas _alternativas in this.alternativas)
            {
                if (preguntas[i].tipo == "LM")
                {
                    if (_alternativas.seleccionada == respuestasCorrectas[i].respuestaCorrecta)
                    {
                        puntaje_lm++;
                    }
                } else if (preguntas[i].tipo == "ES")
                {
                    if (_alternativas.seleccionada == respuestasCorrectas[i].respuestaCorrecta)
                    {
                        puntaje_es++;
                    }
                } else if (preguntas[i].tipo == "EM")
                {
                    if (_alternativas.seleccionada == respuestasCorrectas[i].respuestaCorrecta)
                    {
                        puntaje_em++;
                    }
                }
                i++;
            }

            double _puntaje_lm = ((double)puntaje_lm / (double)getNumPreguntas_LM())*100;
            double _puntaje_es = ((double)puntaje_es / (double)getNumPreguntas_ES())*100;
            double _puntaje_em = ((double)puntaje_em / (double)getNumPreguntas_EM())*100;

            consulta.registrarPuntajesNino(Utils.user, (int)_puntaje_lm, (int)_puntaje_es, (int)_puntaje_em);

            salidaRecomendacion((int)_puntaje_lm, (int)_puntaje_es, (int)_puntaje_em);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            revisarTest();
        }
        private int getNumPreguntas_LM()
        {
            int num = 0;
            foreach (Pregunta pregunta in this.preguntas)
            {
                if (pregunta.tipo == "LM") num++;
            }
            return num;
        }
        private int getNumPreguntas_ES()
        {
            int num = 0;
            foreach (Pregunta pregunta in this.preguntas)
            {
                if (pregunta.tipo == "ES") num++;
            }
            return num;
        }
        private int getNumPreguntas_EM()
        {
            int num = 0;
            foreach (Pregunta pregunta in this.preguntas)
            {
                if (pregunta.tipo == "EM") num++;
            }
            return num;
        }
        private void salidaRecomendacion(int ptj_lm, int ptj_es, int ptj_em)
        {
            string recomendacion_lm = "";
            string recomendacion_es = "";
            string recomendacion_em = "";
            if (ptj_lm < 20)
            {
                recomendacion_lm = "La inteligencia lógico-matemática del niño es deficiente, sin embargo, se puede tratar" +
                    " con simples ejercicios como comparar y clasificar cosas, jugar con bloques y explicar cosas cotidianas";
            } else if (ptj_lm >= 20 && ptj_lm < 50)
            {
                recomendacion_lm = "La inteligencia lógico matemática del niño es un poco deficiente, para tratarla" +
                    " trate de ejercitar al niño con ejercicios de contar cosas por al menos 1 mes.";
            } else if (ptj_lm >= 50 && ptj_lm < 75)
            {
                recomendacion_lm = "La inteligencia lógico matemática del niño debe ejercitarse. Haga ejercicios de agrupar cosas" +
                    " y contarlas por al menos 1 mes.";
            }

            if (ptj_es < 20)
            {
                recomendacion_es = "Invite al niño a jugar videojuegos que lo puedan entretener. Los videojuegos" +
                    " pueden ser muy buenos a toda edad y ayuda a mejorar la inteligencia espacial del niño ";
            } else if (ptj_es >= 20 && ptj_es < 50)
            {
                recomendacion_es = "La inteligencia especial del niño es un poco deficiente, para tratarla" +
                    " trate de ejercitar al niño con ejercicios de asimilar cosas y diferenciar el tamaño de cosas.";
            } else if (ptj_es >= 50 && ptj_es < 75)
            {
                recomendacion_es = "La inteligencia espacial del niño debe ejercitarse. Los juegos de puzzles, LEGO son un buen" +
                    " tratamiento para los niños.";
            }

            if (ptj_em < 20)
            {
                recomendacion_em = "Realice actividades con el niño tales como leer cuentos o dibujar emociones.";
            } else if (ptj_em >= 20 && ptj_em < 50)
            {
                recomendacion_em = "El juego \"Mi nombre, Mis virtudes\" es un buen ejemplo para que el niño" +
                    " se identifique y mejore su autoconcepto: ¿Cómo soy?, ¿Cómo me veo?.";
            } else if (ptj_em >= 50 && ptj_em < 75)
            {
                recomendacion_em = "Haga que el niño dibuje mientras escuche música. La música nos evoca emociones, y" +
                    " la pintura es una buena manera de expresarlas.";
            }

            if (!(recomendacion_lm == ""))
                consulta.addRecomendacion(Utils.user, recomendacion_lm);
            if (!(recomendacion_es == ""))
                consulta.addRecomendacion(Utils.user, recomendacion_es);
            if (!(recomendacion_em == ""))
                consulta.addRecomendacion(Utils.user, recomendacion_em);
        }
    }
}
