// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The start and end date for recurrence schedule. </summary>
    public partial class ExportRecurrencePeriod
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExportRecurrencePeriod"/>. </summary>
        /// <param name="from"> The start date of recurrence. </param>
        public ExportRecurrencePeriod(DateTimeOffset @from)
        {
            From = @from;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRecurrencePeriod"/>. </summary>
        /// <param name="from"> The start date of recurrence. </param>
        /// <param name="to"> The end date of recurrence. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRecurrencePeriod(DateTimeOffset @from, DateTimeOffset? to, Dictionary<string, BinaryData> rawData)
        {
            From = @from;
            To = to;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRecurrencePeriod"/> for deserialization. </summary>
        internal ExportRecurrencePeriod()
        {
        }

        /// <summary> The start date of recurrence. </summary>
        public DateTimeOffset From { get; set; }
        /// <summary> The end date of recurrence. </summary>
        public DateTimeOffset? To { get; set; }
    }
}
