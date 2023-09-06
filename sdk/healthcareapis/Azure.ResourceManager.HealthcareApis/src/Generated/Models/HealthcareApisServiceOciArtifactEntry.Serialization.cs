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
    public partial class HealthcareApisServiceOciArtifactEntry : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareApisServiceOciArtifactEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareApisServiceOciArtifactEntry>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareApisServiceOciArtifactEntry>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceOciArtifactEntry>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LoginServer))
            {
                writer.WritePropertyName("loginServer"u8);
                writer.WriteStringValue(LoginServer);
            }
            if (Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
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

        internal static HealthcareApisServiceOciArtifactEntry DeserializeHealthcareApisServiceOciArtifactEntry(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> loginServer = default;
            Optional<string> imageName = default;
            Optional<string> digest = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginServer"u8))
                {
                    loginServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareApisServiceOciArtifactEntry(loginServer.Value, imageName.Value, digest.Value, rawData);
        }

        HealthcareApisServiceOciArtifactEntry IModelJsonSerializable<HealthcareApisServiceOciArtifactEntry>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceOciArtifactEntry>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceOciArtifactEntry(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareApisServiceOciArtifactEntry>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceOciArtifactEntry>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareApisServiceOciArtifactEntry IModelSerializable<HealthcareApisServiceOciArtifactEntry>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceOciArtifactEntry>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareApisServiceOciArtifactEntry(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareApisServiceOciArtifactEntry"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareApisServiceOciArtifactEntry"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareApisServiceOciArtifactEntry model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareApisServiceOciArtifactEntry"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareApisServiceOciArtifactEntry(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareApisServiceOciArtifactEntry(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
