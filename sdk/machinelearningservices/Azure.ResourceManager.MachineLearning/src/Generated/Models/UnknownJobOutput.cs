// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownJobOutput. </summary>
    internal partial class UnknownJobOutput : MachineLearningJobOutput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJobOutput"/>. </summary>
        /// <param name="description"> Description for the output. </param>
        /// <param name="jobOutputType"> [Required] Specifies the type of job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownJobOutput(string description, JobOutputType jobOutputType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(description, jobOutputType, serializedAdditionalRawData)
        {
            JobOutputType = jobOutputType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownJobOutput"/> for deserialization. </summary>
        internal UnknownJobOutput()
        {
        }
    }
}
