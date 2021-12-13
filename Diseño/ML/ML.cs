using Microsoft.ML;
using ML.Data;
using System;
using System.IO;
using System.Windows.Forms;

namespace ML
{
    class ML
    {
        static readonly string TrainDataPath = System.IO.Directory.GetCurrentDirectory() + @"\ML\Data\SintomasData.csv";
        public static void execute(ref Label salida, string sintoma1, string sintoma2, string sintoma3, string sintoma4)
        {
            var ml = new MLContext(1);

            var data = ml.Data.LoadFromTextFile<Sintomas>(TrainDataPath, hasHeader: true, separatorChar: ';');
            var pipeline = ml.Transforms.Conversion.MapValueToKey("Recomendacion")
                .Append(ml.Transforms.Text.FeaturizeText("S1Feat", "Sintoma1"))
                .Append(ml.Transforms.Text.FeaturizeText("S2Feat", "Sintoma2"))
                .Append(ml.Transforms.Text.FeaturizeText("S3Feat", "Sintoma3"))
                .Append(ml.Transforms.Text.FeaturizeText("S4Feat", "Sintoma4"))
                .Append(ml.Transforms.Concatenate("Features", "S1Feat", "S2Feat", "S3Feat", "S4Feat"))
                .AppendCacheCheckpoint(ml)
                .Append(ml.MulticlassClassification.Trainers.SdcaMaximumEntropy("Recomendacion", "Features"))
                .Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(data);
            Console.WriteLine("Modelo entrenado");

            var engine = ml.Model.CreatePredictionEngine<Sintomas, SintomasPrediction>(model);
            PredictSimple(sintoma1, sintoma2, sintoma3, sintoma4, engine, ref salida);
        }

        private static void PredictSimple(string sintoma1, string sintoma2, string sintoma3, string sintoma4,
            PredictionEngine<Sintomas, SintomasPrediction> predictionFunction, ref Label label)
        {
            var example = new Sintomas()
            {
                Sintoma1 = sintoma1,
                Sintoma2 = sintoma2,
                Sintoma3 = sintoma3,
                Sintoma4 = sintoma4
            };
            var prediction = predictionFunction.Predict(example);

            label.Text = prediction.Label;
        }
    }
}
