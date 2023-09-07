// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A collection of batch configurations. </summary>
    internal partial class BatchConfigurationCollection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchConfigurationCollection"/>. </summary>
        internal BatchConfigurationCollection()
        {
            Value = new ChangeTrackingList<IntegrationAccountBatchConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchConfigurationCollection"/>. </summary>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchConfigurationCollection(IReadOnlyList<IntegrationAccountBatchConfigurationData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IntegrationAccountBatchConfigurationData> Value { get; }
    }
}
