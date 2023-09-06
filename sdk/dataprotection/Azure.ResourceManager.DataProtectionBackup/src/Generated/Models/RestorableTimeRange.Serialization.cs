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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RestorableTimeRange : IUtf8JsonSerializable, IModelJsonSerializable<RestorableTimeRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RestorableTimeRange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RestorableTimeRange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTimeRange>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndOn, "O");
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
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

        internal static RestorableTimeRange DeserializeRestorableTimeRange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            Optional<string> objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RestorableTimeRange(startTime, endTime, objectType.Value, rawData);
        }

        RestorableTimeRange IModelJsonSerializable<RestorableTimeRange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTimeRange>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorableTimeRange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RestorableTimeRange>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTimeRange>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RestorableTimeRange IModelSerializable<RestorableTimeRange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RestorableTimeRange>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRestorableTimeRange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RestorableTimeRange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RestorableTimeRange"/> to convert. </param>
        public static implicit operator RequestContent(RestorableTimeRange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RestorableTimeRange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RestorableTimeRange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRestorableTimeRange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
