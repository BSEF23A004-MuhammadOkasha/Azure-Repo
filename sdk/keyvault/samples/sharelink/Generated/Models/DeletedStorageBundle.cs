// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> A deleted storage account bundle consisting of its previous id, attributes and its tags, as well as information on when it will be purged. </summary>
    public partial class DeletedStorageBundle : StorageBundle
    {
        /// <summary> Initializes a new instance of <see cref="DeletedStorageBundle"/>. </summary>
        internal DeletedStorageBundle()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedStorageBundle"/>. </summary>
        /// <param name="id"> The storage account id. </param>
        /// <param name="resourceId"> The storage account resource id. </param>
        /// <param name="activeKeyName"> The current active storage account key name. </param>
        /// <param name="autoRegenerateKey"> whether keyvault should manage the storage account for the user. </param>
        /// <param name="regenerationPeriod"> The key regeneration time duration specified in ISO-8601 format. </param>
        /// <param name="attributes"> The storage account attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="recoveryId"> The url of the recovery object, used to identify and recover the deleted storage account. </param>
        /// <param name="scheduledPurgeDate"> The time when the storage account is scheduled to be purged, in UTC. </param>
        /// <param name="deletedDate"> The time when the storage account was deleted, in UTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedStorageBundle(string id, string resourceId, string activeKeyName, bool? autoRegenerateKey, string regenerationPeriod, StorageAccountAttributes attributes, IReadOnlyDictionary<string, string> tags, string recoveryId, DateTimeOffset? scheduledPurgeDate, DateTimeOffset? deletedDate, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, resourceId, activeKeyName, autoRegenerateKey, regenerationPeriod, attributes, tags, serializedAdditionalRawData)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary> The url of the recovery object, used to identify and recover the deleted storage account. </summary>
        public string RecoveryId { get; }
        /// <summary> The time when the storage account is scheduled to be purged, in UTC. </summary>
        public DateTimeOffset? ScheduledPurgeDate { get; }
        /// <summary> The time when the storage account was deleted, in UTC. </summary>
        public DateTimeOffset? DeletedDate { get; }
    }
}
