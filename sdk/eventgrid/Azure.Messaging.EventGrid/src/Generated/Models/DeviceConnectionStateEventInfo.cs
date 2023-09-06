// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Information about the device connection state event. </summary>
    public partial class DeviceConnectionStateEventInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceConnectionStateEventInfo"/>. </summary>
        internal DeviceConnectionStateEventInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceConnectionStateEventInfo"/>. </summary>
        /// <param name="sequenceNumber"> Sequence number is string representation of a hexadecimal number. string compare can be used to identify the larger number because both in ASCII and HEX numbers come after alphabets. If you are converting the string to hex, then the number is a 256 bit number. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceConnectionStateEventInfo(string sequenceNumber, Dictionary<string, BinaryData> rawData)
        {
            SequenceNumber = sequenceNumber;
            _rawData = rawData;
        }

        /// <summary> Sequence number is string representation of a hexadecimal number. string compare can be used to identify the larger number because both in ASCII and HEX numbers come after alphabets. If you are converting the string to hex, then the number is a 256 bit number. </summary>
        public string SequenceNumber { get; }
    }
}
