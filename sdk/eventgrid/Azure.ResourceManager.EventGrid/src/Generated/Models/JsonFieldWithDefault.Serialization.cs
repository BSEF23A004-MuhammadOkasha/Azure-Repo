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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class JsonFieldWithDefault : IUtf8JsonSerializable, IJsonModel<JsonFieldWithDefault>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JsonFieldWithDefault>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<JsonFieldWithDefault>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonFieldWithDefault>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JsonFieldWithDefault)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceField))
            {
                writer.WritePropertyName("sourceField"u8);
                writer.WriteStringValue(SourceField);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
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

        JsonFieldWithDefault IJsonModel<JsonFieldWithDefault>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonFieldWithDefault>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JsonFieldWithDefault)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJsonFieldWithDefault(document.RootElement, options);
        }

        internal static JsonFieldWithDefault DeserializeJsonFieldWithDefault(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceField = default;
            string defaultValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceField"u8))
                {
                    sourceField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new JsonFieldWithDefault(sourceField, defaultValue, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceField), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceField: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceField))
                {
                    builder.Append("  sourceField: ");
                    if (SourceField.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceField}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceField}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultValue), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultValue: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultValue))
                {
                    builder.Append("  defaultValue: ");
                    if (DefaultValue.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DefaultValue}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DefaultValue}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<JsonFieldWithDefault>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonFieldWithDefault>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JsonFieldWithDefault)} does not support writing '{options.Format}' format.");
            }
        }

        JsonFieldWithDefault IPersistableModel<JsonFieldWithDefault>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JsonFieldWithDefault>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJsonFieldWithDefault(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JsonFieldWithDefault)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JsonFieldWithDefault>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
