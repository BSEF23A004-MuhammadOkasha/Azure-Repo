// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaJobData : IUtf8JsonSerializable, IJsonModel<MediaJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MediaJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MediaJobData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MediaJobData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("created"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(State))
                {
                    writer.WritePropertyName("state"u8);
                    writer.WriteStringValue(State.Value.ToString());
                }
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastModifiedOn))
                {
                    writer.WritePropertyName("lastModified"u8);
                    writer.WriteStringValue(LastModifiedOn.Value, "O");
                }
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (Optional.IsCollectionDefined(CorrelationData))
            {
                writer.WritePropertyName("correlationData"u8);
                writer.WriteStartObject();
                foreach (var item in CorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StartOn))
                {
                    if (StartOn != null)
                    {
                        writer.WritePropertyName("startTime"u8);
                        writer.WriteStringValue(StartOn.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("startTime");
                    }
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EndOn))
                {
                    if (EndOn != null)
                    {
                        writer.WritePropertyName("endTime"u8);
                        writer.WriteStringValue(EndOn.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("endTime");
                    }
                }
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

        MediaJobData IJsonModel<MediaJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobData(document.RootElement, options);
        }

        internal static MediaJobData DeserializeMediaJobData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> created = default;
            Optional<MediaJobState> state = default;
            Optional<string> description = default;
            Optional<MediaJobInputBasicProperties> input = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<IList<MediaJobOutput>> outputs = default;
            Optional<MediaJobPriority> priority = default;
            Optional<IDictionary<string, string>> correlationData = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new MediaJobState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("input"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            input = MediaJobInputBasicProperties.DeserializeMediaJobInputBasicProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MediaJobOutput> array = new List<MediaJobOutput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MediaJobOutput.DeserializeMediaJobOutput(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = new MediaJobPriority(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("correlationData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            correlationData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                startTime = null;
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
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
            return new MediaJobData(id, name, type, systemData.Value, Optional.ToNullable(created), Optional.ToNullable(state), description.Value, input.Value, Optional.ToNullable(lastModified), Optional.ToList(outputs), Optional.ToNullable(priority), Optional.ToDictionary(correlationData), Optional.ToNullable(startTime), Optional.ToNullable(endTime), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaJobData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MediaJobData IPersistableModel<MediaJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMediaJobData(document.RootElement, options);
        }

        string IPersistableModel<MediaJobData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
