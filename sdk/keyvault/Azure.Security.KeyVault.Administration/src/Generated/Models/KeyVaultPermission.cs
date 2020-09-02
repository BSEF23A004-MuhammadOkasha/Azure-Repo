// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role definition permissions. </summary>
    public partial class KeyVaultPermission
    {
        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        internal KeyVaultPermission()
        {
            Actions = new ChangeTrackingList<string>();
            NotActions = new ChangeTrackingList<string>();
            DataActions = new ChangeTrackingList<string>();
            NotDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        /// <param name="actions"> Allowed actions. </param>
        /// <param name="notActions"> Denied actions. </param>
        /// <param name="dataActions"> Allowed Data actions. </param>
        /// <param name="notDataActions"> Denied Data actions. </param>
        internal KeyVaultPermission(IList<string> actions, IList<string> notActions, IList<string> dataActions, IList<string> notDataActions)
        {
            Actions = actions;
            NotActions = notActions;
            DataActions = dataActions;
            NotDataActions = notDataActions;
        }
    }
}
