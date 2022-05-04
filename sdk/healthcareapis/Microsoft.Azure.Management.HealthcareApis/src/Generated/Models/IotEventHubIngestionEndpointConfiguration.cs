// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Event Hub ingestion endpoint configuration
    /// </summary>
    public partial class IotEventHubIngestionEndpointConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IotEventHubIngestionEndpointConfiguration class.
        /// </summary>
        public IotEventHubIngestionEndpointConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IotEventHubIngestionEndpointConfiguration class.
        /// </summary>
        /// <param name="eventHubName">Event Hub name to connect to.</param>
        /// <param name="consumerGroup">Consumer group of the event hub to
        /// connected to.</param>
        /// <param name="fullyQualifiedEventHubNamespace">Fully qualified
        /// namespace of the Event Hub to connect to.</param>
        public IotEventHubIngestionEndpointConfiguration(string eventHubName = default(string), string consumerGroup = default(string), string fullyQualifiedEventHubNamespace = default(string))
        {
            EventHubName = eventHubName;
            ConsumerGroup = consumerGroup;
            FullyQualifiedEventHubNamespace = fullyQualifiedEventHubNamespace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets event Hub name to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubName")]
        public string EventHubName { get; set; }

        /// <summary>
        /// Gets or sets consumer group of the event hub to connected to.
        /// </summary>
        [JsonProperty(PropertyName = "consumerGroup")]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Gets or sets fully qualified namespace of the Event Hub to connect
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "fullyQualifiedEventHubNamespace")]
        public string FullyQualifiedEventHubNamespace { get; set; }

    }
}
