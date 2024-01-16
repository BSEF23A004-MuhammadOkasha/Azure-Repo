// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmPolicyParameter : IUtf8JsonSerializable, IJsonModel<ArmPolicyParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmPolicyParameter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmPolicyParameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmPolicyParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmPolicyParameter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ParameterType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ParameterType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedValues)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DefaultValue);
#else
                using (JsonDocument document = JsonDocument.Parse(DefaultValue))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
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

        ArmPolicyParameter IJsonModel<ArmPolicyParameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmPolicyParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmPolicyParameter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmPolicyParameter(document.RootElement, options);
        }

        internal static ArmPolicyParameter DeserializeArmPolicyParameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmPolicyParameterType> type = default;
            Optional<IList<BinaryData>> allowedValues = default;
            Optional<BinaryData> defaultValue = default;
            Optional<ParameterDefinitionsValueMetadata> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ArmPolicyParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    allowedValues = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ParameterDefinitionsValueMetadata.DeserializeParameterDefinitionsValueMetadata(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmPolicyParameter(Optional.ToNullable(type), Optional.ToList(allowedValues), defaultValue.Value, metadata.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmPolicyParameter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmPolicyParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmPolicyParameter)} does not support '{options.Format}' format.");
            }
        }

        ArmPolicyParameter IPersistableModel<ArmPolicyParameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmPolicyParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmPolicyParameter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmPolicyParameter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmPolicyParameter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
