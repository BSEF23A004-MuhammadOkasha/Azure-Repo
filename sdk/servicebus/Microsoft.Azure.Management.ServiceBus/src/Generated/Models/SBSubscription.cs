// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of subscription resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SBSubscription : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SBSubscription class.
        /// </summary>
        public SBSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SBSubscription class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="messageCount">Number of messages.</param>
        /// <param name="createdAt">Exact time the message was created.</param>
        /// <param name="accessedAt">Last time there was a receive request to
        /// this subscription.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        /// <param name="countDetails">Message count details</param>
        /// <param name="lockDuration">ISO 8061 lock duration timespan for the
        /// subscription. The default value is 1 minute.</param>
        /// <param name="requiresSession">Value indicating if a subscription
        /// supports the concept of sessions.</param>
        /// <param name="defaultMessageTimeToLive">ISO 8061 Default message
        /// timespan to live value. This is the duration after which the
        /// message expires, starting from when the message is sent to Service
        /// Bus. This is the default value used when TimeToLive is not set on a
        /// message itself.</param>
        /// <param name="deadLetteringOnFilterEvaluationExceptions">Value that
        /// indicates whether a subscription has dead letter support on filter
        /// evaluation exceptions.</param>
        /// <param name="deadLetteringOnMessageExpiration">Value that indicates
        /// whether a subscription has dead letter support when a message
        /// expires.</param>
        /// <param name="duplicateDetectionHistoryTimeWindow">ISO 8601 timeSpan
        /// structure that defines the duration of the duplicate detection
        /// history. The default value is 10 minutes.</param>
        /// <param name="maxDeliveryCount">Number of maximum
        /// deliveries.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of a messaging entity. Possible values include: 'Active',
        /// 'Disabled', 'Restoring', 'SendDisabled', 'ReceiveDisabled',
        /// 'Creating', 'Deleting', 'Renaming', 'Unknown'</param>
        /// <param name="enableBatchedOperations">Value that indicates whether
        /// server-side batched operations are enabled.</param>
        /// <param name="autoDeleteOnIdle">ISO 8061 timeSpan idle interval
        /// after which the topic is automatically deleted. The minimum
        /// duration is 5 minutes.</param>
        /// <param name="forwardTo">Queue/Topic name to forward the
        /// messages</param>
        /// <param name="forwardDeadLetteredMessagesTo">Queue/Topic name to
        /// forward the Dead Letter message</param>
        /// <param name="isClientAffine">Value that indicates whether the
        /// subscription has an affinity to the client id.</param>
        /// <param name="clientAffineProperties">Properties specific to client
        /// affine subscriptions.</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        public SBSubscription(string id = default(string), string name = default(string), string type = default(string), long? messageCount = default(long?), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? accessedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), MessageCountDetails countDetails = default(MessageCountDetails), System.TimeSpan? lockDuration = default(System.TimeSpan?), bool? requiresSession = default(bool?), System.TimeSpan? defaultMessageTimeToLive = default(System.TimeSpan?), bool? deadLetteringOnFilterEvaluationExceptions = default(bool?), bool? deadLetteringOnMessageExpiration = default(bool?), System.TimeSpan? duplicateDetectionHistoryTimeWindow = default(System.TimeSpan?), int? maxDeliveryCount = default(int?), EntityStatus? status = default(EntityStatus?), bool? enableBatchedOperations = default(bool?), System.TimeSpan? autoDeleteOnIdle = default(System.TimeSpan?), string forwardTo = default(string), string forwardDeadLetteredMessagesTo = default(string), bool? isClientAffine = default(bool?), SBClientAffineProperties clientAffineProperties = default(SBClientAffineProperties), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            MessageCount = messageCount;
            CreatedAt = createdAt;
            AccessedAt = accessedAt;
            UpdatedAt = updatedAt;
            CountDetails = countDetails;
            LockDuration = lockDuration;
            RequiresSession = requiresSession;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DeadLetteringOnFilterEvaluationExceptions = deadLetteringOnFilterEvaluationExceptions;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            MaxDeliveryCount = maxDeliveryCount;
            Status = status;
            EnableBatchedOperations = enableBatchedOperations;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            ForwardTo = forwardTo;
            ForwardDeadLetteredMessagesTo = forwardDeadLetteredMessagesTo;
            IsClientAffine = isClientAffine;
            ClientAffineProperties = clientAffineProperties;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets number of messages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageCount")]
        public long? MessageCount { get; private set; }

        /// <summary>
        /// Gets exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets last time there was a receive request to this subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessedAt")]
        public System.DateTime? AccessedAt { get; private set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets message count details
        /// </summary>
        [JsonProperty(PropertyName = "properties.countDetails")]
        public MessageCountDetails CountDetails { get; private set; }

        /// <summary>
        /// Gets or sets ISO 8061 lock duration timespan for the subscription.
        /// The default value is 1 minute.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lockDuration")]
        public System.TimeSpan? LockDuration { get; set; }

        /// <summary>
        /// Gets or sets value indicating if a subscription supports the
        /// concept of sessions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresSession")]
        public bool? RequiresSession { get; set; }

        /// <summary>
        /// Gets or sets ISO 8061 Default message timespan to live value. This
        /// is the duration after which the message expires, starting from when
        /// the message is sent to Service Bus. This is the default value used
        /// when TimeToLive is not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultMessageTimeToLive")]
        public System.TimeSpan? DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether a subscription has dead
        /// letter support on filter evaluation exceptions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnFilterEvaluationExceptions")]
        public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether a subscription has dead
        /// letter support when a message expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnMessageExpiration")]
        public bool? DeadLetteringOnMessageExpiration { get; set; }

        /// <summary>
        /// Gets or sets ISO 8601 timeSpan structure that defines the duration
        /// of the duplicate detection history. The default value is 10
        /// minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.duplicateDetectionHistoryTimeWindow")]
        public System.TimeSpan? DuplicateDetectionHistoryTimeWindow { get; set; }

        /// <summary>
        /// Gets or sets number of maximum deliveries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of a
        /// messaging entity. Possible values include: 'Active', 'Disabled',
        /// 'Restoring', 'SendDisabled', 'ReceiveDisabled', 'Creating',
        /// 'Deleting', 'Renaming', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether server-side batched
        /// operations are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// Gets or sets ISO 8061 timeSpan idle interval after which the topic
        /// is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDeleteOnIdle")]
        public System.TimeSpan? AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// Gets or sets queue/Topic name to forward the messages
        /// </summary>
        [JsonProperty(PropertyName = "properties.forwardTo")]
        public string ForwardTo { get; set; }

        /// <summary>
        /// Gets or sets queue/Topic name to forward the Dead Letter message
        /// </summary>
        [JsonProperty(PropertyName = "properties.forwardDeadLetteredMessagesTo")]
        public string ForwardDeadLetteredMessagesTo { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether the subscription has an
        /// affinity to the client id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isClientAffine")]
        public bool? IsClientAffine { get; set; }

        /// <summary>
        /// Gets or sets properties specific to client affine subscriptions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientAffineProperties")]
        public SBClientAffineProperties ClientAffineProperties { get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
