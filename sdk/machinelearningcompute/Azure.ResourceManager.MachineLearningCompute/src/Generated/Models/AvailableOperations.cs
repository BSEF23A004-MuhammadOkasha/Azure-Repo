// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Available operation list. </summary>
    internal partial class AvailableOperations
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableOperations"/>. </summary>
        internal AvailableOperations()
        {
            Value = new ChangeTrackingList<ResourceOperation>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableOperations"/>. </summary>
        /// <param name="value"> An array of available operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableOperations(IReadOnlyList<ResourceOperation> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of available operations. </summary>
        public IReadOnlyList<ResourceOperation> Value { get; }
    }
}
