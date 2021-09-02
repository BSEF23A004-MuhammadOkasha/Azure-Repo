// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Compute infrastructure Resource
    /// </summary>
    public partial class ComputeResource
    {
        /// <summary>
        /// Initializes a new instance of the ComputeResource class.
        /// </summary>
        public ComputeResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeResource class.
        /// </summary>
        /// <param name="processorCount">Processor count</param>
        /// <param name="memoryInGB">Memory in GB</param>
        public ComputeResource(int processorCount, long memoryInGB)
        {
            ProcessorCount = processorCount;
            MemoryInGB = memoryInGB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets processor count
        /// </summary>
        [JsonProperty(PropertyName = "processorCount")]
        public int ProcessorCount { get; set; }

        /// <summary>
        /// Gets or sets memory in GB
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public long MemoryInGB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
