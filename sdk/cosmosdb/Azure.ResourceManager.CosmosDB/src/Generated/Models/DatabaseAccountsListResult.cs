// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the database accounts and their properties. </summary>
    public partial class DatabaseAccountsListResult
    {
        /// <summary> Initializes a new instance of DatabaseAccountsListResult. </summary>
        internal DatabaseAccountsListResult()
        {
            Value = new ChangeTrackingList<DatabaseAccountGetResults>();
        }

        /// <summary> Initializes a new instance of DatabaseAccountsListResult. </summary>
        /// <param name="value"> List of database account and their properties. </param>
        internal DatabaseAccountsListResult(IReadOnlyList<DatabaseAccountGetResults> value)
        {
            Value = value;
        }

        /// <summary> List of database account and their properties. </summary>
        public IReadOnlyList<DatabaseAccountGetResults> Value { get; }
    }
}
