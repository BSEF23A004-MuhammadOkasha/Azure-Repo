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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAzureDataLakeGen2Datastore : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningAzureDataLakeGen2Datastore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningAzureDataLakeGen2Datastore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningAzureDataLakeGen2Datastore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen2Datastore>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            if (Optional.IsDefined(Endpoint))
            {
                if (Endpoint != null)
                {
                    writer.WritePropertyName("endpoint"u8);
                    writer.WriteStringValue(Endpoint);
                }
                else
                {
                    writer.WriteNull("endpoint");
                }
            }
            writer.WritePropertyName("filesystem"u8);
            writer.WriteStringValue(Filesystem);
            if (Optional.IsDefined(Protocol))
            {
                if (Protocol != null)
                {
                    writer.WritePropertyName("protocol"u8);
                    writer.WriteStringValue(Protocol);
                }
                else
                {
                    writer.WriteNull("protocol");
                }
            }
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity"u8);
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            writer.WritePropertyName("credentials"u8);
            if (Credentials is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MachineLearningDatastoreCredentials>)Credentials).Serialize(writer, options);
            }
            writer.WritePropertyName("datastoreType"u8);
            writer.WriteStringValue(DatastoreType.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
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

        internal static MachineLearningAzureDataLakeGen2Datastore DeserializeMachineLearningAzureDataLakeGen2Datastore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            Optional<string> endpoint = default;
            string filesystem = default;
            Optional<string> protocol = default;
            Optional<MachineLearningServiceDataAccessAuthIdentity> serviceDataAccessAuthIdentity = default;
            MachineLearningDatastoreCredentials credentials = default;
            DatastoreType datastoreType = default;
            Optional<bool> isDefault = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filesystem"u8))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        protocol = null;
                        continue;
                    }
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceDataAccessAuthIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new MachineLearningServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = MachineLearningDatastoreCredentials.DeserializeMachineLearningDatastoreCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("datastoreType"u8))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningAzureDataLakeGen2Datastore(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), credentials, datastoreType, Optional.ToNullable(isDefault), accountName, endpoint.Value, filesystem, protocol.Value, Optional.ToNullable(serviceDataAccessAuthIdentity), serializedAdditionalRawData);
        }

        MachineLearningAzureDataLakeGen2Datastore IModelJsonSerializable<MachineLearningAzureDataLakeGen2Datastore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen2Datastore>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAzureDataLakeGen2Datastore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningAzureDataLakeGen2Datastore>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen2Datastore>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningAzureDataLakeGen2Datastore IModelSerializable<MachineLearningAzureDataLakeGen2Datastore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAzureDataLakeGen2Datastore>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningAzureDataLakeGen2Datastore(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningAzureDataLakeGen2Datastore"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningAzureDataLakeGen2Datastore"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningAzureDataLakeGen2Datastore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningAzureDataLakeGen2Datastore"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningAzureDataLakeGen2Datastore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningAzureDataLakeGen2Datastore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
