// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CsmPublishingProfile : IUtf8JsonSerializable, IJsonModel<CsmPublishingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CsmPublishingProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CsmPublishingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsmPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsmPublishingProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Optional.IsDefined(IsIncludeDisasterRecoveryEndpoints))
            {
                writer.WritePropertyName("includeDisasterRecoveryEndpoints"u8);
                writer.WriteBooleanValue(IsIncludeDisasterRecoveryEndpoints.Value);
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

        CsmPublishingProfile IJsonModel<CsmPublishingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsmPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsmPublishingProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCsmPublishingProfile(document.RootElement, options);
        }

        internal static CsmPublishingProfile DeserializeCsmPublishingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PublishingProfileFormat? format = default;
            bool? includeDisasterRecoveryEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    format = new PublishingProfileFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includeDisasterRecoveryEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeDisasterRecoveryEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CsmPublishingProfile(format, includeDisasterRecoveryEndpoints, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CsmPublishingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsmPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CsmPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        CsmPublishingProfile IPersistableModel<CsmPublishingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsmPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCsmPublishingProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CsmPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CsmPublishingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
