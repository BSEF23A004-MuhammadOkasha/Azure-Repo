// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmVmDetails : IUtf8JsonSerializable, IJsonModel<VmmVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmmVmDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmmVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmVmDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceItemId))
            {
                writer.WritePropertyName("sourceItemId"u8);
                writer.WriteStringValue(SourceItemId);
            }
            if (Optional.IsDefined(Generation))
            {
                writer.WritePropertyName("generation"u8);
                writer.WriteStringValue(Generation);
            }
            if (Optional.IsDefined(OSDetails))
            {
                writer.WritePropertyName("osDetails"u8);
                writer.WriteObjectValue(OSDetails);
            }
            if (Optional.IsCollectionDefined(DiskDetails))
            {
                writer.WritePropertyName("diskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DiskDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HasPhysicalDisk))
            {
                writer.WritePropertyName("hasPhysicalDisk"u8);
                writer.WriteStringValue(HasPhysicalDisk.Value.ToString());
            }
            if (Optional.IsDefined(HasFibreChannelAdapter))
            {
                writer.WritePropertyName("hasFibreChannelAdapter"u8);
                writer.WriteStringValue(HasFibreChannelAdapter.Value.ToString());
            }
            if (Optional.IsDefined(HasSharedVhd))
            {
                writer.WritePropertyName("hasSharedVhd"u8);
                writer.WriteStringValue(HasSharedVhd.Value.ToString());
            }
            if (Optional.IsDefined(HyperVHostId))
            {
                writer.WritePropertyName("hyperVHostId"u8);
                writer.WriteStringValue(HyperVHostId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VmmVmDetails IJsonModel<VmmVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmVmDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmVmDetails(document.RootElement, options);
        }

        internal static VmmVmDetails DeserializeVmmVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceItemId = default;
            string generation = default;
            SiteRecoveryOSDetails osDetails = default;
            IReadOnlyList<SiteRecoveryDiskDetails> diskDetails = default;
            HyperVVmDiskPresenceStatus? hasPhysicalDisk = default;
            HyperVVmDiskPresenceStatus? hasFibreChannelAdapter = default;
            HyperVVmDiskPresenceStatus? hasSharedVhd = default;
            string hyperVHostId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceItemId"u8))
                {
                    sourceItemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generation"u8))
                {
                    generation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDetails.DeserializeSiteRecoveryOSDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDiskDetails> array = new List<SiteRecoveryDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDiskDetails.DeserializeSiteRecoveryDiskDetails(item, options));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("hasPhysicalDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasPhysicalDisk = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasFibreChannelAdapter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasFibreChannelAdapter = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasSharedVhd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasSharedVhd = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVHostId"u8))
                {
                    hyperVHostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmmVmDetails(
                instanceType,
                serializedAdditionalRawData,
                sourceItemId,
                generation,
                osDetails,
                diskDetails ?? new ChangeTrackingList<SiteRecoveryDiskDetails>(),
                hasPhysicalDisk,
                hasFibreChannelAdapter,
                hasSharedVhd,
                hyperVHostId);
        }

        BinaryData IPersistableModel<VmmVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmmVmDetails)} does not support '{options.Format}' format.");
            }
        }

        VmmVmDetails IPersistableModel<VmmVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmmVmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmmVmDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmmVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
