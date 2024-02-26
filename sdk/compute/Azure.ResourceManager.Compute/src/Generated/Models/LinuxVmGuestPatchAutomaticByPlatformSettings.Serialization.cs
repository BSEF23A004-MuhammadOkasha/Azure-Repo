// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class LinuxVmGuestPatchAutomaticByPlatformSettings : IUtf8JsonSerializable, IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinuxVmGuestPatchAutomaticByPlatformSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RebootSetting.HasValue)
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting.Value.ToString());
            }
            if (BypassPlatformSafetyChecksOnUserSchedule.HasValue)
            {
                writer.WritePropertyName("bypassPlatformSafetyChecksOnUserSchedule"u8);
                writer.WriteBooleanValue(BypassPlatformSafetyChecksOnUserSchedule.Value);
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

        LinuxVmGuestPatchAutomaticByPlatformSettings IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinuxVmGuestPatchAutomaticByPlatformSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
        }

        internal static LinuxVmGuestPatchAutomaticByPlatformSettings DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinuxVmGuestPatchAutomaticByPlatformRebootSetting> rebootSetting = default;
            Optional<bool> bypassPlatformSafetyChecksOnUserSchedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootSetting = new LinuxVmGuestPatchAutomaticByPlatformRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bypassPlatformSafetyChecksOnUserSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassPlatformSafetyChecksOnUserSchedule = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinuxVmGuestPatchAutomaticByPlatformSettings(Optional.ToNullable(rebootSetting), Optional.ToNullable(bypassPlatformSafetyChecksOnUserSchedule), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinuxVmGuestPatchAutomaticByPlatformSettings)} does not support '{options.Format}' format.");
            }
        }

        LinuxVmGuestPatchAutomaticByPlatformSettings IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinuxVmGuestPatchAutomaticByPlatformSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
