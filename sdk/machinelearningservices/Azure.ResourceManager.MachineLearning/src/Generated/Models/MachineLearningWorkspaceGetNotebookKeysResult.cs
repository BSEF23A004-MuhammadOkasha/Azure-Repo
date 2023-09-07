// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceGetNotebookKeysResult. </summary>
    public partial class MachineLearningWorkspaceGetNotebookKeysResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceGetNotebookKeysResult"/>. </summary>
        internal MachineLearningWorkspaceGetNotebookKeysResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceGetNotebookKeysResult"/>. </summary>
        /// <param name="primaryAccessKey"></param>
        /// <param name="secondaryAccessKey"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceGetNotebookKeysResult(string primaryAccessKey, string secondaryAccessKey, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryAccessKey = primaryAccessKey;
            SecondaryAccessKey = secondaryAccessKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the primary access key. </summary>
        public string PrimaryAccessKey { get; }
        /// <summary> Gets the secondary access key. </summary>
        public string SecondaryAccessKey { get; }
    }
}
