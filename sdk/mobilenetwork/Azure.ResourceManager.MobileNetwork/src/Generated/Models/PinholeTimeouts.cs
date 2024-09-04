// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// Expiry times of inactive NAPT pinholes, in seconds. All timers must be at least 1 second.
    /// Serialized Name: PinholeTimeouts
    /// </summary>
    public partial class PinholeTimeouts
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

        /// <summary> Initializes a new instance of <see cref="PinholeTimeouts"/>. </summary>
        public PinholeTimeouts()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PinholeTimeouts"/>. </summary>
        /// <param name="tcp">
        /// Pinhole timeout for TCP pinholes in seconds. Default for TCP is 3 minutes.
        /// Serialized Name: PinholeTimeouts.tcp
        /// </param>
        /// <param name="udp">
        /// Pinhole timeout for UDP pinholes in seconds. Default for UDP is 30 seconds.
        /// Serialized Name: PinholeTimeouts.udp
        /// </param>
        /// <param name="icmp">
        /// Pinhole timeout for ICMP pinholes in seconds. Default for ICMP Echo is 30 seconds.
        /// Serialized Name: PinholeTimeouts.icmp
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PinholeTimeouts(int? tcp, int? udp, int? icmp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tcp = tcp;
            Udp = udp;
            Icmp = icmp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Pinhole timeout for TCP pinholes in seconds. Default for TCP is 3 minutes.
        /// Serialized Name: PinholeTimeouts.tcp
        /// </summary>
        [WirePath("tcp")]
        public int? Tcp { get; set; }
        /// <summary>
        /// Pinhole timeout for UDP pinholes in seconds. Default for UDP is 30 seconds.
        /// Serialized Name: PinholeTimeouts.udp
        /// </summary>
        [WirePath("udp")]
        public int? Udp { get; set; }
        /// <summary>
        /// Pinhole timeout for ICMP pinholes in seconds. Default for ICMP Echo is 30 seconds.
        /// Serialized Name: PinholeTimeouts.icmp
        /// </summary>
        [WirePath("icmp")]
        public int? Icmp { get; set; }
    }
}
