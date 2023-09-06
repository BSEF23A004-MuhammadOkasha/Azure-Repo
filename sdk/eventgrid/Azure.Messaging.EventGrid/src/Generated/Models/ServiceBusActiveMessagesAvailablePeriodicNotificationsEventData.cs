// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ServiceBus.ActiveMessagesAvailablePeriodicNotifications event. </summary>
    public partial class ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData"/>. </summary>
        internal ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData"/>. </summary>
        /// <param name="namespaceName"> The namespace name of the Microsoft.ServiceBus resource. </param>
        /// <param name="requestUri"> The endpoint of the Microsoft.ServiceBus resource. </param>
        /// <param name="entityType"> The entity type of the Microsoft.ServiceBus resource. Could be one of 'queue' or 'subscriber'. </param>
        /// <param name="queueName"> The name of the Microsoft.ServiceBus queue. If the entity type is of type 'subscriber', then this value will be null. </param>
        /// <param name="topicName"> The name of the Microsoft.ServiceBus topic. If the entity type is of type 'queue', then this value will be null. </param>
        /// <param name="subscriptionName"> The name of the Microsoft.ServiceBus topic's subscription. If the entity type is of type 'queue', then this value will be null. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData(string namespaceName, string requestUri, string entityType, string queueName, string topicName, string subscriptionName, Dictionary<string, BinaryData> rawData)
        {
            NamespaceName = namespaceName;
            RequestUri = requestUri;
            EntityType = entityType;
            QueueName = queueName;
            TopicName = topicName;
            SubscriptionName = subscriptionName;
            _rawData = rawData;
        }

        /// <summary> The namespace name of the Microsoft.ServiceBus resource. </summary>
        public string NamespaceName { get; }
        /// <summary> The endpoint of the Microsoft.ServiceBus resource. </summary>
        public string RequestUri { get; }
        /// <summary> The entity type of the Microsoft.ServiceBus resource. Could be one of 'queue' or 'subscriber'. </summary>
        public string EntityType { get; }
        /// <summary> The name of the Microsoft.ServiceBus queue. If the entity type is of type 'subscriber', then this value will be null. </summary>
        public string QueueName { get; }
        /// <summary> The name of the Microsoft.ServiceBus topic. If the entity type is of type 'queue', then this value will be null. </summary>
        public string TopicName { get; }
        /// <summary> The name of the Microsoft.ServiceBus topic's subscription. If the entity type is of type 'queue', then this value will be null. </summary>
        public string SubscriptionName { get; }
    }
}
