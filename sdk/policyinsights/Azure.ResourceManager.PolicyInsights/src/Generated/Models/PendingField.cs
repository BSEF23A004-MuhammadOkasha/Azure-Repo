// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> A field that should be evaluated against Azure Policy to determine restrictions. </summary>
    public partial class PendingField
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PendingField"/>. </summary>
        /// <param name="field"> The name of the field. This can be a top-level property like 'name' or 'type' or an Azure Policy field alias. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="field"/> is null. </exception>
        public PendingField(string field)
        {
            Argument.AssertNotNull(field, nameof(field));

            Field = field;
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PendingField"/>. </summary>
        /// <param name="field"> The name of the field. This can be a top-level property like 'name' or 'type' or an Azure Policy field alias. </param>
        /// <param name="values"> The list of potential values for the field that should be evaluated against Azure Policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PendingField(string field, IList<string> values, Dictionary<string, BinaryData> rawData)
        {
            Field = field;
            Values = values;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PendingField"/> for deserialization. </summary>
        internal PendingField()
        {
        }

        /// <summary> The name of the field. This can be a top-level property like 'name' or 'type' or an Azure Policy field alias. </summary>
        public string Field { get; }
        /// <summary> The list of potential values for the field that should be evaluated against Azure Policy. </summary>
        public IList<string> Values { get; }
    }
}
