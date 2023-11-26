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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class MagnitudeScoringParameters : IUtf8JsonSerializable, IJsonModel<MagnitudeScoringParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MagnitudeScoringParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MagnitudeScoringParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MagnitudeScoringParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MagnitudeScoringParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("boostingRangeStart"u8);
            writer.WriteNumberValue(BoostingRangeStart);
            writer.WritePropertyName("boostingRangeEnd"u8);
            writer.WriteNumberValue(BoostingRangeEnd);
            if (Optional.IsDefined(ShouldBoostBeyondRangeByConstant))
            {
                writer.WritePropertyName("constantBoostBeyondRange"u8);
                writer.WriteBooleanValue(ShouldBoostBeyondRangeByConstant.Value);
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

        MagnitudeScoringParameters IJsonModel<MagnitudeScoringParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MagnitudeScoringParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MagnitudeScoringParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMagnitudeScoringParameters(document.RootElement, options);
        }

        internal static MagnitudeScoringParameters DeserializeMagnitudeScoringParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double boostingRangeStart = default;
            double boostingRangeEnd = default;
            Optional<bool> constantBoostBeyondRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostingRangeStart"u8))
                {
                    boostingRangeStart = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("boostingRangeEnd"u8))
                {
                    boostingRangeEnd = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("constantBoostBeyondRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constantBoostBeyondRange = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MagnitudeScoringParameters(boostingRangeStart, boostingRangeEnd, Optional.ToNullable(constantBoostBeyondRange), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MagnitudeScoringParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MagnitudeScoringParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MagnitudeScoringParameters)} does not support '{options.Format}' format.");
            }
        }

        MagnitudeScoringParameters IPersistableModel<MagnitudeScoringParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MagnitudeScoringParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMagnitudeScoringParameters(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MagnitudeScoringParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MagnitudeScoringParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
