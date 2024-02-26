// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabSubnetOverride : IUtf8JsonSerializable, IJsonModel<DevTestLabSubnetOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabSubnetOverride>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabSubnetOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabSubnetOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabSubnetOverride)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (LabSubnetName != null)
            {
                writer.WritePropertyName("labSubnetName"u8);
                writer.WriteStringValue(LabSubnetName);
            }
            if (UseInVmCreationPermission.HasValue)
            {
                writer.WritePropertyName("useInVmCreationPermission"u8);
                writer.WriteStringValue(UseInVmCreationPermission.Value.ToString());
            }
            if (UsePublicIPAddressPermission.HasValue)
            {
                writer.WritePropertyName("usePublicIpAddressPermission"u8);
                writer.WriteStringValue(UsePublicIPAddressPermission.Value.ToString());
            }
            if (SharedPublicIPAddressConfiguration != null)
            {
                writer.WritePropertyName("sharedPublicIpAddressConfiguration"u8);
                writer.WriteObjectValue(SharedPublicIPAddressConfiguration);
            }
            if (VirtualNetworkPoolName != null)
            {
                writer.WritePropertyName("virtualNetworkPoolName"u8);
                writer.WriteStringValue(VirtualNetworkPoolName);
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

        DevTestLabSubnetOverride IJsonModel<DevTestLabSubnetOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabSubnetOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabSubnetOverride)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabSubnetOverride(document.RootElement, options);
        }

        internal static DevTestLabSubnetOverride DeserializeDevTestLabSubnetOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> labSubnetName = default;
            Optional<DevTestLabUsagePermissionType> useInVmCreationPermission = default;
            Optional<DevTestLabUsagePermissionType> usePublicIPAddressPermission = default;
            Optional<SubnetSharedPublicIPAddressConfiguration> sharedPublicIPAddressConfiguration = default;
            Optional<string> virtualNetworkPoolName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labSubnetName"u8))
                {
                    labSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useInVmCreationPermission"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useInVmCreationPermission = new DevTestLabUsagePermissionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usePublicIpAddressPermission"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usePublicIPAddressPermission = new DevTestLabUsagePermissionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sharedPublicIpAddressConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharedPublicIPAddressConfiguration = SubnetSharedPublicIPAddressConfiguration.DeserializeSubnetSharedPublicIPAddressConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("virtualNetworkPoolName"u8))
                {
                    virtualNetworkPoolName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabSubnetOverride(resourceId.Value, labSubnetName.Value, Optional.ToNullable(useInVmCreationPermission), Optional.ToNullable(usePublicIPAddressPermission), sharedPublicIPAddressConfiguration.Value, virtualNetworkPoolName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabSubnetOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabSubnetOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabSubnetOverride)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabSubnetOverride IPersistableModel<DevTestLabSubnetOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabSubnetOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabSubnetOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabSubnetOverride)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabSubnetOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
