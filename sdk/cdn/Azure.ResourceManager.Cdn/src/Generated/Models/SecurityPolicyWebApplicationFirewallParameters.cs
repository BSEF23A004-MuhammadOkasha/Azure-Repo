// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The json object containing security policy waf parameters. </summary>
    internal partial class SecurityPolicyWebApplicationFirewallParameters : SecurityPolicyParameters
    {
        /// <summary> Initializes a new instance of SecurityPolicyWebApplicationFirewallParameters. </summary>
        public SecurityPolicyWebApplicationFirewallParameters()
        {
            Associations = new ChangeTrackingList<SecurityPolicyWebApplicationFirewallAssociation>();
            Type = SecurityPolicyType.WebApplicationFirewall;
        }

        /// <summary> Initializes a new instance of SecurityPolicyWebApplicationFirewallParameters. </summary>
        /// <param name="type"> The type of the Security policy to create. </param>
        /// <param name="wafPolicy"> Resource ID. </param>
        /// <param name="associations"> Waf associations. </param>
        internal SecurityPolicyWebApplicationFirewallParameters(SecurityPolicyType type, WritableSubResource wafPolicy, IList<SecurityPolicyWebApplicationFirewallAssociation> associations) : base(type)
        {
            WafPolicy = wafPolicy;
            Associations = associations;
            Type = type;
        }

        /// <summary> Resource ID. </summary>
        internal WritableSubResource WafPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier WafPolicyId
        {
            get => WafPolicy is null ? default : WafPolicy.Id;
            set
            {
                if (WafPolicy is null)
                    WafPolicy = new WritableSubResource();
                WafPolicy.Id = value;
            }
        }

        /// <summary> Waf associations. </summary>
        public IList<SecurityPolicyWebApplicationFirewallAssociation> Associations { get; }
    }
}
