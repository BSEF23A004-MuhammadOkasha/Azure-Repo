// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageLifecyclePolicyCompletedEventDataConverter))]
    public partial class StorageLifecyclePolicyCompletedEventData : IUtf8JsonSerializable, IModelJsonSerializable<StorageLifecyclePolicyCompletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageLifecyclePolicyCompletedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageLifecyclePolicyCompletedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageLifecyclePolicyCompletedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleTime))
            {
                writer.WritePropertyName("scheduleTime"u8);
                writer.WriteStringValue(ScheduleTime);
            }
            if (Optional.IsDefined(DeleteSummary))
            {
                writer.WritePropertyName("deleteSummary"u8);
                if (DeleteSummary is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>)DeleteSummary).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TierToCoolSummary))
            {
                writer.WritePropertyName("tierToCoolSummary"u8);
                if (TierToCoolSummary is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>)TierToCoolSummary).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TierToArchiveSummary))
            {
                writer.WritePropertyName("tierToArchiveSummary"u8);
                if (TierToArchiveSummary is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>)TierToArchiveSummary).Serialize(writer, options);
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

        internal static StorageLifecyclePolicyCompletedEventData DeserializeStorageLifecyclePolicyCompletedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scheduleTime = default;
            Optional<StorageLifecyclePolicyActionSummaryDetail> deleteSummary = default;
            Optional<StorageLifecyclePolicyActionSummaryDetail> tierToCoolSummary = default;
            Optional<StorageLifecyclePolicyActionSummaryDetail> tierToArchiveSummary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleTime"u8))
                {
                    scheduleTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deleteSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteSummary = StorageLifecyclePolicyActionSummaryDetail.DeserializeStorageLifecyclePolicyActionSummaryDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToCoolSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCoolSummary = StorageLifecyclePolicyActionSummaryDetail.DeserializeStorageLifecyclePolicyActionSummaryDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToArchiveSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToArchiveSummary = StorageLifecyclePolicyActionSummaryDetail.DeserializeStorageLifecyclePolicyActionSummaryDetail(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageLifecyclePolicyCompletedEventData(scheduleTime.Value, deleteSummary.Value, tierToCoolSummary.Value, tierToArchiveSummary.Value, rawData);
        }

        StorageLifecyclePolicyCompletedEventData IModelJsonSerializable<StorageLifecyclePolicyCompletedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageLifecyclePolicyCompletedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageLifecyclePolicyCompletedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageLifecyclePolicyCompletedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageLifecyclePolicyCompletedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageLifecyclePolicyCompletedEventData IModelSerializable<StorageLifecyclePolicyCompletedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageLifecyclePolicyCompletedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageLifecyclePolicyCompletedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageLifecyclePolicyCompletedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageLifecyclePolicyCompletedEventData"/> to convert. </param>
        public static implicit operator RequestContent(StorageLifecyclePolicyCompletedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageLifecyclePolicyCompletedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageLifecyclePolicyCompletedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageLifecyclePolicyCompletedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class StorageLifecyclePolicyCompletedEventDataConverter : JsonConverter<StorageLifecyclePolicyCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageLifecyclePolicyCompletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StorageLifecyclePolicyCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageLifecyclePolicyCompletedEventData(document.RootElement);
            }
        }
    }
}
