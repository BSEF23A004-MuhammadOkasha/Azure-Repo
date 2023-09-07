// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The content hash. </summary>
    public partial class LogicContentHash
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogicContentHash"/>. </summary>
        internal LogicContentHash()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicContentHash"/>. </summary>
        /// <param name="algorithm"> The algorithm of the content hash. </param>
        /// <param name="value"> The value of the content hash. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicContentHash(string algorithm, string value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Algorithm = algorithm;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The algorithm of the content hash. </summary>
        public string Algorithm { get; }
        /// <summary> The value of the content hash. </summary>
        public string Value { get; }
    }
}
