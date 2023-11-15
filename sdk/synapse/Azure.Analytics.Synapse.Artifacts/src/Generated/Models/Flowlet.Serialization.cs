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
    [JsonConverter(typeof(FlowletConverter))]
    public partial class Flowlet : IUtf8JsonSerializable, IJsonModel<Flowlet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Flowlet>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<Flowlet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<Flowlet>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<Flowlet>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sinks))
            {
                writer.WritePropertyName("sinks"u8);
                writer.WriteStartArray();
                foreach (var item in Sinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transformations))
            {
                writer.WritePropertyName("transformations"u8);
                writer.WriteStartArray();
                foreach (var item in Transformations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsCollectionDefined(ScriptLines))
            {
                writer.WritePropertyName("scriptLines"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptLines)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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
            writer.WriteEndObject();
        }

        Flowlet IJsonModel<Flowlet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Flowlet)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlowlet(document.RootElement, options);
        }

        internal static Flowlet DeserializeFlowlet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> description = default;
            Optional<IList<object>> annotations = default;
            Optional<DataFlowFolder> folder = default;
            Optional<IList<DataFlowSource>> sources = default;
            Optional<IList<DataFlowSink>> sinks = default;
            Optional<IList<Transformation>> transformations = default;
            Optional<string> script = default;
            Optional<IList<string>> scriptLines = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DataFlowFolder.DeserializeDataFlowFolder(property.Value);
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
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlowSource> array = new List<DataFlowSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlowSource.DeserializeDataFlowSource(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("sinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlowSink> array = new List<DataFlowSink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlowSink.DeserializeDataFlowSink(item));
                            }
                            sinks = array;
                            continue;
                        }
                        if (property0.NameEquals("transformations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Transformation> array = new List<Transformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Transformation.DeserializeTransformation(item));
                            }
                            transformations = array;
                            continue;
                        }
                        if (property0.NameEquals("script"u8))
                        {
                            script = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scriptLines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            scriptLines = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Flowlet(type, description.Value, Optional.ToList(annotations), folder.Value, serializedAdditionalRawData, Optional.ToList(sources), Optional.ToList(sinks), Optional.ToList(transformations), script.Value, Optional.ToList(scriptLines));
        }

        BinaryData IPersistableModel<Flowlet>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Flowlet)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        Flowlet IPersistableModel<Flowlet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Flowlet)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFlowlet(document.RootElement, options);
        }

        string IPersistableModel<Flowlet>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class FlowletConverter : JsonConverter<Flowlet>
        {
            public override void Write(Utf8JsonWriter writer, Flowlet model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Flowlet Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFlowlet(document.RootElement);
            }
        }
    }
}
