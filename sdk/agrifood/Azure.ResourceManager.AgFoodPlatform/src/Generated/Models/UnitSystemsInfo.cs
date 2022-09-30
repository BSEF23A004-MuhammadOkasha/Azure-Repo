// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Unit systems info for the data provider. </summary>
    public partial class UnitSystemsInfo
    {
        /// <summary> Initializes a new instance of UnitSystemsInfo. </summary>
        /// <param name="key"> UnitSystem key sent as part of ProviderInput. </param>
        /// <param name="values"> List of unit systems supported by this data provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="values"/> is null. </exception>
        internal UnitSystemsInfo(string key, IEnumerable<string> values)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            Key = key;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of UnitSystemsInfo. </summary>
        /// <param name="key"> UnitSystem key sent as part of ProviderInput. </param>
        /// <param name="values"> List of unit systems supported by this data provider. </param>
        internal UnitSystemsInfo(string key, IReadOnlyList<string> values)
        {
            Key = key;
            Values = values;
        }

        /// <summary> UnitSystem key sent as part of ProviderInput. </summary>
        public string Key { get; }
        /// <summary> List of unit systems supported by this data provider. </summary>
        public IReadOnlyList<string> Values { get; }
    }
}
