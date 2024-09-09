// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Extended status information for the reservation. </summary>
    public partial class ReservationExtendedStatusInfo
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

        /// <summary> Initializes a new instance of <see cref="ReservationExtendedStatusInfo"/>. </summary>
        public ReservationExtendedStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationExtendedStatusInfo"/>. </summary>
        /// <param name="statusCode"> The status of the reservation. </param>
        /// <param name="message"> The message giving detailed information about the status code. </param>
        /// <param name="properties"> Properties for extended status information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationExtendedStatusInfo(ReservationStatusCode? statusCode, string message, ExtendedStatusDefinitionProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StatusCode = statusCode;
            Message = message;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the reservation. </summary>
        [WirePath("statusCode")]
        public ReservationStatusCode? StatusCode { get; set; }
        /// <summary> The message giving detailed information about the status code. </summary>
        [WirePath("message")]
        public string Message { get; set; }
        /// <summary> Properties for extended status information. </summary>
        internal ExtendedStatusDefinitionProperties Properties { get; set; }
        /// <summary> Subscription Id. </summary>
        [WirePath("properties.subscriptionId")]
        public string ExtendedStatusDefinitionSubscriptionId
        {
            get => Properties is null ? default : Properties.SubscriptionId;
            set
            {
                if (Properties is null)
                    Properties = new ExtendedStatusDefinitionProperties();
                Properties.SubscriptionId = value;
            }
        }
    }
}
