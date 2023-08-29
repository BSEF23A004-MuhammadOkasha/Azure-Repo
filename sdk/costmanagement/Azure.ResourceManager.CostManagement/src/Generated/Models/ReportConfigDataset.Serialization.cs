// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ReportConfigDataset : IUtf8JsonSerializable, IModelJsonSerializable<ReportConfigDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReportConfigDataset>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReportConfigDataset>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (Optional.IsCollectionDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteStartObject();
                foreach (var item in Aggregation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Grouping))
            {
                writer.WritePropertyName("grouping"u8);
                writer.WriteStartArray();
                foreach (var item in Grouping)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sorting))
            {
                writer.WritePropertyName("sorting"u8);
                writer.WriteStartArray();
                foreach (var item in Sorting)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ReportConfigDataset DeserializeReportConfigDataset(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReportGranularityType> granularity = default;
            Optional<ReportConfigDatasetConfiguration> configuration = default;
            Optional<IDictionary<string, ReportConfigAggregation>> aggregation = default;
            Optional<IList<ReportConfigGrouping>> grouping = default;
            Optional<IList<ReportConfigSorting>> sorting = default;
            Optional<ReportConfigFilter> filter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new ReportGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ReportConfigDatasetConfiguration.DeserializeReportConfigDatasetConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ReportConfigAggregation> dictionary = new Dictionary<string, ReportConfigAggregation>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ReportConfigAggregation.DeserializeReportConfigAggregation(property0.Value));
                    }
                    aggregation = dictionary;
                    continue;
                }
                if (property.NameEquals("grouping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigGrouping> array = new List<ReportConfigGrouping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportConfigGrouping.DeserializeReportConfigGrouping(item));
                    }
                    grouping = array;
                    continue;
                }
                if (property.NameEquals("sorting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigSorting> array = new List<ReportConfigSorting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportConfigSorting.DeserializeReportConfigSorting(item));
                    }
                    sorting = array;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ReportConfigFilter.DeserializeReportConfigFilter(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReportConfigDataset(Optional.ToNullable(granularity), configuration.Value, Optional.ToDictionary(aggregation), Optional.ToList(grouping), Optional.ToList(sorting), filter.Value, rawData);
        }

        ReportConfigDataset IModelJsonSerializable<ReportConfigDataset>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReportConfigDataset(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReportConfigDataset>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReportConfigDataset IModelSerializable<ReportConfigDataset>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReportConfigDataset(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReportConfigDataset model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReportConfigDataset(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReportConfigDataset(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
