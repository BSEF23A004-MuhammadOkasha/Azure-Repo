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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OSDiskImageEncryption : IUtf8JsonSerializable, IModelJsonSerializable<OSDiskImageEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OSDiskImageEncryption>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OSDiskImageEncryption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OSDiskImageEncryption>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                if (SecurityProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OSDiskImageSecurityProfile>)SecurityProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
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

        internal static OSDiskImageEncryption DeserializeOSDiskImageEncryption(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OSDiskImageSecurityProfile> securityProfile = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = OSDiskImageSecurityProfile.DeserializeOSDiskImageSecurityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OSDiskImageEncryption(diskEncryptionSetId.Value, securityProfile.Value, serializedAdditionalRawData);
        }

        OSDiskImageEncryption IModelJsonSerializable<OSDiskImageEncryption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OSDiskImageEncryption>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOSDiskImageEncryption(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OSDiskImageEncryption>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OSDiskImageEncryption>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OSDiskImageEncryption IModelSerializable<OSDiskImageEncryption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OSDiskImageEncryption>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOSDiskImageEncryption(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OSDiskImageEncryption"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OSDiskImageEncryption"/> to convert. </param>
        public static implicit operator RequestContent(OSDiskImageEncryption model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OSDiskImageEncryption"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OSDiskImageEncryption(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOSDiskImageEncryption(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
