// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningUriFileDataVersion : IUtf8JsonSerializable, IJsonModel<MachineLearningUriFileDataVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningUriFileDataVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningUriFileDataVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUriFileDataVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUriFileDataVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType.ToString());
            writer.WritePropertyName("dataUri"u8);
            writer.WriteStringValue(DataUri.AbsoluteUri);
            if (IntellectualProperty != null)
            {
                if (IntellectualProperty != null)
                {
                    writer.WritePropertyName("intellectualProperty"u8);
                    writer.WriteObjectValue(IntellectualProperty);
                }
                else
                {
                    writer.WriteNull("intellectualProperty");
                }
            }
            if (Stage != null)
            {
                if (Stage != null)
                {
                    writer.WritePropertyName("stage"u8);
                    writer.WriteStringValue(Stage);
                }
                else
                {
                    writer.WriteNull("stage");
                }
            }
            if (AutoDeleteSetting != null)
            {
                if (AutoDeleteSetting != null)
                {
                    writer.WritePropertyName("autoDeleteSetting"u8);
                    writer.WriteObjectValue(AutoDeleteSetting);
                }
                else
                {
                    writer.WriteNull("autoDeleteSetting");
                }
            }
            if (IsAnonymous.HasValue)
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (IsArchived.HasValue)
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
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

        MachineLearningUriFileDataVersion IJsonModel<MachineLearningUriFileDataVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUriFileDataVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUriFileDataVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningUriFileDataVersion(document.RootElement, options);
        }

        internal static MachineLearningUriFileDataVersion DeserializeMachineLearningUriFileDataVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningDataType dataType = default;
            Uri dataUri = default;
            Optional<IntellectualProperty> intellectualProperty = default;
            Optional<string> stage = default;
            Optional<AutoDeleteSetting> autoDeleteSetting = default;
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataType"u8))
                {
                    dataType = new MachineLearningDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataUri"u8))
                {
                    dataUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("intellectualProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        intellectualProperty = null;
                        continue;
                    }
                    intellectualProperty = IntellectualProperty.DeserializeIntellectualProperty(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stage = null;
                        continue;
                    }
                    stage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDeleteSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoDeleteSetting = null;
                        continue;
                    }
                    autoDeleteSetting = AutoDeleteSetting.DeserializeAutoDeleteSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningUriFileDataVersion(description.Value, properties ?? new ChangeTrackingDictionary<string, string>(), tags ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData, autoDeleteSetting.Value, Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), dataType, dataUri, intellectualProperty.Value, stage.Value);
        }

        BinaryData IPersistableModel<MachineLearningUriFileDataVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUriFileDataVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUriFileDataVersion)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningUriFileDataVersion IPersistableModel<MachineLearningUriFileDataVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUriFileDataVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningUriFileDataVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUriFileDataVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningUriFileDataVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
