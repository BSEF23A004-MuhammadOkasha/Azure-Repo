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

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyPlayReadyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyPlayReadyConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyPlayReadyConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("licenses"u8);
            writer.WriteStartArray();
            foreach (var item in Licenses)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentKeyPolicyPlayReadyLicense>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ResponseCustomData))
            {
                writer.WritePropertyName("responseCustomData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResponseCustomData);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ResponseCustomData.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static ContentKeyPolicyPlayReadyConfiguration DeserializeContentKeyPolicyPlayReadyConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContentKeyPolicyPlayReadyLicense> licenses = default;
            Optional<BinaryData> responseCustomData = default;
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("licenses"u8))
                {
                    List<ContentKeyPolicyPlayReadyLicense> array = new List<ContentKeyPolicyPlayReadyLicense>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyPlayReadyLicense.DeserializeContentKeyPolicyPlayReadyLicense(item));
                    }
                    licenses = array;
                    continue;
                }
                if (property.NameEquals("responseCustomData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseCustomData = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyConfiguration(odataType, licenses, responseCustomData.Value, serializedAdditionalRawData);
        }

        ContentKeyPolicyPlayReadyConfiguration IModelJsonSerializable<ContentKeyPolicyPlayReadyConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyPlayReadyConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyPlayReadyConfiguration IModelSerializable<ContentKeyPolicyPlayReadyConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyPlayReadyConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyPlayReadyConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyPlayReadyConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyPlayReadyConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyPlayReadyConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyPlayReadyConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
