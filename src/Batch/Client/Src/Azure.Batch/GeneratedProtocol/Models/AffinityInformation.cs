// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A locality hint that can be used by the Batch service to select a
    /// compute node on which to start a task.
    /// </summary>
    public partial class AffinityInformation
    {
        /// <summary>
        /// Initializes a new instance of the AffinityInformation class.
        /// </summary>
        public AffinityInformation() { }

        /// <summary>
        /// Initializes a new instance of the AffinityInformation class.
        /// </summary>
        /// <param name="affinityId">An opaque string representing the location
        /// of a compute node or a task that has run previously.</param>
        public AffinityInformation(string affinityId)
        {
            AffinityId = affinityId;
        }

        /// <summary>
        /// Gets or sets an opaque string representing the location of a
        /// compute node or a task that has run previously.
        /// </summary>
        /// <remarks>
        /// You can pass the affinityId of a compute node or task to indicate
        /// that this task needs to be placed close to the node or task.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affinityId")]
        public string AffinityId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AffinityId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AffinityId");
            }
        }
    }
}
