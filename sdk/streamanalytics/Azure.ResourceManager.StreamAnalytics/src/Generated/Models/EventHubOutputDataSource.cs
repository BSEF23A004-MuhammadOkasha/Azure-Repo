// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an Event Hub output data source. </summary>
    public partial class EventHubOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of EventHubOutputDataSource. </summary>
        public EventHubOutputDataSource()
        {
            PropertyColumns = new Core.ChangeTrackingList<string>();
            OutputDataSourceType = "Microsoft.ServiceBus/EventHub";
        }

        /// <summary> Initializes a new instance of EventHubOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serviceBusNamespace"> The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="sharedAccessPolicyName"> The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="sharedAccessPolicyKey"> The shared access policy key for the specified shared access policy. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="eventHubName"> The name of the Event Hub. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="partitionCount"> The partition count of the event hub data source. Range 1 - 256. </param>
        /// <param name="partitionKey"> The key/column that is used to determine to which partition to send event data. </param>
        /// <param name="propertyColumns"> The properties associated with this Event Hub output. </param>
        internal EventHubOutputDataSource(string outputDataSourceType, string serviceBusNamespace, string sharedAccessPolicyName, string sharedAccessPolicyKey, StreamAnalyticsAuthenticationMode? authenticationMode, string eventHubName, int? partitionCount, string partitionKey, IList<string> propertyColumns) : base(outputDataSourceType)
        {
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyName = sharedAccessPolicyName;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            AuthenticationMode = authenticationMode;
            EventHubName = eventHubName;
            PartitionCount = partitionCount;
            PartitionKey = partitionKey;
            PropertyColumns = propertyColumns;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.ServiceBus/EventHub";
        }

        /// <summary> The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </summary>
        public string ServiceBusNamespace { get; set; }
        /// <summary> The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests. </summary>
        public string SharedAccessPolicyName { get; set; }
        /// <summary> The shared access policy key for the specified shared access policy. Required on PUT (CreateOrReplace) requests. </summary>
        public string SharedAccessPolicyKey { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> The name of the Event Hub. Required on PUT (CreateOrReplace) requests. </summary>
        public string EventHubName { get; set; }
        /// <summary> The partition count of the event hub data source. Range 1 - 256. </summary>
        public int? PartitionCount { get; set; }
        /// <summary> The key/column that is used to determine to which partition to send event data. </summary>
        public string PartitionKey { get; set; }
        /// <summary> The properties associated with this Event Hub output. </summary>
        public IList<string> PropertyColumns { get; }
    }
}
