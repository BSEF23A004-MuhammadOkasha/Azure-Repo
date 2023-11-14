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
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServersCapabilityData : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServersCapabilityData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServersCapabilityData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MySqlFlexibleServersCapabilityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MySqlFlexibleServersCapabilityData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MySqlFlexibleServersCapabilityData>)} interface");
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
                if (Optional.IsCollectionDefined(SupportedGeoBackupRegions))
                {
                    writer.WritePropertyName("supportedGeoBackupRegions"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedGeoBackupRegions)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(SupportedFlexibleServerEditions))
                {
                    writer.WritePropertyName("supportedFlexibleServerEditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedFlexibleServerEditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(SupportedServerVersions))
                {
                    writer.WritePropertyName("supportedServerVersions"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedServerVersions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
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

        MySqlFlexibleServersCapabilityData IJsonModel<MySqlFlexibleServersCapabilityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServersCapabilityData(document.RootElement, options);
        }

        internal static MySqlFlexibleServersCapabilityData DeserializeMySqlFlexibleServersCapabilityData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<IReadOnlyList<string>> supportedGeoBackupRegions = default;
            Optional<IReadOnlyList<ServerEditionCapabilityV2>> supportedFlexibleServerEditions = default;
            Optional<IReadOnlyList<ServerVersionCapabilityV2>> supportedServerVersions = default;
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
                        if (property0.NameEquals("supportedGeoBackupRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedGeoBackupRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedFlexibleServerEditions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServerEditionCapabilityV2> array = new List<ServerEditionCapabilityV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerEditionCapabilityV2.DeserializeServerEditionCapabilityV2(item));
                            }
                            supportedFlexibleServerEditions = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedServerVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServerVersionCapabilityV2> array = new List<ServerVersionCapabilityV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerVersionCapabilityV2.DeserializeServerVersionCapabilityV2(item));
                            }
                            supportedServerVersions = array;
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
            return new MySqlFlexibleServersCapabilityData(id, name, type, systemData.Value, Optional.ToList(supportedGeoBackupRegions), Optional.ToList(supportedFlexibleServerEditions), Optional.ToList(supportedServerVersions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServersCapabilityData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlFlexibleServersCapabilityData IPersistableModel<MySqlFlexibleServersCapabilityData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServersCapabilityData(document.RootElement, options);
        }

        string IPersistableModel<MySqlFlexibleServersCapabilityData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
