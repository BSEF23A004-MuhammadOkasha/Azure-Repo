// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SearchMetadata : IUtf8JsonSerializable, IJsonModel<SearchMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchMetadata>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SearchMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchMetadata>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchMetadata>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SearchId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(SearchId);
            }
            if (Optional.IsDefined(ResultType))
            {
                writer.WritePropertyName("resultType"u8);
                writer.WriteStringValue(ResultType);
            }
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(CoreSummaries))
            {
                writer.WritePropertyName("coreSummaries"u8);
                writer.WriteStartArray();
                foreach (var item in CoreSummaries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated.Value, "O");
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Sort))
            {
                writer.WritePropertyName("sort"u8);
                writer.WriteStartArray();
                foreach (var item in Sort)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestTime))
            {
                writer.WritePropertyName("requestTime"u8);
                writer.WriteNumberValue(RequestTime.Value);
            }
            if (Optional.IsDefined(AggregatedValueField))
            {
                writer.WritePropertyName("aggregatedValueField"u8);
                writer.WriteStringValue(AggregatedValueField);
            }
            if (Optional.IsDefined(AggregatedGroupingFields))
            {
                writer.WritePropertyName("aggregatedGroupingFields"u8);
                writer.WriteStringValue(AggregatedGroupingFields);
            }
            if (Optional.IsDefined(Sum))
            {
                writer.WritePropertyName("sum"u8);
                writer.WriteNumberValue(Sum.Value);
            }
            if (Optional.IsDefined(Max))
            {
                writer.WritePropertyName("max"u8);
                writer.WriteNumberValue(Max.Value);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema);
            }
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

        SearchMetadata IJsonModel<SearchMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchMetadata(document.RootElement, options);
        }

        internal static SearchMetadata DeserializeSearchMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> requestId = default;
            Optional<string> resultType = default;
            Optional<long> total = default;
            Optional<long> top = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<OperationalInsightsSearchCoreSummary>> coreSummaries = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<ETag> eTag = default;
            Optional<IReadOnlyList<SearchSort>> sort = default;
            Optional<long> requestTime = default;
            Optional<string> aggregatedValueField = default;
            Optional<string> aggregatedGroupingFields = default;
            Optional<long> sum = default;
            Optional<long> max = default;
            Optional<SearchMetadataSchema> schema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreSummaries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsSearchCoreSummary> array = new List<OperationalInsightsSearchCoreSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsSearchCoreSummary.DeserializeOperationalInsightsSearchCoreSummary(item));
                    }
                    coreSummaries = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchSort> array = new List<SearchSort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchSort.DeserializeSearchSort(item));
                    }
                    sort = array;
                    continue;
                }
                if (property.NameEquals("requestTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("aggregatedValueField"u8))
                {
                    aggregatedValueField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregatedGroupingFields"u8))
                {
                    aggregatedGroupingFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("max"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    max = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = SearchMetadataSchema.DeserializeSearchMetadataSchema(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchMetadata(requestId.Value, resultType.Value, Optional.ToNullable(total), Optional.ToNullable(top), id.Value, Optional.ToList(coreSummaries), status.Value, Optional.ToNullable(startTime), Optional.ToNullable(lastUpdated), Optional.ToNullable(eTag), Optional.ToList(sort), Optional.ToNullable(requestTime), aggregatedValueField.Value, aggregatedGroupingFields.Value, Optional.ToNullable(sum), Optional.ToNullable(max), schema.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchMetadata>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchMetadata)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchMetadata IPersistableModel<SearchMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchMetadata(document.RootElement, options);
        }

        string IPersistableModel<SearchMetadata>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
