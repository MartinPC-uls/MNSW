using Microsoft.ML;
using ML.Data;
using System;
using System.IO;
using System.Windows.Forms;

namespace ML
{
    class ML
    {
        static readonly string TrainDataPath = System.IO.Directory.GetCurrentDirectory() + @"\ML\Data\AgeRangeData03.csv";
        public static void execute(ref Label salida, string sintoma1, string sintoma2, string sintoma3, string sintoma4)
        {
            var ml = new MLContext(1);
            //Lee la data desde el dataView
            var data = ml.Data.LoadFromTextFile<AgeRange>(TrainDataPath, hasHeader: true, separatorChar: ';');

            //Entrena
            //Permite identificar la columna Label y lo convertirá en una clave para ser analizada dado que es un String
            //y la IA solo trabaja con valores numericos
            var pipeline = ml.Transforms.Conversion.MapValueToKey("Recomendacion")
                .Append(ml.Transforms.Text.FeaturizeText("S1Feat", "Sintoma1"))
                .Append(ml.Transforms.Text.FeaturizeText("S2Feat", "Sintoma2"))
                .Append(ml.Transforms.Text.FeaturizeText("S3Feat", "Sintoma3"))
                .Append(ml.Transforms.Text.FeaturizeText("S4Feat", "Sintoma4"))
                //Indica las caracteristicas con las que se trabajará y al ser Age un campo numerico no hay que hacer nada mas
                //<- Crea una columna nueva llamada features y contiene lo que le sigue
                .Append(ml.Transforms.Concatenate("Features", "S1Feat", "S2Feat", "S3Feat", "S4Feat"))
                .AppendCacheCheckpoint(ml)
                //Indica el trainer que se ocupará (En este caso se ocupa los de Multiclass)
                .Append(ml.MulticlassClassification.Trainers.SdcaMaximumEntropy("Recomendacion", "Features"))
                //Como se habia convertido el label a un numero se revierte 
                .Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            //Entrenar el modelo
            var model = pipeline.Fit(data);
            Console.WriteLine("Modelo entrenado");

            //A partir del modelo se crea un engine de prediccion
            //Se dice cual es el input y el output (AgeRange, AgeRangePrediction)
            var engine = ml.Model.CreatePredictionEngine<AgeRange, AgeRangePrediction>(model);
            PredictSimple(sintoma1, sintoma2, sintoma3, sintoma4, engine, ref salida);
        }

        //Pide los valores de la clase y el predictionEngine
        //Crea un nuevo AgeRange con los valores
        //Hace una prediccion en base a este AgeRange
        private static void PredictSimple(string sintoma1, string sintoma2, string sintoma3, string sintoma4,
            PredictionEngine<AgeRange, AgeRangePrediction> predictionFunction, ref Label label)

        {
            var example = new AgeRange()
            {
                //Age = age,
                //Name = name,
                //Gender = gender,
                //Peso = peso,
                //CI = ci,
                Sintoma1 = sintoma1,
                Sintoma2 = sintoma2,
                Sintoma3 = sintoma3,
                Sintoma4 = sintoma4
            };
            var prediction = predictionFunction.Predict(example);
            /*Console.WriteLine($"{example.Sintoma1} | {example.Sintoma2} | " +
                $"{example.Sintoma3} | {example.Sintoma4}>> " +
                $"\t {prediction.Label}");*/

            label.Text = prediction.Label;
        }
    }
}
