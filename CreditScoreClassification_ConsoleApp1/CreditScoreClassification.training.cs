﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace CreditScoreClassification_ConsoleApp1
{
    public partial class CreditScoreClassification
    {
        public const string RetrainFilePath =  @".\data\train.csv";
        public const char RetrainSeparatorChar = ',';
        public const bool RetrainHasHeader =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader);
        }



        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }


        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"Monthly_Inhand_Salary", @"Monthly_Inhand_Salary"),new InputOutputColumnPair(@"Num_Bank_Accounts", @"Num_Bank_Accounts"),new InputOutputColumnPair(@"Num_Credit_Card", @"Num_Credit_Card"),new InputOutputColumnPair(@"Interest_Rate", @"Interest_Rate"),new InputOutputColumnPair(@"Changed_Credit_Limit", @"Changed_Credit_Limit"),new InputOutputColumnPair(@"Num_Credit_Inquiries", @"Num_Credit_Inquiries"),new InputOutputColumnPair(@"Outstanding_Debt", @"Outstanding_Debt"),new InputOutputColumnPair(@"Credit_Utilization_Ratio", @"Credit_Utilization_Ratio")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"ID",outputColumnName:@"ID"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Customer_ID",outputColumnName:@"Customer_ID"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Month",outputColumnName:@"Month"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Name",outputColumnName:@"Name"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Age",outputColumnName:@"Age"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"SSN",outputColumnName:@"SSN"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Occupation",outputColumnName:@"Occupation"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Annual_Income",outputColumnName:@"Annual_Income"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Num_of_Loan",outputColumnName:@"Num_of_Loan"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Type_of_Loan",outputColumnName:@"Type_of_Loan"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Delay_from_due_date",outputColumnName:@"Delay_from_due_date"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Num_of_Delayed_Payment",outputColumnName:@"Num_of_Delayed_Payment"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Credit_Mix",outputColumnName:@"Credit_Mix"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Credit_History_Age",outputColumnName:@"Credit_History_Age"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Payment_of_Min_Amount",outputColumnName:@"Payment_of_Min_Amount"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Total_EMI_per_month",outputColumnName:@"Total_EMI_per_month"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Amount_invested_monthly",outputColumnName:@"Amount_invested_monthly"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Payment_Behaviour",outputColumnName:@"Payment_Behaviour"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Monthly_Balance",outputColumnName:@"Monthly_Balance"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Monthly_Inhand_Salary",@"Num_Bank_Accounts",@"Num_Credit_Card",@"Interest_Rate",@"Changed_Credit_Limit",@"Num_Credit_Inquiries",@"Outstanding_Debt",@"Credit_Utilization_Ratio",@"ID",@"Customer_ID",@"Month",@"Name",@"Age",@"SSN",@"Occupation",@"Annual_Income",@"Num_of_Loan",@"Type_of_Loan",@"Delay_from_due_date",@"Num_of_Delayed_Payment",@"Credit_Mix",@"Credit_History_Age",@"Payment_of_Min_Amount",@"Total_EMI_per_month",@"Amount_invested_monthly",@"Payment_Behaviour",@"Monthly_Balance"}))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName:@"Credit_Score",inputColumnName:@"Credit_Score",addKeyValueAnnotationsAsText:false))      
                                    .Append(mlContext.MulticlassClassification.Trainers.OneVersusAll(binaryEstimator:mlContext.BinaryClassification.Trainers.FastForest(new FastForestBinaryTrainer.Options(){NumberOfTrees=4,NumberOfLeaves=4,FeatureFraction=1F,LabelColumnName=@"Credit_Score",FeatureColumnName=@"Features"}),labelColumnName:@"Credit_Score"))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName:@"PredictedLabel",inputColumnName:@"PredictedLabel"));

            return pipeline;
        }
    }
 }
