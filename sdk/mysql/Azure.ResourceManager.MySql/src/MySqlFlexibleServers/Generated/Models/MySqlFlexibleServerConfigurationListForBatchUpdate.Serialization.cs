// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerConfigurationListForBatchUpdate : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerConfigurationListForBatchUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerConfigurationListForBatchUpdate>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MySqlFlexibleServerConfigurationListForBatchUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResetAllToDefault))
            {
                writer.WritePropertyName("resetAllToDefault"u8);
                writer.WriteStringValue(ResetAllToDefault.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MySqlFlexibleServerConfigurationListForBatchUpdate IJsonModel<MySqlFlexibleServerConfigurationListForBatchUpdate>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationListForBatchUpdate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerConfigurationListForBatchUpdate(document.RootElement, options);
        }

        internal static MySqlFlexibleServerConfigurationListForBatchUpdate DeserializeMySqlFlexibleServerConfigurationListForBatchUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MySqlFlexibleServerConfigurationForBatchUpdate>> value = default;
            Optional<MySqlFlexibleServerConfigurationResetAllToDefault> resetAllToDefault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerConfigurationForBatchUpdate> array = new List<MySqlFlexibleServerConfigurationForBatchUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerConfigurationForBatchUpdate.DeserializeMySqlFlexibleServerConfigurationForBatchUpdate(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("resetAllToDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resetAllToDefault = new MySqlFlexibleServerConfigurationResetAllToDefault(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerConfigurationListForBatchUpdate(Optional.ToList(value), Optional.ToNullable(resetAllToDefault), serializedAdditionalRawData);
        }

        BinaryData IModel<MySqlFlexibleServerConfigurationListForBatchUpdate>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationListForBatchUpdate)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlFlexibleServerConfigurationListForBatchUpdate IModel<MySqlFlexibleServerConfigurationListForBatchUpdate>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationListForBatchUpdate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServerConfigurationListForBatchUpdate(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MySqlFlexibleServerConfigurationListForBatchUpdate>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
