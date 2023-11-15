// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableRequestTargetDistributionOptionsConverter))]
    public partial class LinkTableRequestTargetDistributionOptions : IUtf8JsonSerializable, IJsonModel<LinkTableRequestTargetDistributionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkTableRequestTargetDistributionOptions>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LinkTableRequestTargetDistributionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LinkTableRequestTargetDistributionOptions>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LinkTableRequestTargetDistributionOptions>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(DistributionColumn))
            {
                writer.WritePropertyName("distributionColumn"u8);
                writer.WriteStringValue(DistributionColumn);
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

        LinkTableRequestTargetDistributionOptions IJsonModel<LinkTableRequestTargetDistributionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestTargetDistributionOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkTableRequestTargetDistributionOptions(document.RootElement, options);
        }

        internal static LinkTableRequestTargetDistributionOptions DeserializeLinkTableRequestTargetDistributionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<string> distributionColumn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributionColumn"u8))
                {
                    distributionColumn = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkTableRequestTargetDistributionOptions(type.Value, distributionColumn.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkTableRequestTargetDistributionOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestTargetDistributionOptions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinkTableRequestTargetDistributionOptions IPersistableModel<LinkTableRequestTargetDistributionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableRequestTargetDistributionOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinkTableRequestTargetDistributionOptions(document.RootElement, options);
        }

        string IPersistableModel<LinkTableRequestTargetDistributionOptions>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class LinkTableRequestTargetDistributionOptionsConverter : JsonConverter<LinkTableRequestTargetDistributionOptions>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableRequestTargetDistributionOptions model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableRequestTargetDistributionOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableRequestTargetDistributionOptions(document.RootElement);
            }
        }
    }
}
