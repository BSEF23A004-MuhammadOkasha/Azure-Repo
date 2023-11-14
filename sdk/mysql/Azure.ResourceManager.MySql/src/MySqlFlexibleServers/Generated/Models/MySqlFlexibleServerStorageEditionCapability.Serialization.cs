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
    public partial class MySqlFlexibleServerStorageEditionCapability : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerStorageEditionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerStorageEditionCapability>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MySqlFlexibleServerStorageEditionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MySqlFlexibleServerStorageEditionCapability>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MySqlFlexibleServerStorageEditionCapability>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MinStorageSize))
                {
                    writer.WritePropertyName("minStorageSize"u8);
                    writer.WriteNumberValue(MinStorageSize.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MaxStorageSize))
                {
                    writer.WritePropertyName("maxStorageSize"u8);
                    writer.WriteNumberValue(MaxStorageSize.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MinBackupRetentionDays))
                {
                    writer.WritePropertyName("minBackupRetentionDays"u8);
                    writer.WriteNumberValue(MinBackupRetentionDays.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MaxBackupRetentionDays))
                {
                    writer.WritePropertyName("maxBackupRetentionDays"u8);
                    writer.WriteNumberValue(MaxBackupRetentionDays.Value);
                }
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

        MySqlFlexibleServerStorageEditionCapability IJsonModel<MySqlFlexibleServerStorageEditionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerStorageEditionCapability)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerStorageEditionCapability(document.RootElement, options);
        }

        internal static MySqlFlexibleServerStorageEditionCapability DeserializeMySqlFlexibleServerStorageEditionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<long> minStorageSize = default;
            Optional<long> maxStorageSize = default;
            Optional<long> minBackupRetentionDays = default;
            Optional<long> maxBackupRetentionDays = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minStorageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxStorageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerStorageEditionCapability(name.Value, Optional.ToNullable(minStorageSize), Optional.ToNullable(maxStorageSize), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxBackupRetentionDays), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerStorageEditionCapability>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerStorageEditionCapability)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlFlexibleServerStorageEditionCapability IPersistableModel<MySqlFlexibleServerStorageEditionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerStorageEditionCapability)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServerStorageEditionCapability(document.RootElement, options);
        }

        string IPersistableModel<MySqlFlexibleServerStorageEditionCapability>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
