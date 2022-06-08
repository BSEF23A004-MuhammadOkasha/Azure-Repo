// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> Response of getting a model. </summary>
    public partial class Model
    {
        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        internal Model(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo"> Train result of a model including status, errors and diagnose info for model and variables. </param>
        internal Model(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime, ModelInfo modelInfo)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            ModelInfo = modelInfo;
        }

        /// <summary> Model identifier. </summary>
        public Guid ModelId { get; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedTime { get; }
        /// <summary> Date and time (UTC) when the model was last updated. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary> Train result of a model including status, errors and diagnose info for model and variables. </summary>
        public ModelInfo ModelInfo { get; }
    }
}
