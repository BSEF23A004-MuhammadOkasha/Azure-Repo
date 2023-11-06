// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchField : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(IsKey))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteBooleanValue(IsKey.Value);
            }
            if (Optional.IsDefined(IsRetrievable))
            {
                writer.WritePropertyName("retrievable"u8);
                writer.WriteBooleanValue(IsRetrievable.Value);
            }
            if (Optional.IsDefined(IsSearchable))
            {
                writer.WritePropertyName("searchable"u8);
                writer.WriteBooleanValue(IsSearchable.Value);
            }
            if (Optional.IsDefined(IsFilterable))
            {
                writer.WritePropertyName("filterable"u8);
                writer.WriteBooleanValue(IsFilterable.Value);
            }
            if (Optional.IsDefined(IsSortable))
            {
                writer.WritePropertyName("sortable"u8);
                writer.WriteBooleanValue(IsSortable.Value);
            }
            if (Optional.IsDefined(IsFacetable))
            {
                writer.WritePropertyName("facetable"u8);
                writer.WriteBooleanValue(IsFacetable.Value);
            }
            if (Optional.IsDefined(AnalyzerName))
            {
                if (AnalyzerName != null)
                {
                    writer.WritePropertyName("analyzer"u8);
                    writer.WriteStringValue(AnalyzerName.Value.ToString());
                }
                else
                {
                    writer.WriteNull("analyzer");
                }
            }
            if (Optional.IsDefined(SearchAnalyzerName))
            {
                if (SearchAnalyzerName != null)
                {
                    writer.WritePropertyName("searchAnalyzer"u8);
                    writer.WriteStringValue(SearchAnalyzerName.Value.ToString());
                }
                else
                {
                    writer.WriteNull("searchAnalyzer");
                }
            }
            if (Optional.IsDefined(IndexAnalyzerName))
            {
                if (IndexAnalyzerName != null)
                {
                    writer.WritePropertyName("indexAnalyzer"u8);
                    writer.WriteStringValue(IndexAnalyzerName.Value.ToString());
                }
                else
                {
                    writer.WriteNull("indexAnalyzer");
                }
            }
            if (Optional.IsDefined(NormalizerName))
            {
                if (NormalizerName != null)
                {
                    writer.WritePropertyName("normalizer"u8);
                    writer.WriteStringValue(NormalizerName.Value.ToString());
                }
                else
                {
                    writer.WriteNull("normalizer");
                }
            }
            if (Optional.IsDefined(VectorSearchDimensions))
            {
                if (VectorSearchDimensions != null)
                {
                    writer.WritePropertyName("dimensions"u8);
                    writer.WriteNumberValue(VectorSearchDimensions.Value);
                }
                else
                {
                    writer.WriteNull("dimensions");
                }
            }
            if (Optional.IsDefined(VectorSearchProfile))
            {
                if (VectorSearchProfile != null)
                {
                    writer.WritePropertyName("vectorSearchProfile"u8);
                    writer.WriteStringValue(VectorSearchProfile);
                }
                else
                {
                    writer.WriteNull("vectorSearchProfile");
                }
            }
            if (Optional.IsCollectionDefined(SynonymMapNames))
            {
                writer.WritePropertyName("synonymMaps"u8);
                writer.WriteStartArray();
                foreach (var item in SynonymMapNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Fields))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SearchField DeserializeSearchField(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            SearchFieldDataType type = default;
            Optional<bool> key = default;
            Optional<bool> retrievable = default;
            Optional<bool> searchable = default;
            Optional<bool> filterable = default;
            Optional<bool> sortable = default;
            Optional<bool> facetable = default;
            Optional<LexicalAnalyzerName?> analyzer = default;
            Optional<LexicalAnalyzerName?> searchAnalyzer = default;
            Optional<LexicalAnalyzerName?> indexAnalyzer = default;
            Optional<LexicalNormalizerName?> normalizer = default;
            Optional<int?> dimensions = default;
            Optional<string> vectorSearchProfile = default;
            Optional<IList<string>> synonymMaps = default;
            Optional<IList<SearchField>> fields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SearchFieldDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retrievable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retrievable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("searchable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filterable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filterable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sortable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sortable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facetable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    facetable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("analyzer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        analyzer = null;
                        continue;
                    }
                    analyzer = new LexicalAnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("searchAnalyzer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchAnalyzer = null;
                        continue;
                    }
                    searchAnalyzer = new LexicalAnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("indexAnalyzer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        indexAnalyzer = null;
                        continue;
                    }
                    indexAnalyzer = new LexicalAnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("normalizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        normalizer = null;
                        continue;
                    }
                    normalizer = new LexicalNormalizerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dimensions = null;
                        continue;
                    }
                    dimensions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vectorSearchProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vectorSearchProfile = null;
                        continue;
                    }
                    vectorSearchProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synonymMaps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    synonymMaps = array;
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchField> array = new List<SearchField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeSearchField(item));
                    }
                    fields = array;
                    continue;
                }
            }
            return new SearchField(name, type, Optional.ToNullable(key), Optional.ToNullable(retrievable), Optional.ToNullable(searchable), Optional.ToNullable(filterable), Optional.ToNullable(sortable), Optional.ToNullable(facetable), Optional.ToNullable(analyzer), Optional.ToNullable(searchAnalyzer), Optional.ToNullable(indexAnalyzer), Optional.ToNullable(normalizer), Optional.ToNullable(dimensions), vectorSearchProfile.Value, Optional.ToList(synonymMaps), Optional.ToList(fields));
        }
    }
}
