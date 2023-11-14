// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> advanced security object. </summary>
    public partial class AdvancedSecurityObjectListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AdvancedSecurityObjectListResult"/>. </summary>
        /// <param name="value"> response value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AdvancedSecurityObjectListResult(AdvancedSecurityObject value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedSecurityObjectListResult"/>. </summary>
        /// <param name="value"> response value. </param>
        /// <param name="nextLink"> next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdvancedSecurityObjectListResult(AdvancedSecurityObject value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedSecurityObjectListResult"/> for deserialization. </summary>
        internal AdvancedSecurityObjectListResult()
        {
        }

        /// <summary> response value. </summary>
        public AdvancedSecurityObject Value { get; }
        /// <summary> next link. </summary>
        public string NextLink { get; }
    }
}
