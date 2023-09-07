// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Represents a date and time. </summary>
    internal partial class OperatingHoursTime
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperatingHoursTime"/>. </summary>
        internal OperatingHoursTime()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperatingHoursTime"/>. </summary>
        /// <param name="date"> Represents current calendar date in POI time zone, e.g. "2019-02-07". </param>
        /// <param name="hour"> Hours are in the 24 hour format in the local time of a POI; possible values are 0 - 23. </param>
        /// <param name="minute"> Minutes are in the local time of a POI; possible values are 0 - 59. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperatingHoursTime(string date, int? hour, int? minute, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Date = date;
            Hour = hour;
            Minute = minute;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Represents current calendar date in POI time zone, e.g. "2019-02-07". </summary>
        public string Date { get; }
        /// <summary> Hours are in the 24 hour format in the local time of a POI; possible values are 0 - 23. </summary>
        public int? Hour { get; }
        /// <summary> Minutes are in the local time of a POI; possible values are 0 - 59. </summary>
        public int? Minute { get; }
    }
}
