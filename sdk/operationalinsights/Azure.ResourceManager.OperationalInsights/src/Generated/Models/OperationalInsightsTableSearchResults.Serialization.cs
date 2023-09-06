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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsTableSearchResults : IUtf8JsonSerializable, IModelJsonSerializable<OperationalInsightsTableSearchResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationalInsightsTableSearchResults>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationalInsightsTableSearchResults>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsTableSearchResults>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (Optional.IsDefined(StartSearchOn))
            {
                writer.WritePropertyName("startSearchTime"u8);
                writer.WriteStringValue(StartSearchOn.Value, "O");
            }
            if (Optional.IsDefined(EndSearchOn))
            {
                writer.WritePropertyName("endSearchTime"u8);
                writer.WriteStringValue(EndSearchOn.Value, "O");
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

        internal static OperationalInsightsTableSearchResults DeserializeOperationalInsightsTableSearchResults(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> query = default;
            Optional<string> description = default;
            Optional<int> limit = default;
            Optional<DateTimeOffset> startSearchTime = default;
            Optional<DateTimeOffset> endSearchTime = default;
            Optional<string> sourceTable = default;
            Optional<Guid> azureAsyncOperationId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startSearchTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startSearchTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endSearchTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endSearchTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceTable"u8))
                {
                    sourceTable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureAsyncOperationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureAsyncOperationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OperationalInsightsTableSearchResults(query.Value, description.Value, Optional.ToNullable(limit), Optional.ToNullable(startSearchTime), Optional.ToNullable(endSearchTime), sourceTable.Value, Optional.ToNullable(azureAsyncOperationId), rawData);
        }

        OperationalInsightsTableSearchResults IModelJsonSerializable<OperationalInsightsTableSearchResults>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsTableSearchResults>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableSearchResults(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationalInsightsTableSearchResults>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsTableSearchResults>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationalInsightsTableSearchResults IModelSerializable<OperationalInsightsTableSearchResults>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsTableSearchResults>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsTableSearchResults(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationalInsightsTableSearchResults"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationalInsightsTableSearchResults"/> to convert. </param>
        public static implicit operator RequestContent(OperationalInsightsTableSearchResults model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationalInsightsTableSearchResults"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationalInsightsTableSearchResults(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationalInsightsTableSearchResults(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
