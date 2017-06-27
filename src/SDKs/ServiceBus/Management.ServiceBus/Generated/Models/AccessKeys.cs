// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Namespace/ServiceBus Connection String
    /// </summary>
    public partial class AccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        public AccessKeys()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessKeys class.
        /// </summary>
        /// <param name="primaryConnectionString">Primary connection string of
        /// the created namespace authorization rule.</param>
        /// <param name="secondaryConnectionString">Secondary connection string
        /// of the created namespace authorization rule.</param>
        /// <param name="primaryKey">A base64-encoded 256-bit primary key for
        /// signing and validating the SAS token.</param>
        /// <param name="secondaryKey">A base64-encoded 256-bit primary key for
        /// signing and validating the SAS token.</param>
        /// <param name="keyName">A string that describes the authorization
        /// rule.</param>
        public AccessKeys(string primaryConnectionString = default(string), string secondaryConnectionString = default(string), string primaryKey = default(string), string secondaryKey = default(string), string keyName = default(string))
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets primary connection string of the created namespace
        /// authorization rule.
        /// </summary>
        [JsonProperty(PropertyName = "primaryConnectionString")]
        public string PrimaryConnectionString { get; private set; }

        /// <summary>
        /// Gets secondary connection string of the created namespace
        /// authorization rule.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryConnectionString")]
        public string SecondaryConnectionString { get; private set; }

        /// <summary>
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets a base64-encoded 256-bit primary key for signing and
        /// validating the SAS token.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

        /// <summary>
        /// Gets a string that describes the authorization rule.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; private set; }

    }
}
