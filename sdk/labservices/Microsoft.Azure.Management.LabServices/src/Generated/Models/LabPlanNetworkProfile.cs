// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile for how to handle networking for Lab Plans.
    /// </summary>
    public partial class LabPlanNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the LabPlanNetworkProfile class.
        /// </summary>
        public LabPlanNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabPlanNetworkProfile class.
        /// </summary>
        /// <param name="subnetId">The external subnet resource id</param>
        public LabPlanNetworkProfile(string subnetId = default(string))
        {
            SubnetId = subnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the external subnet resource id
        /// </summary>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

    }
}
