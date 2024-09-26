// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RecoveryPointDataStoreDetail : IUtf8JsonSerializable, IJsonModel<RecoveryPointDataStoreDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointDataStoreDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPointDataStoreDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDataStoreDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointDataStoreDetail)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointDataStoreId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(RecoveryPointDataStoreId.Value);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStringValue(Metadata);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(RecoveryPointDataStoreType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RecoveryPointDataStoreType);
            }
            if (Optional.IsDefined(IsVisible))
            {
                writer.WritePropertyName("visible"u8);
                writer.WriteBooleanValue(IsVisible.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RehydrationExpireOn))
            {
                writer.WritePropertyName("rehydrationExpiryTime"u8);
                writer.WriteStringValue(RehydrationExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RehydrationStatus))
            {
                writer.WritePropertyName("rehydrationStatus"u8);
                writer.WriteStringValue(RehydrationStatus.Value.ToString());
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
        }

        RecoveryPointDataStoreDetail IJsonModel<RecoveryPointDataStoreDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDataStoreDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointDataStoreDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointDataStoreDetail(document.RootElement, options);
        }

        internal static RecoveryPointDataStoreDetail DeserializeRecoveryPointDataStoreDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? creationTime = default;
            DateTimeOffset? expiryTime = default;
            Guid? id = default;
            string metaData = default;
            string state = default;
            string type = default;
            bool? visible = default;
            DateTimeOffset? rehydrationExpiryTime = default;
            RecoveryPointDataStoreRehydrationStatus? rehydrationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    metaData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visible = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rehydrationExpiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationExpiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rehydrationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationStatus = new RecoveryPointDataStoreRehydrationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPointDataStoreDetail(
                creationTime,
                expiryTime,
                id,
                metaData,
                state,
                type,
                visible,
                rehydrationExpiryTime,
                rehydrationStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointDataStoreDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDataStoreDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointDataStoreDetail)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPointDataStoreDetail IPersistableModel<RecoveryPointDataStoreDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointDataStoreDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPointDataStoreDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointDataStoreDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPointDataStoreDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
