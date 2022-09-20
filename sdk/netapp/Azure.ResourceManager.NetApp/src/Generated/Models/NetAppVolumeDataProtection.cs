// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
    public partial class NetAppVolumeDataProtection
    {
        /// <summary> Initializes a new instance of NetAppVolumeDataProtection. </summary>
        public NetAppVolumeDataProtection()
        {
        }

        /// <summary> Initializes a new instance of NetAppVolumeDataProtection. </summary>
        /// <param name="backup"> Backup Properties. </param>
        /// <param name="replication"> Replication properties. </param>
        /// <param name="snapshot"> Snapshot properties. </param>
        internal NetAppVolumeDataProtection(NetAppVolumeBackupConfiguration backup, NetAppReplicationObject replication, VolumeSnapshotProperties snapshot)
        {
            Backup = backup;
            Replication = replication;
            Snapshot = snapshot;
        }

        /// <summary> Backup Properties. </summary>
        public NetAppVolumeBackupConfiguration Backup { get; set; }
        /// <summary> Replication properties. </summary>
        public NetAppReplicationObject Replication { get; set; }
        /// <summary> Snapshot properties. </summary>
        internal VolumeSnapshotProperties Snapshot { get; set; }
        /// <summary> Snapshot Policy ResourceId. </summary>
        public ResourceIdentifier SnapshotPolicyId
        {
            get => Snapshot is null ? default : Snapshot.SnapshotPolicyId;
            set
            {
                if (Snapshot is null)
                    Snapshot = new VolumeSnapshotProperties();
                Snapshot.SnapshotPolicyId = value;
            }
        }
    }
}
