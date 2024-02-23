// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndex : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("fields"u8);
            writer.WriteStartArray();
            foreach (var item in _fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(ScoringProfiles is ChangeTrackingList<ScoringProfile> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("scoringProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultScoringProfile != null)
            {
                writer.WritePropertyName("defaultScoringProfile"u8);
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (CorsOptions != null)
            {
                if (CorsOptions != null)
                {
                    writer.WritePropertyName("corsOptions"u8);
                    writer.WriteObjectValue(CorsOptions);
                }
                else
                {
                    writer.WriteNull("corsOptions");
                }
            }
            if (!(Suggesters is ChangeTrackingList<SearchSuggester> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("suggesters"u8);
                writer.WriteStartArray();
                foreach (var item in Suggesters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Analyzers is ChangeTrackingList<LexicalAnalyzer> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("analyzers"u8);
                writer.WriteStartArray();
                foreach (var item in Analyzers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Tokenizers is ChangeTrackingList<LexicalTokenizer> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("tokenizers"u8);
                writer.WriteStartArray();
                foreach (var item in Tokenizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TokenFilters is ChangeTrackingList<TokenFilter> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("tokenFilters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CharFilters is ChangeTrackingList<CharFilter> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("charFilters"u8);
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Normalizers is ChangeTrackingList<LexicalNormalizer> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("normalizers"u8);
                writer.WriteStartArray();
                foreach (var item in Normalizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EncryptionKey != null)
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            if (Similarity != null)
            {
                writer.WritePropertyName("similarity"u8);
                writer.WriteObjectValue(Similarity);
            }
            if (SemanticSearch != null)
            {
                if (SemanticSearch != null)
                {
                    writer.WritePropertyName("semantic"u8);
                    writer.WriteObjectValue(SemanticSearch);
                }
                else
                {
                    writer.WriteNull("semantic");
                }
            }
            if (VectorSearch != null)
            {
                if (VectorSearch != null)
                {
                    writer.WritePropertyName("vectorSearch"u8);
                    writer.WriteObjectValue(VectorSearch);
                }
                else
                {
                    writer.WriteNull("vectorSearch");
                }
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SearchIndex DeserializeSearchIndex(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<SearchField> fields = default;
            IList<ScoringProfile> scoringProfiles = default;
            Optional<string> defaultScoringProfile = default;
            Optional<CorsOptions> corsOptions = default;
            IList<SearchSuggester> suggesters = default;
            IList<LexicalAnalyzer> analyzers = default;
            IList<LexicalTokenizer> tokenizers = default;
            IList<TokenFilter> tokenFilters = default;
            IList<CharFilter> charFilters = default;
            IList<LexicalNormalizer> normalizers = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            Optional<SimilarityAlgorithm> similarity = default;
            Optional<SemanticSearch> semantic = default;
            Optional<VectorSearch> vectorSearch = default;
            Optional<string> odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    List<SearchField> array = new List<SearchField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchField.DeserializeSearchField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("scoringProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringProfile> array = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScoringProfile.DeserializeScoringProfile(item));
                    }
                    scoringProfiles = array;
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"u8))
                {
                    defaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        corsOptions = null;
                        continue;
                    }
                    corsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchSuggester> array = new List<SearchSuggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchSuggester.DeserializeSearchSuggester(item));
                    }
                    suggesters = array;
                    continue;
                }
                if (property.NameEquals("analyzers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalAnalyzer> array = new List<LexicalAnalyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LexicalAnalyzer.DeserializeLexicalAnalyzer(item));
                    }
                    analyzers = array;
                    continue;
                }
                if (property.NameEquals("tokenizers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalTokenizer> array = new List<LexicalTokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LexicalTokenizer.DeserializeLexicalTokenizer(item));
                    }
                    tokenizers = array;
                    continue;
                }
                if (property.NameEquals("tokenFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilter> array = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TokenFilter.DeserializeTokenFilter(item));
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CharFilter> array = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CharFilter.DeserializeCharFilter(item));
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("normalizers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalNormalizer> array = new List<LexicalNormalizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LexicalNormalizer.DeserializeLexicalNormalizer(item));
                    }
                    normalizers = array;
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("similarity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    similarity = SimilarityAlgorithm.DeserializeSimilarityAlgorithm(property.Value);
                    continue;
                }
                if (property.NameEquals("semantic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semantic = null;
                        continue;
                    }
                    semantic = SemanticSearch.DeserializeSemanticSearch(property.Value);
                    continue;
                }
                if (property.NameEquals("vectorSearch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vectorSearch = null;
                        continue;
                    }
                    vectorSearch = VectorSearch.DeserializeVectorSearch(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SearchIndex(name, fields, scoringProfiles ?? new ChangeTrackingList<ScoringProfile>(), defaultScoringProfile.Value, corsOptions.Value, suggesters ?? new ChangeTrackingList<SearchSuggester>(), analyzers ?? new ChangeTrackingList<LexicalAnalyzer>(), tokenizers ?? new ChangeTrackingList<LexicalTokenizer>(), tokenFilters ?? new ChangeTrackingList<TokenFilter>(), charFilters ?? new ChangeTrackingList<CharFilter>(), normalizers ?? new ChangeTrackingList<LexicalNormalizer>(), encryptionKey.Value, similarity.Value, semantic.Value, vectorSearch.Value, odataEtag.Value);
        }
    }
}
