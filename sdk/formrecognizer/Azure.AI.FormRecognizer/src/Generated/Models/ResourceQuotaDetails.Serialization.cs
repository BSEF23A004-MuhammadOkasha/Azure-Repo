// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class ResourceQuotaDetails : IUtf8JsonSerializable, IJsonModel<ResourceQuotaDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceQuotaDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceQuotaDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ResourceQuotaDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("used"u8);
            writer.WriteNumberValue(Used);
            writer.WritePropertyName("quota"u8);
            writer.WriteNumberValue(Quota);
            writer.WritePropertyName("quotaResetDateTime"u8);
            writer.WriteStringValue(QuotaResetsOn, "O");
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

        ResourceQuotaDetails IJsonModel<ResourceQuotaDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ResourceQuotaDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceQuotaDetails(document.RootElement, options);
        }

        internal static ResourceQuotaDetails DeserializeResourceQuotaDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int used = default;
            int quota = default;
            DateTimeOffset quotaResetDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("used"u8))
                {
                    used = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    quota = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quotaResetDateTime"u8))
                {
                    quotaResetDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceQuotaDetails(used, quota, quotaResetDateTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceQuotaDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ResourceQuotaDetails)} does not support '{options.Format}' format.");
            }
        }

        ResourceQuotaDetails IPersistableModel<ResourceQuotaDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQuotaDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceQuotaDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ResourceQuotaDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceQuotaDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
