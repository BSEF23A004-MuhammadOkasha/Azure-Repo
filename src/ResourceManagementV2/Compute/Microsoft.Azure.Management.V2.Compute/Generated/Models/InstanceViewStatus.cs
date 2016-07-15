// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Instance view status.
    /// </summary>
    public partial class InstanceViewStatus
    {
        /// <summary>
        /// Initializes a new instance of the InstanceViewStatus class.
        /// </summary>
        public InstanceViewStatus() { }

        /// <summary>
        /// Initializes a new instance of the InstanceViewStatus class.
        /// </summary>
        /// <param name="code">the status Code.</param>
        /// <param name="level">the level Code. Possible values include:
        /// 'Info', 'Warning', 'Error'</param>
        /// <param name="displayStatus">the short localizable label for the
        /// status.</param>
        /// <param name="message">the detailed Message, including for alerts
        /// and error messages.</param>
        /// <param name="time">the time of the status.</param>
        public InstanceViewStatus(string code = default(string), StatusLevelTypes? level = default(StatusLevelTypes?), string displayStatus = default(string), string message = default(string), DateTime? time = default(DateTime?))
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
        }

        /// <summary>
        /// Gets or sets the status Code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the level Code. Possible values include: 'Info',
        /// 'Warning', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public StatusLevelTypes? Level { get; set; }

        /// <summary>
        /// Gets or sets the short localizable label for the status.
        /// </summary>
        [JsonProperty(PropertyName = "displayStatus")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// Gets or sets the detailed Message, including for alerts and error
        /// messages.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the time of the status.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

    }
}
