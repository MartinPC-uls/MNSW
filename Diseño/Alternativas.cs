using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class Alternativas
    {
        public int idPregunta;
        public string a, b, c, d, e, f, g, h, seleccionada;

        public Alternativas(int idPregunta, string a, string b, string c, string d = " ", string e = " ",
            string f = " ", string g = " ", string h = " ", string seleccionada = " ")
        {
            this.idPregunta = idPregunta;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.seleccionada = seleccionada;
        }
    }
}
