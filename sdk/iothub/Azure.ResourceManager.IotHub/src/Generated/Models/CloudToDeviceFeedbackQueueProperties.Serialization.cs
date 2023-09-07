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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class CloudToDeviceFeedbackQueueProperties : IUtf8JsonSerializable, IModelJsonSerializable<CloudToDeviceFeedbackQueueProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudToDeviceFeedbackQueueProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudToDeviceFeedbackQueueProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudToDeviceFeedbackQueueProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LockDurationAsIso8601))
            {
                writer.WritePropertyName("lockDurationAsIso8601"u8);
                writer.WriteStringValue(LockDurationAsIso8601.Value, "P");
            }
            if (Optional.IsDefined(TtlAsIso8601))
            {
                writer.WritePropertyName("ttlAsIso8601"u8);
                writer.WriteStringValue(TtlAsIso8601.Value, "P");
            }
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
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

        internal static CloudToDeviceFeedbackQueueProperties DeserializeCloudToDeviceFeedbackQueueProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> lockDurationAsIso8601 = default;
            Optional<TimeSpan> ttlAsIso8601 = default;
            Optional<int> maxDeliveryCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lockDurationAsIso8601"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lockDurationAsIso8601 = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("ttlAsIso8601"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttlAsIso8601 = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxDeliveryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudToDeviceFeedbackQueueProperties(Optional.ToNullable(lockDurationAsIso8601), Optional.ToNullable(ttlAsIso8601), Optional.ToNullable(maxDeliveryCount), serializedAdditionalRawData);
        }

        CloudToDeviceFeedbackQueueProperties IModelJsonSerializable<CloudToDeviceFeedbackQueueProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudToDeviceFeedbackQueueProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudToDeviceFeedbackQueueProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudToDeviceFeedbackQueueProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudToDeviceFeedbackQueueProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudToDeviceFeedbackQueueProperties IModelSerializable<CloudToDeviceFeedbackQueueProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudToDeviceFeedbackQueueProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudToDeviceFeedbackQueueProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudToDeviceFeedbackQueueProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudToDeviceFeedbackQueueProperties"/> to convert. </param>
        public static implicit operator RequestContent(CloudToDeviceFeedbackQueueProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudToDeviceFeedbackQueueProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudToDeviceFeedbackQueueProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudToDeviceFeedbackQueueProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
