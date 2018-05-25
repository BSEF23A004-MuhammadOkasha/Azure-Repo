// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SharedAccessAuthorizationRule properties.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        /// <param name="primaryKey">A base64-encoded 256-bit primary key for
        /// signing and validating the SAS token.</param>
        /// <param name="secondaryKey">A base64-encoded 256-bit primary key for
        /// signing and validating the SAS token.</param>
        /// <param name="keyName">A string that describes the authorization
        /// rule.</param>
        /// <param name="claimType">A string that describes the claim
        /// type</param>
        /// <param name="claimValue">A string that describes the claim
        /// value</param>
        /// <param name="modifiedTime">The last modified time for this
        /// rule</param>
        /// <param name="createdTime">The created time for this rule</param>
        /// <param name="revision">The revision number for the rule</param>
        public SharedAccessAuthorizationRuleProperties(IList<AccessRights?> rights = default(IList<AccessRights?>), string primaryKey = default(string), string secondaryKey = default(string), string keyName = default(string), string claimType = default(string), string claimValue = default(string), string modifiedTime = default(string), string createdTime = default(string), int? revision = default(int?))
        {
            Rights = rights;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            ClaimType = claimType;
            ClaimValue = claimValue;
            ModifiedTime = modifiedTime;
            CreatedTime = createdTime;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "rights")]
        public IList<AccessRights?> Rights { get; set; }

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

        /// <summary>
        /// Gets a string that describes the claim type
        /// </summary>
        [JsonProperty(PropertyName = "claimType")]
        public string ClaimType { get; private set; }

        /// <summary>
        /// Gets a string that describes the claim value
        /// </summary>
        [JsonProperty(PropertyName = "claimValue")]
        public string ClaimValue { get; private set; }

        /// <summary>
        /// Gets the last modified time for this rule
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public string ModifiedTime { get; private set; }

        /// <summary>
        /// Gets the created time for this rule
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public string CreatedTime { get; private set; }

        /// <summary>
        /// Gets the revision number for the rule
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; private set; }

    }
}
