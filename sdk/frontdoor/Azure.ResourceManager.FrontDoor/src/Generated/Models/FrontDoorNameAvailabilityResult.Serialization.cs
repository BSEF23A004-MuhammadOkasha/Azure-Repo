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
    public partial class FrontDoorNameAvailabilityResult : IUtf8JsonSerializable, IModelJsonSerializable<FrontDoorNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FrontDoorNameAvailabilityResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FrontDoorNameAvailabilityResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorNameAvailabilityResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static FrontDoorNameAvailabilityResult DeserializeFrontDoorNameAvailabilityResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FrontDoorNameAvailabilityState> nameAvailability = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailability = new FrontDoorNameAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
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
            return new FrontDoorNameAvailabilityResult(Optional.ToNullable(nameAvailability), reason.Value, message.Value, rawData);
        }

        FrontDoorNameAvailabilityResult IModelJsonSerializable<FrontDoorNameAvailabilityResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorNameAvailabilityResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorNameAvailabilityResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FrontDoorNameAvailabilityResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorNameAvailabilityResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FrontDoorNameAvailabilityResult IModelSerializable<FrontDoorNameAvailabilityResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorNameAvailabilityResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFrontDoorNameAvailabilityResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FrontDoorNameAvailabilityResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FrontDoorNameAvailabilityResult"/> to convert. </param>
        public static implicit operator RequestContent(FrontDoorNameAvailabilityResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FrontDoorNameAvailabilityResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FrontDoorNameAvailabilityResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFrontDoorNameAvailabilityResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
