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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Rewrite rule set of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayRewriteRuleSet : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayRewriteRuleSet
        /// class.
        /// </summary>
        public ApplicationGatewayRewriteRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayRewriteRuleSet
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="rewriteRules">Rewrite rules in the rewrite rule
        /// set.</param>
        /// <param name="provisioningState">Provisioning state of the rewrite
        /// rule set resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="name">Name of the rewrite rule set that is unique
        /// within an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayRewriteRuleSet(string id = default(string), IList<ApplicationGatewayRewriteRule> rewriteRules = default(IList<ApplicationGatewayRewriteRule>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            RewriteRules = rewriteRules;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rewrite rules in the rewrite rule set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rewriteRules")]
        public IList<ApplicationGatewayRewriteRule> RewriteRules { get; set; }

        /// <summary>
        /// Gets provisioning state of the rewrite rule set resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the rewrite rule set that is unique within an
        /// Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
