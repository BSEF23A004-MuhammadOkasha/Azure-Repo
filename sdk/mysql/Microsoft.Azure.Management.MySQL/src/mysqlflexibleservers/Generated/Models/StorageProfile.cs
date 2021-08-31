// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage Profile properties of a server
    /// </summary>
    public partial class StorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        public StorageProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        /// <param name="backupRetentionDays">Backup retention days for the
        /// server.</param>
        /// <param name="storageMB">Max storage allowed for a server.</param>
        /// <param name="storageIops">Storage IOPS for a server.</param>
        /// <param name="storageAutogrow">Enable Storage Auto Grow. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="fileStorageSkuName">The sku name of the file
        /// storage.</param>
        public StorageProfile(int? backupRetentionDays = default(int?), int? storageMB = default(int?), int? storageIops = default(int?), string storageAutogrow = default(string), string fileStorageSkuName = default(string))
        {
            BackupRetentionDays = backupRetentionDays;
            StorageMB = storageMB;
            StorageIops = storageIops;
            StorageAutogrow = storageAutogrow;
            FileStorageSkuName = fileStorageSkuName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup retention days for the server.
        /// </summary>
        [JsonProperty(PropertyName = "backupRetentionDays")]
        public int? BackupRetentionDays { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "storageMB")]
        public int? StorageMB { get; set; }

        /// <summary>
        /// Gets or sets storage IOPS for a server.
        /// </summary>
        [JsonProperty(PropertyName = "storageIops")]
        public int? StorageIops { get; set; }

        /// <summary>
        /// Gets or sets enable Storage Auto Grow. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "storageAutogrow")]
        public string StorageAutogrow { get; set; }

        /// <summary>
        /// Gets the sku name of the file storage.
        /// </summary>
        [JsonProperty(PropertyName = "fileStorageSkuName")]
        public string FileStorageSkuName { get; private set; }

    }
}
