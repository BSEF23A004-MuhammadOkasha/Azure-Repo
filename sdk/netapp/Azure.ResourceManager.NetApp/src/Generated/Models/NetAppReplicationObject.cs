// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Replication properties. </summary>
    public partial class NetAppReplicationObject
    {
        /// <summary> Initializes a new instance of NetAppReplicationObject. </summary>
        /// <param name="remoteVolumeResourceId"> The resource ID of the remote volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="remoteVolumeResourceId"/> is null. </exception>
        public NetAppReplicationObject(ResourceIdentifier remoteVolumeResourceId)
        {
            if (remoteVolumeResourceId == null)
            {
                throw new ArgumentNullException(nameof(remoteVolumeResourceId));
            }

            RemoteVolumeResourceId = remoteVolumeResourceId;
        }

        /// <summary> Initializes a new instance of NetAppReplicationObject. </summary>
        /// <param name="replicationId"> Id. </param>
        /// <param name="endpointType"> Indicates whether the local volume is the source or destination for the Volume Replication. </param>
        /// <param name="replicationSchedule"> Schedule. </param>
        /// <param name="remoteVolumeResourceId"> The resource ID of the remote volume. </param>
        /// <param name="remoteVolumeRegion"> The remote region for the other end of the Volume Replication. </param>
        internal NetAppReplicationObject(string replicationId, NetAppEndpointType? endpointType, NetAppReplicationSchedule? replicationSchedule, ResourceIdentifier remoteVolumeResourceId, string remoteVolumeRegion)
        {
            ReplicationId = replicationId;
            EndpointType = endpointType;
            ReplicationSchedule = replicationSchedule;
            RemoteVolumeResourceId = remoteVolumeResourceId;
            RemoteVolumeRegion = remoteVolumeRegion;
        }

        /// <summary> Id. </summary>
        public string ReplicationId { get; set; }
        /// <summary> Indicates whether the local volume is the source or destination for the Volume Replication. </summary>
        public NetAppEndpointType? EndpointType { get; set; }
        /// <summary> Schedule. </summary>
        public NetAppReplicationSchedule? ReplicationSchedule { get; set; }
        /// <summary> The resource ID of the remote volume. </summary>
        public ResourceIdentifier RemoteVolumeResourceId { get; set; }
        /// <summary> The remote region for the other end of the Volume Replication. </summary>
        public string RemoteVolumeRegion { get; set; }
    }
}
