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
    /// Container App scaling configurations.
    /// </summary>
    public partial class Scale
    {
        /// <summary>
        /// Initializes a new instance of the Scale class.
        /// </summary>
        public Scale()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Scale class.
        /// </summary>
        /// <param name="minReplicas">Optional. Minimum number of container
        /// replicas.</param>
        /// <param name="maxReplicas">Optional. Maximum number of container
        /// replicas. Defaults to 10 if not set.</param>
        /// <param name="rules">Scaling rules.</param>
        public Scale(int? minReplicas = default(int?), int? maxReplicas = default(int?), IList<ScaleRule> rules = default(IList<ScaleRule>))
        {
            MinReplicas = minReplicas;
            MaxReplicas = maxReplicas;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional. Minimum number of container replicas.
        /// </summary>
        [JsonProperty(PropertyName = "minReplicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Gets or sets optional. Maximum number of container replicas.
        /// Defaults to 10 if not set.
        /// </summary>
        [JsonProperty(PropertyName = "maxReplicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Gets or sets scaling rules.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ScaleRule> Rules { get; set; }

    }
}
