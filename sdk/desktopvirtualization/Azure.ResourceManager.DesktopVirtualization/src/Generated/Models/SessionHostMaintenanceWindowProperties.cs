// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Maintenance window starting hour and day of week. </summary>
    public partial class SessionHostMaintenanceWindowProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SessionHostMaintenanceWindowProperties"/>. </summary>
        public SessionHostMaintenanceWindowProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SessionHostMaintenanceWindowProperties"/>. </summary>
        /// <param name="hour"> The update start hour of the day. (0 - 23). </param>
        /// <param name="dayOfWeek"> Day of the week. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionHostMaintenanceWindowProperties(int? hour, DesktopVirtualizationDayOfWeek? dayOfWeek, Dictionary<string, BinaryData> rawData)
        {
            Hour = hour;
            DayOfWeek = dayOfWeek;
            _rawData = rawData;
        }

        /// <summary> The update start hour of the day. (0 - 23). </summary>
        public int? Hour { get; set; }
        /// <summary> Day of the week. </summary>
        public DesktopVirtualizationDayOfWeek? DayOfWeek { get; set; }
    }
}
