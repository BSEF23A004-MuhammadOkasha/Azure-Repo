// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Group contract Properties.
    /// </summary>
    public partial class GroupContractProperties
    {
        /// <summary>
        /// Initializes a new instance of the GroupContractProperties class.
        /// </summary>
        public GroupContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupContractProperties class.
        /// </summary>
        /// <param name="displayName">Group name.</param>
        /// <param name="description">Group description. Can contain HTML
        /// formatting tags.</param>
        /// <param name="builtIn">true if the group is one of the three system
        /// groups (Administrators, Developers, or Guests); otherwise
        /// false.</param>
        /// <param name="type">Group type. Possible values include: 'custom',
        /// 'system', 'external'</param>
        /// <param name="externalId">For external groups, this property
        /// contains the id of the group from the external identity provider,
        /// e.g. for Azure Active Directory
        /// `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object
        /// id&gt;`; otherwise the value is null.</param>
        public GroupContractProperties(string displayName, string description = default(string), bool? builtIn = default(bool?), GroupType? type = default(GroupType?), string externalId = default(string))
        {
            DisplayName = displayName;
            Description = description;
            BuiltIn = builtIn;
            Type = type;
            ExternalId = externalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets group name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets group description. Can contain HTML formatting tags.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets true if the group is one of the three system groups
        /// (Administrators, Developers, or Guests); otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "builtIn")]
        public bool? BuiltIn { get; private set; }

        /// <summary>
        /// Gets or sets group type. Possible values include: 'custom',
        /// 'system', 'external'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public GroupType? Type { get; set; }

        /// <summary>
        /// Gets or sets for external groups, this property contains the id of
        /// the group from the external identity provider, e.g. for Azure
        /// Active Directory
        /// `aad://&amp;lt;tenant&amp;gt;.onmicrosoft.com/groups/&amp;lt;group
        /// object id&amp;gt;`; otherwise the value is null.
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
        }
    }
}
