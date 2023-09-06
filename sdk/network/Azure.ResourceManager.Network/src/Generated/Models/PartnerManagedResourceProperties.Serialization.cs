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
    public partial class PartnerManagedResourceProperties : IUtf8JsonSerializable, IModelJsonSerializable<PartnerManagedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerManagedResourceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerManagedResourceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerManagedResourceProperties>(this, options.Format);

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

        internal static PartnerManagedResourceProperties DeserializePartnerManagedResourceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> internalLoadBalancerId = default;
            Optional<ResourceIdentifier> standardLoadBalancerId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("internalLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("standardLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standardLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PartnerManagedResourceProperties(id.Value, internalLoadBalancerId.Value, standardLoadBalancerId.Value, rawData);
        }

        PartnerManagedResourceProperties IModelJsonSerializable<PartnerManagedResourceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerManagedResourceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerManagedResourceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerManagedResourceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerManagedResourceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerManagedResourceProperties IModelSerializable<PartnerManagedResourceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerManagedResourceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerManagedResourceProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartnerManagedResourceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartnerManagedResourceProperties"/> to convert. </param>
        public static implicit operator RequestContent(PartnerManagedResourceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartnerManagedResourceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartnerManagedResourceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerManagedResourceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
