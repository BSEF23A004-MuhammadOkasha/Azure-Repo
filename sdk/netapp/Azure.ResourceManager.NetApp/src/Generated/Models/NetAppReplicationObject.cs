// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Replication properties. </summary>
    public partial class NetAppReplicationObject
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationObject"/>. </summary>
        public NetAppReplicationObject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppReplicationObject"/>. </summary>
        /// <param name="replicationId"> Id. </param>
        /// <param name="endpointType"> Indicates whether the local volume is the source or destination for the Volume Replication. </param>
        /// <param name="replicationSchedule"> Schedule. </param>
        /// <param name="remoteVolumeResourceId"> The resource ID of the remote volume. Required for cross region and cross zone replication. </param>
        /// <param name="remotePath"> The full path to a volume that is to be migrated into ANF. Required for Migration volumes. </param>
        /// <param name="remoteVolumeRegion"> The remote region for the other end of the Volume Replication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppReplicationObject(string replicationId, NetAppEndpointType? endpointType, NetAppReplicationSchedule? replicationSchedule, ResourceIdentifier remoteVolumeResourceId, RemotePath remotePath, string remoteVolumeRegion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReplicationId = replicationId;
            EndpointType = endpointType;
            ReplicationSchedule = replicationSchedule;
            RemoteVolumeResourceId = remoteVolumeResourceId;
            RemotePath = remotePath;
            RemoteVolumeRegion = remoteVolumeRegion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Indicates whether the local volume is the source or destination for the Volume Replication. </summary>
        public NetAppEndpointType? EndpointType { get; set; }
        /// <summary> Schedule. </summary>
        public NetAppReplicationSchedule? ReplicationSchedule { get; set; }
        /// <summary> The resource ID of the remote volume. Required for cross region and cross zone replication. </summary>
        public ResourceIdentifier RemoteVolumeResourceId { get; set; }
        /// <summary> The full path to a volume that is to be migrated into ANF. Required for Migration volumes. </summary>
        public RemotePath RemotePath { get; set; }
        /// <summary> The remote region for the other end of the Volume Replication. </summary>
        public string RemoteVolumeRegion { get; set; }
    }
}
