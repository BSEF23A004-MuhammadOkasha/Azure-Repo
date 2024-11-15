// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class HDInsightMapReduceActivity : IUtf8JsonSerializable, IJsonModel<HDInsightMapReduceActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightMapReduceActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightMapReduceActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightMapReduceActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightMapReduceActivity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageLinkedServices))
            {
                writer.WritePropertyName("storageLinkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in StorageLinkedServices)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GetDebugInfo))
            {
                writer.WritePropertyName("getDebugInfo"u8);
                writer.WriteStringValue(GetDebugInfo.Value.ToString());
            }
            writer.WritePropertyName("className"u8);
            JsonSerializer.Serialize(writer, ClassName);
            writer.WritePropertyName("jarFilePath"u8);
            JsonSerializer.Serialize(writer, JarFilePath);
            if (Optional.IsDefined(JarLinkedService))
            {
                writer.WritePropertyName("jarLinkedService"u8);
                JsonSerializer.Serialize(writer, JarLinkedService);
            }
            if (Optional.IsCollectionDefined(JarLibs))
            {
                writer.WritePropertyName("jarLibs"u8);
                writer.WriteStartArray();
                foreach (var item in JarLibs)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Defines))
            {
                writer.WritePropertyName("defines"u8);
                writer.WriteStartObject();
                foreach (var item in Defines)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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

        HDInsightMapReduceActivity IJsonModel<HDInsightMapReduceActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightMapReduceActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightMapReduceActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightMapReduceActivity(document.RootElement, options);
        }

        internal static HDInsightMapReduceActivity DeserializeHDInsightMapReduceActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryLinkedServiceReference linkedServiceName = default;
            PipelineActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            PipelineActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<PipelineActivityDependency> dependsOn = default;
            IList<PipelineActivityUserProperty> userProperties = default;
            IList<DataFactoryLinkedServiceReference> storageLinkedServices = default;
            IList<BinaryData> arguments = default;
            HDInsightActivityDebugInfoOptionSetting? getDebugInfo = default;
            DataFactoryElement<string> className = default;
            DataFactoryElement<string> jarFilePath = default;
            DataFactoryLinkedServiceReference jarLinkedService = default;
            IList<BinaryData> jarLibs = default;
            IDictionary<string, BinaryData> defines = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
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
                        if (property0.NameEquals("storageLinkedServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFactoryLinkedServiceReference> array = new List<DataFactoryLinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(item.GetRawText()));
                            }
                            storageLinkedServices = array;
                            continue;
                        }
                        if (property0.NameEquals("arguments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            arguments = array;
                            continue;
                        }
                        if (property0.NameEquals("getDebugInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            getDebugInfo = new HDInsightActivityDebugInfoOptionSetting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("className"u8))
                        {
                            className = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jarFilePath"u8))
                        {
                            jarFilePath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jarLinkedService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jarLinkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jarLibs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            jarLibs = array;
                            continue;
                        }
                        if (property0.NameEquals("defines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            defines = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightMapReduceActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<PipelineActivityDependency>(),
                userProperties ?? new ChangeTrackingList<PipelineActivityUserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy,
                storageLinkedServices ?? new ChangeTrackingList<DataFactoryLinkedServiceReference>(),
                arguments ?? new ChangeTrackingList<BinaryData>(),
                getDebugInfo,
                className,
                jarFilePath,
                jarLinkedService,
                jarLibs ?? new ChangeTrackingList<BinaryData>(),
                defines ?? new ChangeTrackingDictionary<string, BinaryData>());
        }

        BinaryData IPersistableModel<HDInsightMapReduceActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightMapReduceActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightMapReduceActivity)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightMapReduceActivity IPersistableModel<HDInsightMapReduceActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightMapReduceActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightMapReduceActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightMapReduceActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightMapReduceActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
