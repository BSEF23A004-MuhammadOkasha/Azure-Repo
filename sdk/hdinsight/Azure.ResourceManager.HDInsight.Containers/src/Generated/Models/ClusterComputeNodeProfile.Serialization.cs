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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterComputeNodeProfile : IUtf8JsonSerializable, IModelJsonSerializable<ClusterComputeNodeProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterComputeNodeProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterComputeNodeProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterComputeNodeProfile>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(NodeProfileType);
            writer.WritePropertyName("vmSize"u8);
            writer.WriteStringValue(VmSize);
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
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

        internal static ClusterComputeNodeProfile DeserializeClusterComputeNodeProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string vmSize = default;
            int count = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterComputeNodeProfile(type, vmSize, count, rawData);
        }

        ClusterComputeNodeProfile IModelJsonSerializable<ClusterComputeNodeProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterComputeNodeProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterComputeNodeProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterComputeNodeProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterComputeNodeProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterComputeNodeProfile IModelSerializable<ClusterComputeNodeProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterComputeNodeProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterComputeNodeProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterComputeNodeProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterComputeNodeProfile"/> to convert. </param>
        public static implicit operator RequestContent(ClusterComputeNodeProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterComputeNodeProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterComputeNodeProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterComputeNodeProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
