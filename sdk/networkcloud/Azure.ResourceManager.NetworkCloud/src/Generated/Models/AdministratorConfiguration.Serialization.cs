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
    public partial class AdministratorConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<AdministratorConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AdministratorConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AdministratorConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdministratorConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Optional.IsCollectionDefined(SshPublicKeys))
            {
                writer.WritePropertyName("sshPublicKeys"u8);
                writer.WriteStartArray();
                foreach (var item in SshPublicKeys)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkCloudSshPublicKey>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static AdministratorConfiguration DeserializeAdministratorConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> adminUsername = default;
            Optional<IList<NetworkCloudSshPublicKey>> sshPublicKeys = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPublicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkCloudSshPublicKey> array = new List<NetworkCloudSshPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkCloudSshPublicKey.DeserializeNetworkCloudSshPublicKey(item));
                    }
                    sshPublicKeys = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AdministratorConfiguration(adminUsername.Value, Optional.ToList(sshPublicKeys), rawData);
        }

        AdministratorConfiguration IModelJsonSerializable<AdministratorConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdministratorConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAdministratorConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AdministratorConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdministratorConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AdministratorConfiguration IModelSerializable<AdministratorConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AdministratorConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAdministratorConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AdministratorConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AdministratorConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(AdministratorConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AdministratorConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AdministratorConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAdministratorConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
