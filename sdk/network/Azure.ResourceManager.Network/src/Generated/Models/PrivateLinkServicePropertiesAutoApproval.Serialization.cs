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
    internal partial class PrivateLinkServicePropertiesAutoApproval : IUtf8JsonSerializable, IModelJsonSerializable<PrivateLinkServicePropertiesAutoApproval>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateLinkServicePropertiesAutoApproval>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateLinkServicePropertiesAutoApproval>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkServicePropertiesAutoApproval>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
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

        internal static PrivateLinkServicePropertiesAutoApproval DeserializePrivateLinkServicePropertiesAutoApproval(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> subscriptions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateLinkServicePropertiesAutoApproval(Optional.ToList(subscriptions), rawData);
        }

        PrivateLinkServicePropertiesAutoApproval IModelJsonSerializable<PrivateLinkServicePropertiesAutoApproval>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkServicePropertiesAutoApproval>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkServicePropertiesAutoApproval(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateLinkServicePropertiesAutoApproval>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkServicePropertiesAutoApproval>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateLinkServicePropertiesAutoApproval IModelSerializable<PrivateLinkServicePropertiesAutoApproval>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkServicePropertiesAutoApproval>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateLinkServicePropertiesAutoApproval(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateLinkServicePropertiesAutoApproval"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateLinkServicePropertiesAutoApproval"/> to convert. </param>
        public static implicit operator RequestContent(PrivateLinkServicePropertiesAutoApproval model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateLinkServicePropertiesAutoApproval"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateLinkServicePropertiesAutoApproval(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateLinkServicePropertiesAutoApproval(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
