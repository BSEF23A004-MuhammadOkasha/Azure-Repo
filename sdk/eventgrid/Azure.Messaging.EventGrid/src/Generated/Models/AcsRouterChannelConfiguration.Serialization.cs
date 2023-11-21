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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterChannelConfiguration : IUtf8JsonSerializable, IJsonModel<AcsRouterChannelConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterChannelConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsRouterChannelConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterChannelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterChannelConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
            }
            if (Optional.IsDefined(CapacityCostPerJob))
            {
                writer.WritePropertyName("capacityCostPerJob"u8);
                writer.WriteNumberValue(CapacityCostPerJob.Value);
            }
            if (Optional.IsDefined(MaxNumberOfJobs))
            {
                writer.WritePropertyName("maxNumberOfJobs"u8);
                writer.WriteNumberValue(MaxNumberOfJobs.Value);
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

        AcsRouterChannelConfiguration IJsonModel<AcsRouterChannelConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterChannelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterChannelConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterChannelConfiguration(document.RootElement, options);
        }

        internal static AcsRouterChannelConfiguration DeserializeAcsRouterChannelConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> channelId = default;
            Optional<int> capacityCostPerJob = default;
            Optional<int> maxNumberOfJobs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCostPerJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityCostPerJob = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNumberOfJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNumberOfJobs = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AcsRouterChannelConfiguration(channelId.Value, Optional.ToNullable(capacityCostPerJob), Optional.ToNullable(maxNumberOfJobs), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcsRouterChannelConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterChannelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterChannelConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AcsRouterChannelConfiguration IPersistableModel<AcsRouterChannelConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterChannelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsRouterChannelConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterChannelConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterChannelConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
