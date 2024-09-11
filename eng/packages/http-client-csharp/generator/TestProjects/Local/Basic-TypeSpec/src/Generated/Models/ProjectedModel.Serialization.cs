// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using BasicTypeSpec;

namespace BasicTypeSpec.Models
{
    /// <summary></summary>
    public partial class ProjectedModel : IJsonModel<ProjectedModel>
    {
        internal ProjectedModel()
        {
        }

        void IJsonModel<ProjectedModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ProjectedModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectedModel)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ProjectedModel IJsonModel<ProjectedModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ProjectedModel JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ProjectedModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectedModel)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProjectedModel(document.RootElement, options);
        }

        internal static ProjectedModel DeserializeProjectedModel(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    serializedAdditionalRawData.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ProjectedModel(name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProjectedModel>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ProjectedModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProjectedModel)} does not support writing '{options.Format}' format.");
            }
        }

        ProjectedModel IPersistableModel<ProjectedModel>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ProjectedModel PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ProjectedModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeProjectedModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProjectedModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProjectedModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="projectedModel"> The <see cref="ProjectedModel"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(ProjectedModel projectedModel)
        {
            return BinaryContent.Create(projectedModel, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="ProjectedModel"/> from. </param>
        public static explicit operator ProjectedModel(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeProjectedModel(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
