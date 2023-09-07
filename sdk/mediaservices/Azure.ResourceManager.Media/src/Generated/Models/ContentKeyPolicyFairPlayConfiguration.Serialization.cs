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
    public partial class ContentKeyPolicyFairPlayConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyFairPlayConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyFairPlayConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyFairPlayConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyFairPlayConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (ApplicationSecretKey != null)
            {
                writer.WritePropertyName("ask"u8);
                writer.WriteBase64StringValue(ApplicationSecretKey, "D");
            }
            else
            {
                writer.WriteNull("ask");
            }
            if (FairPlayPfxPassword != null)
            {
                writer.WritePropertyName("fairPlayPfxPassword"u8);
                writer.WriteStringValue(FairPlayPfxPassword);
            }
            else
            {
                writer.WriteNull("fairPlayPfxPassword");
            }
            if (FairPlayPfx != null)
            {
                writer.WritePropertyName("fairPlayPfx"u8);
                writer.WriteStringValue(FairPlayPfx);
            }
            else
            {
                writer.WriteNull("fairPlayPfx");
            }
            writer.WritePropertyName("rentalAndLeaseKeyType"u8);
            writer.WriteStringValue(RentalAndLeaseKeyType.ToString());
            writer.WritePropertyName("rentalDuration"u8);
            writer.WriteNumberValue(RentalDuration);
            if (Optional.IsDefined(OfflineRentalConfiguration))
            {
                writer.WritePropertyName("offlineRentalConfiguration"u8);
                if (OfflineRentalConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)OfflineRentalConfiguration).Serialize(writer, options);
                }
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

        internal static ContentKeyPolicyFairPlayConfiguration DeserializeContentKeyPolicyFairPlayConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            byte[] ask = default;
            string fairPlayPfxPassword = default;
            string fairPlayPfx = default;
            ContentKeyPolicyFairPlayRentalAndLeaseKeyType rentalAndLeaseKeyType = default;
            long rentalDuration = default;
            Optional<ContentKeyPolicyFairPlayOfflineRentalConfiguration> offlineRentalConfiguration = default;
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ask = null;
                        continue;
                    }
                    ask = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("fairPlayPfxPassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fairPlayPfxPassword = null;
                        continue;
                    }
                    fairPlayPfxPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fairPlayPfx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fairPlayPfx = null;
                        continue;
                    }
                    fairPlayPfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rentalAndLeaseKeyType"u8))
                {
                    rentalAndLeaseKeyType = new ContentKeyPolicyFairPlayRentalAndLeaseKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rentalDuration"u8))
                {
                    rentalDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("offlineRentalConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineRentalConfiguration = ContentKeyPolicyFairPlayOfflineRentalConfiguration.DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(property.Value);
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
            return new ContentKeyPolicyFairPlayConfiguration(odataType, ask, fairPlayPfxPassword, fairPlayPfx, rentalAndLeaseKeyType, rentalDuration, offlineRentalConfiguration.Value, serializedAdditionalRawData);
        }

        ContentKeyPolicyFairPlayConfiguration IModelJsonSerializable<ContentKeyPolicyFairPlayConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyFairPlayConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyFairPlayConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyFairPlayConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyFairPlayConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyFairPlayConfiguration IModelSerializable<ContentKeyPolicyFairPlayConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContentKeyPolicyFairPlayConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyFairPlayConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentKeyPolicyFairPlayConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentKeyPolicyFairPlayConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContentKeyPolicyFairPlayConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentKeyPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentKeyPolicyFairPlayConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyFairPlayConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
