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
    [JsonConverter(typeof(EventHubCaptureFileCreatedEventDataConverter))]
    public partial class EventHubCaptureFileCreatedEventData : IUtf8JsonSerializable, IModelJsonSerializable<EventHubCaptureFileCreatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubCaptureFileCreatedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubCaptureFileCreatedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubCaptureFileCreatedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Fileurl))
            {
                writer.WritePropertyName("fileUrl"u8);
                writer.WriteStringValue(Fileurl);
            }
            if (Optional.IsDefined(FileType))
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType);
            }
            if (Optional.IsDefined(PartitionId))
            {
                writer.WritePropertyName("partitionId"u8);
                writer.WriteStringValue(PartitionId);
            }
            if (Optional.IsDefined(SizeInBytes))
            {
                writer.WritePropertyName("sizeInBytes"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (Optional.IsDefined(EventCount))
            {
                writer.WritePropertyName("eventCount"u8);
                writer.WriteNumberValue(EventCount.Value);
            }
            if (Optional.IsDefined(FirstSequenceNumber))
            {
                writer.WritePropertyName("firstSequenceNumber"u8);
                writer.WriteNumberValue(FirstSequenceNumber.Value);
            }
            if (Optional.IsDefined(LastSequenceNumber))
            {
                writer.WritePropertyName("lastSequenceNumber"u8);
                writer.WriteNumberValue(LastSequenceNumber.Value);
            }
            if (Optional.IsDefined(FirstEnqueueTime))
            {
                writer.WritePropertyName("firstEnqueueTime"u8);
                writer.WriteStringValue(FirstEnqueueTime.Value, "O");
            }
            if (Optional.IsDefined(LastEnqueueTime))
            {
                writer.WritePropertyName("lastEnqueueTime"u8);
                writer.WriteStringValue(LastEnqueueTime.Value, "O");
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

        internal static EventHubCaptureFileCreatedEventData DeserializeEventHubCaptureFileCreatedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileUrl = default;
            Optional<string> fileType = default;
            Optional<string> partitionId = default;
            Optional<int> sizeInBytes = default;
            Optional<int> eventCount = default;
            Optional<int> firstSequenceNumber = default;
            Optional<int> lastSequenceNumber = default;
            Optional<DateTimeOffset> firstEnqueueTime = default;
            Optional<DateTimeOffset> lastEnqueueTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileUrl"u8))
                {
                    fileUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    fileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionId"u8))
                {
                    partitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("firstEnqueueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEnqueueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEnqueueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EventHubCaptureFileCreatedEventData(fileUrl.Value, fileType.Value, partitionId.Value, Optional.ToNullable(sizeInBytes), Optional.ToNullable(eventCount), Optional.ToNullable(firstSequenceNumber), Optional.ToNullable(lastSequenceNumber), Optional.ToNullable(firstEnqueueTime), Optional.ToNullable(lastEnqueueTime), rawData);
        }

        EventHubCaptureFileCreatedEventData IModelJsonSerializable<EventHubCaptureFileCreatedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubCaptureFileCreatedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubCaptureFileCreatedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubCaptureFileCreatedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubCaptureFileCreatedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubCaptureFileCreatedEventData IModelSerializable<EventHubCaptureFileCreatedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubCaptureFileCreatedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubCaptureFileCreatedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubCaptureFileCreatedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubCaptureFileCreatedEventData"/> to convert. </param>
        public static implicit operator RequestContent(EventHubCaptureFileCreatedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubCaptureFileCreatedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubCaptureFileCreatedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubCaptureFileCreatedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class EventHubCaptureFileCreatedEventDataConverter : JsonConverter<EventHubCaptureFileCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, EventHubCaptureFileCreatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventHubCaptureFileCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventHubCaptureFileCreatedEventData(document.RootElement);
            }
        }
    }
}
