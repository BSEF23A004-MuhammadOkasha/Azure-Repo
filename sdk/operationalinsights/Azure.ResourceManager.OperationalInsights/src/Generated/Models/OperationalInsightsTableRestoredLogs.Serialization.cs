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
    public partial class OperationalInsightsTableRestoredLogs : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableRestoredLogs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableRestoredLogs>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<OperationalInsightsTableRestoredLogs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartRestoreOn))
            {
                writer.WritePropertyName("startRestoreTime"u8);
                writer.WriteStringValue(StartRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(EndRestoreOn))
            {
                writer.WritePropertyName("endRestoreTime"u8);
                writer.WriteStringValue(EndRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(SourceTable))
            {
                writer.WritePropertyName("sourceTable"u8);
                writer.WriteStringValue(SourceTable);
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

        OperationalInsightsTableRestoredLogs IJsonModel<OperationalInsightsTableRestoredLogs>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableRestoredLogs(document.RootElement, options);
        }

        internal static OperationalInsightsTableRestoredLogs DeserializeOperationalInsightsTableRestoredLogs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startRestoreTime = default;
            Optional<DateTimeOffset> endRestoreTime = default;
            Optional<string> sourceTable = default;
            Optional<Guid> azureAsyncOperationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startRestoreTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startRestoreTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endRestoreTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endRestoreTime = property.Value.GetDateTimeOffset("O");
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
            return new OperationalInsightsTableRestoredLogs(Optional.ToNullable(startRestoreTime), Optional.ToNullable(endRestoreTime), sourceTable.Value, Optional.ToNullable(azureAsyncOperationId), serializedAdditionalRawData);
        }

        BinaryData IModel<OperationalInsightsTableRestoredLogs>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationalInsightsTableRestoredLogs IModel<OperationalInsightsTableRestoredLogs>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsTableRestoredLogs(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<OperationalInsightsTableRestoredLogs>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
