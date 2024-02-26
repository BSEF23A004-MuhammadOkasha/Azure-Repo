// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType.ToString());
            if (MaxDegreeOfParallelismPerJob.HasValue)
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (MinPriorityPerJob.HasValue)
            {
                writer.WritePropertyName("minPriorityPerJob"u8);
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            writer.WriteEndObject();
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

        ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent IJsonModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent(document.RootElement, options);
        }

        internal static ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent DeserializeComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Guid objectId = default;
            AadObjectIdentifierType objectType = default;
            Optional<int> maxDegreeOfParallelismPerJob = default;
            Optional<int> minPriorityPerJob = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("objectType"u8))
                        {
                            objectType = new AadObjectIdentifierType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelismPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelismPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minPriorityPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minPriorityPerJob = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent(name, objectId, objectType, Optional.ToNullable(maxDegreeOfParallelismPerJob), Optional.ToNullable(minPriorityPerJob), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputePolicyForDataLakeAnalyticsAccountCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
