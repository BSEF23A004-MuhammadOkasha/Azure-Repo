// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(XmlDatasetConverter))]
    public partial class XmlDataset : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure"u8);
                writer.WriteObjectValue(Structure);
            }
            if (Core.Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            writer.WriteObjectValue(LinkedServiceName);
            if (Core.Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(Annotations))
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
            if (Core.Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteObjectValue(Location);
            }
            if (Core.Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                writer.WriteObjectValue(EncodingName);
            }
            if (Core.Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue"u8);
                writer.WriteObjectValue(NullValue);
            }
            if (Core.Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteObjectValue(Compression);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static XmlDataset DeserializeXmlDataset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Core.Optional<string> description = default;
            Core.Optional<object> structure = default;
            Core.Optional<object> schema = default;
            LinkedServiceReference linkedServiceName = default;
            Core.Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Core.Optional<IList<object>> annotations = default;
            Core.Optional<DatasetFolder> folder = default;
            Core.Optional<DatasetLocation> location = default;
            Core.Optional<object> encodingName = default;
            Core.Optional<object> nullValue = default;
            Core.Optional<DatasetCompression> compression = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
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
                if (property.NameEquals("structure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
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
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
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
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encodingName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encodingName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("nullValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nullValue = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("compression"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compression = DatasetCompression.DeserializeDatasetCompression(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new XmlDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Core.Optional.ToDictionary(parameters), Core.Optional.ToList(annotations), folder.Value, additionalProperties, location.Value, encodingName.Value, nullValue.Value, compression.Value);
        }

        internal partial class XmlDatasetConverter : JsonConverter<XmlDataset>
        {
            public override void Write(Utf8JsonWriter writer, XmlDataset model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override XmlDataset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeXmlDataset(document.RootElement);
            }
        }
    }
}
