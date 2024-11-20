// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CapacityReservationGroupInstanceView. </summary>
    public partial class CapacityReservationGroupInstanceView
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

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupInstanceView"/>. </summary>
        internal CapacityReservationGroupInstanceView()
        {
            CapacityReservations = new ChangeTrackingList<CapacityReservationInstanceViewWithName>();
            SharedSubscriptionIds = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupInstanceView"/>. </summary>
        /// <param name="capacityReservations"> List of instance view of the capacity reservations under the capacity reservation group. </param>
        /// <param name="sharedSubscriptionIds"> List of the subscriptions that the capacity reservation group is shared with. **Note:** Minimum api-version: 2023-09-01. Please refer to https://aka.ms/computereservationsharing for more details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityReservationGroupInstanceView(IReadOnlyList<CapacityReservationInstanceViewWithName> capacityReservations, IReadOnlyList<SubResource> sharedSubscriptionIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CapacityReservations = capacityReservations;
            SharedSubscriptionIds = sharedSubscriptionIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of instance view of the capacity reservations under the capacity reservation group. </summary>
        public IReadOnlyList<CapacityReservationInstanceViewWithName> CapacityReservations { get; }
        /// <summary> List of the subscriptions that the capacity reservation group is shared with. **Note:** Minimum api-version: 2023-09-01. Please refer to https://aka.ms/computereservationsharing for more details. </summary>
        public IReadOnlyList<SubResource> SharedSubscriptionIds { get; }
    }
}
