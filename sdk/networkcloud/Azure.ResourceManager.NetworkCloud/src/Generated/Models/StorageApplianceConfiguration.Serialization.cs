// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class StorageApplianceConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<StorageApplianceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageApplianceConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageApplianceConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageApplianceConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("adminCredentials"u8);
            if (AdminCredentials is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AdministrativeCredentials>)AdminCredentials).Serialize(writer, options);
            }
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            if (Optional.IsDefined(StorageApplianceName))
            {
                writer.WritePropertyName("storageApplianceName"u8);
                writer.WriteStringValue(StorageApplianceName);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static StorageApplianceConfiguration DeserializeStorageApplianceConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdministrativeCredentials adminCredentials = default;
            long rackSlot = default;
            string serialNumber = default;
            Optional<string> storageApplianceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminCredentials"u8))
                {
                    adminCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("rackSlot"u8))
                {
                    rackSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageApplianceName"u8))
                {
                    storageApplianceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageApplianceConfiguration(adminCredentials, rackSlot, serialNumber, storageApplianceName.Value, rawData);
        }

        StorageApplianceConfiguration IModelJsonSerializable<StorageApplianceConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageApplianceConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageApplianceConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageApplianceConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageApplianceConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageApplianceConfiguration IModelSerializable<StorageApplianceConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageApplianceConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageApplianceConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageApplianceConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageApplianceConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(StorageApplianceConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageApplianceConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageApplianceConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageApplianceConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
