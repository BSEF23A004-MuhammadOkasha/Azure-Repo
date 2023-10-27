// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Basic custom model information. </summary>
    public partial class CustomFormModelInfo
    {
        /// <summary> Initializes a new instance of CustomFormModelInfo. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="trainingStartedOn"> Date and time (UTC) when the model was created. </param>
        /// <param name="trainingCompletedOn"> Date and time (UTC) when the status was last updated. </param>
        internal CustomFormModelInfo(Guid modelId, CustomFormModelStatus status, DateTimeOffset trainingStartedOn, DateTimeOffset trainingCompletedOn)
        {
            ModelId = modelId;
            Status = status;
            TrainingStartedOn = trainingStartedOn;
            TrainingCompletedOn = trainingCompletedOn;
        }

        /// <summary> Initializes a new instance of CustomFormModelInfo. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="trainingStartedOn"> Date and time (UTC) when the model was created. </param>
        /// <param name="trainingCompletedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="modelName"> Optional user defined model name (max length: 1024). </param>
        /// <param name="properties"> Optional model attributes. </param>
        internal CustomFormModelInfo(Guid modelId, CustomFormModelStatus status, DateTimeOffset trainingStartedOn, DateTimeOffset trainingCompletedOn, string modelName, CustomFormModelProperties properties)
        {
            ModelId = modelId;
            Status = status;
            TrainingStartedOn = trainingStartedOn;
            TrainingCompletedOn = trainingCompletedOn;
            ModelName = modelName;
            Properties = properties;
        }
    }
}
