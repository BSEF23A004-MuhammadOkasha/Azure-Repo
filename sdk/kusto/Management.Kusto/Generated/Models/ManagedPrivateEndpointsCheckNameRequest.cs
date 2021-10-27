// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result returned from a managedPrivateEndpoints check name
    /// availability request.
    /// </summary>
    public partial class ManagedPrivateEndpointsCheckNameRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedPrivateEndpointsCheckNameRequest class.
        /// </summary>
        public ManagedPrivateEndpointsCheckNameRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedPrivateEndpointsCheckNameRequest class.
        /// </summary>
        /// <param name="name">Managed private endpoint resource name.</param>
        public ManagedPrivateEndpointsCheckNameRequest(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ManagedPrivateEndpointsCheckNameRequest
        /// class.
        /// </summary>
        static ManagedPrivateEndpointsCheckNameRequest()
        {
            Type = "Microsoft.Kusto/clusters/managedPrivateEndpoints";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets managed private endpoint resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of resource, for instance
        /// Microsoft.Kusto/clusters/managedPrivateEndpoints.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
