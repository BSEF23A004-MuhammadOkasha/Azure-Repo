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
    public partial class AksClusterProfile : IUtf8JsonSerializable, IModelJsonSerializable<AksClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AksClusterProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AksClusterProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AksClusterProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AksClusterResourceId))
            {
                writer.WritePropertyName("aksClusterResourceId"u8);
                writer.WriteStringValue(AksClusterResourceId);
            }
            if (Optional.IsDefined(AksClusterAgentPoolIdentityProfile))
            {
                writer.WritePropertyName("aksClusterAgentPoolIdentityProfile"u8);
                if (AksClusterAgentPoolIdentityProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HDInsightIdentityProfile>)AksClusterAgentPoolIdentityProfile).Serialize(writer, options);
                }
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

        internal static AksClusterProfile DeserializeAksClusterProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> aksClusterResourceId = default;
            Optional<HDInsightIdentityProfile> aksClusterAgentPoolIdentityProfile = default;
            Optional<string> aksVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aksClusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aksClusterAgentPoolIdentityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterAgentPoolIdentityProfile = HDInsightIdentityProfile.DeserializeHDInsightIdentityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("aksVersion"u8))
                {
                    aksVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AksClusterProfile(aksClusterResourceId.Value, aksClusterAgentPoolIdentityProfile.Value, aksVersion.Value, rawData);
        }

        AksClusterProfile IModelJsonSerializable<AksClusterProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AksClusterProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAksClusterProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AksClusterProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AksClusterProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AksClusterProfile IModelSerializable<AksClusterProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AksClusterProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAksClusterProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AksClusterProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AksClusterProfile"/> to convert. </param>
        public static implicit operator RequestContent(AksClusterProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AksClusterProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AksClusterProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAksClusterProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
