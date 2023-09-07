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
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabServicesScheduleData : IUtf8JsonSerializable, IModelJsonSerializable<LabServicesScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LabServicesScheduleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LabServicesScheduleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabServicesScheduleData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startAt"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(StopOn))
            {
                writer.WritePropertyName("stopAt"u8);
                writer.WriteStringValue(StopOn.Value, "O");
            }
            if (Optional.IsDefined(RecurrencePattern))
            {
                writer.WritePropertyName("recurrencePattern"u8);
                if (RecurrencePattern is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LabServicesRecurrencePattern>)RecurrencePattern).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Notes);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Notes.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
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

        internal static LabServicesScheduleData DeserializeLabServicesScheduleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startAt = default;
            Optional<DateTimeOffset> stopAt = default;
            Optional<LabServicesRecurrencePattern> recurrencePattern = default;
            Optional<string> timeZoneId = default;
            Optional<BinaryData> notes = default;
            Optional<LabServicesProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("stopAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stopAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recurrencePattern"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recurrencePattern = LabServicesRecurrencePattern.DeserializeLabServicesRecurrencePattern(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notes = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LabServicesScheduleData(id, name, type, systemData.Value, Optional.ToNullable(startAt), Optional.ToNullable(stopAt), recurrencePattern.Value, timeZoneId.Value, notes.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        LabServicesScheduleData IModelJsonSerializable<LabServicesScheduleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabServicesScheduleData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLabServicesScheduleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LabServicesScheduleData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabServicesScheduleData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LabServicesScheduleData IModelSerializable<LabServicesScheduleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabServicesScheduleData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLabServicesScheduleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LabServicesScheduleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LabServicesScheduleData"/> to convert. </param>
        public static implicit operator RequestContent(LabServicesScheduleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LabServicesScheduleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LabServicesScheduleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLabServicesScheduleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
