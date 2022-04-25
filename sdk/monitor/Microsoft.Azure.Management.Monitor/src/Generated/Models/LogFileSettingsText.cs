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
    using System.Linq;

    /// <summary>
    /// Text settings
    /// </summary>
    public partial class LogFileSettingsText : LogFileTextSettings
    {
        /// <summary>
        /// Initializes a new instance of the LogFileSettingsText class.
        /// </summary>
        public LogFileSettingsText()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFileSettingsText class.
        /// </summary>
        /// <param name="recordStartTimestampFormat">One of the supported
        /// timestamp formats. Possible values include: 'ISO 8601', 'YYYY-MM-DD
        /// HH:MM:SS', 'M/D/YYYY HH:MM:SS AM/PM', 'Mon DD, YYYY HH:MM:SS',
        /// 'yyMMdd HH:mm:ss', 'ddMMyy HH:mm:ss', 'MMM d hh:mm:ss',
        /// 'dd/MMM/yyyy:HH:mm:ss zzz', 'yyyy-MM-ddTHH:mm:ssK'</param>
        public LogFileSettingsText(string recordStartTimestampFormat)
            : base(recordStartTimestampFormat)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
