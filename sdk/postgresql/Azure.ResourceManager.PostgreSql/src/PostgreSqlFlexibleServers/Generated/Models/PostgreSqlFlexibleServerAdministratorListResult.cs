// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of active directory administrators. </summary>
    internal partial class PostgreSqlFlexibleServerAdministratorListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerAdministratorListResult"/>. </summary>
        internal PostgreSqlFlexibleServerAdministratorListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerAdministratorListResult"/>. </summary>
        /// <param name="value"> The list of active directory administrators. </param>
        /// <param name="nextLink"> The link used to get the next page of active directory. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerAdministratorListResult(IReadOnlyList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of active directory administrators. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData> Value { get; }
        /// <summary> The link used to get the next page of active directory. </summary>
        public string NextLink { get; }
    }
}
