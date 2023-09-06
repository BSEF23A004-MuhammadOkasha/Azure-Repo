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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RedirectConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<RedirectConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedirectConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedirectConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedirectConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RedirectType))
            {
                writer.WritePropertyName("redirectType"u8);
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (Optional.IsDefined(RedirectProtocol))
            {
                writer.WritePropertyName("redirectProtocol"u8);
                writer.WriteStringValue(RedirectProtocol.Value.ToString());
            }
            if (Optional.IsDefined(CustomHost))
            {
                writer.WritePropertyName("customHost"u8);
                writer.WriteStringValue(CustomHost);
            }
            if (Optional.IsDefined(CustomPath))
            {
                writer.WritePropertyName("customPath"u8);
                writer.WriteStringValue(CustomPath);
            }
            if (Optional.IsDefined(CustomFragment))
            {
                writer.WritePropertyName("customFragment"u8);
                writer.WriteStringValue(CustomFragment);
            }
            if (Optional.IsDefined(CustomQueryString))
            {
                writer.WritePropertyName("customQueryString"u8);
                writer.WriteStringValue(CustomQueryString);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static RedirectConfiguration DeserializeRedirectConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FrontDoorRedirectType> redirectType = default;
            Optional<FrontDoorRedirectProtocol> redirectProtocol = default;
            Optional<string> customHost = default;
            Optional<string> customPath = default;
            Optional<string> customFragment = default;
            Optional<string> customQueryString = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redirectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectType = new FrontDoorRedirectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectProtocol = new FrontDoorRedirectProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customHost"u8))
                {
                    customHost = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customPath"u8))
                {
                    customPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customFragment"u8))
                {
                    customFragment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customQueryString"u8))
                {
                    customQueryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedirectConfiguration(odataType, Optional.ToNullable(redirectType), Optional.ToNullable(redirectProtocol), customHost.Value, customPath.Value, customFragment.Value, customQueryString.Value, rawData);
        }

        RedirectConfiguration IModelJsonSerializable<RedirectConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedirectConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedirectConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedirectConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedirectConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedirectConfiguration IModelSerializable<RedirectConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedirectConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedirectConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RedirectConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RedirectConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(RedirectConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RedirectConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RedirectConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedirectConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
