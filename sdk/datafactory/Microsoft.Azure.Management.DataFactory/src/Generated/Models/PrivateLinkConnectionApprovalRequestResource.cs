// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Private Endpoint Connection Approval ARM resource.
    /// </summary>
    public partial class PrivateLinkConnectionApprovalRequestResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkConnectionApprovalRequestResource class.
        /// </summary>
        public PrivateLinkConnectionApprovalRequestResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkConnectionApprovalRequestResource class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">Etag identifies change in the resource.</param>
        /// <param name="properties">Core resource properties</param>
        public PrivateLinkConnectionApprovalRequestResource(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), PrivateLinkConnectionApprovalRequest properties = default(PrivateLinkConnectionApprovalRequest))
            : base(id, name, type, etag)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets core resource properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PrivateLinkConnectionApprovalRequest Properties { get; set; }

    }
}
