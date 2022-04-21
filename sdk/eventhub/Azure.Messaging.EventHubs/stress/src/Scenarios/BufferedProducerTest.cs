// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Producer;
using Azure.Messaging.EventHubs.Tests;

namespace Azure.Messaging.EventHubs.Stress
{
    internal class BufferedProducerTest
    {
        private Metrics metrics;
        private ProducerConfiguration testConfiguration;

        public BufferedProducerTest(ProducerConfiguration configuration)
        {
            testConfiguration = configuration;
            metrics = new Metrics(configuration.InstrumentationKey);
        }

        public async Task Run()
        {
            var connectionString = testConfiguration.EventHubsConnectionString;
            var eventHubName = testConfiguration.EventHub;
            var appInsightsKey = testConfiguration.InstrumentationKey;
            var durationInHours = testConfiguration.DurationInHours;

            metrics = new Metrics(appInsightsKey);
            using var enqueueingCancellationSource = new CancellationTokenSource();

            var runDuration = TimeSpan.FromHours(durationInHours);
            enqueueingCancellationSource.CancelAfter(runDuration);

            var startOutput = $"Starting a {durationInHours} hour BufferedProducerTest run. Using Event Hub: {eventHubName} which has {testConfiguration.NumPartitions} partitions. See the App Insights dashboard for more information.";
            metrics.Client.TrackTrace(startOutput);

            var enqueuingTasks = default(IEnumerable<Task>);

            try
            {
                enqueuingTasks = Enumerable
                    .Range(0, 2)
                    .Select(_ => Task.Run(() => new BufferedPublisher(testConfiguration, metrics).Start(enqueueingCancellationSource.Token)))
                    .ToList();

                await Task.WhenAll(enqueuingTasks).ConfigureAwait(false);
            }
            catch (TaskCanceledException)
            {
                // No action needed.
            }
            catch (Exception ex) when
                (ex is OutOfMemoryException
                || ex is StackOverflowException
                || ex is ThreadAbortException)
            {
                metrics.Client.TrackException(ex);
                Environment.FailFast(ex.Message);
            }
            catch (Exception ex)
            {
                metrics.Client.TrackException(ex);
            }
        }
    }
}