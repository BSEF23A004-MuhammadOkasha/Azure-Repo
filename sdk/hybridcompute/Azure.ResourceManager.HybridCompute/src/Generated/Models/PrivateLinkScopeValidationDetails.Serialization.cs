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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class PrivateLinkScopeValidationDetails : IUtf8JsonSerializable, IModelJsonSerializable<PrivateLinkScopeValidationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateLinkScopeValidationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateLinkScopeValidationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkScopeValidationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ConnectionDetails))
            {
                writer.WritePropertyName("connectionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ConnectionDetail>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static PrivateLinkScopeValidationDetails DeserializePrivateLinkScopeValidationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<PublicNetworkAccessType> publicNetworkAccess = default;
            Optional<IReadOnlyList<ConnectionDetail>> connectionDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionDetail> array = new List<ConnectionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionDetail.DeserializeConnectionDetail(item));
                    }
                    connectionDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateLinkScopeValidationDetails(id.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(connectionDetails), serializedAdditionalRawData);
        }

        PrivateLinkScopeValidationDetails IModelJsonSerializable<PrivateLinkScopeValidationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkScopeValidationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkScopeValidationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateLinkScopeValidationDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkScopeValidationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateLinkScopeValidationDetails IModelSerializable<PrivateLinkScopeValidationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkScopeValidationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateLinkScopeValidationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateLinkScopeValidationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateLinkScopeValidationDetails"/> to convert. </param>
        public static implicit operator RequestContent(PrivateLinkScopeValidationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateLinkScopeValidationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateLinkScopeValidationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateLinkScopeValidationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
