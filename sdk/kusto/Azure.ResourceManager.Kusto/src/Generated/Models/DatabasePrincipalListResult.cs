// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto database principals operation response. </summary>
    internal partial class DatabasePrincipalListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DatabasePrincipalListResult"/>. </summary>
        internal DatabasePrincipalListResult()
        {
            Value = new ChangeTrackingList<KustoDatabasePrincipal>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabasePrincipalListResult"/>. </summary>
        /// <param name="value"> The list of Kusto database principals. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabasePrincipalListResult(IReadOnlyList<KustoDatabasePrincipal> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Kusto database principals. </summary>
        public IReadOnlyList<KustoDatabasePrincipal> Value { get; }
    }
}
