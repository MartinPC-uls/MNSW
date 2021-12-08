using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data
{
    class AgeRange
    {  
        /*[LoadColumn(0)]
        public string Name;

        [LoadColumn(1)]
        public float Age;

        [LoadColumn(2)]
        public string Gender;

        [LoadColumn(3)]
        public string Label;

        [LoadColumn(4)]
        public float Peso;

        [LoadColumn(5)]
        public float CI;*/

        [LoadColumn(0)]
        public string Sintoma1;

        [LoadColumn(1)]
        public string Sintoma2;

        [LoadColumn(2)]
        public string Sintoma3;

        [LoadColumn(3)]
        public string Sintoma4;

        [LoadColumn(4)]
        public string Recomendacion;
    }
}
