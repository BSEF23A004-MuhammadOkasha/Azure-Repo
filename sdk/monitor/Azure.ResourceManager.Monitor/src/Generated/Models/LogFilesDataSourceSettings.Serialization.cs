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

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class LogFilesDataSourceSettings : IUtf8JsonSerializable, IModelJsonSerializable<LogFilesDataSourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogFilesDataSourceSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogFilesDataSourceSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogFilesDataSourceSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                if (Text is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LogFileSettingsText>)Text).Serialize(writer, options);
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

        internal static LogFilesDataSourceSettings DeserializeLogFilesDataSourceSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogFileSettingsText> text = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = LogFileSettingsText.DeserializeLogFileSettingsText(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogFilesDataSourceSettings(text.Value, rawData);
        }

        LogFilesDataSourceSettings IModelJsonSerializable<LogFilesDataSourceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogFilesDataSourceSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogFilesDataSourceSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogFilesDataSourceSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogFilesDataSourceSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogFilesDataSourceSettings IModelSerializable<LogFilesDataSourceSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LogFilesDataSourceSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogFilesDataSourceSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogFilesDataSourceSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogFilesDataSourceSettings"/> to convert. </param>
        public static implicit operator RequestContent(LogFilesDataSourceSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogFilesDataSourceSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogFilesDataSourceSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogFilesDataSourceSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
