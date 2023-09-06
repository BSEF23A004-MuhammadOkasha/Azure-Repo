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

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RestRequestAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<RestRequestAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RestRequestAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RestRequestAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestRequestAuthentication>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AuthType.ToSerialString());
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

        internal static RestRequestAuthentication DeserializeRestRequestAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ApiKey": return ApiKeyAuthentication.DeserializeApiKeyAuthentication(element);
                    case "RolloutIdentity": return RolloutIdentityAuthentication.DeserializeRolloutIdentityAuthentication(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            RestAuthType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToRestAuthType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownRestRequestAuthentication(type, rawData);
        }

        RestRequestAuthentication IModelJsonSerializable<RestRequestAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestRequestAuthentication>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRestRequestAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RestRequestAuthentication>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestRequestAuthentication>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RestRequestAuthentication IModelSerializable<RestRequestAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestRequestAuthentication>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRestRequestAuthentication(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RestRequestAuthentication"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RestRequestAuthentication"/> to convert. </param>
        public static implicit operator RequestContent(RestRequestAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RestRequestAuthentication"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RestRequestAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRestRequestAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
