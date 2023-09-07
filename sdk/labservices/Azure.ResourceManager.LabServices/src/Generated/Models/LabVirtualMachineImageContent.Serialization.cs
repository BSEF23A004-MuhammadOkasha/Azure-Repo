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

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabVirtualMachineImageContent : IUtf8JsonSerializable, IModelJsonSerializable<LabVirtualMachineImageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LabVirtualMachineImageContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LabVirtualMachineImageContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabVirtualMachineImageContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(LabVirtualMachineId))
            {
                writer.WritePropertyName("labVirtualMachineId"u8);
                writer.WriteStringValue(LabVirtualMachineId);
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

        internal static LabVirtualMachineImageContent DeserializeLabVirtualMachineImageContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceIdentifier> labVirtualMachineId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LabVirtualMachineImageContent(name.Value, labVirtualMachineId.Value, serializedAdditionalRawData);
        }

        LabVirtualMachineImageContent IModelJsonSerializable<LabVirtualMachineImageContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabVirtualMachineImageContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLabVirtualMachineImageContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LabVirtualMachineImageContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabVirtualMachineImageContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LabVirtualMachineImageContent IModelSerializable<LabVirtualMachineImageContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabVirtualMachineImageContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLabVirtualMachineImageContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LabVirtualMachineImageContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LabVirtualMachineImageContent"/> to convert. </param>
        public static implicit operator RequestContent(LabVirtualMachineImageContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LabVirtualMachineImageContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LabVirtualMachineImageContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLabVirtualMachineImageContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
