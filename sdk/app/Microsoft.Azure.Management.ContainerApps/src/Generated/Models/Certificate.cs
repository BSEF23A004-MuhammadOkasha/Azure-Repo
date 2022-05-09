// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Certificate used for Custom Domain bindings of Container Apps in a
    /// Managed Environment
    /// </summary>
    public partial class Certificate : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        public Certificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="properties">Certificate resource specific
        /// properties</param>
        public Certificate(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), CertificateProperties properties = default(CertificateProperties))
            : base(location, id, name, type, systemData, tags)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate resource specific properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CertificateProperties Properties { get; set; }

    }
}
