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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsTableSearchResults : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableSearchResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableSearchResults>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<OperationalInsightsTableSearchResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
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
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SourceTable))
                {
                    writer.WritePropertyName("sourceTable"u8);
                    writer.WriteStringValue(SourceTable);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(AzureAsyncOperationId))
                {
                    writer.WritePropertyName("azureAsyncOperationId"u8);
                    writer.WriteStringValue(AzureAsyncOperationId.Value);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        OperationalInsightsTableSearchResults IJsonModel<OperationalInsightsTableSearchResults>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableSearchResults(document.RootElement, options);
        }

        internal static OperationalInsightsTableSearchResults DeserializeOperationalInsightsTableSearchResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsTableSearchResults(query.Value, description.Value, Optional.ToNullable(limit), Optional.ToNullable(startSearchTime), Optional.ToNullable(endSearchTime), sourceTable.Value, Optional.ToNullable(azureAsyncOperationId), serializedAdditionalRawData);
        }

        BinaryData IModel<OperationalInsightsTableSearchResults>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationalInsightsTableSearchResults IModel<OperationalInsightsTableSearchResults>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableSearchResults)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsTableSearchResults(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<OperationalInsightsTableSearchResults>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
