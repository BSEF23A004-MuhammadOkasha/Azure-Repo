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
    public partial class ScheduleBasedBackupTriggerContext : IUtf8JsonSerializable, IModelJsonSerializable<ScheduleBasedBackupTriggerContext>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScheduleBasedBackupTriggerContext>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScheduleBasedBackupTriggerContext>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleBasedBackupTriggerContext>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("schedule"u8);
            if (Schedule is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DataProtectionBackupSchedule>)Schedule).Serialize(writer, options);
            }
            writer.WritePropertyName("taggingCriteria"u8);
            writer.WriteStartArray();
            foreach (var item in TaggingCriteriaList)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataProtectionBackupTaggingCriteria>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static ScheduleBasedBackupTriggerContext DeserializeScheduleBasedBackupTriggerContext(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupSchedule schedule = default;
            IList<DataProtectionBackupTaggingCriteria> taggingCriteria = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = DataProtectionBackupSchedule.DeserializeDataProtectionBackupSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("taggingCriteria"u8))
                {
                    List<DataProtectionBackupTaggingCriteria> array = new List<DataProtectionBackupTaggingCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupTaggingCriteria.DeserializeDataProtectionBackupTaggingCriteria(item));
                    }
                    taggingCriteria = array;
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
            return new ScheduleBasedBackupTriggerContext(objectType, schedule, taggingCriteria, rawData);
        }

        ScheduleBasedBackupTriggerContext IModelJsonSerializable<ScheduleBasedBackupTriggerContext>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleBasedBackupTriggerContext>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleBasedBackupTriggerContext(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScheduleBasedBackupTriggerContext>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleBasedBackupTriggerContext>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScheduleBasedBackupTriggerContext IModelSerializable<ScheduleBasedBackupTriggerContext>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleBasedBackupTriggerContext>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScheduleBasedBackupTriggerContext(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScheduleBasedBackupTriggerContext"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScheduleBasedBackupTriggerContext"/> to convert. </param>
        public static implicit operator RequestContent(ScheduleBasedBackupTriggerContext model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScheduleBasedBackupTriggerContext"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScheduleBasedBackupTriggerContext(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScheduleBasedBackupTriggerContext(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
