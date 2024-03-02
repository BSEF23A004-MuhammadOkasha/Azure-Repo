// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxAccountCredentialDetails : IUtf8JsonSerializable, IJsonModel<DataBoxAccountCredentialDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxAccountCredentialDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxAccountCredentialDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxAccountCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxAccountCredentialDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AccountName != null)
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (options.Format != "W" && DataAccountType.HasValue)
            {
                writer.WritePropertyName("dataAccountType"u8);
                writer.WriteStringValue(DataAccountType.Value.ToSerialString());
            }
            if (options.Format != "W" && AccountConnectionString != null)
            {
                writer.WritePropertyName("accountConnectionString"u8);
                writer.WriteStringValue(AccountConnectionString);
            }
            if (options.Format != "W" && !(ShareCredentialDetails is ChangeTrackingList<ShareCredentialDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("shareCredentialDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ShareCredentialDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DataBoxAccountCredentialDetails IJsonModel<DataBoxAccountCredentialDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxAccountCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxAccountCredentialDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxAccountCredentialDetails(document.RootElement, options);
        }

        internal static DataBoxAccountCredentialDetails DeserializeDataBoxAccountCredentialDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            DataAccountType? dataAccountType = default;
            string accountConnectionString = default;
            IReadOnlyList<ShareCredentialDetails> shareCredentialDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountConnectionString"u8))
                {
                    accountConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShareCredentialDetails> array = new List<ShareCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ShareCredentialDetails.DeserializeShareCredentialDetails(item, options));
                    }
                    shareCredentialDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxAccountCredentialDetails(accountName, dataAccountType, accountConnectionString, shareCredentialDetails ?? new ChangeTrackingList<ShareCredentialDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxAccountCredentialDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxAccountCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxAccountCredentialDetails)} does not support '{options.Format}' format.");
            }
        }

        DataBoxAccountCredentialDetails IPersistableModel<DataBoxAccountCredentialDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxAccountCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxAccountCredentialDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxAccountCredentialDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxAccountCredentialDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
