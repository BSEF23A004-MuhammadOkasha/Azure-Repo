// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureDataExplorerSourceConverter))]
    public partial class AzureDataExplorerSource : IUtf8JsonSerializable, IJsonModel<AzureDataExplorerSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDataExplorerSource>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureDataExplorerSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureDataExplorerSource>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureDataExplorerSource>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("query"u8);
            writer.WriteObjectValue(Query);
            if (Optional.IsDefined(NoTruncation))
            {
                writer.WritePropertyName("noTruncation"u8);
                writer.WriteObjectValue(NoTruncation);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                writer.WriteObjectValue(QueryTimeout);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        AzureDataExplorerSource IJsonModel<AzureDataExplorerSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataExplorerSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataExplorerSource(document.RootElement, options);
        }

        internal static AzureDataExplorerSource DeserializeAzureDataExplorerSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object query = default;
            Optional<object> noTruncation = default;
            Optional<object> queryTimeout = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("noTruncation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noTruncation = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDataExplorerSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, query, noTruncation.Value, queryTimeout.Value, additionalColumns.Value);
        }

        BinaryData IPersistableModel<AzureDataExplorerSource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataExplorerSource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureDataExplorerSource IPersistableModel<AzureDataExplorerSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataExplorerSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureDataExplorerSource(document.RootElement, options);
        }

        string IPersistableModel<AzureDataExplorerSource>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class AzureDataExplorerSourceConverter : JsonConverter<AzureDataExplorerSource>
        {
            public override void Write(Utf8JsonWriter writer, AzureDataExplorerSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDataExplorerSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDataExplorerSource(document.RootElement);
            }
        }
    }
}
