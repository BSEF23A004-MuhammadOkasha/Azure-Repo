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
    public partial class NetworkCloudKubernetesClusterPatch : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudKubernetesClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudKubernetesClusterPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudKubernetesClusterPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudKubernetesClusterPatch>(this, options.Format);

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ControlPlaneNodeConfiguration))
            {
                writer.WritePropertyName("controlPlaneNodeConfiguration"u8);
                if (ControlPlaneNodeConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ControlPlaneNodePatchConfiguration>)ControlPlaneNodeConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            writer.WriteEndObject();
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

        internal static NetworkCloudKubernetesClusterPatch DeserializeNetworkCloudKubernetesClusterPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ControlPlaneNodePatchConfiguration> controlPlaneNodeConfiguration = default;
            Optional<string> kubernetesVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("controlPlaneNodeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            controlPlaneNodeConfiguration = ControlPlaneNodePatchConfiguration.DeserializeControlPlaneNodePatchConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkCloudKubernetesClusterPatch(Optional.ToDictionary(tags), controlPlaneNodeConfiguration.Value, kubernetesVersion.Value, rawData);
        }

        NetworkCloudKubernetesClusterPatch IModelJsonSerializable<NetworkCloudKubernetesClusterPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudKubernetesClusterPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudKubernetesClusterPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudKubernetesClusterPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudKubernetesClusterPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudKubernetesClusterPatch IModelSerializable<NetworkCloudKubernetesClusterPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudKubernetesClusterPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudKubernetesClusterPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkCloudKubernetesClusterPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkCloudKubernetesClusterPatch"/> to convert. </param>
        public static implicit operator RequestContent(NetworkCloudKubernetesClusterPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkCloudKubernetesClusterPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkCloudKubernetesClusterPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudKubernetesClusterPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
