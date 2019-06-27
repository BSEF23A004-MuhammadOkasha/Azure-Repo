// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Attestation service response message.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AttestationProvider : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AttestationProvider class.
        /// </summary>
        public AttestationProvider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttestationProvider class.
        /// </summary>
        /// <param name="status">Status of attestation service. Possible values
        /// include: 'Ready', 'NotReady', 'Error'</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="attestUri">Gets the uri of attestation service</param>
        public AttestationProvider(string status, string id = default(string), string name = default(string), string type = default(string), string attestUri = default(string))
            : base(id, name, type)
        {
            Status = status;
            AttestUri = attestUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of attestation service. Possible values
        /// include: 'Ready', 'NotReady', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets the uri of attestation service
        /// </summary>
        [JsonProperty(PropertyName = "properties.attestUri")]
        public string AttestUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
