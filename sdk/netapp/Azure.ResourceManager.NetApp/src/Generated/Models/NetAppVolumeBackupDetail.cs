// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume details using the backup policy. </summary>
    public partial class NetAppVolumeBackupDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupDetail"/>. </summary>
        internal NetAppVolumeBackupDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupDetail"/>. </summary>
        /// <param name="volumeName"> Volume name. </param>
        /// <param name="backupsCount"> Total count of backups for volume. </param>
        /// <param name="isPolicyEnabled"> Policy enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupDetail(string volumeName, int? backupsCount, bool? isPolicyEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VolumeName = volumeName;
            BackupsCount = backupsCount;
            IsPolicyEnabled = isPolicyEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Volume name. </summary>
        public string VolumeName { get; }
        /// <summary> Total count of backups for volume. </summary>
        public int? BackupsCount { get; }
        /// <summary> Policy enabled. </summary>
        public bool? IsPolicyEnabled { get; }
    }
}
