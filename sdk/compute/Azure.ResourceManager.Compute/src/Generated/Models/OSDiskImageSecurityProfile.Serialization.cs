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
    public partial class OSDiskImageSecurityProfile : IUtf8JsonSerializable, IModelJsonSerializable<OSDiskImageSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OSDiskImageSecurityProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OSDiskImageSecurityProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConfidentialVmEncryptionType))
            {
                writer.WritePropertyName("confidentialVMEncryptionType"u8);
                writer.WriteStringValue(ConfidentialVmEncryptionType.Value.ToString());
            }
            if (Optional.IsDefined(SecureVmDiskEncryptionSetId))
            {
                writer.WritePropertyName("secureVMDiskEncryptionSetId"u8);
                writer.WriteStringValue(SecureVmDiskEncryptionSetId);
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

        internal static OSDiskImageSecurityProfile DeserializeOSDiskImageSecurityProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConfidentialVmEncryptionType> confidentialVmEncryptionType = default;
            Optional<string> secureVmDiskEncryptionSetId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidentialVMEncryptionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidentialVmEncryptionType = new ConfidentialVmEncryptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secureVMDiskEncryptionSetId"u8))
                {
                    secureVmDiskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OSDiskImageSecurityProfile(Optional.ToNullable(confidentialVmEncryptionType), secureVmDiskEncryptionSetId.Value, serializedAdditionalRawData);
        }

        OSDiskImageSecurityProfile IModelJsonSerializable<OSDiskImageSecurityProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOSDiskImageSecurityProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OSDiskImageSecurityProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OSDiskImageSecurityProfile IModelSerializable<OSDiskImageSecurityProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOSDiskImageSecurityProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OSDiskImageSecurityProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OSDiskImageSecurityProfile"/> to convert. </param>
        public static implicit operator RequestContent(OSDiskImageSecurityProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OSDiskImageSecurityProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OSDiskImageSecurityProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOSDiskImageSecurityProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
