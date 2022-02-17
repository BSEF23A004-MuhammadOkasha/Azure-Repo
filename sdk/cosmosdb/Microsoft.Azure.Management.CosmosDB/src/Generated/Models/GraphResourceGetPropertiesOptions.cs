// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class GraphResourceGetPropertiesOptions : OptionsResource
    {
        /// <summary>
        /// Initializes a new instance of the GraphResourceGetPropertiesOptions
        /// class.
        /// </summary>
        public GraphResourceGetPropertiesOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GraphResourceGetPropertiesOptions
        /// class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource throughput
        /// or autoscaleSettings. Use the ThroughputSetting resource when
        /// retrieving offer details.</param>
        /// <param name="autoscaleSettings">Specifies the Autoscale
        /// settings.</param>
        public GraphResourceGetPropertiesOptions(int? throughput = default(int?), AutoscaleSettings autoscaleSettings = default(AutoscaleSettings))
            : base(throughput, autoscaleSettings)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
