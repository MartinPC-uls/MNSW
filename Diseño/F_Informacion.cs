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
    public partial class F_Informacion : Form
    {
        public F_Informacion()
        {
            InitializeComponent();
        }

        private void btnQueEs_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "¿Qué es?";
            lblTexto.Text = "El síndrome de Down es una afección en la que la persona tiene un cromosoma extra." +
                " Los cromosomas son pequeños “paquetes” de genes en el organismo. " +
                "Determinan cómo se forma el cuerpo del bebé durante el embarazo y cómo funciona mientras se desarrolla " +
                "en el vientre materno y después de nacer. Por lo general, los bebés nacen con 46 cromosomas. " +
                "Los bebés con síndrome de Down tienen una copia extra de uno de estos cromosomas: el cromosoma 21." +
                " El término médico de tener una copia extra de un cromosoma es ‘trisomía’. Al síndrome de Down " +
                "también se lo llama trisomía 21. Esta copia extra cambia la manera en que se desarrollan el cuerpo y" +
                " el cerebro del bebé, lo que puede causarle tanto problemas mentales como físicos.";
        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Recomendaciones generadas";
            lblTexto.Text = "Las recomendaciones se hacen en base a los datos del niño que han sido obtenidos de:" +
                "\r\n- El test cognitivo realizado (una vez por mes)" +
                "\r\n- Las características físicas del niño: altura, peso y sexo (incluyendo la edad)" +
                "\r\n\r\nTambién puede hacer consultas por síntomas que el niño presente, y una recomendación" +
                " al instante.";
        }

        private void btnCentrosDeAyuda_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Centros de ayuda";
            lblTexto.Text = "";
        }
    }
}
