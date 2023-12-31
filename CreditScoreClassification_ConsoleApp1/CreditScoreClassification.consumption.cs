﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace CreditScoreClassification_ConsoleApp1
{
    public partial class CreditScoreClassification
    {
        /// <summary>
        /// model input class for CreditScoreClassification.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"ID")]
            public string ID { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"Customer_ID")]
            public string Customer_ID { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"Month")]
            public string Month { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"Name")]
            public string Name { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"Age")]
            public string Age { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"SSN")]
            public string SSN { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"Occupation")]
            public string Occupation { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"Annual_Income")]
            public string Annual_Income { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"Monthly_Inhand_Salary")]
            public float Monthly_Inhand_Salary { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"Num_Bank_Accounts")]
            public float Num_Bank_Accounts { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"Num_Credit_Card")]
            public float Num_Credit_Card { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"Interest_Rate")]
            public float Interest_Rate { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"Num_of_Loan")]
            public string Num_of_Loan { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"Type_of_Loan")]
            public string Type_of_Loan { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"Delay_from_due_date")]
            public string Delay_from_due_date { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"Num_of_Delayed_Payment")]
            public string Num_of_Delayed_Payment { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"Changed_Credit_Limit")]
            public float Changed_Credit_Limit { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"Num_Credit_Inquiries")]
            public float Num_Credit_Inquiries { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"Credit_Mix")]
            public string Credit_Mix { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"Outstanding_Debt")]
            public float Outstanding_Debt { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"Credit_Utilization_Ratio")]
            public float Credit_Utilization_Ratio { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"Credit_History_Age")]
            public string Credit_History_Age { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"Payment_of_Min_Amount")]
            public string Payment_of_Min_Amount { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"Total_EMI_per_month")]
            public string Total_EMI_per_month { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"Amount_invested_monthly")]
            public string Amount_invested_monthly { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"Payment_Behaviour")]
            public string Payment_Behaviour { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"Monthly_Balance")]
            public string Monthly_Balance { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"Credit_Score")]
            public string Credit_Score { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for CreditScoreClassification.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"ID")]
            public float[] ID { get; set; }

            [ColumnName(@"Customer_ID")]
            public float[] Customer_ID { get; set; }

            [ColumnName(@"Month")]
            public float[] Month { get; set; }

            [ColumnName(@"Name")]
            public float[] Name { get; set; }

            [ColumnName(@"Age")]
            public float[] Age { get; set; }

            [ColumnName(@"SSN")]
            public float[] SSN { get; set; }

            [ColumnName(@"Occupation")]
            public float[] Occupation { get; set; }

            [ColumnName(@"Annual_Income")]
            public float[] Annual_Income { get; set; }

            [ColumnName(@"Monthly_Inhand_Salary")]
            public float Monthly_Inhand_Salary { get; set; }

            [ColumnName(@"Num_Bank_Accounts")]
            public float Num_Bank_Accounts { get; set; }

            [ColumnName(@"Num_Credit_Card")]
            public float Num_Credit_Card { get; set; }

            [ColumnName(@"Interest_Rate")]
            public float Interest_Rate { get; set; }

            [ColumnName(@"Num_of_Loan")]
            public float[] Num_of_Loan { get; set; }

            [ColumnName(@"Type_of_Loan")]
            public float[] Type_of_Loan { get; set; }

            [ColumnName(@"Delay_from_due_date")]
            public float[] Delay_from_due_date { get; set; }

            [ColumnName(@"Num_of_Delayed_Payment")]
            public float[] Num_of_Delayed_Payment { get; set; }

            [ColumnName(@"Changed_Credit_Limit")]
            public float Changed_Credit_Limit { get; set; }

            [ColumnName(@"Num_Credit_Inquiries")]
            public float Num_Credit_Inquiries { get; set; }

            [ColumnName(@"Credit_Mix")]
            public float[] Credit_Mix { get; set; }

            [ColumnName(@"Outstanding_Debt")]
            public float Outstanding_Debt { get; set; }

            [ColumnName(@"Credit_Utilization_Ratio")]
            public float Credit_Utilization_Ratio { get; set; }

            [ColumnName(@"Credit_History_Age")]
            public float[] Credit_History_Age { get; set; }

            [ColumnName(@"Payment_of_Min_Amount")]
            public float[] Payment_of_Min_Amount { get; set; }

            [ColumnName(@"Total_EMI_per_month")]
            public float[] Total_EMI_per_month { get; set; }

            [ColumnName(@"Amount_invested_monthly")]
            public float[] Amount_invested_monthly { get; set; }

            [ColumnName(@"Payment_Behaviour")]
            public float[] Payment_Behaviour { get; set; }

            [ColumnName(@"Monthly_Balance")]
            public float[] Monthly_Balance { get; set; }

            [ColumnName(@"Credit_Score")]
            public uint Credit_Score { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("CreditScoreClassification.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict scores for all possible labels.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static IOrderedEnumerable<KeyValuePair<string, float>> PredictAllLabels(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            var result = predEngine.Predict(input);
            return GetSortedScoresWithLabels(result);
        }

        /// <summary>
        /// Map the unlabeled result score array to the predicted label names.
        /// </summary>
        /// <param name="result">Prediction to get the labeled scores from.</param>
        /// <returns>Ordered list of label and score.</returns>
        /// <exception cref="Exception"></exception>
        public static IOrderedEnumerable<KeyValuePair<string, float>> GetSortedScoresWithLabels(ModelOutput result)
        {
            var unlabeledScores = result.Score;
            var labelNames = GetLabels(result);

            Dictionary<string, float> labledScores = new Dictionary<string, float>();
            for (int i = 0; i < labelNames.Count(); i++)
            {
                // Map the names to the predicted result score array
                var labelName = labelNames.ElementAt(i);
                labledScores.Add(labelName.ToString(), unlabeledScores[i]);
            }

            return labledScores.OrderByDescending(c => c.Value);
        }

        /// <summary>
        /// Get the ordered label names.
        /// </summary>
        /// <param name="result">Predicted result to get the labels from.</param>
        /// <returns>List of labels.</returns>
        /// <exception cref="Exception"></exception>
        private static IEnumerable<string> GetLabels(ModelOutput result)
        {
            var schema = PredictEngine.Value.OutputSchema;

            var labelColumn = schema.GetColumnOrNull("Credit_Score");
            if (labelColumn == null)
            {
                throw new Exception("Credit_Score column not found. Make sure the name searched for matches the name in the schema.");
            }

            // Key values contains an ordered array of the possible labels. This allows us to map the results to the correct label value.
            var keyNames = new VBuffer<ReadOnlyMemory<char>>();
            labelColumn.Value.GetKeyValues(ref keyNames);
            return keyNames.DenseValues().Select(x => x.ToString());
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
