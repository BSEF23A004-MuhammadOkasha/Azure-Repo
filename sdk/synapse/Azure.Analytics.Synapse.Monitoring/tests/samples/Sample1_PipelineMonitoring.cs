// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Azure.Analytics.Synapse.Monitoring;
using Azure.Analytics.Synapse.Monitoring.Models;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.Samples
{
    /// <summary>
    /// This sample demonstrates how to monitor pipeline runs using synchronous methods of <see cref="MonitoringClient"/>.
    /// </summary>
    public partial class PipelineMonitoring
    {
        [Ignore("https://github.com/Azure/azure-sdk-for-net/issues/17455")]
        [Test]
        public void MonitorPipelineRuns()
        {
            string endpoint = TestEnvironment.EndpointUrl;
            MonitoringClient client = new MonitoringClient(new Uri(endpoint), new DefaultAzureCredential());

            SparkJobListViewResponse sparkJobList = client.GetSparkJobList();
            foreach (var sparkJob in sparkJobList.SparkJobs)
            {
                if (sparkJob.State == "Running")
                {
                    Console.WriteLine ($"{sparkJob.Name} has been running for {sparkJob.RunningDuration}");
                }
                else
                {
                    Console.WriteLine ($"{sparkJob.Name} has been in {sparkJob.State} for {sparkJob.QueuedDuration}");
                }
            }
        }
    }
}
