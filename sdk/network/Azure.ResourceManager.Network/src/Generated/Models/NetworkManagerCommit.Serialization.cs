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

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerCommit : IUtf8JsonSerializable, IModelJsonSerializable<NetworkManagerCommit>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkManagerCommit>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkManagerCommit>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkManagerCommit>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetLocations"u8);
            writer.WriteStartArray();
            foreach (var item in TargetLocations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ConfigurationIds))
            {
                writer.WritePropertyName("configurationIds"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("commitType"u8);
            writer.WriteStringValue(CommitType.ToString());
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

        internal static NetworkManagerCommit DeserializeNetworkManagerCommit(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> commitId = default;
            IList<string> targetLocations = default;
            Optional<IList<string>> configurationIds = default;
            NetworkConfigurationDeploymentType commitType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitId"u8))
                {
                    commitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocations"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    targetLocations = array;
                    continue;
                }
                if (property.NameEquals("configurationIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    configurationIds = array;
                    continue;
                }
                if (property.NameEquals("commitType"u8))
                {
                    commitType = new NetworkConfigurationDeploymentType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkManagerCommit(commitId.Value, targetLocations, Optional.ToList(configurationIds), commitType, rawData);
        }

        NetworkManagerCommit IModelJsonSerializable<NetworkManagerCommit>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkManagerCommit>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerCommit(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkManagerCommit>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkManagerCommit>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkManagerCommit IModelSerializable<NetworkManagerCommit>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkManagerCommit>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkManagerCommit(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkManagerCommit"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkManagerCommit"/> to convert. </param>
        public static implicit operator RequestContent(NetworkManagerCommit model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkManagerCommit"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkManagerCommit(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkManagerCommit(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
