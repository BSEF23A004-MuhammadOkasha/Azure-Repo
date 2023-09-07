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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveSummary : IUtf8JsonSerializable, IModelJsonSerializable<CveSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CveSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CveSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CveSummary>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Critical))
            {
                if (Critical != null)
                {
                    writer.WritePropertyName("critical"u8);
                    writer.WriteNumberValue(Critical.Value);
                }
                else
                {
                    writer.WriteNull("critical");
                }
            }
            if (Optional.IsDefined(High))
            {
                if (High != null)
                {
                    writer.WritePropertyName("high"u8);
                    writer.WriteNumberValue(High.Value);
                }
                else
                {
                    writer.WriteNull("high");
                }
            }
            if (Optional.IsDefined(Medium))
            {
                if (Medium != null)
                {
                    writer.WritePropertyName("medium"u8);
                    writer.WriteNumberValue(Medium.Value);
                }
                else
                {
                    writer.WriteNull("medium");
                }
            }
            if (Optional.IsDefined(Low))
            {
                if (Low != null)
                {
                    writer.WritePropertyName("low"u8);
                    writer.WriteNumberValue(Low.Value);
                }
                else
                {
                    writer.WriteNull("low");
                }
            }
            if (Optional.IsDefined(Unknown))
            {
                if (Unknown != null)
                {
                    writer.WritePropertyName("unknown"u8);
                    writer.WriteNumberValue(Unknown.Value);
                }
                else
                {
                    writer.WriteNull("unknown");
                }
            }
            if (Optional.IsDefined(Undefined))
            {
                if (Undefined != null)
                {
                    writer.WritePropertyName("undefined"u8);
                    writer.WriteNumberValue(Undefined.Value);
                }
                else
                {
                    writer.WriteNull("undefined");
                }
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

        internal static CveSummary DeserializeCveSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long?> critical = default;
            Optional<long?> high = default;
            Optional<long?> medium = default;
            Optional<long?> low = default;
            Optional<long?> unknown = default;
            Optional<long?> undefined = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("critical"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        critical = null;
                        continue;
                    }
                    critical = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        high = null;
                        continue;
                    }
                    high = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("medium"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        medium = null;
                        continue;
                    }
                    medium = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        low = null;
                        continue;
                    }
                    low = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        unknown = null;
                        continue;
                    }
                    unknown = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("undefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        undefined = null;
                        continue;
                    }
                    undefined = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CveSummary(Optional.ToNullable(critical), Optional.ToNullable(high), Optional.ToNullable(medium), Optional.ToNullable(low), Optional.ToNullable(unknown), Optional.ToNullable(undefined), serializedAdditionalRawData);
        }

        CveSummary IModelJsonSerializable<CveSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CveSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCveSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CveSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CveSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CveSummary IModelSerializable<CveSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CveSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCveSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CveSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CveSummary"/> to convert. </param>
        public static implicit operator RequestContent(CveSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CveSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CveSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCveSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
