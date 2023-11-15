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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureDataLakeStorageGen2Parameter : IUtf8JsonSerializable, IJsonModel<AzureDataLakeStorageGen2Parameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDataLakeStorageGen2Parameter>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureDataLakeStorageGen2Parameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureDataLakeStorageGen2Parameter>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureDataLakeStorageGen2Parameter>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                if (AccountName != null)
                {
                    writer.WritePropertyName("accountName"u8);
                    writer.WriteStringValue(AccountName);
                }
                else
                {
                    writer.WriteNull("accountName");
                }
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey"u8);
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (FileSystemName != null)
            {
                writer.WritePropertyName("fileSystemName"u8);
                writer.WriteStringValue(FileSystemName);
            }
            else
            {
                writer.WriteNull("fileSystemName");
            }
            if (DirectoryTemplate != null)
            {
                writer.WritePropertyName("directoryTemplate"u8);
                writer.WriteStringValue(DirectoryTemplate);
            }
            else
            {
                writer.WriteNull("directoryTemplate");
            }
            if (FileTemplate != null)
            {
                writer.WritePropertyName("fileTemplate"u8);
                writer.WriteStringValue(FileTemplate);
            }
            else
            {
                writer.WriteNull("fileTemplate");
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

        AzureDataLakeStorageGen2Parameter IJsonModel<AzureDataLakeStorageGen2Parameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStorageGen2Parameter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataLakeStorageGen2Parameter(document.RootElement, options);
        }

        internal static AzureDataLakeStorageGen2Parameter DeserializeAzureDataLakeStorageGen2Parameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountName = default;
            Optional<string> accountKey = default;
            string fileSystemName = default;
            string directoryTemplate = default;
            string fileTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountName = null;
                        continue;
                    }
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountKey = null;
                        continue;
                    }
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileSystemName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileSystemName = null;
                        continue;
                    }
                    fileSystemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directoryTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        directoryTemplate = null;
                        continue;
                    }
                    directoryTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileTemplate = null;
                        continue;
                    }
                    fileTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureDataLakeStorageGen2Parameter(accountName.Value, accountKey.Value, fileSystemName, directoryTemplate, fileTemplate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureDataLakeStorageGen2Parameter>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStorageGen2Parameter)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureDataLakeStorageGen2Parameter IPersistableModel<AzureDataLakeStorageGen2Parameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStorageGen2Parameter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureDataLakeStorageGen2Parameter(document.RootElement, options);
        }

        string IPersistableModel<AzureDataLakeStorageGen2Parameter>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
