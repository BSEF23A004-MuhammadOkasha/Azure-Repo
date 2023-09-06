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

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterSchedulePatch : IUtf8JsonSerializable, IModelJsonSerializable<DevCenterSchedulePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevCenterSchedulePatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevCenterSchedulePatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterSchedulePatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduledType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ScheduledType.Value.ToString());
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static DevCenterSchedulePatch DeserializeDevCenterSchedulePatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<AzureLocation> location = default;
            Optional<DevCenterScheduledType> type = default;
            Optional<DevCenterScheduledFrequency> frequency = default;
            Optional<string> time = default;
            Optional<string> timeZone = default;
            Optional<DevCenterScheduleEnableStatus> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new DevCenterScheduledType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = new DevCenterScheduledFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("time"u8))
                        {
                            time = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new DevCenterScheduleEnableStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevCenterSchedulePatch(Optional.ToDictionary(tags), Optional.ToNullable(location), Optional.ToNullable(type), Optional.ToNullable(frequency), time.Value, timeZone.Value, Optional.ToNullable(state), rawData);
        }

        DevCenterSchedulePatch IModelJsonSerializable<DevCenterSchedulePatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterSchedulePatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterSchedulePatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevCenterSchedulePatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterSchedulePatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevCenterSchedulePatch IModelSerializable<DevCenterSchedulePatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterSchedulePatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevCenterSchedulePatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevCenterSchedulePatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevCenterSchedulePatch"/> to convert. </param>
        public static implicit operator RequestContent(DevCenterSchedulePatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevCenterSchedulePatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevCenterSchedulePatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevCenterSchedulePatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
