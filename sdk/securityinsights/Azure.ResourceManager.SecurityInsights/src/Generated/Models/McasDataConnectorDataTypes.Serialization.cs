// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class McasDataConnectorDataTypes : IUtf8JsonSerializable, IJsonModel<McasDataConnectorDataTypes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<McasDataConnectorDataTypes>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<McasDataConnectorDataTypes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(DiscoveryLogs))
            {
                writer.WritePropertyName("discoveryLogs"u8);
                writer.WriteObjectValue(DiscoveryLogs, options);
            }
        }

        McasDataConnectorDataTypes IJsonModel<McasDataConnectorDataTypes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
        }

        internal static McasDataConnectorDataTypes DeserializeMcasDataConnectorDataTypes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataConnectorDataTypeCommon discoveryLogs = default;
            DataConnectorDataTypeCommon alerts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("discoveryLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveryLogs = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("alerts"u8))
                {
                    alerts = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new McasDataConnectorDataTypes(alerts, serializedAdditionalRawData, discoveryLogs);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DiscoveryLogsState", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  discoveryLogs: ");
                builder.AppendLine("{");
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(DiscoveryLogs))
                {
                    builder.Append("  discoveryLogs: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DiscoveryLogs, options, 2, false, "  discoveryLogs: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AlertsState", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alerts: ");
                builder.AppendLine("{");
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Alerts))
                {
                    builder.Append("  alerts: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Alerts, options, 2, false, "  alerts: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<McasDataConnectorDataTypes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support writing '{options.Format}' format.");
            }
        }

        McasDataConnectorDataTypes IPersistableModel<McasDataConnectorDataTypes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<McasDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMcasDataConnectorDataTypes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(McasDataConnectorDataTypes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<McasDataConnectorDataTypes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
