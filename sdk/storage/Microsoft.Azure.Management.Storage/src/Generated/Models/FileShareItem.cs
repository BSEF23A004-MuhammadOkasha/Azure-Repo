// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The file share properties be listed out.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileShareItem : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the FileShareItem class.
        /// </summary>
        public FileShareItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileShareItem class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="lastModifiedTime">Returns the date and time the share
        /// was last modified.</param>
        /// <param name="metadata">A name-value pair to associate with the
        /// share as metadata.</param>
        /// <param name="shareQuota">The maximum size of the share, in
        /// gigabytes. Must be greater than 0, and less than or equal to 5TB
        /// (5120). For Large File Shares, the maximum size is 102400.</param>
        /// <param name="enabledProtocols">The authentication protocol that is
        /// used for the file share. Can only be specified when creating a
        /// share. Possible values include: 'SMB', 'NFS'</param>
        /// <param name="rootSquash">The property is for NFS share only. The
        /// default is NoRootSquash. Possible values include: 'NoRootSquash',
        /// 'RootSquash', 'AllSquash'</param>
        /// <param name="version">The version of the share.</param>
        /// <param name="deleted">Indicates whether the share was
        /// deleted.</param>
        /// <param name="deletedTime">The deleted time if the share was
        /// deleted.</param>
        /// <param name="remainingRetentionDays">Remaining retention days for
        /// share that was soft deleted.</param>
        /// <param name="accessTier">Access tier for specific share. GpV2
        /// account can choose between TransactionOptimized (default), Hot, and
        /// Cool. FileStorage account can choose Premium. Possible values
        /// include: 'TransactionOptimized', 'Hot', 'Cool', 'Premium'</param>
        /// <param name="accessTierChangeTime">Indicates the last modification
        /// time for share access tier.</param>
        /// <param name="accessTierStatus">Indicates if there is a pending
        /// transition for access tier.</param>
        /// <param name="shareUsageBytes">The approximate size of the data
        /// stored on the share. Note that this value may not include all
        /// recently created or recently resized files.</param>
        public FileShareItem(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), IDictionary<string, string> metadata = default(IDictionary<string, string>), int? shareQuota = default(int?), string enabledProtocols = default(string), string rootSquash = default(string), string version = default(string), bool? deleted = default(bool?), System.DateTime? deletedTime = default(System.DateTime?), int? remainingRetentionDays = default(int?), string accessTier = default(string), System.DateTime? accessTierChangeTime = default(System.DateTime?), string accessTierStatus = default(string), long? shareUsageBytes = default(long?))
            : base(id, name, type, etag)
        {
            LastModifiedTime = lastModifiedTime;
            Metadata = metadata;
            ShareQuota = shareQuota;
            EnabledProtocols = enabledProtocols;
            RootSquash = rootSquash;
            Version = version;
            Deleted = deleted;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTier = accessTier;
            AccessTierChangeTime = accessTierChangeTime;
            AccessTierStatus = accessTierStatus;
            ShareUsageBytes = shareUsageBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the date and time the share was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets a name-value pair to associate with the share as
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the share, in gigabytes. Must be
        /// greater than 0, and less than or equal to 5TB (5120). For Large
        /// File Shares, the maximum size is 102400.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareQuota")]
        public int? ShareQuota { get; set; }

        /// <summary>
        /// Gets or sets the authentication protocol that is used for the file
        /// share. Can only be specified when creating a share. Possible values
        /// include: 'SMB', 'NFS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledProtocols")]
        public string EnabledProtocols { get; set; }

        /// <summary>
        /// Gets or sets the property is for NFS share only. The default is
        /// NoRootSquash. Possible values include: 'NoRootSquash',
        /// 'RootSquash', 'AllSquash'
        /// </summary>
        [JsonProperty(PropertyName = "properties.rootSquash")]
        public string RootSquash { get; set; }

        /// <summary>
        /// Gets the version of the share.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets indicates whether the share was deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleted")]
        public bool? Deleted { get; private set; }

        /// <summary>
        /// Gets the deleted time if the share was deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletedTime")]
        public System.DateTime? DeletedTime { get; private set; }

        /// <summary>
        /// Gets remaining retention days for share that was soft deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remainingRetentionDays")]
        public int? RemainingRetentionDays { get; private set; }

        /// <summary>
        /// Gets or sets access tier for specific share. GpV2 account can
        /// choose between TransactionOptimized (default), Hot, and Cool.
        /// FileStorage account can choose Premium. Possible values include:
        /// 'TransactionOptimized', 'Hot', 'Cool', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public string AccessTier { get; set; }

        /// <summary>
        /// Gets indicates the last modification time for share access tier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTierChangeTime")]
        public System.DateTime? AccessTierChangeTime { get; private set; }

        /// <summary>
        /// Gets indicates if there is a pending transition for access tier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTierStatus")]
        public string AccessTierStatus { get; private set; }

        /// <summary>
        /// Gets the approximate size of the data stored on the share. Note
        /// that this value may not include all recently created or recently
        /// resized files.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareUsageBytes")]
        public long? ShareUsageBytes { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareQuota != null)
            {
                if (ShareQuota > 102400)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "ShareQuota", 102400);
                }
                if (ShareQuota < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ShareQuota", 1);
                }
            }
        }
    }
}
