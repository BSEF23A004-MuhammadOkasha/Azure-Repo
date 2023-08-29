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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SupportedCapabilities : IUtf8JsonSerializable, IModelJsonSerializable<SupportedCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SupportedCapabilities>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SupportedCapabilities>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskControllerTypes))
            {
                writer.WritePropertyName("diskControllerTypes"u8);
                writer.WriteStringValue(DiskControllerTypes);
            }
            if (Optional.IsDefined(AcceleratedNetwork))
            {
                writer.WritePropertyName("acceleratedNetwork"u8);
                writer.WriteBooleanValue(AcceleratedNetwork.Value);
            }
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture.Value.ToString());
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

        internal static SupportedCapabilities DeserializeSupportedCapabilities(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskControllerTypes = default;
            Optional<bool> acceleratedNetwork = default;
            Optional<ArchitectureType> architecture = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskControllerTypes"u8))
                {
                    diskControllerTypes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceleratedNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceleratedNetwork = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    architecture = new ArchitectureType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SupportedCapabilities(diskControllerTypes.Value, Optional.ToNullable(acceleratedNetwork), Optional.ToNullable(architecture), rawData);
        }

        SupportedCapabilities IModelJsonSerializable<SupportedCapabilities>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportedCapabilities(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SupportedCapabilities>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SupportedCapabilities IModelSerializable<SupportedCapabilities>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSupportedCapabilities(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SupportedCapabilities model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SupportedCapabilities(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSupportedCapabilities(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
