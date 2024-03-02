// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeDataFlowProperties : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeDataFlowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeDataFlowProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeDataFlowProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeDataFlowProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ComputeType.HasValue)
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType.Value.ToString());
            }
            if (CoreCount.HasValue)
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (TimeToLiveInMinutes.HasValue)
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLiveInMinutes.Value);
            }
            if (ShouldCleanupAfterTtl.HasValue)
            {
                writer.WritePropertyName("cleanup"u8);
                writer.WriteBooleanValue(ShouldCleanupAfterTtl.Value);
            }
            if (!(CustomProperties is ChangeTrackingList<IntegrationRuntimeDataFlowCustomItem> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customProperties"u8);
                writer.WriteStartArray();
                foreach (var item in CustomProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        IntegrationRuntimeDataFlowProperties IJsonModel<IntegrationRuntimeDataFlowProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeDataFlowProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeDataFlowProperties(document.RootElement, options);
        }

        internal static IntegrationRuntimeDataFlowProperties DeserializeIntegrationRuntimeDataFlowProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFlowComputeType? computeType = default;
            int? coreCount = default;
            int? timeToLive = default;
            bool? cleanup = default;
            IList<IntegrationRuntimeDataFlowCustomItem> customProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeType = new DataFlowComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cleanup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cleanup = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationRuntimeDataFlowCustomItem> array = new List<IntegrationRuntimeDataFlowCustomItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationRuntimeDataFlowCustomItem.DeserializeIntegrationRuntimeDataFlowCustomItem(item, options));
                    }
                    customProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeDataFlowProperties(
                computeType,
                coreCount,
                timeToLive,
                cleanup,
                customProperties ?? new ChangeTrackingList<IntegrationRuntimeDataFlowCustomItem>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<IntegrationRuntimeDataFlowProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeDataFlowProperties)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeDataFlowProperties IPersistableModel<IntegrationRuntimeDataFlowProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeDataFlowProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeDataFlowProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeDataFlowProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeDataFlowProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
