// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class OperationTimeoutPolicyTests: SyncAsyncPolicyTestBase
    {
        public OperationTimeoutPolicyTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void CancelsTheTokenAfterTimeoutExpires()
        {
            var ticks = Environment.TickCount;

            Assert.ThrowsAsync<TaskCanceledException>(async () => await SendGetRequest(new ForeverWaitingTransport(), new OperationTimeoutPolicy(TimeSpan.FromSeconds(1))).TimeoutAfterDefault());

            ticks = Environment.TickCount;

            Assert.Greater((double)ticks / TimeSpan.TicksPerSecond, 1);
        }

        private class ForeverWaitingTransport: MockTransport
        {
            public override async ValueTask ProcessAsync(HttpMessage message)
            {
                await Task.Delay(Timeout.InfiniteTimeSpan, message.CancellationToken);
            }

            public override void Process(HttpMessage message)
            {
                ProcessAsync(message).GetAwaiter().GetResult();
            }
        }
    }
}