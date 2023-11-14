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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerEditionCapability : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerEditionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerEditionCapability>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PostgreSqlFlexibleServerEditionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PostgreSqlFlexibleServerEditionCapability>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PostgreSqlFlexibleServerEditionCapability>)} interface");
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
                if (Optional.IsDefined(DefaultSkuName))
                {
                    writer.WritePropertyName("defaultSkuName"u8);
                    writer.WriteStringValue(DefaultSkuName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(SupportedStorageEditions))
                {
                    writer.WritePropertyName("supportedStorageEditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedStorageEditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(SupportedServerSkus))
                {
                    writer.WritePropertyName("supportedServerSkus"u8);
                    writer.WriteStartArray();
                    foreach (var item in SupportedServerSkus)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CapabilityStatus))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(CapabilityStatus.Value.ToSerialString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Reason))
                {
                    writer.WritePropertyName("reason"u8);
                    writer.WriteStringValue(Reason);
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

        PostgreSqlFlexibleServerEditionCapability IJsonModel<PostgreSqlFlexibleServerEditionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerEditionCapability)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerEditionCapability(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerEditionCapability DeserializePostgreSqlFlexibleServerEditionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> defaultSkuName = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerSkuCapability>> supportedServerSkus = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultSkuName"u8))
                {
                    defaultSkuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageEditionCapability> array = new List<PostgreSqlFlexibleServerStorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageEditionCapability.DeserializePostgreSqlFlexibleServerStorageEditionCapability(item));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerSkuCapability> array = new List<PostgreSqlFlexibleServerSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerSkuCapability.DeserializePostgreSqlFlexibleServerSkuCapability(item));
                    }
                    supportedServerSkus = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerEditionCapability(Optional.ToNullable(status), reason.Value, serializedAdditionalRawData, name.Value, defaultSkuName.Value, Optional.ToList(supportedStorageEditions), Optional.ToList(supportedServerSkus));
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerEditionCapability>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerEditionCapability)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PostgreSqlFlexibleServerEditionCapability IPersistableModel<PostgreSqlFlexibleServerEditionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerEditionCapability)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerEditionCapability(document.RootElement, options);
        }

        string IPersistableModel<PostgreSqlFlexibleServerEditionCapability>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
