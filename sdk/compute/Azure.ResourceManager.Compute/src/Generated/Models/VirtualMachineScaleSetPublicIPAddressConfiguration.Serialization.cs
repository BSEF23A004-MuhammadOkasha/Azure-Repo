// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (IdleTimeoutInMinutes.HasValue)
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings);
            }
            if (!(IPTags is ChangeTrackingList<VirtualMachineScaleSetIPTag> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipTags"u8);
                writer.WriteStartArray();
                foreach (var item in IPTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicIPPrefix != null)
            {
                writer.WritePropertyName("publicIPPrefix"u8);
                JsonSerializer.Serialize(writer, PublicIPPrefix);
            }
            if (PublicIPAddressVersion.HasValue)
            {
                writer.WritePropertyName("publicIPAddressVersion"u8);
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (DeleteOption.HasValue)
            {
                writer.WritePropertyName("deleteOption"u8);
                writer.WriteStringValue(DeleteOption.Value.ToString());
            }
            writer.WriteEndObject();
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

        VirtualMachineScaleSetPublicIPAddressConfiguration IJsonModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetPublicIPAddressConfiguration DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ComputePublicIPAddressSku> sku = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings> dnsSettings = default;
            IList<VirtualMachineScaleSetIPTag> ipTags = default;
            Optional<WritableSubResource> publicIPPrefix = default;
            Optional<IPVersion> publicIPAddressVersion = default;
            Optional<ComputeDeleteOption> deleteOption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputePublicIPAddressSku.DeserializeComputePublicIPAddressSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings.DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachineScaleSetIPTag> array = new List<VirtualMachineScaleSetIPTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachineScaleSetIPTag.DeserializeVirtualMachineScaleSetIPTag(item, options));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPPrefix = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deleteOption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteOption = new ComputeDeleteOption(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetPublicIPAddressConfiguration(name, sku.Value, Optional.ToNullable(idleTimeoutInMinutes), dnsSettings.Value, ipTags ?? new ChangeTrackingList<VirtualMachineScaleSetIPTag>(), publicIPPrefix, Optional.ToNullable(publicIPAddressVersion), Optional.ToNullable(deleteOption), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetPublicIPAddressConfiguration IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetPublicIPAddressConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetPublicIPAddressConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
