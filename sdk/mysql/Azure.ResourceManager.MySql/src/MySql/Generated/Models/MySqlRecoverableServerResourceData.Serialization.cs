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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlRecoverableServerResourceData : IUtf8JsonSerializable, IJsonModel<MySqlRecoverableServerResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlRecoverableServerResourceData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MySqlRecoverableServerResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MySqlRecoverableServerResourceData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MySqlRecoverableServerResourceData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastAvailableBackupOn))
                {
                    writer.WritePropertyName("lastAvailableBackupDateTime"u8);
                    writer.WriteStringValue(LastAvailableBackupOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ServiceLevelObjective))
                {
                    writer.WritePropertyName("serviceLevelObjective"u8);
                    writer.WriteStringValue(ServiceLevelObjective);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Edition))
                {
                    writer.WritePropertyName("edition"u8);
                    writer.WriteStringValue(Edition);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VCores))
                {
                    writer.WritePropertyName("vCore"u8);
                    writer.WriteNumberValue(VCores.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(HardwareGeneration))
                {
                    writer.WritePropertyName("hardwareGeneration"u8);
                    writer.WriteStringValue(HardwareGeneration);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Version))
                {
                    writer.WritePropertyName("version"u8);
                    writer.WriteStringValue(Version);
                }
            }
            writer.WriteEndObject();
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

        MySqlRecoverableServerResourceData IJsonModel<MySqlRecoverableServerResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlRecoverableServerResourceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlRecoverableServerResourceData(document.RootElement, options);
        }

        internal static MySqlRecoverableServerResourceData DeserializeMySqlRecoverableServerResourceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> lastAvailableBackupDateTime = default;
            Optional<string> serviceLevelObjective = default;
            Optional<string> edition = default;
            Optional<int> vCore = default;
            Optional<string> hardwareGeneration = default;
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lastAvailableBackupDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastAvailableBackupDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceLevelObjective"u8))
                        {
                            serviceLevelObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("edition"u8))
                        {
                            edition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vCore = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("hardwareGeneration"u8))
                        {
                            hardwareGeneration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlRecoverableServerResourceData(id, name, type, systemData.Value, Optional.ToNullable(lastAvailableBackupDateTime), serviceLevelObjective.Value, edition.Value, Optional.ToNullable(vCore), hardwareGeneration.Value, version.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlRecoverableServerResourceData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlRecoverableServerResourceData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlRecoverableServerResourceData IPersistableModel<MySqlRecoverableServerResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlRecoverableServerResourceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlRecoverableServerResourceData(document.RootElement, options);
        }

        string IPersistableModel<MySqlRecoverableServerResourceData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
