// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings for text log files
    /// </summary>
    public partial class LogFileTextSettings
    {
        /// <summary>
        /// Initializes a new instance of the LogFileTextSettings class.
        /// </summary>
        public LogFileTextSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFileTextSettings class.
        /// </summary>
        /// <param name="recordStartTimestampFormat">One of the supported
        /// timestamp formats. Possible values include: 'ISO 8601', 'YYYY-MM-DD
        /// HH:MM:SS', 'M/D/YYYY HH:MM:SS AM/PM', 'Mon DD, YYYY HH:MM:SS',
        /// 'yyMMdd HH:mm:ss', 'ddMMyy HH:mm:ss', 'MMM d hh:mm:ss',
        /// 'dd/MMM/yyyy:HH:mm:ss zzz', 'yyyy-MM-ddTHH:mm:ssK'</param>
        public LogFileTextSettings(string recordStartTimestampFormat)
        {
            RecordStartTimestampFormat = recordStartTimestampFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one of the supported timestamp formats. Possible
        /// values include: 'ISO 8601', 'YYYY-MM-DD HH:MM:SS', 'M/D/YYYY
        /// HH:MM:SS AM/PM', 'Mon DD, YYYY HH:MM:SS', 'yyMMdd HH:mm:ss',
        /// 'ddMMyy HH:mm:ss', 'MMM d hh:mm:ss', 'dd/MMM/yyyy:HH:mm:ss zzz',
        /// 'yyyy-MM-ddTHH:mm:ssK'
        /// </summary>
        [JsonProperty(PropertyName = "recordStartTimestampFormat")]
        public string RecordStartTimestampFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecordStartTimestampFormat == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecordStartTimestampFormat");
            }
        }
    }
}
