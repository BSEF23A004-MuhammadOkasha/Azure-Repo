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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppCheckAvailabilityResult : IUtf8JsonSerializable, IModelJsonSerializable<NetAppCheckAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppCheckAvailabilityResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppCheckAvailabilityResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppCheckAvailabilityResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAvailable))
            {
                writer.WritePropertyName("isAvailable"u8);
                writer.WriteBooleanValue(IsAvailable.Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        internal static NetAppCheckAvailabilityResult DeserializeNetAppCheckAvailabilityResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isAvailable = default;
            Optional<NetAppNameUnavailableReason> reason = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = new NetAppNameUnavailableReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppCheckAvailabilityResult(Optional.ToNullable(isAvailable), Optional.ToNullable(reason), message.Value, rawData);
        }

        NetAppCheckAvailabilityResult IModelJsonSerializable<NetAppCheckAvailabilityResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppCheckAvailabilityResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppCheckAvailabilityResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppCheckAvailabilityResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppCheckAvailabilityResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppCheckAvailabilityResult IModelSerializable<NetAppCheckAvailabilityResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppCheckAvailabilityResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppCheckAvailabilityResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppCheckAvailabilityResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppCheckAvailabilityResult"/> to convert. </param>
        public static implicit operator RequestContent(NetAppCheckAvailabilityResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppCheckAvailabilityResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppCheckAvailabilityResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppCheckAvailabilityResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
