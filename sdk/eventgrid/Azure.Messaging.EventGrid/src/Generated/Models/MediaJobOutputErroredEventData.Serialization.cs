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
    [JsonConverter(typeof(MediaJobOutputErroredEventDataConverter))]
    public partial class MediaJobOutputErroredEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobOutputErroredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobOutputErroredEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobOutputErroredEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutputErroredEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                if (Output is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaJobOutput>)Output).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(JobCorrelationData))
            {
                writer.WritePropertyName("jobCorrelationData"u8);
                writer.WriteStartObject();
                foreach (var item in JobCorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MediaJobOutputErroredEventData DeserializeMediaJobOutputErroredEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobOutput> output = default;
            Optional<IReadOnlyDictionary<string, string>> jobCorrelationData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MediaJobOutput.DeserializeMediaJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("jobCorrelationData"u8))
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
                    jobCorrelationData = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobOutputErroredEventData(Optional.ToNullable(previousState), output.Value, Optional.ToDictionary(jobCorrelationData), rawData);
        }

        MediaJobOutputErroredEventData IModelJsonSerializable<MediaJobOutputErroredEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutputErroredEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobOutputErroredEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobOutputErroredEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutputErroredEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobOutputErroredEventData IModelSerializable<MediaJobOutputErroredEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaJobOutputErroredEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobOutputErroredEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaJobOutputErroredEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaJobOutputErroredEventData"/> to convert. </param>
        public static implicit operator RequestContent(MediaJobOutputErroredEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaJobOutputErroredEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaJobOutputErroredEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobOutputErroredEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaJobOutputErroredEventDataConverter : JsonConverter<MediaJobOutputErroredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobOutputErroredEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobOutputErroredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobOutputErroredEventData(document.RootElement);
            }
        }
    }
}
