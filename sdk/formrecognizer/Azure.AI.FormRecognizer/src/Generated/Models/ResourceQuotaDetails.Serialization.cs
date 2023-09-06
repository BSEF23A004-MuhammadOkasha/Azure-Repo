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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class ResourceQuotaDetails : IUtf8JsonSerializable, IModelJsonSerializable<ResourceQuotaDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceQuotaDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceQuotaDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceQuotaDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("used"u8);
            writer.WriteNumberValue(Used);
            writer.WritePropertyName("quota"u8);
            writer.WriteNumberValue(Quota);
            writer.WritePropertyName("quotaResetDateTime"u8);
            writer.WriteStringValue(QuotaResetsOn, "O");
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

        internal static ResourceQuotaDetails DeserializeResourceQuotaDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int used = default;
            int quota = default;
            DateTimeOffset quotaResetDateTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("used"u8))
                {
                    used = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    quota = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quotaResetDateTime"u8))
                {
                    quotaResetDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceQuotaDetails(used, quota, quotaResetDateTime, rawData);
        }

        ResourceQuotaDetails IModelJsonSerializable<ResourceQuotaDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceQuotaDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceQuotaDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceQuotaDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceQuotaDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceQuotaDetails IModelSerializable<ResourceQuotaDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceQuotaDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceQuotaDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceQuotaDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceQuotaDetails"/> to convert. </param>
        public static implicit operator RequestContent(ResourceQuotaDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceQuotaDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceQuotaDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceQuotaDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
