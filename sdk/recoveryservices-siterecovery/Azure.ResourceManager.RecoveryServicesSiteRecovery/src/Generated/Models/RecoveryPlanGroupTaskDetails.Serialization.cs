// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanGroupTaskDetails : IUtf8JsonSerializable, IJsonModel<RecoveryPlanGroupTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanGroupTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanGroupTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RpGroupType))
            {
                writer.WritePropertyName("rpGroupType"u8);
                writer.WriteStringValue(RpGroupType);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (Optional.IsCollectionDefined(ChildTasks))
            {
                writer.WritePropertyName("childTasks"u8);
                writer.WriteStartArray();
                foreach (var item in ChildTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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
            writer.WriteEndObject();
        }

        RecoveryPlanGroupTaskDetails IJsonModel<RecoveryPlanGroupTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanGroupTaskDetails(document.RootElement, options);
        }

        internal static RecoveryPlanGroupTaskDetails DeserializeRecoveryPlanGroupTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RecoveryPlanShutdownGroupTaskDetails": return RecoveryPlanShutdownGroupTaskDetails.DeserializeRecoveryPlanShutdownGroupTaskDetails(element);
                }
            }
            Optional<string> name = default;
            Optional<string> groupId = default;
            Optional<string> rpGroupType = default;
            string instanceType = "RecoveryPlanGroupTaskDetails";
            Optional<IReadOnlyList<AsrTask>> childTasks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpGroupType"u8))
                {
                    rpGroupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("childTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AsrTask> array = new List<AsrTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsrTask.DeserializeAsrTask(item));
                    }
                    childTasks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanGroupTaskDetails(instanceType, Optional.ToList(childTasks), serializedAdditionalRawData, name.Value, groupId.Value, rpGroupType.Value);
        }

        BinaryData IPersistableModel<RecoveryPlanGroupTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        RecoveryPlanGroupTaskDetails IPersistableModel<RecoveryPlanGroupTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanGroupTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanGroupTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RecoveryPlanGroupTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanGroupTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
