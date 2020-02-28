﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Reflection;
using Azure.Messaging.EventHubs.Core;
using Azure.Messaging.EventHubs.Producer;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="EventDataBatch" />
    ///   class.
    /// </summary>
    ///
    [TestFixture]
    public class EventDataBatchTests
    {
        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorVerifiesTheTransportBatch()
        {
            Assert.That(() => new EventDataBatch(null, "ns", "eh", new SendEventOptions()), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorVerifiesTheFullyQualifiedNamespace(string fullyQualifiedNamespace)
        {
            // Seems ExactTypeConstraints is not re-entrant.
            ExactTypeConstraint TypeConstraint() => fullyQualifiedNamespace is null ? Throws.ArgumentNullException : Throws.ArgumentException;

            Assert.That(() => new EventDataBatch(new MockTransportBatch(), fullyQualifiedNamespace, "eh", new SendEventOptions()), TypeConstraint());
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ConstructorVerifiesTheEventHubName(string eventHubName)
        {
            // Seems ExactTypeConstraints is not re-entrant.
            ExactTypeConstraint TypeConstraint() => eventHubName is null ? Throws.ArgumentNullException : Throws.ArgumentException;

            Assert.That(() => new EventDataBatch(new MockTransportBatch(), "ns", eventHubName, new SendEventOptions()), TypeConstraint());
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorVerifiesTheSendOptions()
        {
            Assert.That(() => new EventDataBatch(new MockTransportBatch(), "ns", "eh", null), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorUpdatesState()
        {
            var sendOptions = new SendEventOptions();
            var mockBatch = new MockTransportBatch();
            var batch = new EventDataBatch(mockBatch, "ns", "eh", sendOptions);

            Assert.That(batch.SendOptions, Is.SameAs(sendOptions), "The send options should have been set.");
            Assert.That(GetInnerBatch(batch), Is.SameAs(mockBatch), "The inner transport batch should have been set.");
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch" />
        ///   class.
        /// </summary>
        ///
        [Test]
        public void PropertyAccessIsDelegatedToTheTransportClient()
        {
            var mockBatch = new MockTransportBatch();
            var batch = new EventDataBatch(mockBatch, "ns", "eh", new SendEventOptions());

            Assert.That(batch.MaximumSizeInBytes, Is.EqualTo(mockBatch.MaximumSizeInBytes), "The maximum size should have been delegated.");
            Assert.That(batch.SizeInBytes, Is.EqualTo(mockBatch.SizeInBytes), "The size should have been delegated.");
            Assert.That(batch.Count, Is.EqualTo(mockBatch.Count), "The count should have been delegated.");
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch.TryAdd" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void TryAddIsDelegatedToTheTransportClient()
        {
            var mockBatch = new MockTransportBatch();
            var batch = new EventDataBatch(mockBatch, "ns", "eh", new SendEventOptions());
            var eventData = new EventData(new byte[] { 0x21 });

            Assert.That(batch.TryAdd(eventData), Is.True, "The event should have been accepted.");
            Assert.That(mockBatch.TryAddCalledWith, Is.SameAs(eventData), "The event data should have been passed with delegation.");
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch.AsEnumerable" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AsEnumerableIsDelegatedToTheTransportClient()
        {
            var mockBatch = new MockTransportBatch();
            var batch = new EventDataBatch(mockBatch, "ns", "eh", new SendEventOptions());

            batch.AsEnumerable<string>();
            Assert.That(mockBatch.AsEnumerableCalledWith, Is.EqualTo(typeof(string)), "The enumerable should delegated the requested type parameter.");
        }

        /// <summary>
        ///   Verifies property accessors for the <see cref="EventDataBatch.TryAdd" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void DisposeIsDelegatedToTheTransportClient()
        {
            var mockBatch = new MockTransportBatch();
            var batch = new EventDataBatch(mockBatch, "ns", "eh", new SendEventOptions());

            batch.Dispose();
            Assert.That(mockBatch.DisposeInvoked, Is.True);
        }

        /// <summary>
        ///   Retrieves the inner transport batch from an <see cref="EventDataBatch" />
        ///   using its private accessors.
        /// </summary>
        ///
        /// <param name="batch">The batch to retrieve the inner transport batch from.</param>
        ///
        /// <returns>The inner transport batch.</returns>
        ///
        private static TransportEventBatch GetInnerBatch(EventDataBatch batch) =>
            (TransportEventBatch)
                typeof(EventDataBatch)
                    .GetProperty("InnerBatch", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(batch);

        /// <summary>
        ///   Allows for the transport event batch created by a client to be injected for testing purposes.
        /// </summary>
        ///
        private class MockTransportBatch : TransportEventBatch
        {
            public bool DisposeInvoked = false;
            public Type AsEnumerableCalledWith = null;
            public EventData TryAddCalledWith = null;

            public override long MaximumSizeInBytes { get; } = 200;
            public override long SizeInBytes { get; } = 100;
            public override int Count { get; } = 300;

            public override void Dispose()
            {
                DisposeInvoked = true;
            }

            public override bool TryAdd(EventData eventData)
            {
                TryAddCalledWith = eventData;
                return true;
            }

            public override IEnumerable<T> AsEnumerable<T>()
            {
                AsEnumerableCalledWith = typeof(T);
                return default;
            }
        }
    }
}
