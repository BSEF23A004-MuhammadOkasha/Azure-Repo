// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AVmManagedDiskUpdateDetails : IUtf8JsonSerializable, IJsonModel<A2AVmManagedDiskUpdateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AVmManagedDiskUpdateDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AVmManagedDiskUpdateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AVmManagedDiskUpdateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(A2AVmManagedDiskUpdateDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(RecoveryTargetDiskAccountType))
            {
                writer.WritePropertyName("recoveryTargetDiskAccountType"u8);
                writer.WriteStringValue(RecoveryTargetDiskAccountType);
            }
            if (Optional.IsDefined(RecoveryReplicaDiskAccountType))
            {
                writer.WritePropertyName("recoveryReplicaDiskAccountType"u8);
                writer.WriteStringValue(RecoveryReplicaDiskAccountType);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(FailoverDiskName))
            {
                writer.WritePropertyName("failoverDiskName"u8);
                writer.WriteStringValue(FailoverDiskName);
            }
            if (Optional.IsDefined(TfoDiskName))
            {
                writer.WritePropertyName("tfoDiskName"u8);
                writer.WriteStringValue(TfoDiskName);
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

        A2AVmManagedDiskUpdateDetails IJsonModel<A2AVmManagedDiskUpdateDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AVmManagedDiskUpdateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(A2AVmManagedDiskUpdateDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AVmManagedDiskUpdateDetails(document.RootElement, options);
        }

        internal static A2AVmManagedDiskUpdateDetails DeserializeA2AVmManagedDiskUpdateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> recoveryTargetDiskAccountType = default;
            Optional<string> recoveryReplicaDiskAccountType = default;
            Optional<SiteRecoveryDiskEncryptionInfo> diskEncryptionInfo = default;
            Optional<string> failoverDiskName = default;
            Optional<string> tfoDiskName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryTargetDiskAccountType"u8))
                {
                    recoveryTargetDiskAccountType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryReplicaDiskAccountType"u8))
                {
                    recoveryReplicaDiskAccountType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("failoverDiskName"u8))
                {
                    failoverDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoDiskName"u8))
                {
                    tfoDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AVmManagedDiskUpdateDetails(diskId.Value, recoveryTargetDiskAccountType.Value, recoveryReplicaDiskAccountType.Value, diskEncryptionInfo.Value, failoverDiskName.Value, tfoDiskName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2AVmManagedDiskUpdateDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AVmManagedDiskUpdateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(A2AVmManagedDiskUpdateDetails)} does not support '{options.Format}' format.");
            }
        }

        A2AVmManagedDiskUpdateDetails IPersistableModel<A2AVmManagedDiskUpdateDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AVmManagedDiskUpdateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AVmManagedDiskUpdateDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(A2AVmManagedDiskUpdateDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AVmManagedDiskUpdateDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
