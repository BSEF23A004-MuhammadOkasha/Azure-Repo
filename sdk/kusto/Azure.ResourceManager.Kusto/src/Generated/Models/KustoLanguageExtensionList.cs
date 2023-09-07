// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list of language extension objects. </summary>
    public partial class KustoLanguageExtensionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoLanguageExtensionList"/>. </summary>
        public KustoLanguageExtensionList()
        {
            Value = new ChangeTrackingList<KustoLanguageExtension>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoLanguageExtensionList"/>. </summary>
        /// <param name="value"> The list of language extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoLanguageExtensionList(IList<KustoLanguageExtension> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of language extensions. </summary>
        public IList<KustoLanguageExtension> Value { get; }
    }
}
