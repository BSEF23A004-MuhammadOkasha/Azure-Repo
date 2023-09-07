// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role Definitions filter. </summary>
    internal partial class RoleDefinitionFilter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionFilter"/>. </summary>
        internal RoleDefinitionFilter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionFilter"/>. </summary>
        /// <param name="roleName"> Returns role definition with the specific name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleDefinitionFilter(string roleName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleName = roleName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Returns role definition with the specific name. </summary>
        public string RoleName { get; }
    }
}
