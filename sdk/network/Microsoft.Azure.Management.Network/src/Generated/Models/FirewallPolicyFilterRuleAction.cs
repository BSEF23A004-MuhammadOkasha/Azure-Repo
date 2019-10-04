// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the FirewallPolicyFilterRuleAction.
    /// </summary>
    public partial class FirewallPolicyFilterRuleAction
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyFilterRuleAction
        /// class.
        /// </summary>
        public FirewallPolicyFilterRuleAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyFilterRuleAction
        /// class.
        /// </summary>
        /// <param name="type">The type of action. Possible values include:
        /// 'Allow', 'Deny'</param>
        public FirewallPolicyFilterRuleAction(string type = default(string))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of action. Possible values include: 'Allow',
        /// 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
