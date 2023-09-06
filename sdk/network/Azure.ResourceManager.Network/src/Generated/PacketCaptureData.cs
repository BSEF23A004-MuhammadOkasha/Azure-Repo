// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the PacketCapture data model.
    /// Information about packet capture session.
    /// </summary>
    public partial class PacketCaptureData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PacketCaptureData"/>. </summary>
        internal PacketCaptureData()
        {
            Filters = new ChangeTrackingList<PacketCaptureFilter>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="target"> The ID of the targeted resource, only AzureVM and AzureVMSS as target type are currently supported. </param>
        /// <param name="scope"> A list of AzureVMSS instances which can be included or excluded to run packet capture. If both included and excluded are empty, then the packet capture will run on all instances of AzureVMSS. </param>
        /// <param name="targetType"> Target type of the resource provided. </param>
        /// <param name="bytesToCapturePerPacket"> Number of bytes captured per packet, the remaining bytes are truncated. </param>
        /// <param name="totalBytesPerSession"> Maximum size of the capture output. </param>
        /// <param name="timeLimitInSeconds"> Maximum duration of the capture session in seconds. </param>
        /// <param name="storageLocation"> The storage location for a packet capture session. </param>
        /// <param name="filters"> A list of packet capture filters. </param>
        /// <param name="provisioningState"> The provisioning state of the packet capture session. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCaptureData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string target, PacketCaptureMachineScope scope, PacketCaptureTargetType? targetType, long? bytesToCapturePerPacket, long? totalBytesPerSession, int? timeLimitInSeconds, PacketCaptureStorageLocation storageLocation, IReadOnlyList<PacketCaptureFilter> filters, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Target = target;
            Scope = scope;
            TargetType = targetType;
            BytesToCapturePerPacket = bytesToCapturePerPacket;
            TotalBytesPerSession = totalBytesPerSession;
            TimeLimitInSeconds = timeLimitInSeconds;
            StorageLocation = storageLocation;
            Filters = filters;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The ID of the targeted resource, only AzureVM and AzureVMSS as target type are currently supported. </summary>
        public string Target { get; }
        /// <summary> A list of AzureVMSS instances which can be included or excluded to run packet capture. If both included and excluded are empty, then the packet capture will run on all instances of AzureVMSS. </summary>
        public PacketCaptureMachineScope Scope { get; }
        /// <summary> Target type of the resource provided. </summary>
        public PacketCaptureTargetType? TargetType { get; }
        /// <summary> Number of bytes captured per packet, the remaining bytes are truncated. </summary>
        public long? BytesToCapturePerPacket { get; }
        /// <summary> Maximum size of the capture output. </summary>
        public long? TotalBytesPerSession { get; }
        /// <summary> Maximum duration of the capture session in seconds. </summary>
        public int? TimeLimitInSeconds { get; }
        /// <summary> The storage location for a packet capture session. </summary>
        public PacketCaptureStorageLocation StorageLocation { get; }
        /// <summary> A list of packet capture filters. </summary>
        public IReadOnlyList<PacketCaptureFilter> Filters { get; }
        /// <summary> The provisioning state of the packet capture session. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
