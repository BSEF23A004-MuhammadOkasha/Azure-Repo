// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FetchTieringCostSavingsInfoForVaultContent : IUtf8JsonSerializable, IJsonModel<FetchTieringCostSavingsInfoForVaultContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FetchTieringCostSavingsInfoForVaultContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FetchTieringCostSavingsInfoForVaultContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForVaultContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        FetchTieringCostSavingsInfoForVaultContent IJsonModel<FetchTieringCostSavingsInfoForVaultContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForVaultContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFetchTieringCostSavingsInfoForVaultContent(document.RootElement, options);
        }

        internal static FetchTieringCostSavingsInfoForVaultContent DeserializeFetchTieringCostSavingsInfoForVaultContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPointTierType sourceTierType = default;
            RecoveryPointTierType targetTierType = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceTierType"u8))
                {
                    sourceTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("targetTierType"u8))
                {
                    targetTierType = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FetchTieringCostSavingsInfoForVaultContent(sourceTierType, targetTierType, objectType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForVaultContent)} does not support writing '{options.Format}' format.");
            }
        }

        FetchTieringCostSavingsInfoForVaultContent IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFetchTieringCostSavingsInfoForVaultContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FetchTieringCostSavingsInfoForVaultContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FetchTieringCostSavingsInfoForVaultContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
