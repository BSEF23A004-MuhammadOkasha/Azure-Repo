// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkSimPolicy data model.
    /// SIM policy resource.
    /// </summary>
    public partial class MobileNetworkSimPolicyData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimPolicyData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="ueAmbr"> Aggregate maximum bit rate across all non-GBR QoS flows of all PDU sessions of a given UE. See 3GPP TS23.501 section 5.7.2.6 for a full description of the UE-AMBR. </param>
        /// <param name="defaultSlice"> The default slice to use if the UE does not explicitly specify it. This slice must exist in the `sliceConfigurations` map. The slice must be in the same location as the SIM policy. </param>
        /// <param name="sliceConfigurations"> The allowed slices and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ueAmbr"/>, <paramref name="defaultSlice"/> or <paramref name="sliceConfigurations"/> is null. </exception>
        public MobileNetworkSimPolicyData(AzureLocation location, Ambr ueAmbr, WritableSubResource defaultSlice, IEnumerable<MobileNetworkSliceConfiguration> sliceConfigurations) : base(location)
        {
            Argument.AssertNotNull(ueAmbr, nameof(ueAmbr));
            Argument.AssertNotNull(defaultSlice, nameof(defaultSlice));
            Argument.AssertNotNull(sliceConfigurations, nameof(sliceConfigurations));

            SiteProvisioningState = new ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState>();
            UeAmbr = ueAmbr;
            DefaultSlice = defaultSlice;
            SliceConfigurations = sliceConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM policy resource. </param>
        /// <param name="siteProvisioningState"> A dictionary of sites to the provisioning state of this SIM policy on that site. </param>
        /// <param name="ueAmbr"> Aggregate maximum bit rate across all non-GBR QoS flows of all PDU sessions of a given UE. See 3GPP TS23.501 section 5.7.2.6 for a full description of the UE-AMBR. </param>
        /// <param name="defaultSlice"> The default slice to use if the UE does not explicitly specify it. This slice must exist in the `sliceConfigurations` map. The slice must be in the same location as the SIM policy. </param>
        /// <param name="rfspIndex"> RAT/Frequency Selection Priority Index, defined in 3GPP TS 36.413. This is an optional setting and by default is unspecified. </param>
        /// <param name="registrationTimer"> UE periodic registration update timer (5G) or UE periodic tracking area update timer (4G), in seconds. </param>
        /// <param name="sliceConfigurations"> The allowed slices and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkSimPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState, Ambr ueAmbr, WritableSubResource defaultSlice, int? rfspIndex, int? registrationTimer, IList<MobileNetworkSliceConfiguration> sliceConfigurations, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            SiteProvisioningState = siteProvisioningState;
            UeAmbr = ueAmbr;
            DefaultSlice = defaultSlice;
            RfspIndex = rfspIndex;
            RegistrationTimer = registrationTimer;
            SliceConfigurations = sliceConfigurations;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimPolicyData"/> for deserialization. </summary>
        internal MobileNetworkSimPolicyData()
        {
        }

        /// <summary> The provisioning state of the SIM policy resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A dictionary of sites to the provisioning state of this SIM policy on that site. </summary>
        public IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> SiteProvisioningState { get; }
        /// <summary> Aggregate maximum bit rate across all non-GBR QoS flows of all PDU sessions of a given UE. See 3GPP TS23.501 section 5.7.2.6 for a full description of the UE-AMBR. </summary>
        public Ambr UeAmbr { get; set; }
        /// <summary> The default slice to use if the UE does not explicitly specify it. This slice must exist in the `sliceConfigurations` map. The slice must be in the same location as the SIM policy. </summary>
        internal WritableSubResource DefaultSlice { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultSliceId
        {
            get => DefaultSlice is null ? default : DefaultSlice.Id;
            set
            {
                if (DefaultSlice is null)
                    DefaultSlice = new WritableSubResource();
                DefaultSlice.Id = value;
            }
        }

        /// <summary> RAT/Frequency Selection Priority Index, defined in 3GPP TS 36.413. This is an optional setting and by default is unspecified. </summary>
        public int? RfspIndex { get; set; }
        /// <summary> UE periodic registration update timer (5G) or UE periodic tracking area update timer (4G), in seconds. </summary>
        public int? RegistrationTimer { get; set; }
        /// <summary> The allowed slices and the settings to use for them. The list must not contain duplicate items and must contain at least one item. </summary>
        public IList<MobileNetworkSliceConfiguration> SliceConfigurations { get; }
    }
}
