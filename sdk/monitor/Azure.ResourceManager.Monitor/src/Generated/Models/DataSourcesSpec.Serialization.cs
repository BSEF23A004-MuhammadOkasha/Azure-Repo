// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataSourcesSpec : IUtf8JsonSerializable, IJsonModel<DataSourcesSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataSourcesSpec>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataSourcesSpec>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourcesSpec)} does not support '{format}' format.");
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
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DataSourcesSpec IJsonModel<DataSourcesSpec>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourcesSpec)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourcesSpec(document.RootElement, options);
        }

        internal static DataSourcesSpec DeserializeDataSourcesSpec(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

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
                        array.Add(PerfCounterDataSource.DeserializePerfCounterDataSource(item, options));
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
                        array.Add(WindowsEventLogDataSource.DeserializeWindowsEventLogDataSource(item, options));
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
                        array.Add(SyslogDataSource.DeserializeSyslogDataSource(item, options));
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
                        array.Add(ExtensionDataSource.DeserializeExtensionDataSource(item, options));
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
                        array.Add(LogFilesDataSource.DeserializeLogFilesDataSource(item, options));
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
                        array.Add(IisLogsDataSource.DeserializeIisLogsDataSource(item, options));
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
                        array.Add(WindowsFirewallLogsDataSource.DeserializeWindowsFirewallLogsDataSource(item, options));
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
                        array.Add(PrometheusForwarderDataSource.DeserializePrometheusForwarderDataSource(item, options));
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
                        array.Add(PlatformTelemetryDataSource.DeserializePlatformTelemetryDataSource(item, options));
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
                    dataImports = DataSourcesSpecDataImports.DeserializeDataSourcesSpecDataImports(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataSourcesSpec(Optional.ToList(performanceCounters), Optional.ToList(windowsEventLogs), Optional.ToList(syslog), Optional.ToList(extensions), Optional.ToList(logFiles), Optional.ToList(iisLogs), Optional.ToList(windowsFirewallLogs), Optional.ToList(prometheusForwarder), Optional.ToList(platformTelemetry), dataImports.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataSourcesSpec>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataSourcesSpec)} does not support '{options.Format}' format.");
            }
        }

        DataSourcesSpec IPersistableModel<DataSourcesSpec>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataSourcesSpec(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataSourcesSpec)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataSourcesSpec>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
