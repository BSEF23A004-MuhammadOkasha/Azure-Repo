// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(BlobTriggerConverter))]
    public partial class BlobTrigger : IUtf8JsonSerializable, IJsonModel<BlobTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobTrigger>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BlobTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BlobTrigger>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BlobTrigger>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Pipelines))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RuntimeState))
                {
                    writer.WritePropertyName("runtimeState"u8);
                    writer.WriteStringValue(RuntimeState.Value.ToString());
                }
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("folderPath"u8);
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("maxConcurrency"u8);
            writer.WriteNumberValue(MaxConcurrency);
            writer.WritePropertyName("linkedService"u8);
            writer.WriteObjectValue(LinkedService);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        BlobTrigger IJsonModel<BlobTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobTrigger(document.RootElement, options);
        }

        internal static BlobTrigger DeserializeBlobTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            string folderPath = default;
            int maxConcurrency = default;
            LinkedServiceReference linkedService = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new TriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("folderPath"u8))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"u8))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("linkedService"u8))
                        {
                            linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new BlobTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), folderPath, maxConcurrency, linkedService);
        }

        BinaryData IPersistableModel<BlobTrigger>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobTrigger)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BlobTrigger IPersistableModel<BlobTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBlobTrigger(document.RootElement, options);
        }

        string IPersistableModel<BlobTrigger>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class BlobTriggerConverter : JsonConverter<BlobTrigger>
        {
            public override void Write(Utf8JsonWriter writer, BlobTrigger model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override BlobTrigger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBlobTrigger(document.RootElement);
            }
        }
    }
}
