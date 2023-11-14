// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleDataSources : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleDataSources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleDataSources>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DataCollectionRuleDataSources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataCollectionRuleDataSources>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataCollectionRuleDataSources>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PerformanceCounters))
            {
                writer.WritePropertyName("performanceCounters"u8);
                writer.WriteStartArray();
                foreach (var item in PerformanceCounters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WindowsEventLogs))
            {
                writer.WritePropertyName("windowsEventLogs"u8);
                writer.WriteStartArray();
                foreach (var item in WindowsEventLogs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Syslog))
            {
                writer.WritePropertyName("syslog"u8);
                writer.WriteStartArray();
                foreach (var item in Syslog)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogFiles))
            {
                writer.WritePropertyName("logFiles"u8);
                writer.WriteStartArray();
                foreach (var item in LogFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IisLogs))
            {
                writer.WritePropertyName("iisLogs"u8);
                writer.WriteStartArray();
                foreach (var item in IisLogs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WindowsFirewallLogs))
            {
                writer.WritePropertyName("windowsFirewallLogs"u8);
                writer.WriteStartArray();
                foreach (var item in WindowsFirewallLogs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrometheusForwarder))
            {
                writer.WritePropertyName("prometheusForwarder"u8);
                writer.WriteStartArray();
                foreach (var item in PrometheusForwarder)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PlatformTelemetry))
            {
                writer.WritePropertyName("platformTelemetry"u8);
                writer.WriteStartArray();
                foreach (var item in PlatformTelemetry)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DataImports))
            {
                writer.WritePropertyName("dataImports"u8);
                writer.WriteObjectValue(DataImports);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataCollectionRuleDataSources IJsonModel<DataCollectionRuleDataSources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleDataSources(document.RootElement, options);
        }

        internal static DataCollectionRuleDataSources DeserializeDataCollectionRuleDataSources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PerfCounterDataSource>> performanceCounters = default;
            Optional<IList<WindowsEventLogDataSource>> windowsEventLogs = default;
            Optional<IList<SyslogDataSource>> syslog = default;
            Optional<IList<ExtensionDataSource>> extensions = default;
            Optional<IList<LogFilesDataSource>> logFiles = default;
            Optional<IList<IisLogsDataSource>> iisLogs = default;
            Optional<IList<WindowsFirewallLogsDataSource>> windowsFirewallLogs = default;
            Optional<IList<PrometheusForwarderDataSource>> prometheusForwarder = default;
            Optional<IList<PlatformTelemetryDataSource>> platformTelemetry = default;
            Optional<DataSourcesSpecDataImports> dataImports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("performanceCounters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PerfCounterDataSource> array = new List<PerfCounterDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PerfCounterDataSource.DeserializePerfCounterDataSource(item));
                    }
                    performanceCounters = array;
                    continue;
                }
                if (property.NameEquals("windowsEventLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsEventLogDataSource> array = new List<WindowsEventLogDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WindowsEventLogDataSource.DeserializeWindowsEventLogDataSource(item));
                    }
                    windowsEventLogs = array;
                    continue;
                }
                if (property.NameEquals("syslog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyslogDataSource> array = new List<SyslogDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyslogDataSource.DeserializeSyslogDataSource(item));
                    }
                    syslog = array;
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionDataSource> array = new List<ExtensionDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtensionDataSource.DeserializeExtensionDataSource(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("logFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogFilesDataSource> array = new List<LogFilesDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogFilesDataSource.DeserializeLogFilesDataSource(item));
                    }
                    logFiles = array;
                    continue;
                }
                if (property.NameEquals("iisLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IisLogsDataSource> array = new List<IisLogsDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IisLogsDataSource.DeserializeIisLogsDataSource(item));
                    }
                    iisLogs = array;
                    continue;
                }
                if (property.NameEquals("windowsFirewallLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsFirewallLogsDataSource> array = new List<WindowsFirewallLogsDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WindowsFirewallLogsDataSource.DeserializeWindowsFirewallLogsDataSource(item));
                    }
                    windowsFirewallLogs = array;
                    continue;
                }
                if (property.NameEquals("prometheusForwarder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrometheusForwarderDataSource> array = new List<PrometheusForwarderDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrometheusForwarderDataSource.DeserializePrometheusForwarderDataSource(item));
                    }
                    prometheusForwarder = array;
                    continue;
                }
                if (property.NameEquals("platformTelemetry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PlatformTelemetryDataSource> array = new List<PlatformTelemetryDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlatformTelemetryDataSource.DeserializePlatformTelemetryDataSource(item));
                    }
                    platformTelemetry = array;
                    continue;
                }
                if (property.NameEquals("dataImports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataImports = DataSourcesSpecDataImports.DeserializeDataSourcesSpecDataImports(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRuleDataSources(Optional.ToList(performanceCounters), Optional.ToList(windowsEventLogs), Optional.ToList(syslog), Optional.ToList(extensions), Optional.ToList(logFiles), Optional.ToList(iisLogs), Optional.ToList(windowsFirewallLogs), Optional.ToList(prometheusForwarder), Optional.ToList(platformTelemetry), dataImports.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleDataSources>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataCollectionRuleDataSources IPersistableModel<DataCollectionRuleDataSources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDataSources)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataCollectionRuleDataSources(document.RootElement, options);
        }

        string IPersistableModel<DataCollectionRuleDataSources>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
