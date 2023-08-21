// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Valid enum values in case of an enum property. </summary>
    public partial class ProfileEnumValidValuesFormat
    {
        /// <summary> Initializes a new instance of ProfileEnumValidValuesFormat. </summary>
        public ProfileEnumValidValuesFormat()
        {
            LocalizedValueNames = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ProfileEnumValidValuesFormat. </summary>
        /// <param name="value"> The integer value of the enum member. </param>
        /// <param name="localizedValueNames"> Localized names of the enum member. </param>
        internal ProfileEnumValidValuesFormat(int? value, IDictionary<string, string> localizedValueNames)
        {
            Value = value;
            LocalizedValueNames = localizedValueNames;
        }

        /// <summary> The integer value of the enum member. </summary>
        public int? Value { get; set; }
        /// <summary> Localized names of the enum member. </summary>
        public IDictionary<string, string> LocalizedValueNames { get; }
    }
}
