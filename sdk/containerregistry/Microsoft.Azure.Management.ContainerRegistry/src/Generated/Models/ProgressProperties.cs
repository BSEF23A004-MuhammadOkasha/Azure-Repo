// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProgressProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProgressProperties class.
        /// </summary>
        public ProgressProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProgressProperties class.
        /// </summary>
        /// <param name="percentage">The percentage complete of the copy
        /// operation.</param>
        public ProgressProperties(string percentage = default(string))
        {
            Percentage = percentage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the percentage complete of the copy operation.
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public string Percentage { get; set; }

    }
}
