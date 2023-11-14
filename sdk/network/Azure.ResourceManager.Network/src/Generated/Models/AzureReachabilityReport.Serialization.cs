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

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReport : IUtf8JsonSerializable, IJsonModel<AzureReachabilityReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureReachabilityReport>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureReachabilityReport>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureReachabilityReport>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureReachabilityReport>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("aggregationLevel"u8);
            writer.WriteStringValue(AggregationLevel);
            writer.WritePropertyName("providerLocation"u8);
            writer.WriteObjectValue(ProviderLocation);
            writer.WritePropertyName("reachabilityReport"u8);
            writer.WriteStartArray();
            foreach (var item in ReachabilityReport)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        AzureReachabilityReport IJsonModel<AzureReachabilityReport>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureReachabilityReport(document.RootElement, options);
        }

        internal static AzureReachabilityReport DeserializeAzureReachabilityReport(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aggregationLevel = default;
            AzureReachabilityReportLocation providerLocation = default;
            IReadOnlyList<AzureReachabilityReportItem> reachabilityReport = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregationLevel"u8))
                {
                    aggregationLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerLocation"u8))
                {
                    providerLocation = AzureReachabilityReportLocation.DeserializeAzureReachabilityReportLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("reachabilityReport"u8))
                {
                    List<AzureReachabilityReportItem> array = new List<AzureReachabilityReportItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureReachabilityReportItem.DeserializeAzureReachabilityReportItem(item));
                    }
                    reachabilityReport = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureReachabilityReport(aggregationLevel, providerLocation, reachabilityReport, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureReachabilityReport>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureReachabilityReport IPersistableModel<AzureReachabilityReport>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureReachabilityReport)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureReachabilityReport(document.RootElement, options);
        }

        string IPersistableModel<AzureReachabilityReport>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
