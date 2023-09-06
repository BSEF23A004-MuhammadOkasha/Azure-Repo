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
    public partial class HealthcareApisServiceCosmosDbConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareApisServiceCosmosDbConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareApisServiceCosmosDbConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareApisServiceCosmosDbConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceCosmosDbConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OfferThroughput))
            {
                writer.WritePropertyName("offerThroughput"u8);
                writer.WriteNumberValue(OfferThroughput.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
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

        internal static HealthcareApisServiceCosmosDbConfiguration DeserializeHealthcareApisServiceCosmosDbConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> offerThroughput = default;
            Optional<Uri> keyVaultKeyUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offerThroughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareApisServiceCosmosDbConfiguration(Optional.ToNullable(offerThroughput), keyVaultKeyUri.Value, rawData);
        }

        HealthcareApisServiceCosmosDbConfiguration IModelJsonSerializable<HealthcareApisServiceCosmosDbConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceCosmosDbConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceCosmosDbConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareApisServiceCosmosDbConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceCosmosDbConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareApisServiceCosmosDbConfiguration IModelSerializable<HealthcareApisServiceCosmosDbConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceCosmosDbConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareApisServiceCosmosDbConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareApisServiceCosmosDbConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareApisServiceCosmosDbConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareApisServiceCosmosDbConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareApisServiceCosmosDbConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareApisServiceCosmosDbConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareApisServiceCosmosDbConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
