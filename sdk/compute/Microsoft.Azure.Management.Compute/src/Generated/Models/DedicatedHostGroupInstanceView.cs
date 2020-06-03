// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DedicatedHostGroupInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedHostGroupInstanceView
        /// class.
        /// </summary>
        public DedicatedHostGroupInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedHostGroupInstanceView
        /// class.
        /// </summary>
        public DedicatedHostGroupInstanceView(IList<DedicatedHostInstanceViewWithName> hosts = default(IList<DedicatedHostInstanceViewWithName>))
        {
            Hosts = hosts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<DedicatedHostInstanceViewWithName> Hosts { get; set; }

    }
}
