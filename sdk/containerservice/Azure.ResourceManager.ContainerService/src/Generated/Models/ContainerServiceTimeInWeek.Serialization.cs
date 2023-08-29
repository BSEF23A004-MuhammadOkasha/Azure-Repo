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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceTimeInWeek : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceTimeInWeek>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceTimeInWeek>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceTimeInWeek>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HourSlots))
            {
                writer.WritePropertyName("hourSlots"u8);
                writer.WriteStartArray();
                foreach (var item in HourSlots)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        internal static ContainerServiceTimeInWeek DeserializeContainerServiceTimeInWeek(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerServiceWeekDay> day = default;
            Optional<IList<int>> hourSlots = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = new ContainerServiceWeekDay(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourSlots"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hourSlots = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceTimeInWeek(Optional.ToNullable(day), Optional.ToList(hourSlots), rawData);
        }

        ContainerServiceTimeInWeek IModelJsonSerializable<ContainerServiceTimeInWeek>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceTimeInWeek(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceTimeInWeek>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceTimeInWeek IModelSerializable<ContainerServiceTimeInWeek>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceTimeInWeek(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerServiceTimeInWeek model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerServiceTimeInWeek(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceTimeInWeek(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
