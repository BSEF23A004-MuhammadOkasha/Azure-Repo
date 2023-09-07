// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Literal input type. </summary>
    public partial class MachineLearningLiteralJobInput : MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningLiteralJobInput"/>. </summary>
        /// <param name="value"> [Required] Literal value for the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningLiteralJobInput(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
            JobInputType = JobInputType.Literal;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningLiteralJobInput"/>. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="value"> [Required] Literal value for the input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningLiteralJobInput(string description, JobInputType jobInputType, string value, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(description, jobInputType, serializedAdditionalRawData)
        {
            Value = value;
            JobInputType = jobInputType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningLiteralJobInput"/> for deserialization. </summary>
        internal MachineLearningLiteralJobInput()
        {
        }

        /// <summary> [Required] Literal value for the input. </summary>
        public string Value { get; set; }
    }
}
