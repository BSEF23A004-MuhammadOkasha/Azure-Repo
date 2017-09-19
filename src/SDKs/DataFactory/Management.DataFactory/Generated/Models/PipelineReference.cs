// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Pipeline reference type.
    /// </summary>
    public partial class PipelineReference
    {
        /// <summary>
        /// Initializes a new instance of the PipelineReference class.
        /// </summary>
        public PipelineReference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineReference class.
        /// </summary>
        /// <param name="referenceName">Reference pipeline name.</param>
        /// <param name="name">Reference name.</param>
        public PipelineReference(string referenceName, string name = default(string))
        {
            ReferenceName = referenceName;
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for PipelineReference class.
        /// </summary>
        static PipelineReference()
        {
            Type = "PipelineReference";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference pipeline name.
        /// </summary>
        [JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or sets reference name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Pipeline reference type.
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
            if (ReferenceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReferenceName");
            }
        }
    }
}
