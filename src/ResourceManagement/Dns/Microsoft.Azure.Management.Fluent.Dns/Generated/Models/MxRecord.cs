// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.Dns.Models
{
    using System.Linq;

    /// <summary>
    /// An MX record.
    /// </summary>
    public partial class MxRecord
    {
        /// <summary>
        /// Initializes a new instance of the MxRecord class.
        /// </summary>
        public MxRecord() { }

        /// <summary>
        /// Initializes a new instance of the MxRecord class.
        /// </summary>
        /// <param name="preference">The preference value for this MX
        /// record.</param>
        /// <param name="exchange">The domain name of the mail host for this MX
        /// record.</param>
        public MxRecord(int? preference = default(int?), string exchange = default(string))
        {
            Preference = preference;
            Exchange = exchange;
        }

        /// <summary>
        /// Gets or sets the preference value for this MX record.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preference")]
        public int? Preference { get; set; }

        /// <summary>
        /// Gets or sets the domain name of the mail host for this MX record.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exchange")]
        public string Exchange { get; set; }

    }
}
