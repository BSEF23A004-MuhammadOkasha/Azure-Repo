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

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsManagedIdentityReference : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsManagedIdentityReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsManagedIdentityReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsManagedIdentityReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsManagedIdentityReference>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityType.Value.ToString());
            }
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                if (UserAssignedIdentity != null)
                {
                    writer.WritePropertyName("userAssignedIdentity"u8);
                    writer.WriteStringValue(UserAssignedIdentity);
                }
                else
                {
                    writer.WriteNull("userAssignedIdentity");
                }
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

        internal static DigitalTwinsManagedIdentityReference DeserializeDigitalTwinsManagedIdentityReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DigitalTwinsManagedIdentityType> type = default;
            Optional<string> userAssignedIdentity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new DigitalTwinsManagedIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userAssignedIdentity = null;
                        continue;
                    }
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DigitalTwinsManagedIdentityReference(Optional.ToNullable(type), userAssignedIdentity.Value, rawData);
        }

        DigitalTwinsManagedIdentityReference IModelJsonSerializable<DigitalTwinsManagedIdentityReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsManagedIdentityReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsManagedIdentityReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsManagedIdentityReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsManagedIdentityReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsManagedIdentityReference IModelSerializable<DigitalTwinsManagedIdentityReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsManagedIdentityReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsManagedIdentityReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsManagedIdentityReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsManagedIdentityReference"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsManagedIdentityReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsManagedIdentityReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsManagedIdentityReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsManagedIdentityReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
