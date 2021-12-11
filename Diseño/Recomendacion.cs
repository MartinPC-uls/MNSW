using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    public class Recomendacion
    {
        public string tituloRecomendacion;
        public string textoRecomendacion;

        public Recomendacion(string tituloRecomendacion, string textoRecomendacion)
        {
            this.tituloRecomendacion = tituloRecomendacion;
            this.textoRecomendacion = textoRecomendacion;
        }
    }
}
