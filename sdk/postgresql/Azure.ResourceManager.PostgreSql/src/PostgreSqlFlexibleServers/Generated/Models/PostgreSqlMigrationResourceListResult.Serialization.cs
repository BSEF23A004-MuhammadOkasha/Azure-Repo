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
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    internal partial class PostgreSqlMigrationResourceListResult : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationResourceListResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PostgreSqlMigrationResourceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PostgreSqlMigrationResourceListResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PostgreSqlMigrationResourceListResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Value))
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteStartArray();
                    foreach (var item in Value)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NextLink))
                {
                    writer.WritePropertyName("nextLink"u8);
                    writer.WriteStringValue(NextLink);
                }
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

        PostgreSqlMigrationResourceListResult IJsonModel<PostgreSqlMigrationResourceListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationResourceListResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationResourceListResult(document.RootElement, options);
        }

        internal static PostgreSqlMigrationResourceListResult DeserializePostgreSqlMigrationResourceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PostgreSqlMigrationData>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlMigrationData> array = new List<PostgreSqlMigrationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlMigrationData.DeserializePostgreSqlMigrationData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlMigrationResourceListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlMigrationResourceListResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationResourceListResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PostgreSqlMigrationResourceListResult IPersistableModel<PostgreSqlMigrationResourceListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationResourceListResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePostgreSqlMigrationResourceListResult(document.RootElement, options);
        }

        string IPersistableModel<PostgreSqlMigrationResourceListResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
