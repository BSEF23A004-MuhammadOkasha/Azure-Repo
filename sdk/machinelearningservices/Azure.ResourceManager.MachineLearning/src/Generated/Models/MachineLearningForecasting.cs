// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Forecasting task in AutoML Table vertical. </summary>
    public partial class MachineLearningForecasting : AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningForecasting"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        public MachineLearningForecasting(MachineLearningTableJobInput trainingData) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));

            CvSplitColumnNames = new ChangeTrackingList<string>();
            TaskType = TaskType.Forecasting;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningForecasting"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="forecastingSettings"> Forecasting task specific inputs. </param>
        /// <param name="primaryMetric"> Primary metric for forecasting task. </param>
        /// <param name="trainingSettings"> Inputs for training phase for an AutoML Job. </param>
        /// <param name="cvSplitColumnNames"> Columns to use for CVSplit data. </param>
        /// <param name="featurizationSettings"> Featurization inputs needed for AutoML job. </param>
        /// <param name="limitSettings"> Execution constraints for AutoMLJob. </param>
        /// <param name="nCrossValidations">
        /// Number of cross validation folds to be applied on training dataset
        /// when validation dataset is not provided.
        /// Please note <see cref="NCrossValidations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoNCrossValidations"/> and <see cref="CustomNCrossValidations"/>.
        /// </param>
        /// <param name="testData"> Test data input. </param>
        /// <param name="testDataSize">
        /// The fraction of test dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        /// <param name="validationData"> Validation data inputs. </param>
        /// <param name="validationDataSize">
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        /// <param name="weightColumnName"> The name of the sample weight column. Automated ML supports a weighted column as an input, causing rows in the data to be weighted up or down. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningForecasting(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, ForecastingSettings forecastingSettings, ForecastingPrimaryMetric? primaryMetric, ForecastingTrainingSettings trainingSettings, IList<string> cvSplitColumnNames, TableVerticalFeaturizationSettings featurizationSettings, TableVerticalLimitSettings limitSettings, NCrossValidations nCrossValidations, MachineLearningTableJobInput testData, double? testDataSize, MachineLearningTableJobInput validationData, double? validationDataSize, string weightColumnName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(logVerbosity, targetColumnName, taskType, trainingData, serializedAdditionalRawData)
        {
            ForecastingSettings = forecastingSettings;
            PrimaryMetric = primaryMetric;
            TrainingSettings = trainingSettings;
            CvSplitColumnNames = cvSplitColumnNames;
            FeaturizationSettings = featurizationSettings;
            LimitSettings = limitSettings;
            NCrossValidations = nCrossValidations;
            TestData = testData;
            TestDataSize = testDataSize;
            ValidationData = validationData;
            ValidationDataSize = validationDataSize;
            WeightColumnName = weightColumnName;
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningForecasting"/> for deserialization. </summary>
        internal MachineLearningForecasting()
        {
        }

        /// <summary> Forecasting task specific inputs. </summary>
        public ForecastingSettings ForecastingSettings { get; set; }
        /// <summary> Primary metric for forecasting task. </summary>
        public ForecastingPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary> Inputs for training phase for an AutoML Job. </summary>
        public ForecastingTrainingSettings TrainingSettings { get; set; }
        /// <summary> Columns to use for CVSplit data. </summary>
        public IList<string> CvSplitColumnNames { get; set; }
        /// <summary> Featurization inputs needed for AutoML job. </summary>
        public TableVerticalFeaturizationSettings FeaturizationSettings { get; set; }
        /// <summary> Execution constraints for AutoMLJob. </summary>
        public TableVerticalLimitSettings LimitSettings { get; set; }
        /// <summary>
        /// Number of cross validation folds to be applied on training dataset
        /// when validation dataset is not provided.
        /// Please note <see cref="NCrossValidations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoNCrossValidations"/> and <see cref="CustomNCrossValidations"/>.
        /// </summary>
        public NCrossValidations NCrossValidations { get; set; }
        /// <summary> Test data input. </summary>
        public MachineLearningTableJobInput TestData { get; set; }
        /// <summary>
        /// The fraction of test dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </summary>
        public double? TestDataSize { get; set; }
        /// <summary> Validation data inputs. </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
        /// <summary>
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </summary>
        public double? ValidationDataSize { get; set; }
        /// <summary> The name of the sample weight column. Automated ML supports a weighted column as an input, causing rows in the data to be weighted up or down. </summary>
        public string WeightColumnName { get; set; }
    }
}
