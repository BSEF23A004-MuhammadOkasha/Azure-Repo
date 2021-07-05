// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    /// <summary> Properties of the deleted managed HSM. </summary>
    public partial class DeletedManagedHsmProperties
    {
        /// <summary> Initializes a new instance of DeletedManagedHsmProperties. </summary>
        internal DeletedManagedHsmProperties()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DeletedManagedHsmProperties. </summary>
        /// <param name="mhsmId"> The resource id of the original managed HSM. </param>
        /// <param name="location"> The location of the original managed HSM. </param>
        /// <param name="deletionDate"> The deleted date. </param>
        /// <param name="scheduledPurgeDate"> The scheduled purged date. </param>
        /// <param name="purgeProtectionEnabled"> Purge protection status of the original managed HSM. </param>
        /// <param name="tags"> Tags of the original managed HSM. </param>
        internal DeletedManagedHsmProperties(string mhsmId, string location, DateTimeOffset? deletionDate, DateTimeOffset? scheduledPurgeDate, bool? purgeProtectionEnabled, IReadOnlyDictionary<string, string> tags)
        {
            MhsmId = mhsmId;
            Location = location;
            DeletionDate = deletionDate;
            ScheduledPurgeDate = scheduledPurgeDate;
            PurgeProtectionEnabled = purgeProtectionEnabled;
            Tags = tags;
        }

        /// <summary> The resource id of the original managed HSM. </summary>
        public string MhsmId { get; }
        /// <summary> The location of the original managed HSM. </summary>
        public string Location { get; }
        /// <summary> The deleted date. </summary>
        public DateTimeOffset? DeletionDate { get; }
        /// <summary> The scheduled purged date. </summary>
        public DateTimeOffset? ScheduledPurgeDate { get; }
        /// <summary> Purge protection status of the original managed HSM. </summary>
        public bool? PurgeProtectionEnabled { get; }
        /// <summary> Tags of the original managed HSM. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
