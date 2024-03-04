// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(MappingDataFlowConverter))]
    public partial class MappingDataFlow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Annotations is ChangeTrackingList<object> collection && collection.IsUndefined))
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
            if (Folder != null)
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (!(Sources is ChangeTrackingList<DataFlowSource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Sinks is ChangeTrackingList<DataFlowSink> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sinks"u8);
                writer.WriteStartArray();
                foreach (var item in Sinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Transformations is ChangeTrackingList<Transformation> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("transformations"u8);
                writer.WriteStartArray();
                foreach (var item in Transformations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Script != null)
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (!(ScriptLines is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
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
            writer.WriteEndObject();
        }

        internal static MappingDataFlow DeserializeMappingDataFlow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string description = default;
            IList<object> annotations = default;
            DataFlowFolder folder = default;
            IList<DataFlowSource> sources = default;
            IList<DataFlowSink> sinks = default;
            IList<Transformation> transformations = default;
            string script = default;
            IList<string> scriptLines = default;
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
            }
            return new MappingDataFlow(
                type,
                description,
                annotations ?? new ChangeTrackingList<object>(),
                folder,
                sources ?? new ChangeTrackingList<DataFlowSource>(),
                sinks ?? new ChangeTrackingList<DataFlowSink>(),
                transformations ?? new ChangeTrackingList<Transformation>(),
                script,
                scriptLines ?? new ChangeTrackingList<string>());
        }

        internal partial class MappingDataFlowConverter : JsonConverter<MappingDataFlow>
        {
            public override void Write(Utf8JsonWriter writer, MappingDataFlow model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MappingDataFlow Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMappingDataFlow(document.RootElement);
            }
        }
    }
}
