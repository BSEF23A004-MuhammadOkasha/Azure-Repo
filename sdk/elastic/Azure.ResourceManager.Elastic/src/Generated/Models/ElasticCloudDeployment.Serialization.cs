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

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticCloudDeployment : IUtf8JsonSerializable, IModelJsonSerializable<ElasticCloudDeployment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticCloudDeployment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticCloudDeployment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudDeployment>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ElasticCloudDeployment DeserializeElasticCloudDeployment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> deploymentId = default;
            Optional<string> azureSubscriptionId = default;
            Optional<string> elasticsearchRegion = default;
            Optional<Uri> elasticsearchServiceUrl = default;
            Optional<Uri> kibanaServiceUrl = default;
            Optional<Uri> kibanaSsoUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentId"u8))
                {
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchRegion"u8))
                {
                    elasticsearchRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticsearchServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kibanaServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kibanaServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kibanaSsoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kibanaSsoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticCloudDeployment(name.Value, deploymentId.Value, azureSubscriptionId.Value, elasticsearchRegion.Value, elasticsearchServiceUrl.Value, kibanaServiceUrl.Value, kibanaSsoUrl.Value, rawData);
        }

        ElasticCloudDeployment IModelJsonSerializable<ElasticCloudDeployment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudDeployment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticCloudDeployment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticCloudDeployment>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudDeployment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticCloudDeployment IModelSerializable<ElasticCloudDeployment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudDeployment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticCloudDeployment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ElasticCloudDeployment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ElasticCloudDeployment"/> to convert. </param>
        public static implicit operator RequestContent(ElasticCloudDeployment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ElasticCloudDeployment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ElasticCloudDeployment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticCloudDeployment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
