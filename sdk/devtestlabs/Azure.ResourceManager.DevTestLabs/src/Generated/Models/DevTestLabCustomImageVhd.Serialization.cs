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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCustomImageVhd : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabCustomImageVhd>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabCustomImageVhd>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabCustomImageVhd>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCustomImageVhd>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(IsSysPrepEnabled))
            {
                writer.WritePropertyName("sysPrep"u8);
                writer.WriteBooleanValue(IsSysPrepEnabled.Value);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
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

        internal static DevTestLabCustomImageVhd DeserializeDevTestLabCustomImageVhd(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> imageName = default;
            Optional<bool> sysPrep = default;
            DevTestLabCustomImageOSType osType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sysPrep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sysPrep = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new DevTestLabCustomImageOSType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabCustomImageVhd(imageName.Value, Optional.ToNullable(sysPrep), osType, rawData);
        }

        DevTestLabCustomImageVhd IModelJsonSerializable<DevTestLabCustomImageVhd>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCustomImageVhd>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageVhd(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabCustomImageVhd>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCustomImageVhd>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabCustomImageVhd IModelSerializable<DevTestLabCustomImageVhd>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCustomImageVhd>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabCustomImageVhd(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabCustomImageVhd"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabCustomImageVhd"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabCustomImageVhd model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabCustomImageVhd"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabCustomImageVhd(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabCustomImageVhd(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
