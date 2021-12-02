// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to perform long term retention backup update operation. </summary>
    public partial class UpdateLongTermRetentionBackupOptions
    {
        /// <summary> Initializes a new instance of UpdateLongTermRetentionBackupOptions. </summary>
        public UpdateLongTermRetentionBackupOptions()
        {
        }

        /// <summary> The storage redundancy type of the copied backup. </summary>
        public RequestedBackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
    }
}
