// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> SharedAccessAuthorizationRule properties. </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleProperties"/>. </summary>
        public SharedAccessAuthorizationRuleProperties()
        {
            Rights = new ChangeTrackingList<AuthorizationRuleAccessRight>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the authorization rule. </param>
        /// <param name="claimType"> A string that describes the claim type. </param>
        /// <param name="claimValue"> A string that describes the claim value. </param>
        /// <param name="modifiedOn"> The last modified time for this rule. </param>
        /// <param name="createdOn"> The created time for this rule. </param>
        /// <param name="revision"> The revision number for the rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedAccessAuthorizationRuleProperties(IList<AuthorizationRuleAccessRight> rights, string primaryKey, string secondaryKey, string keyName, string claimType, string claimValue, DateTimeOffset? modifiedOn, DateTimeOffset? createdOn, int? revision, Dictionary<string, BinaryData> rawData)
        {
            Rights = rights;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            ClaimType = claimType;
            ClaimValue = claimValue;
            ModifiedOn = modifiedOn;
            CreatedOn = createdOn;
            Revision = revision;
            _rawData = rawData;
        }

        /// <summary> The rights associated with the rule. </summary>
        public IList<AuthorizationRuleAccessRight> Rights { get; }
        /// <summary> A base64-encoded 256-bit primary key for signing and validating the SAS token. </summary>
        public string PrimaryKey { get; }
        /// <summary> A base64-encoded 256-bit primary key for signing and validating the SAS token. </summary>
        public string SecondaryKey { get; }
        /// <summary> A string that describes the authorization rule. </summary>
        public string KeyName { get; }
        /// <summary> A string that describes the claim type. </summary>
        public string ClaimType { get; }
        /// <summary> A string that describes the claim value. </summary>
        public string ClaimValue { get; }
        /// <summary> The last modified time for this rule. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> The created time for this rule. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The revision number for the rule. </summary>
        public int? Revision { get; }
    }
}
