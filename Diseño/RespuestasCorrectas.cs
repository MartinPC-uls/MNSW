using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class RespuestasCorrectas
    {
        public int id;
        public string respuestaCorrecta;

        public RespuestasCorrectas(int id, string respuestaCorrecta)
        {
            this.id = id;
            this.respuestaCorrecta = respuestaCorrecta;
        }
    }
}
