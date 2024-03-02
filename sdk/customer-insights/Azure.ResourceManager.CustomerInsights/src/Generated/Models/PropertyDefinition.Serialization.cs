// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PropertyDefinition : IUtf8JsonSerializable, IJsonModel<PropertyDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PropertyDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PropertyDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropertyDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ArrayValueSeparator != null)
            {
                writer.WritePropertyName("arrayValueSeparator"u8);
                writer.WriteStringValue(ArrayValueSeparator);
            }
            if (!(EnumValidValues is ChangeTrackingList<ProfileEnumValidValuesFormat> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("enumValidValues"u8);
                writer.WriteStartArray();
                foreach (var item in EnumValidValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("fieldName"u8);
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("fieldType"u8);
            writer.WriteStringValue(FieldType);
            if (IsArray.HasValue)
            {
                writer.WritePropertyName("isArray"u8);
                writer.WriteBooleanValue(IsArray.Value);
            }
            if (IsEnum.HasValue)
            {
                writer.WritePropertyName("isEnum"u8);
                writer.WriteBooleanValue(IsEnum.Value);
            }
            if (IsFlagEnum.HasValue)
            {
                writer.WritePropertyName("isFlagEnum"u8);
                writer.WriteBooleanValue(IsFlagEnum.Value);
            }
            if (IsImage.HasValue)
            {
                writer.WritePropertyName("isImage"u8);
                writer.WriteBooleanValue(IsImage.Value);
            }
            if (IsLocalizedString.HasValue)
            {
                writer.WritePropertyName("isLocalizedString"u8);
                writer.WriteBooleanValue(IsLocalizedString.Value);
            }
            if (IsName.HasValue)
            {
                writer.WritePropertyName("isName"u8);
                writer.WriteBooleanValue(IsName.Value);
            }
            if (IsRequired.HasValue)
            {
                writer.WritePropertyName("isRequired"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (PropertyId != null)
            {
                writer.WritePropertyName("propertyId"u8);
                writer.WriteStringValue(PropertyId);
            }
            if (SchemaItemPropLink != null)
            {
                writer.WritePropertyName("schemaItemPropLink"u8);
                writer.WriteStringValue(SchemaItemPropLink);
            }
            if (MaxLength.HasValue)
            {
                writer.WritePropertyName("maxLength"u8);
                writer.WriteNumberValue(MaxLength.Value);
            }
            if (IsAvailableInGraph.HasValue)
            {
                writer.WritePropertyName("isAvailableInGraph"u8);
                writer.WriteBooleanValue(IsAvailableInGraph.Value);
            }
            if (options.Format != "W" && !(DataSourcePrecedenceRules is ChangeTrackingList<DataSourcePrecedence> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dataSourcePrecedenceRules"u8);
                writer.WriteStartArray();
                foreach (var item in DataSourcePrecedenceRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PropertyDefinition IJsonModel<PropertyDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropertyDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePropertyDefinition(document.RootElement, options);
        }

        internal static PropertyDefinition DeserializePropertyDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string arrayValueSeparator = default;
            IList<ProfileEnumValidValuesFormat> enumValidValues = default;
            string fieldName = default;
            string fieldType = default;
            bool? isArray = default;
            bool? isEnum = default;
            bool? isFlagEnum = default;
            bool? isImage = default;
            bool? isLocalizedString = default;
            bool? isName = default;
            bool? isRequired = default;
            string propertyId = default;
            string schemaItemPropLink = default;
            int? maxLength = default;
            bool? isAvailableInGraph = default;
            IReadOnlyList<DataSourcePrecedence> dataSourcePrecedenceRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arrayValueSeparator"u8))
                {
                    arrayValueSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enumValidValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProfileEnumValidValuesFormat> array = new List<ProfileEnumValidValuesFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProfileEnumValidValuesFormat.DeserializeProfileEnumValidValuesFormat(item, options));
                    }
                    enumValidValues = array;
                    continue;
                }
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldType"u8))
                {
                    fieldType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArray"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArray = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFlagEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFlagEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isImage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isLocalizedString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLocalizedString = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyId"u8))
                {
                    propertyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaItemPropLink"u8))
                {
                    schemaItemPropLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isAvailableInGraph"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAvailableInGraph = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataSourcePrecedenceRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataSourcePrecedence> array = new List<DataSourcePrecedence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSourcePrecedence.DeserializeDataSourcePrecedence(item, options));
                    }
                    dataSourcePrecedenceRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PropertyDefinition(
                arrayValueSeparator,
                enumValidValues ?? new ChangeTrackingList<ProfileEnumValidValuesFormat>(),
                fieldName,
                fieldType,
                isArray,
                isEnum,
                isFlagEnum,
                isImage,
                isLocalizedString,
                isName,
                isRequired,
                propertyId,
                schemaItemPropLink,
                maxLength,
                isAvailableInGraph,
                dataSourcePrecedenceRules ?? new ChangeTrackingList<DataSourcePrecedence>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PropertyDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PropertyDefinition)} does not support '{options.Format}' format.");
            }
        }

        PropertyDefinition IPersistableModel<PropertyDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePropertyDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PropertyDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PropertyDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
