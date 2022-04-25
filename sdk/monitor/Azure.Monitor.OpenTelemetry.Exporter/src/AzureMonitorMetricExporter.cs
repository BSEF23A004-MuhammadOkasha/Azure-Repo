﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;

using Azure.Core.Pipeline;

using OpenTelemetry;
using OpenTelemetry.Metrics;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    [AggregationTemporality(AggregationTemporality.Delta)]
    internal class AzureMonitorMetricExporter : BaseExporter<Metric>
    {
        private readonly ITransmitter _transmitter;
        private readonly string _instrumentationKey;
        private readonly ResourceParser _resourceParser;
        private readonly AzureMonitorPersistentStorage _persistentStorage;

        public AzureMonitorMetricExporter(AzureMonitorExporterOptions options) : this(new AzureMonitorTransmitter(options))
        {
        }

        internal AzureMonitorMetricExporter(ITransmitter transmitter)
        {
            _transmitter = transmitter;
            _instrumentationKey = transmitter.InstrumentationKey;
            _resourceParser = new ResourceParser();

            if (transmitter is AzureMonitorTransmitter _azureMonitorTransmitter && _azureMonitorTransmitter._storage != null)
            {
                _persistentStorage = new AzureMonitorPersistentStorage(transmitter);
            }
        }

        /// <inheritdoc/>
        public override ExportResult Export(in Batch<Metric> batch)
        {
            _persistentStorage?.StartExporterTimer();

            // Prevent Azure Monitor's HTTP operations from being instrumented.
            using var scope = SuppressInstrumentationScope.Begin();

            try
            {
                if (_resourceParser.RoleName is null && _resourceParser.RoleInstance is null)
                {
                    var resource = ParentProvider.GetResource();
                    _resourceParser.UpdateRoleNameAndInstance(resource);
                }

                var telemetryItems = MetricHelper.OtelToAzureMonitorMetrics(batch, _resourceParser.RoleName, _resourceParser.RoleInstance, _instrumentationKey);
                var exportResult = _transmitter.TrackAsync(telemetryItems, false, CancellationToken.None).EnsureCompleted();
                _persistentStorage?.StopExporterTimerAndTransmitFromStorage();

                return exportResult;
            }
            catch (Exception ex)
            {
                AzureMonitorExporterEventSource.Log.Write($"FailedToExport{EventLevelSuffix.Error}", ex.LogAsyncException());
                return ExportResult.Failure;
            }
        }
    }
}
