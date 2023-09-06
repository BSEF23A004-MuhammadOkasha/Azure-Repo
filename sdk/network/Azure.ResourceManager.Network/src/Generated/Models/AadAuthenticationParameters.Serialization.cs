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
    public partial class AadAuthenticationParameters : IUtf8JsonSerializable, IModelJsonSerializable<AadAuthenticationParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AadAuthenticationParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AadAuthenticationParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AadAuthenticationParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AadTenant))
            {
                writer.WritePropertyName("aadTenant"u8);
                writer.WriteStringValue(AadTenant);
            }
            if (Optional.IsDefined(AadAudience))
            {
                writer.WritePropertyName("aadAudience"u8);
                writer.WriteStringValue(AadAudience);
            }
            if (Optional.IsDefined(AadIssuer))
            {
                writer.WritePropertyName("aadIssuer"u8);
                writer.WriteStringValue(AadIssuer);
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

        internal static AadAuthenticationParameters DeserializeAadAuthenticationParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> aadTenant = default;
            Optional<string> aadAudience = default;
            Optional<string> aadIssuer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aadTenant"u8))
                {
                    aadTenant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"u8))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadIssuer"u8))
                {
                    aadIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AadAuthenticationParameters(aadTenant.Value, aadAudience.Value, aadIssuer.Value, rawData);
        }

        AadAuthenticationParameters IModelJsonSerializable<AadAuthenticationParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AadAuthenticationParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAadAuthenticationParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AadAuthenticationParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AadAuthenticationParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AadAuthenticationParameters IModelSerializable<AadAuthenticationParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AadAuthenticationParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAadAuthenticationParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AadAuthenticationParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AadAuthenticationParameters"/> to convert. </param>
        public static implicit operator RequestContent(AadAuthenticationParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AadAuthenticationParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AadAuthenticationParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAadAuthenticationParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
