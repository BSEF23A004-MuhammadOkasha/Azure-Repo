// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of servers. </summary>
    internal partial class MySqlServerListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlServerListResult"/>. </summary>
        internal MySqlServerListResult()
        {
            Value = new ChangeTrackingList<MySqlServerData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerListResult"/>. </summary>
        /// <param name="value"> The list of servers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlServerListResult(IReadOnlyList<MySqlServerData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of servers. </summary>
        public IReadOnlyList<MySqlServerData> Value { get; }
    }
}
