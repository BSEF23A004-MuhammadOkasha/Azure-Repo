// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KubernetesLabel represents a single entry for a Kubernetes label or taint such as those used on a node or pod. </summary>
    public partial class KubernetesLabel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesLabel"/>. </summary>
        /// <param name="key"> The name of the label or taint. </param>
        /// <param name="value"> The value of the label or taint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public KubernetesLabel(string key, string value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesLabel"/>. </summary>
        /// <param name="key"> The name of the label or taint. </param>
        /// <param name="value"> The value of the label or taint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesLabel(string key, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesLabel"/> for deserialization. </summary>
        internal KubernetesLabel()
        {
        }

        /// <summary> The name of the label or taint. </summary>
        public string Key { get; set; }
        /// <summary> The value of the label or taint. </summary>
        public string Value { get; set; }
    }
}
