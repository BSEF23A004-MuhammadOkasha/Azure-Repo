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

namespace Azure.Communication.JobRouter
{
    public partial class JobMatchingMode : IUtf8JsonSerializable, IModelJsonSerializable<JobMatchingMode>
    {
        void IModelJsonSerializable<JobMatchingMode>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ModeType))
            {
                writer.WritePropertyName("modeType"u8);
                writer.WriteStringValue(ModeType.Value.ToString());
            }
            if (Optional.IsDefined(_queueAndMatchMode))
            {
                writer.WritePropertyName("queueAndMatchMode"u8);
                writer.WriteObjectValue(_queueAndMatchMode);
            }
            if (Optional.IsDefined(ScheduleAndSuspendMode))
            {
                writer.WritePropertyName("scheduleAndSuspendMode"u8);
                writer.WriteObjectValue(ScheduleAndSuspendMode);
            }
            if (Optional.IsDefined(_suspendMode))
            {
                writer.WritePropertyName("suspendMode"u8);
                writer.WriteObjectValue(_suspendMode);
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

        internal static JobMatchingMode DeserializeJobMatchingMode(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobMatchModeType> modeType = default;
            Optional<object> queueAndMatchMode = default;
            Optional<ScheduleAndSuspendMode> scheduleAndSuspendMode = default;
            Optional<object> suspendMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modeType = new JobMatchModeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queueAndMatchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queueAndMatchMode = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("scheduleAndSuspendMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAndSuspendMode = JobRouter.ScheduleAndSuspendMode.DeserializeScheduleAndSuspendMode(property.Value);
                    continue;
                }
                if (property.NameEquals("suspendMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suspendMode = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JobMatchingMode(Optional.ToNullable(modeType), queueAndMatchMode.Value, scheduleAndSuspendMode.Value, suspendMode.Value, rawData);
        }

        JobMatchingMode IModelJsonSerializable<JobMatchingMode>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobMatchingMode(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobMatchingMode>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobMatchingMode IModelSerializable<JobMatchingMode>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobMatchingMode(doc.RootElement, options);
        }

        public static implicit operator RequestContent(JobMatchingMode model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator JobMatchingMode(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobMatchingMode(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
