// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> RackDefinition represents details regarding the rack. </summary>
    public partial class NetworkCloudRackDefinition
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

        /// <summary> Initializes a new instance of <see cref="NetworkCloudRackDefinition"/>. </summary>
        /// <param name="networkRackId"> The resource ID of the network rack that matches this rack definition. </param>
        /// <param name="rackSerialNumber"> The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial number may be provided if desired. </param>
        /// <param name="rackSkuId"> The resource ID of the sku for the rack being added. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackId"/>, <paramref name="rackSerialNumber"/> or <paramref name="rackSkuId"/> is null. </exception>
        public NetworkCloudRackDefinition(ResourceIdentifier networkRackId, string rackSerialNumber, ResourceIdentifier rackSkuId)
        {
            if (networkRackId == null)
            {
                throw new ArgumentNullException(nameof(networkRackId));
            }
            if (rackSerialNumber == null)
            {
                throw new ArgumentNullException(nameof(rackSerialNumber));
            }
            if (rackSkuId == null)
            {
                throw new ArgumentNullException(nameof(rackSkuId));
            }

            BareMetalMachineConfigurationData = new ChangeTrackingList<BareMetalMachineConfiguration>();
            NetworkRackId = networkRackId;
            RackSerialNumber = rackSerialNumber;
            RackSkuId = rackSkuId;
            StorageApplianceConfigurationData = new ChangeTrackingList<StorageApplianceConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudRackDefinition"/>. </summary>
        /// <param name="availabilityZone"> The zone name used for this rack when created. Availability zones are used for workload placement. </param>
        /// <param name="bareMetalMachineConfigurationData"> The unordered list of bare metal machine configuration. </param>
        /// <param name="networkRackId"> The resource ID of the network rack that matches this rack definition. </param>
        /// <param name="rackLocation"> The free-form description of the rack's location. </param>
        /// <param name="rackSerialNumber"> The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial number may be provided if desired. </param>
        /// <param name="rackSkuId"> The resource ID of the sku for the rack being added. </param>
        /// <param name="storageApplianceConfigurationData"> The list of storage appliance configuration data for this rack. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudRackDefinition(string availabilityZone, IList<BareMetalMachineConfiguration> bareMetalMachineConfigurationData, ResourceIdentifier networkRackId, string rackLocation, string rackSerialNumber, ResourceIdentifier rackSkuId, IList<StorageApplianceConfiguration> storageApplianceConfigurationData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AvailabilityZone = availabilityZone;
            BareMetalMachineConfigurationData = bareMetalMachineConfigurationData;
            NetworkRackId = networkRackId;
            RackLocation = rackLocation;
            RackSerialNumber = rackSerialNumber;
            RackSkuId = rackSkuId;
            StorageApplianceConfigurationData = storageApplianceConfigurationData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudRackDefinition"/> for deserialization. </summary>
        internal NetworkCloudRackDefinition()
        {
        }

        /// <summary> The zone name used for this rack when created. Availability zones are used for workload placement. </summary>
        public string AvailabilityZone { get; set; }
        /// <summary> The unordered list of bare metal machine configuration. </summary>
        public IList<BareMetalMachineConfiguration> BareMetalMachineConfigurationData { get; }
        /// <summary> The resource ID of the network rack that matches this rack definition. </summary>
        public ResourceIdentifier NetworkRackId { get; set; }
        /// <summary> The free-form description of the rack's location. </summary>
        public string RackLocation { get; set; }
        /// <summary> The unique identifier for the rack within Network Cloud cluster. An alternate unique alphanumeric value other than a serial number may be provided if desired. </summary>
        public string RackSerialNumber { get; set; }
        /// <summary> The resource ID of the sku for the rack being added. </summary>
        public ResourceIdentifier RackSkuId { get; set; }
        /// <summary> The list of storage appliance configuration data for this rack. </summary>
        public IList<StorageApplianceConfiguration> StorageApplianceConfigurationData { get; }
    }
}
