// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Represents the profile for a single additional location in the Fleet. The location and the virtualMachineProfileOverride (optional). </summary>
    public partial class LocationProfile
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

        /// <summary> Initializes a new instance of <see cref="LocationProfile"/>. </summary>
        /// <param name="location"> The ARM location name of the additional region. If LocationProfile is specified, then location is required. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public LocationProfile(string location)
        {
            Argument.AssertNotNull(location, nameof(location));

            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="LocationProfile"/>. </summary>
        /// <param name="location"> The ARM location name of the additional region. If LocationProfile is specified, then location is required. </param>
        /// <param name="virtualMachineProfileOverride">
        /// An override for computeProfile.baseVirtualMachineProfile specific to this region.
        /// This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources deployed in this location.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LocationProfile(string location, ComputeFleetVmProfile virtualMachineProfileOverride, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            VirtualMachineProfileOverride = virtualMachineProfileOverride;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LocationProfile"/> for deserialization. </summary>
        internal LocationProfile()
        {
        }

        /// <summary> The ARM location name of the additional region. If LocationProfile is specified, then location is required. </summary>
        public string Location { get; set; }
        /// <summary>
        /// An override for computeProfile.baseVirtualMachineProfile specific to this region.
        /// This override is merged with the base virtual machine profile to define the final virtual machine profile for the resources deployed in this location.
        /// </summary>
        public ComputeFleetVmProfile VirtualMachineProfileOverride { get; set; }
    }
}
