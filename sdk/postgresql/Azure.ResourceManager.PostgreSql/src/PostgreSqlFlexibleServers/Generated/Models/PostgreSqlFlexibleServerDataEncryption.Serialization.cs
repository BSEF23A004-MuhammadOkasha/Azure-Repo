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
    public partial class PostgreSqlFlexibleServerDataEncryption : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerDataEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerDataEncryption>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PostgreSqlFlexibleServerDataEncryption>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKeyUri))
            {
                writer.WritePropertyName("primaryKeyURI"u8);
                writer.WriteStringValue(PrimaryKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(GeoBackupKeyUri))
            {
                writer.WritePropertyName("geoBackupKeyURI"u8);
                writer.WriteStringValue(GeoBackupKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(GeoBackupUserAssignedIdentityId))
            {
                writer.WritePropertyName("geoBackupUserAssignedIdentityId"u8);
                writer.WriteStringValue(GeoBackupUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryEncryptionKeyStatus))
            {
                writer.WritePropertyName("primaryEncryptionKeyStatus"u8);
                writer.WriteStringValue(PrimaryEncryptionKeyStatus.Value.ToString());
            }
            if (Optional.IsDefined(GeoBackupEncryptionKeyStatus))
            {
                writer.WritePropertyName("geoBackupEncryptionKeyStatus"u8);
                writer.WriteStringValue(GeoBackupEncryptionKeyStatus.Value.ToString());
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

        PostgreSqlFlexibleServerDataEncryption IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerDataEncryption DeserializePostgreSqlFlexibleServerDataEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> primaryKeyUri = default;
            Optional<ResourceIdentifier> primaryUserAssignedIdentityId = default;
            Optional<Uri> geoBackupKeyUri = default;
            Optional<string> geoBackupUserAssignedIdentityId = default;
            Optional<PostgreSqlFlexibleServerKeyType> type = default;
            Optional<PostgreSqlKeyStatus> primaryEncryptionKeyStatus = default;
            Optional<PostgreSqlKeyStatus> geoBackupEncryptionKeyStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupUserAssignedIdentityId"u8))
                {
                    geoBackupUserAssignedIdentityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new PostgreSqlFlexibleServerKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerDataEncryption(primaryKeyUri.Value, primaryUserAssignedIdentityId.Value, geoBackupKeyUri.Value, geoBackupUserAssignedIdentityId.Value, Optional.ToNullable(type), Optional.ToNullable(primaryEncryptionKeyStatus), Optional.ToNullable(geoBackupEncryptionKeyStatus), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PostgreSqlFlexibleServerDataEncryption IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
        }

        string IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
