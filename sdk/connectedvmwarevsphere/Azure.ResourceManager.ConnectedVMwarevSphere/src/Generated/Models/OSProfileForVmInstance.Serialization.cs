// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class OSProfileForVmInstance : IUtf8JsonSerializable, IJsonModel<OSProfileForVmInstance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSProfileForVmInstance>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OSProfileForVmInstance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ComputerName != null)
            {
                writer.WritePropertyName("computerName"u8);
                writer.WriteStringValue(ComputerName);
            }
            if (AdminUsername != null)
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (AdminPassword != null)
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (GuestId != null)
            {
                writer.WritePropertyName("guestId"u8);
                writer.WriteStringValue(GuestId);
            }
            if (OSType.HasValue)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format != "W" && OSSku != null)
            {
                writer.WritePropertyName("osSku"u8);
                writer.WriteStringValue(OSSku);
            }
            if (options.Format != "W" && ToolsRunningStatus != null)
            {
                writer.WritePropertyName("toolsRunningStatus"u8);
                writer.WriteStringValue(ToolsRunningStatus);
            }
            if (options.Format != "W" && ToolsVersionStatus != null)
            {
                writer.WritePropertyName("toolsVersionStatus"u8);
                writer.WriteStringValue(ToolsVersionStatus);
            }
            if (options.Format != "W" && ToolsVersion != null)
            {
                writer.WritePropertyName("toolsVersion"u8);
                writer.WriteStringValue(ToolsVersion);
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

        OSProfileForVmInstance IJsonModel<OSProfileForVmInstance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSProfileForVmInstance(document.RootElement, options);
        }

        internal static OSProfileForVmInstance DeserializeOSProfileForVmInstance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> computerName = default;
            Optional<string> adminUsername = default;
            Optional<string> adminPassword = default;
            Optional<string> guestId = default;
            Optional<VMwareOSType> osType = default;
            Optional<string> osSku = default;
            Optional<string> toolsRunningStatus = default;
            Optional<string> toolsVersionStatus = default;
            Optional<string> toolsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"u8))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guestId"u8))
                {
                    guestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new VMwareOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSku"u8))
                {
                    osSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsRunningStatus"u8))
                {
                    toolsRunningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsVersionStatus"u8))
                {
                    toolsVersionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolsVersion"u8))
                {
                    toolsVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OSProfileForVmInstance(computerName.Value, adminUsername.Value, adminPassword.Value, guestId.Value, Optional.ToNullable(osType), osSku.Value, toolsRunningStatus.Value, toolsVersionStatus.Value, toolsVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OSProfileForVmInstance>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support '{options.Format}' format.");
            }
        }

        OSProfileForVmInstance IPersistableModel<OSProfileForVmInstance>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSProfileForVmInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSProfileForVmInstance(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OSProfileForVmInstance)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSProfileForVmInstance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
