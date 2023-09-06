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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ComputeResourceRequirement : IUtf8JsonSerializable, IModelJsonSerializable<ComputeResourceRequirement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ComputeResourceRequirement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ComputeResourceRequirement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComputeResourceRequirement>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("cpu"u8);
            writer.WriteNumberValue(Cpu);
            writer.WritePropertyName("memory"u8);
            writer.WriteNumberValue(Memory);
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

        internal static ComputeResourceRequirement DeserializeComputeResourceRequirement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float cpu = default;
            long memory = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ComputeResourceRequirement(cpu, memory, rawData);
        }

        ComputeResourceRequirement IModelJsonSerializable<ComputeResourceRequirement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComputeResourceRequirement>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeResourceRequirement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ComputeResourceRequirement>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComputeResourceRequirement>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ComputeResourceRequirement IModelSerializable<ComputeResourceRequirement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComputeResourceRequirement>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComputeResourceRequirement(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ComputeResourceRequirement"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ComputeResourceRequirement"/> to convert. </param>
        public static implicit operator RequestContent(ComputeResourceRequirement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ComputeResourceRequirement"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ComputeResourceRequirement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComputeResourceRequirement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
