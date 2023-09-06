// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a daily schedule. </summary>
    internal partial class DayDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DayDetails"/>. </summary>
        public DayDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DayDetails"/>. </summary>
        /// <param name="time"> The time of day the schedule will occur. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DayDetails(string time, Dictionary<string, BinaryData> rawData)
        {
            Time = time;
            _rawData = rawData;
        }

        /// <summary> The time of day the schedule will occur. </summary>
        public string Time { get; set; }
    }
}
