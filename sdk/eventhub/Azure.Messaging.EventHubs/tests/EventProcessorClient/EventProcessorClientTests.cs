﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.EventHubs.Authorization;
using Azure.Messaging.EventHubs.Core;
using Azure.Messaging.EventHubs.Metadata;
using Azure.Messaging.EventHubs.Processor;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="EventProcessorClient" />
    ///   class.
    /// </summary>
    ///
    [TestFixture]
    public class EventProcessorClientTests
    {
        /// <summary>
        ///   Provides test cases for the constructor tests.
        /// </summary>
        ///
        public static IEnumerable<object[]> ConstructorCreatesDefaultOptionsCases()
        {
            var connectionString = "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub";
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");

            yield return new object[] { new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), connectionString), "connection string with default options" };
            yield return new object[] { new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), connectionString, null), "connection string with explicit null options" };
            yield return new object[] { new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), "namespace", "hub", credential.Object), "namespace with default options" };
            yield return new object[] { new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), "namespace", "hub", credential.Object, null), "namespace with explicit null options" };
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventProcessorClient" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorValidatesTheConsumerGroup(string consumerGroup)
        {
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            Assert.That(() => new EventProcessorClient(consumerGroup, Mock.Of<PartitionManager>(), "dummyConnection", new EventProcessorClientOptions()), Throws.InstanceOf<ArgumentException>(), "The connection string constructor should validate the consumer group.");
            Assert.That(() => new EventProcessorClient(consumerGroup, Mock.Of<PartitionManager>(), "dummyNamespace", "dummyEventHub", credential.Object, new EventProcessorClientOptions()), Throws.InstanceOf<ArgumentException>(), "The namespace constructor should validate the consumer group.");
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorValidatesThePartitionManager()
        {
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            Assert.That(() => new EventProcessorClient("consumerGroup", null, "dummyConnection", new EventProcessorClientOptions()), Throws.InstanceOf<ArgumentException>(), "The connection string constructor should validate the event processor store.");
            Assert.That(() => new EventProcessorClient("consumerGroup", null, "dummyNamespace", "dummyEventHub", credential.Object, new EventProcessorClientOptions()), Throws.InstanceOf<ArgumentException>(), "The namespace constructor should validate the event processor store.");
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorValidatesTheConnectionString(string connectionString)
        {
            Assert.That(() => new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connectionString), Throws.InstanceOf<ArgumentException>(), "The constructor without options should ensure a connection string.");
            Assert.That(() => new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connectionString, "dummy", new EventProcessorClientOptions()), Throws.InstanceOf<ArgumentException>(), "The constructor with options should ensure a connection string.");
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorValidatesTheNamespace(string constructorArgument)
        {
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            Assert.That(() => new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), constructorArgument, "dummy", credential.Object), Throws.InstanceOf<ArgumentException>());
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorValidatesTheEventHub(string constructorArgument)
        {
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            Assert.That(() => new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), "namespace", constructorArgument, credential.Object), Throws.InstanceOf<ArgumentException>());
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorValidatesTheCredential()
        {
            Assert.That(() => new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), "namespace", "hubName", default(TokenCredential)), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void ConnectionStringConstructorSetsTheRetryPolicy()
        {
            var expected = Mock.Of<EventHubsRetryPolicy>();
            var options = new EventProcessorClientOptions { RetryOptions = new RetryOptions { CustomRetryPolicy = expected } };
            var connectionString = "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub";
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connectionString, options);

            Assert.That(GetRetryPolicy(processor), Is.SameAs(expected));
        }

        /// <summary>
        ///   Verifies functionality of the constructor.
        /// </summary>
        ///
        [Test]
        public void NamespaceConstructorSetsTheRetryPolicy()
        {
            var expected = Mock.Of<EventHubsRetryPolicy>();
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            var options = new EventProcessorClientOptions { RetryOptions = new RetryOptions { CustomRetryPolicy = expected } };
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), "namespace", "hubName", credential.Object, options);

            Assert.That(GetRetryPolicy(processor), Is.SameAs(expected));
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(ConstructorCreatesDefaultOptionsCases))]
        public void ConstructorCreatesDefaultOptions(ReadableOptionsMock eventProcessor,
                                                     string constructorDescription)
        {
            var defaultOptions = new EventProcessorClientOptions();
            EventProcessorClientOptions options = eventProcessor.Options;

            Assert.That(options, Is.Not.Null, $"The { constructorDescription } constructor should have set default options.");
            Assert.That(options, Is.Not.SameAs(defaultOptions), $"The { constructorDescription } constructor should not have the same options instance.");
            Assert.That(options.MaximumReceiveWaitTime, Is.EqualTo(defaultOptions.MaximumReceiveWaitTime), $"The { constructorDescription } constructor should have the correct maximum receive wait time.");
            Assert.That(options.TrackLastEnqueuedEventInformation, Is.EqualTo(defaultOptions.TrackLastEnqueuedEventInformation), $"The { constructorDescription } constructor should default tracking of last event information.");
            Assert.That(options.ConnectionOptions.TransportType, Is.EqualTo(defaultOptions.ConnectionOptions.TransportType), $"The { constructorDescription } constructor should have a default set of connection options.");
            Assert.That(options.RetryOptions.IsEquivalentTo(defaultOptions.RetryOptions), Is.True, $"The { constructorDescription } constructor should have a default set of retry options.");
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        public void ConnectionStringConstructorClonesOptions()
        {
            var options = new EventProcessorClientOptions
            {
                MaximumReceiveWaitTime = TimeSpan.FromMinutes(65),
                RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(1), Delay = TimeSpan.FromMinutes(4) },
                ConnectionOptions = new EventHubConnectionOptions { TransportType = TransportType.AmqpWebSockets }
            };

            var eventProcessor = new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub", options);
            EventProcessorClientOptions clonedOptions = eventProcessor.Options;

            Assert.That(clonedOptions, Is.Not.Null, "The constructor should have set the options.");
            Assert.That(clonedOptions, Is.Not.SameAs(options), "The constructor should have cloned the options.");
            Assert.That(clonedOptions.MaximumReceiveWaitTime, Is.EqualTo(options.MaximumReceiveWaitTime), "The constructor should have the correct maximum receive wait time.");
            Assert.That(clonedOptions.TrackLastEnqueuedEventInformation, Is.EqualTo(options.TrackLastEnqueuedEventInformation), "The tracking of last event information of the clone should match.");
            Assert.That(clonedOptions.ConnectionOptions.TransportType, Is.EqualTo(options.ConnectionOptions.TransportType), "The connection options of the clone should copy properties.");
            Assert.That(clonedOptions.ConnectionOptions, Is.Not.SameAs(options.ConnectionOptions), "The connection options of the clone should be a copy, not the same instance.");
            Assert.That(clonedOptions.RetryOptions.IsEquivalentTo(options.RetryOptions), Is.True, "The retry options of the clone should be considered equal.");
            Assert.That(clonedOptions.RetryOptions, Is.Not.SameAs(options.RetryOptions), "The retry options of the clone should be a copy, not the same instance.");
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        public void NamespaceConstructorClonesOptions()
        {
            var options = new EventProcessorClientOptions
            {
                MaximumReceiveWaitTime = TimeSpan.FromMinutes(65),
                RetryOptions = new RetryOptions { TryTimeout = TimeSpan.FromMinutes(1), Delay = TimeSpan.FromMinutes(4) },
                ConnectionOptions = new EventHubConnectionOptions { TransportType = TransportType.AmqpWebSockets }
            };

            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            var eventProcessor = new ReadableOptionsMock("consumerGroup", Mock.Of<PartitionManager>(), "namespace", "hub", credential.Object, options);
            EventProcessorClientOptions clonedOptions = eventProcessor.Options;

            Assert.That(clonedOptions, Is.Not.Null, "The constructor should have set the options.");
            Assert.That(clonedOptions, Is.Not.SameAs(options), "The constructor should have cloned the options.");
            Assert.That(clonedOptions.MaximumReceiveWaitTime, Is.EqualTo(options.MaximumReceiveWaitTime), "The constructor should have the correct maximum receive wait time.");
            Assert.That(clonedOptions.TrackLastEnqueuedEventInformation, Is.EqualTo(options.TrackLastEnqueuedEventInformation), "The tracking of last event information of the clone should match.");
            Assert.That(clonedOptions.ConnectionOptions.TransportType, Is.EqualTo(options.ConnectionOptions.TransportType), "The connection options of the clone should copy properties.");
            Assert.That(clonedOptions.ConnectionOptions, Is.Not.SameAs(options.ConnectionOptions), "The connection options of the clone should be a copy, not the same instance.");
            Assert.That(clonedOptions.RetryOptions.IsEquivalentTo(options.RetryOptions), Is.True, "The retry options of the clone should be considered equal.");
            Assert.That(clonedOptions.RetryOptions, Is.Not.SameAs(options.RetryOptions), "The retry options of the clone should be a copy, not the same instance.");
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        public void ConnectionStringConstructorCreatesTheIdentifier()
        {
            var eventProcessor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub");

            Assert.That(eventProcessor.Identifier, Is.Not.Null);
            Assert.That(eventProcessor.Identifier, Is.Not.Empty);
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" />
        ///    constructor.
        /// </summary>
        ///
        [Test]
        public void NamespaceConstructorCreatesTheIdentifier()
        {
            var credential = new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net");
            var eventProcessor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), "namespace", "hub", credential.Object);

            Assert.That(eventProcessor.Identifier, Is.Not.Null);
            Assert.That(eventProcessor.Identifier, Is.Not.Empty);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventHubConsumerClient.FullyQualifiedNamespace" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void ProcessorDelegatesForTheFullyQualifiedNamespaceName()
        {
            var expected = "SomeNamespace";
            var mockConnection = new MockConnection(expected);
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), mockConnection, default);

            Assert.That(processor.FullyQualifiedNamespace, Is.EqualTo(expected));
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventHubProducerClient.EventHubName" />
        ///   property.
        /// </summary>
        ///
        [Test]
        public void ConsumerDelegatesForTheEventHubName()
        {
            var expected = "EventHubName";
            var mockConnection = new MockConnection(eventHubName: expected);
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), mockConnection, default);

            Assert.That(processor.EventHubName, Is.EqualTo(expected));
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient.StartAsync" />
        ///    method.
        /// </summary>
        ///
        [Test]
        public void StartAsyncValidatesProcessEventsAsync()
        {
            var processor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), new MockConnection(), default);
            processor.ProcessExceptionAsync = errorContext => new ValueTask();

            Assert.That(async () => await processor.StartAsync(), Throws.InstanceOf<InvalidOperationException>().And.Message.Contains(nameof(EventProcessorClient.ProcessEventAsync)));
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient.StartAsync" />
        ///    method.
        /// </summary>
        ///
        [Test]
        public void StartAsyncValidatesProcessExceptionAsync()
        {
            var processor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), new MockConnection(), default);
            processor.ProcessEventAsync = processorEvent => new ValueTask();

            Assert.That(async () => await processor.StartAsync(), Throws.InstanceOf<InvalidOperationException>().And.Message.Contains(nameof(EventProcessorClient.ProcessExceptionAsync)));
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient.StartAsync" />
        ///    method.
        /// </summary>
        ///
        [Test]
        public async Task StartAsyncStartsTheEventProcessorWhenProcessingHandlerPropertiesAreSet()
        {
            var processor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), new MockConnection(), default);

            processor.ProcessEventAsync = processorEvent => new ValueTask();
            processor.ProcessExceptionAsync = errorContext => new ValueTask();

            Assert.That(async () => await processor.StartAsync(), Throws.Nothing);

            await processor.StopAsync();
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" /> properties.
        /// </summary>
        ///
        [Test]
        public async Task HandlerPropertiesCannotBeSetWhenEventProcessorIsRunning()
        {
            var processor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), new MockConnection(), default);

            processor.ProcessEventAsync = processorEvent => new ValueTask();
            processor.ProcessExceptionAsync = errorContext => new ValueTask();

            await processor.StartAsync();

            Assert.That(() => processor.InitializeProcessingForPartitionAsync = initializationContext => new ValueTask(), Throws.InstanceOf<InvalidOperationException>());
            Assert.That(() => processor.ProcessingForPartitionStoppedAsync = stopContext => new ValueTask(), Throws.InstanceOf<InvalidOperationException>());
            Assert.That(() => processor.ProcessEventAsync = processorEvent => new ValueTask(), Throws.InstanceOf<InvalidOperationException>());
            Assert.That(() => processor.ProcessExceptionAsync = errorContext => new ValueTask(), Throws.InstanceOf<InvalidOperationException>());

            await processor.StopAsync();
        }

        /// <summary>
        ///    Verifies functionality of the <see cref="EventProcessorClient" /> properties.
        /// </summary>
        ///
        [Test]
        public async Task HandlerPropertiesCanBeSetAfterEventProcessorHasStopped()
        {
            var processor = new EventProcessorClient("consumerGroup", Mock.Of<PartitionManager>(), new MockConnection(), default);

            processor.ProcessEventAsync = processorEvent => new ValueTask();
            processor.ProcessExceptionAsync = errorContext => new ValueTask();

            await processor.StartAsync();
            await processor.StopAsync();

            Assert.That(() => processor.InitializeProcessingForPartitionAsync = initializationContext => new ValueTask(), Throws.Nothing);
            Assert.That(() => processor.ProcessingForPartitionStoppedAsync = stopContext => new ValueTask(), Throws.Nothing);
            Assert.That(() => processor.ProcessEventAsync = processorEvent => new ValueTask(), Throws.Nothing);
            Assert.That(() => processor.ProcessExceptionAsync = errorContext => new ValueTask(), Throws.Nothing);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventProcessorClient.CloseAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task CloseAsyncClosesTheConnectionWhenOwned()
        {
            var connectionString = "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub";
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connectionString);

            await processor.CloseAsync();

            var connection = GetConnection(processor);
            Assert.That(connection.IsClosed, Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventProcessorClient.Close" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void CloseClosesTheConnectionWhenOwned()
        {
            var connectionString = "Endpoint=sb://somehost.com;SharedAccessKeyName=ABC;SharedAccessKey=123;EntityPath=somehub";
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connectionString);

            processor.Close();

            var connection = GetConnection(processor);
            Assert.That(connection.IsClosed, Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventProcessorClient.CloseAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task CloseAsyncDoesNotCloseTheConnectionWhenNotOwned()
        {
            var connection = new MockConnection();
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connection, default);

            await processor.CloseAsync();
            Assert.That(connection.IsClosed, Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventHubProducer.Close" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void CloseDoesNotCloseTheConnectionWhenNotOwned()
        {
            var connection = new MockConnection();
            var processor = new EventProcessorClient(EventHubConsumerClient.DefaultConsumerGroupName, Mock.Of<PartitionManager>(), connection, default);

            processor.Close();
            Assert.That(connection.IsClosed, Is.False);
        }

        [Test]
        public async Task FindAndClaimOwnershipAsyncClaimsAllClaimablePartitions()
        {
            var connection = new MockConnection();
            var partitionManager = new InMemoryPartitionManager();
            var processor = new MockEventProcessorClient(
                "consumerGroup",
                partitionManager,
                connection,
                default);

            var partitionIds = Enumerable.Range(1, 3)
                .Select(i => i.ToString())
                .ToList();
            var completeOwnership = connection.CreatePartitionOwnerships(partitionIds, processor.Identifier);

            // ownership should start empty
            var activeOwnership = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            CollectionAssert.IsEmpty(activeOwnership);


            // start the processor so that the procesor claims a random partition until none are left
            await processor.StartAsync();
            await processor.WaitStabilization();
            await processor.StopAsync();

            activeOwnership = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);

            Assert.AreEqual(partitionIds.Count, activeOwnership.Count());
        }

        [Test]
        public async Task FindAndClaimOwnershipAsync_ClaimsPartitions_WhenOwned_Equals_MinimumOwnedPartitionsCount()
        {
            const int minimumParitionCount = 4;
            const int NumberOfPartitions = 13;
            var connection = new MockConnection(numberOfPartitions: NumberOfPartitions);
            var partitionManager = new InMemoryPartitionManager();
            var processor = new MockEventProcessorClient(
                "consumerGroup",
                partitionManager,
                connection,
                default);

            // create more partitions owned by this Processor
            var processor1PartitionIds = Enumerable.Range(1, minimumParitionCount)
                .Select(i => i.ToString());
            var ownedPartitions = connection.CreatePartitionOwnerships(processor1PartitionIds, processor.Identifier);

            // create more partitions owned by a different Processor
            var Processor2Id = Guid.NewGuid().ToString();
            var processor2PartitionIds = Enumerable.Range(minimumParitionCount + 1, minimumParitionCount)
                .Select(i => i.ToString());
            ownedPartitions = ownedPartitions
                .Concat(connection.CreatePartitionOwnerships(processor2PartitionIds, Processor2Id));

            // create more partitions owned by a different Processor
            var Processor3Id = Guid.NewGuid().ToString();
            var processor3PartitionIds = Enumerable.Range((2 * minimumParitionCount) + 1, minimumParitionCount)
                .Select(i => i.ToString());
            ownedPartitions = ownedPartitions
                .Concat(connection.CreatePartitionOwnerships(processor3PartitionIds, Processor3Id));

            // seed the partitionManager with the owned partitions
            await partitionManager.ClaimOwnershipAsync(ownedPartitions);

            var claimablePartitionIds = (await connection.GetPartitionIdsAsync(Mock.Of<EventHubsRetryPolicy>()))
                                            .Except(ownedPartitions.Select(p => p.PartitionId));

            // get owned partitions
            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            var ownedByProcessor1 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == processor.Identifier);

            // verify owned partitionIds match the owned partitions
            Assert.AreEqual(minimumParitionCount, ownedByProcessor1.Count());
            Assert.IsFalse(ownedByProcessor1.Any(owned => claimablePartitionIds.Contains(owned.PartitionId)));

            // start the processor to claim owership from of a Partition even though ownedPartitionCount == minimumOwnedPartitionsCount
            await processor.StartAsync();
            await processor.WaitStabilization();
            await processor.StopAsync();

            // get owned partitions
            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            ownedByProcessor1 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == processor.Identifier);

            //verify that we took ownership of the additional partition
            Assert.Greater(ownedByProcessor1.Count(), minimumParitionCount);
            Assert.IsTrue(ownedByProcessor1.Any(owned => claimablePartitionIds.Contains(owned.PartitionId)));
        }

        // pre-req: when no unclaimed partitions exist
        [Test]
        public async Task FindAndClaimOwnershipAsync_StealsPartitions_ThisProcessor_OwnsMinPartitions_OtherProcessorOwnsGreatherThanMaxPartitions()
        {
            const int minimumParitionCount = 4;
            const int maximumParitionCount = 5;
            const int NumberOfPartitions = 14;
            var connection = new MockConnection(numberOfPartitions: NumberOfPartitions);
            var partitionManager = new InMemoryPartitionManager();
            var processor = new MockEventProcessorClient(
                "consumerGroup",
                partitionManager,
                connection,
                default);

            // create partitions owned by this Processor
            var processor1PartitionIds = Enumerable.Range(1, minimumParitionCount)
                .Select(i => i.ToString());
            var completeOwnership = connection.CreatePartitionOwnerships(processor1PartitionIds, processor.Identifier);

            // create partitions owned by a different Processor
            var Processor2Id = Guid.NewGuid().ToString();
            var processor2PartitionIds = Enumerable.Range(minimumParitionCount + 1, minimumParitionCount)
                .Select(i => i.ToString());
            completeOwnership = completeOwnership
                .Concat(connection.CreatePartitionOwnerships(processor2PartitionIds, Processor2Id));

            // create partitions owned by a different Processor above the maximumPartitionCount
            var Processor3Id = Guid.NewGuid().ToString();
            var stealablePartitionIds = Enumerable.Range((2 * minimumParitionCount) + 1, NumberOfPartitions - (2 * minimumParitionCount))
                .Select(i => i.ToString());
            completeOwnership = completeOwnership
                .Concat(connection.CreatePartitionOwnerships(stealablePartitionIds, Processor3Id));

            // seed the partitionManager with the owned partitions
            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            // get owned partitions
            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            var ownedByProcessor1 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == processor.Identifier);
            var ownedByProcessor3 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == Processor3Id);

            // verify owned partitionIds match the owned partitions
            Assert.IsFalse(ownedByProcessor1.Any(owned => stealablePartitionIds.Contains(owned.PartitionId)));

            //verify processor 3 has stealable partitions
            Assert.Greater(ownedByProcessor3.Count(), maximumParitionCount);

            // start the processor to steal owership from of a when ownedPartitionCount == minimumOwnedPartitionsCount but a processor owns > maximumPartitionCount
            await processor.StartAsync();
            await processor.WaitStabilization();
            await processor.StopAsync();

            // get owned partitions
            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            ownedByProcessor1 = totalOwnedPartitions
                .Where(p => p.OwnerIdentifier == processor.Identifier);
            ownedByProcessor3 = totalOwnedPartitions
                .Where(p => p.OwnerIdentifier == Processor3Id);

            //verify that we took ownership of the additional partition
            Assert.IsTrue(ownedByProcessor1.Any(owned => stealablePartitionIds.Contains(owned.PartitionId)));

            //verify processor 3 now does not own > maximumPartitionCount
            Assert.AreEqual(maximumParitionCount, ownedByProcessor3.Count());
        }

        [Test]
        public async Task FindAndClaimOwnershipAsync_StealsPartitions_ThisProcessor_OwnsLessThanMinPartitions_OtherProcessor_OwnsMaxPartitions()
        {
            const int minimumParitionCount = 4;
            const int maximumParitionCount = 5;
            const int NumberOfPartitions = 12;
            var connection = new MockConnection(numberOfPartitions: NumberOfPartitions);
            var partitionManager = new InMemoryPartitionManager();
            var processor = new MockEventProcessorClient(
                "consumerGroup",
                partitionManager,
                connection,
                default);

            // create more partitions owned by this Processor
            var processor1PartitionIds = Enumerable.Range(1, minimumParitionCount - 1)
                .Select(i => i.ToString());
            var completeOwnership = connection.CreatePartitionOwnerships(processor1PartitionIds, processor.Identifier);

            // create more partitions owned by a different Processor
            var Processor2Id = Guid.NewGuid().ToString();
            var processor2PartitionIds = Enumerable.Range(minimumParitionCount, minimumParitionCount)
                .Select(i => i.ToString());
            completeOwnership = completeOwnership
                .Concat(connection.CreatePartitionOwnerships(processor2PartitionIds, Processor2Id));

            // create more partitions owned by a different Processor above the maximumPartitionCount
            var Processor3Id = Guid.NewGuid().ToString();
            var stealablePartitionIds = Enumerable.Range((2 * minimumParitionCount), maximumParitionCount)
                .Select(i => i.ToString());
            completeOwnership = completeOwnership
                .Concat(connection.CreatePartitionOwnerships(stealablePartitionIds, Processor3Id));

            // seed the partitionManager with the owned partitions
            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            // get owned partitions
            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            var ownedByProcessor1 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == processor.Identifier);
            var ownedByProcessor3 = totalOwnedPartitions
                                        .Where(p => p.OwnerIdentifier == Processor3Id);

            // verify owned partitionIds match the owned partitions
            Assert.IsFalse(ownedByProcessor1.Any(owned => stealablePartitionIds.Contains(owned.PartitionId)));

            //verify processor 3 has stealable partitions
            Assert.AreEqual(maximumParitionCount, ownedByProcessor3.Count());

            // start the processor to steal owership from of a when ownedPartitionCount == minimumOwnedPartitionsCount but a processor owns > maximumPartitionCount
            await processor.StartAsync();
            await processor.WaitStabilization();
            await processor.StopAsync();

            // get owned partitions
            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(connection.FullyQualifiedNamespace, connection.EventHubName, processor.ConsumerGroup);
            ownedByProcessor1 = totalOwnedPartitions
                .Where(p => p.OwnerIdentifier == processor.Identifier);
            ownedByProcessor3 = totalOwnedPartitions
                .Where(p => p.OwnerIdentifier == Processor3Id);

            //verify that we took ownership of the additional partition
            Assert.IsTrue(ownedByProcessor1.Any(owned => stealablePartitionIds.Contains(owned.PartitionId)));

            //verify processor 3 now does not own > maximumPartitionCount
            Assert.Less(ownedByProcessor3.Count(), maximumParitionCount);
        }

        /// <summary>
        ///   Retrieves the Connection for the processor client using its private accessor.
        /// </summary>
        ///
        private static EventHubConnection GetConnection(EventProcessorClient client) =>
            (EventHubConnection)
                typeof(EventProcessorClient)
                    .GetProperty("Connection", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(client);

        /// <summary>
        ///   Retrieves the RetryPolicy for the processor client using its private accessor.
        /// </summary>
        ///
        private static EventHubsRetryPolicy GetRetryPolicy(EventProcessorClient client) =>
            (EventHubsRetryPolicy)
                typeof(EventProcessorClient)
                    .GetProperty("RetryPolicy", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(client);

        /// <summary>
        ///   Allows for the options used by the event processor to be exposed for testing purposes.
        /// </summary>
        ///
        public class ReadableOptionsMock : EventProcessorClient
        {
            public EventProcessorClientOptions Options =>
                typeof(EventProcessorClient)
                    .GetProperty(nameof(Options), BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(this) as EventProcessorClientOptions;

            public ReadableOptionsMock(string consumerGroup,
                                       PartitionManager partitionManager,
                                       string connectionString,
                                       EventProcessorClientOptions options = default) : base(consumerGroup, partitionManager, connectionString, options)
            {
            }

            public ReadableOptionsMock(string consumerGroup,
                                       PartitionManager partitionManager,
                                       string fullyQualifiedNamespace,
                                       string eventHubName,
                                       TokenCredential credential,
                                       EventProcessorClientOptions options = default) : base(consumerGroup, partitionManager, fullyQualifiedNamespace, eventHubName, credential, options)
            {
            }
        }

        /// <summary>
        ///   Serves as a non-functional connection for testing consumer functionality.
        /// </summary>
        ///
        private class MockConnection : EventHubConnection
        {

            private readonly Mock<TransportClient> client = new Mock<TransportClient>();
            private readonly EventHubProperties _eventHubProperties;

            private readonly Dictionary<string, ConcurrentQueue<EventData>> eventPipeline = new Dictionary<string, ConcurrentQueue<EventData>>();

            private EventHubProperties MockProperties => _eventHubProperties;

            public MockConnection(string namespaceName = "fakeNamespace",
                                  string eventHubName = "fakeEventHub",
                                  int numberOfPartitions = 3) : base(namespaceName, eventHubName, CreateCredentials())
            {
                var partitionIds = Enumerable
                    .Range(1, numberOfPartitions)
                    .Select(p => p.ToString())
                    .ToArray();

                foreach (var partitionId in partitionIds)
                {
                    eventPipeline[partitionId] = new ConcurrentQueue<EventData>();
                }

                _eventHubProperties = new EventHubProperties(
                    eventHubName,
                    DateTime.UtcNow,
                    partitionIds);
            }

            private static EventHubTokenCredential CreateCredentials()
            {
                return new Mock<EventHubTokenCredential>(Mock.Of<TokenCredential>(), "{namespace}.servicebus.windows.net").Object;
            }

            internal override TransportProducer CreateTransportProducer(string partitionID, EventHubProducerClientOptions producerOptions = null)
            {
                var transportProducer = new Mock<TransportProducer>();

                transportProducer
                    .Setup(producer => producer.SendAsync(It.IsAny<IEnumerable<EventData>>(), It.IsAny<SendOptions>(), It.IsAny<System.Threading.CancellationToken>()))
                    .Returns(Task.CompletedTask)
                    .Callback<IEnumerable<EventData>, SendOptions, System.Threading.CancellationToken>((events, options, token) =>
                    {
                        foreach (var eventData in events)
                        {
                            eventPipeline[options.PartitionKey].Enqueue(eventData);
                        }
                    });

                return transportProducer.Object;
            }

            internal override TransportConsumer CreateTransportConsumer(string consumerGroup,
                                                                        string partitionId,
                                                                        EventPosition eventPosition,
                                                                        EventHubConsumerClientOptions consumerOptions = default)
            {
                var transportConsumer = new Mock<TransportConsumer>();

                transportConsumer
                    .Setup(consumer => consumer.ReceiveAsync(It.IsAny<int>(), It.IsAny<TimeSpan>(), It.IsAny<System.Threading.CancellationToken>()))
                    .Returns<int, TimeSpan, System.Threading.CancellationToken>((maxCount, wait, token) =>
                     {
                         int receiveCount = 0;
                         var events = new List<EventData>();
                         while (eventPipeline[partitionId].TryDequeue(out var eventData) && receiveCount < maxCount)
                         {
                             events.Add(eventData);
                             receiveCount++;
                         }
                         return Task.FromResult((IEnumerable<EventData>)events);
                     });

                return transportConsumer.Object;
            }
            internal override TransportClient CreateTransportClient(string fullyQualifiedNamespace, string eventHubName, EventHubTokenCredential credential, EventHubConnectionOptions options)
            {
                client
                    .Setup(client => client.ServiceEndpoint)
                    .Returns(new Uri($"amgp://{ fullyQualifiedNamespace}.com/{eventHubName}"));

                client
                    .Setup(client => client.CloseAsync(It.IsAny<System.Threading.CancellationToken>()))
                    .Returns(Task.CompletedTask);

                return client.Object;
            }

            internal override Task<EventHubProperties> GetPropertiesAsync(EventHubsRetryPolicy retryPolicy, System.Threading.CancellationToken cancellationToken = default)
            {
                return Task.FromResult(MockProperties);
            }

            internal IEnumerable<PartitionOwnership> CreatePartitionOwnerships(IEnumerable<string> partitionIds, string identifier)
            {
                return partitionIds
                    .Select(partitionId =>
                        new PartitionOwnership
                            (
                                this.FullyQualifiedNamespace,
                                this.EventHubName,
                                "consumerGroup",
                                identifier,
                                partitionId,
                                null,
                                null,
                                DateTimeOffset.UtcNow,
                                Guid.NewGuid().ToString()
                            )).ToList();
            }
        }
    }
}
