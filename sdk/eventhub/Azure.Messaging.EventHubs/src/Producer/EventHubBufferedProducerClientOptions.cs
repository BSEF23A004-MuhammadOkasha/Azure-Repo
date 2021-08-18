﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Messaging.EventHubs.Producer
{
    /// <summary>
    ///   The set of options that can be specified when creating an <see cref="EventHubBufferedProducerClient" />
    ///   to configure its behavior.
    /// </summary>
    ///
    public class EventHubBufferedProducerClientOptions : EventHubProducerClientOptions
    {
        /// <summary>
        ///   The amount of time to wait for a new event to be added to the buffer before sending a partially
        ///   full batch.
        /// </summary>
        ///
        /// <value>
        ///   The default wait time is 250 milliseconds.
        /// </value>
        ///
        public TimeSpan? MaximumWaitTime { get; set; } = TimeSpan.FromMilliseconds(250);

        /// <summary>
        ///   The total number of events that can be buffered for publishing at a given time across all partitions.
        ///   Once this capacity is reached, more events can enqueued by calling <see cref="EventHubBufferedProducerClient.EnqueueEventAsync(EventData, EnqueueEventOptions, System.Threading.CancellationToken)" /> or
        ///   <see cref="EventHubBufferedProducerClient.EnqueueEventsAsync(System.Collections.Generic.IEnumerable{EventData}, EnqueueEventOptions, System.Threading.CancellationToken)" />, which will automatically wait for room to be available.
        /// </summary>
        ///
        /// <value>
        ///   The default limit is 2,500 queued events.
        /// </value>
        ///
        public int MaximumBufferedEventCount { get; set; } = 2500;

        /// <summary>
        ///    Indicates whether or not events should be published using idempotent semantics for retries. If enabled, retries during publishing
        ///    will attempt to avoid duplication with a minor cost to throughput.  Duplicates are still possible but the chance of them occurring is
        ///    much lower when idempotent retries are enabled.
        ///</summary>
        ///
        /// <value>
        ///   By default, idempotent retries are disabled.
        ///</value>
        ///
        /// <remarks>
        ///   It is important to note that enabling idempotent retries does not guarantee exactly-once semantics.  The existing
        ///   Event Hubs at-least-once delivery contract still applies and event duplication is unlikely, but possible.
        /// </remarks>
        ///
        public bool EnableIdempotentRetries { get; set; }

        /// <summary>
        ///   The number of batches that may be sent concurrently to each partition.
        /// </summary>
        ///
        /// <value>
        ///   By default, each partition will allow only one publishing operation to be active in
        ///   order to ensure that events are published in the order that they were enqueued.
        ///</value>
        ///
        /// <remarks>
        ///   When batches are published concurrently, the ordering of events is not guaranteed.  If the order events are published
        ///   must be maintained, <see cref="MaximumConcurrentSendsPerPartition" /> should not exceed 1.
        /// </remarks>
        ///
        public int MaximumConcurrentSendsPerPartition
        {
            get => _maximumConcurrentSendsPerPartition;
            set
            {
                Argument.AssertInRange(value, 1, 100, nameof(MaximumConcurrentSendsPerPartition));
                _maximumConcurrentSendsPerPartition = value;
            }
        }

        /// <summary> The number of batches that may be sent concurrently to each partition. </summary>
        private int _maximumConcurrentSendsPerPartition = 1;

        /// <summary>
        ///   Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        ///
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        ///   Returns a hash code for this instance.
        /// </summary>
        ///
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        ///   Converts the instance to string representation.
        /// </summary>
        ///
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
