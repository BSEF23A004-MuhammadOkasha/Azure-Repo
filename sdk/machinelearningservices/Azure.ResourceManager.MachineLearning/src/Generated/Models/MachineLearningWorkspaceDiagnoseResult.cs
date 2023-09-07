// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceDiagnoseResult. </summary>
    public partial class MachineLearningWorkspaceDiagnoseResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceDiagnoseResult"/>. </summary>
        internal MachineLearningWorkspaceDiagnoseResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceDiagnoseResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceDiagnoseResult(MachineLearningDiagnoseResultValue value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public MachineLearningDiagnoseResultValue Value { get; }
    }
}
