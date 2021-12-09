using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class Pregunta
    {
        public int id;
        public string pregunta;
        public string tipo;
        public string image;

        public Pregunta(int id, string pregunta, string tipo, string image = "")
        {
            this.id = id;
            this.pregunta = pregunta;
            this.tipo = tipo;
            this.image = image;
        }
    }
}
