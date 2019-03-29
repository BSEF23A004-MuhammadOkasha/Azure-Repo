﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Base.Diagnostics;
using Azure.Base.Http;
using Azure.Base.Http.Pipeline;
using Azure.Base.Testing;
using Azure.Base.Tests.Testing;
using NUnit.Framework;

namespace Azure.Base.Tests
{
    public class FixedRetryPolicyTests
    {
        [Test]
        public async Task WaitsBetweenRetries()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, delay: TimeSpan.FromSeconds(3));
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.Cycle(new MockResponse(500));

            var delay = await policy.DelayGate.Cycle();
            Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

            await mockTransport.RequestGate.Cycle(new MockResponse(200));

            var response = await task.TimeoutAfterDefault();
            Assert.AreEqual(200, response.Status);
        }

        [Test]
        public async Task DoesNotExceedRetryCount()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, delay: TimeSpan.FromSeconds(3), maxRetries: 3);
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.Cycle(new MockResponse(500));

            for (int i = 0; i < 3; i++)
            {
                var delay = await policy.DelayGate.Cycle();
                Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

                await mockTransport.RequestGate.Cycle(new MockResponse(500));
            }

            var response = await task.TimeoutAfterDefault();
            Assert.AreEqual(500, response.Status);
        }

        [Test]
        public async Task OnlyRetriesRetriebleCodes()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, delay: TimeSpan.FromSeconds(3), maxRetries: 3);
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.Cycle(new MockResponse(500));

            var delay = await policy.DelayGate.Cycle();
            Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

            await mockTransport.RequestGate.Cycle(new MockResponse(501));

            var response = await task.TimeoutAfterDefault();
            Assert.AreEqual(501, response.Status);
        }

        [Test]
        public async Task RetriesOnException()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, exceptionFilter: ex => ex is InvalidOperationException, delay: TimeSpan.FromSeconds(3));
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.CycleWithException(new InvalidOperationException());

            var delay = await policy.DelayGate.Cycle();
            Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

            await mockTransport.RequestGate.Cycle(new MockResponse(200));

            var response = await task.TimeoutAfterDefault();
            Assert.AreEqual(200, response.Status);
        }

        [Test]
        public async Task RetriesOnlyFilteredException()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, exceptionFilter: ex => ex is InvalidOperationException, delay: TimeSpan.FromSeconds(3));
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.CycleWithException(new InvalidOperationException());

            var delay = await policy.DelayGate.Cycle();
            Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

            await mockTransport.RequestGate.CycleWithException(new IOException());

            var exception = Assert.ThrowsAsync<AggregateException>(async () => await task.TimeoutAfterDefault());
            StringAssert.StartsWith("Retry failed after 2 tries.", exception.Message);
            Assert.IsInstanceOf<InvalidOperationException>(exception.InnerExceptions[0]);
            Assert.IsInstanceOf<IOException>(exception.InnerExceptions[1]);
        }

        [Test]
        public async Task RetriesOnlyFilteredExceptionFirst()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, exceptionFilter: ex => ex is InvalidOperationException, delay: TimeSpan.FromSeconds(3));
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            await mockTransport.RequestGate.CycleWithException(new IOException());

            var exception = Assert.ThrowsAsync<AggregateException>(async () => await task.TimeoutAfterDefault());
            StringAssert.StartsWith("Retry failed after 1 tries.", exception.Message);
            Assert.IsInstanceOf<IOException>(exception.InnerExceptions[0]);
        }

        [Test]
        public async Task RethrowsAggregateExceptionAfterMaxRetryCount()
        {
            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, exceptionFilter: ex => ex is InvalidOperationException, delay: TimeSpan.FromSeconds(3), maxRetries: 3);
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);
            var exceptions = new List<Exception>();

            exceptions.Add(new InvalidOperationException());
            await mockTransport.RequestGate.CycleWithException(exceptions.Last());

            for (int i = 0; i < 3; i++)
            {
                var delay = await policy.DelayGate.Cycle();
                Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

                exceptions.Add(new InvalidOperationException());
                await mockTransport.RequestGate.CycleWithException(exceptions.Last());
            }

            var exception = Assert.ThrowsAsync<AggregateException>(async () => await task.TimeoutAfterDefault());
            StringAssert.StartsWith("Retry failed after 4 tries.", exception.Message);
            CollectionAssert.AreEqual(exceptions, exception.InnerExceptions);
        }

        [Test]
        public void DoesntMutateOriginalArray()
        {
            var codes = new[] { 1, 500, 0 };
            _ = new FixedRetryPolicyMock(retriableCodes: codes);

            CollectionAssert.AreEqual(new[] {1, 500, 0}, codes);
        }

        [Test]
        [NonParallelizable]
        public async Task RetryingEmitsEventSourceEvent()
        {
            var listener = new TestEventListener();
            listener.EnableEvents(HttpPipelineEventSource.Singleton, EventLevel.Informational);

            var policy = new FixedRetryPolicyMock(retriableCodes: new [] { 500 }, delay: TimeSpan.FromSeconds(3), maxRetries: 2);
            var mockTransport = new MockTransport();
            var task = SendRequest(mockTransport, policy);

            var request = await mockTransport.RequestGate.Cycle(new MockResponse(500));

            for (int i = 0; i < 2; i++)
            {
                var delay = await policy.DelayGate.Cycle();
                Assert.AreEqual(delay, TimeSpan.FromSeconds(3));

                await mockTransport.RequestGate.Cycle(new MockResponse(500));
            }

            await task.TimeoutAfterDefault();

            AssertRetryEvent(listener, request, 1);
            AssertRetryEvent(listener, request, 2);
        }

        private static void AssertRetryEvent(TestEventListener listener, MockRequest request, int retryNumber)
        {
            var e = listener.SingleEventById(10, args => args.GetProperty<int>("retryNumber") == retryNumber);

            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual("RequestRetrying", e.EventName);
            Assert.AreEqual(request.RequestId, e.GetProperty<string>("requestId"));
        }

        private static Task<Response> SendRequest(MockTransport mockTransport, FixedRetryPolicyMock policy)
        {
            var options = new HttpPipelineOptions(mockTransport);
            options.RetryPolicy = policy;

            var pipeline = options.Build(typeof(FixedRetryPolicyTests).Assembly);

            var httpPipelineRequest = pipeline.CreateRequest();
            httpPipelineRequest.SetRequestLine(HttpVerb.Get, new Uri("http://example.com/"));

            return pipeline.SendRequestAsync(httpPipelineRequest, CancellationToken.None);
        }

        private class FixedRetryPolicyMock: FixedRetryPolicy
        {
            public AsyncGate<TimeSpan, object> DelayGate { get; } = new AsyncGate<TimeSpan, object>();

            public FixedRetryPolicyMock(int[] retriableCodes, Func<Exception, bool> exceptionFilter = null, int maxRetries = 3, TimeSpan delay = default) : base(retriableCodes, exceptionFilter, maxRetries, delay)
            {
            }

            internal override Task Delay(TimeSpan time, CancellationToken cancellationToken)
            {
                return DelayGate.WaitForRelease(time);
            }
        }
    }
}
