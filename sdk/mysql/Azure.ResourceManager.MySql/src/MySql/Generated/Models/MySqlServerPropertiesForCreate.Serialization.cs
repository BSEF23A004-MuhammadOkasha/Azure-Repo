// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    [PersistableModelProxy(typeof(UnknownServerPropertiesForCreate))]
    public partial class MySqlServerPropertiesForCreate : IUtf8JsonSerializable, IJsonModel<MySqlServerPropertiesForCreate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlServerPropertiesForCreate>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MySqlServerPropertiesForCreate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MySqlServerPropertiesForCreate>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MySqlServerPropertiesForCreate>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(SslEnforcement))
            {
                writer.WritePropertyName("sslEnforcement"u8);
                writer.WriteStringValue(SslEnforcement.Value.ToSerialString());
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            writer.WritePropertyName("createMode"u8);
            writer.WriteStringValue(CreateMode.ToString());
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

        MySqlServerPropertiesForCreate IJsonModel<MySqlServerPropertiesForCreate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlServerPropertiesForCreate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlServerPropertiesForCreate(document.RootElement, options);
        }

        internal static MySqlServerPropertiesForCreate DeserializeMySqlServerPropertiesForCreate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("createMode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Default": return MySqlServerPropertiesForDefaultCreate.DeserializeMySqlServerPropertiesForDefaultCreate(element);
                    case "GeoRestore": return MySqlServerPropertiesForGeoRestore.DeserializeMySqlServerPropertiesForGeoRestore(element);
                    case "PointInTimeRestore": return MySqlServerPropertiesForRestore.DeserializeMySqlServerPropertiesForRestore(element);
                    case "Replica": return MySqlServerPropertiesForReplica.DeserializeMySqlServerPropertiesForReplica(element);
                }
            }
            return UnknownServerPropertiesForCreate.DeserializeUnknownServerPropertiesForCreate(element);
        }

        BinaryData IPersistableModel<MySqlServerPropertiesForCreate>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlServerPropertiesForCreate)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlServerPropertiesForCreate IPersistableModel<MySqlServerPropertiesForCreate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlServerPropertiesForCreate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlServerPropertiesForCreate(document.RootElement, options);
        }

        string IPersistableModel<MySqlServerPropertiesForCreate>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
