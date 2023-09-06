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

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class FhirServiceAccessPolicyEntry : IUtf8JsonSerializable, IModelJsonSerializable<FhirServiceAccessPolicyEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FhirServiceAccessPolicyEntry>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FhirServiceAccessPolicyEntry>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FhirServiceAccessPolicyEntry>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
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

        internal static FhirServiceAccessPolicyEntry DeserializeFhirServiceAccessPolicyEntry(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string objectId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FhirServiceAccessPolicyEntry(objectId, rawData);
        }

        FhirServiceAccessPolicyEntry IModelJsonSerializable<FhirServiceAccessPolicyEntry>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FhirServiceAccessPolicyEntry>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirServiceAccessPolicyEntry(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FhirServiceAccessPolicyEntry>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FhirServiceAccessPolicyEntry>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FhirServiceAccessPolicyEntry IModelSerializable<FhirServiceAccessPolicyEntry>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FhirServiceAccessPolicyEntry>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFhirServiceAccessPolicyEntry(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FhirServiceAccessPolicyEntry"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FhirServiceAccessPolicyEntry"/> to convert. </param>
        public static implicit operator RequestContent(FhirServiceAccessPolicyEntry model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FhirServiceAccessPolicyEntry"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FhirServiceAccessPolicyEntry(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFhirServiceAccessPolicyEntry(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
