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
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaServicesAccountPatch : IUtf8JsonSerializable, IModelJsonSerializable<MediaServicesAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaServicesAccountPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaServicesAccountPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaServicesAccountPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MediaServicesStorageAccount>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAuthentication))
            {
                if (StorageAuthentication != null)
                {
                    writer.WritePropertyName("storageAuthentication"u8);
                    writer.WriteStringValue(StorageAuthentication.Value.ToString());
                }
                else
                {
                    writer.WriteNull("storageAuthentication");
                }
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                if (Encryption is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AccountEncryption>)Encryption).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(KeyDelivery))
            {
                writer.WritePropertyName("keyDelivery"u8);
                if (KeyDelivery is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaKeyDelivery>)KeyDelivery).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                if (PublicNetworkAccess != null)
                {
                    writer.WritePropertyName("publicNetworkAccess"u8);
                    writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
                }
                else
                {
                    writer.WriteNull("publicNetworkAccess");
                }
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static MediaServicesAccountPatch DeserializeMediaServicesAccountPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<Guid> mediaServiceId = default;
            Optional<IList<MediaServicesStorageAccount>> storageAccounts = default;
            Optional<MediaStorageAuthentication?> storageAuthentication = default;
            Optional<AccountEncryption> encryption = default;
            Optional<MediaKeyDelivery> keyDelivery = default;
            Optional<MediaServicesPublicNetworkAccess?> publicNetworkAccess = default;
            Optional<MediaServicesProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<MediaServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<MediaServicesMinimumTlsVersion> minimumTlsVersion = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("mediaServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mediaServiceId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesStorageAccount> array = new List<MediaServicesStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesStorageAccount.DeserializeMediaServicesStorageAccount(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                storageAuthentication = null;
                                continue;
                            }
                            storageAuthentication = new MediaStorageAuthentication(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = AccountEncryption.DeserializeAccountEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyDelivery"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyDelivery = MediaKeyDelivery.DeserializeMediaKeyDelivery(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicNetworkAccess = null;
                                continue;
                            }
                            publicNetworkAccess = new MediaServicesPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MediaServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaServicesPrivateEndpointConnectionData> array = new List<MediaServicesPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaServicesPrivateEndpointConnectionData.DeserializeMediaServicesPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new MediaServicesMinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaServicesAccountPatch(Optional.ToDictionary(tags), identity, Optional.ToNullable(mediaServiceId), Optional.ToList(storageAccounts), Optional.ToNullable(storageAuthentication), encryption.Value, keyDelivery.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(provisioningState), Optional.ToList(privateEndpointConnections), Optional.ToNullable(minimumTlsVersion), serializedAdditionalRawData);
        }

        MediaServicesAccountPatch IModelJsonSerializable<MediaServicesAccountPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaServicesAccountPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaServicesAccountPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaServicesAccountPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaServicesAccountPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaServicesAccountPatch IModelSerializable<MediaServicesAccountPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaServicesAccountPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaServicesAccountPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaServicesAccountPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaServicesAccountPatch"/> to convert. </param>
        public static implicit operator RequestContent(MediaServicesAccountPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaServicesAccountPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaServicesAccountPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaServicesAccountPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
