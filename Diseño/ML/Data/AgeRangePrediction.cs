using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data
{
    class AgeRangePrediction
    {
        [ColumnName("PredictedLabel")]
        public string Label;

        public float[] Score;
    }
}
