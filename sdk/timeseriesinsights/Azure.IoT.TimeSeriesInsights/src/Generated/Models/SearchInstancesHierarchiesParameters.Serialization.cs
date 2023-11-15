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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class SearchInstancesHierarchiesParameters : IUtf8JsonSerializable, IJsonModel<SearchInstancesHierarchiesParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchInstancesHierarchiesParameters>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SearchInstancesHierarchiesParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchInstancesHierarchiesParameters>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchInstancesHierarchiesParameters>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Expand))
            {
                writer.WritePropertyName("expand"u8);
                writer.WriteObjectValue(Expand);
            }
            if (Optional.IsDefined(Sort))
            {
                writer.WritePropertyName("sort"u8);
                writer.WriteObjectValue(Sort);
            }
            if (Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteNumberValue(PageSize.Value);
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

        SearchInstancesHierarchiesParameters IJsonModel<SearchInstancesHierarchiesParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchInstancesHierarchiesParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchInstancesHierarchiesParameters(document.RootElement, options);
        }

        internal static SearchInstancesHierarchiesParameters DeserializeSearchInstancesHierarchiesParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HierarchiesExpandParameter> expand = default;
            Optional<HierarchiesSortParameter> sort = default;
            Optional<int> pageSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expand"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expand = HierarchiesExpandParameter.DeserializeHierarchiesExpandParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("sort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sort = HierarchiesSortParameter.DeserializeHierarchiesSortParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("pageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchInstancesHierarchiesParameters(expand.Value, sort.Value, Optional.ToNullable(pageSize), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchInstancesHierarchiesParameters>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchInstancesHierarchiesParameters)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchInstancesHierarchiesParameters IPersistableModel<SearchInstancesHierarchiesParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchInstancesHierarchiesParameters)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchInstancesHierarchiesParameters(document.RootElement, options);
        }

        string IPersistableModel<SearchInstancesHierarchiesParameters>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
