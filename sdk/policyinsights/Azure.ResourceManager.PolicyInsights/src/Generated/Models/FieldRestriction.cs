// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The restrictions on a field imposed by a specific policy. </summary>
    public partial class FieldRestriction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FieldRestriction"/>. </summary>
        internal FieldRestriction()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FieldRestriction"/>. </summary>
        /// <param name="result"> The type of restriction that is imposed on the field. </param>
        /// <param name="defaultValue"> The value that policy will set for the field if the user does not provide a value. </param>
        /// <param name="values"> The values that policy either requires or denies for the field. </param>
        /// <param name="policy"> The details of the policy that is causing the field restriction. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FieldRestriction(FieldRestrictionResult? result, string defaultValue, IReadOnlyList<string> values, PolicyReference policy, Dictionary<string, BinaryData> rawData)
        {
            Result = result;
            DefaultValue = defaultValue;
            Values = values;
            Policy = policy;
            _rawData = rawData;
        }

        /// <summary> The type of restriction that is imposed on the field. </summary>
        public FieldRestrictionResult? Result { get; }
        /// <summary> The value that policy will set for the field if the user does not provide a value. </summary>
        public string DefaultValue { get; }
        /// <summary> The values that policy either requires or denies for the field. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The details of the policy that is causing the field restriction. </summary>
        public PolicyReference Policy { get; }
    }
}
