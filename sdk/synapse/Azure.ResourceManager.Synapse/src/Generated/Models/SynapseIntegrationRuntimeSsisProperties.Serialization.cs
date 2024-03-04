// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeSsisProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeSsisProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeSsisProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeSsisProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CatalogInfo != null)
            {
                writer.WritePropertyName("catalogInfo"u8);
                writer.WriteObjectValue(CatalogInfo);
            }
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (CustomSetupScriptProperties != null)
            {
                writer.WritePropertyName("customSetupScriptProperties"u8);
                writer.WriteObjectValue(CustomSetupScriptProperties);
            }
            if (DataProxyProperties != null)
            {
                writer.WritePropertyName("dataProxyProperties"u8);
                writer.WriteObjectValue(DataProxyProperties);
            }
            if (Edition.HasValue)
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (!(ExpressCustomSetupProperties is ChangeTrackingList<SynapseCustomSetupBase> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("expressCustomSetupProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ExpressCustomSetupProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeSsisProperties IJsonModel<SynapseIntegrationRuntimeSsisProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeSsisProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeSsisProperties DeserializeSynapseIntegrationRuntimeSsisProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseIntegrationRuntimeSsisCatalogInfo catalogInfo = default;
            SynapseIntegrationRuntimeLicenseType? licenseType = default;
            SynapseIntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties = default;
            SynapseIntegrationRuntimeDataProxyProperties dataProxyProperties = default;
            SynapseIntegrationRuntimeEdition? edition = default;
            IList<SynapseCustomSetupBase> expressCustomSetupProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogInfo = SynapseIntegrationRuntimeSsisCatalogInfo.DeserializeSynapseIntegrationRuntimeSsisCatalogInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SynapseIntegrationRuntimeLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customSetupScriptProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customSetupScriptProperties = SynapseIntegrationRuntimeCustomSetupScriptProperties.DeserializeSynapseIntegrationRuntimeCustomSetupScriptProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataProxyProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProxyProperties = SynapseIntegrationRuntimeDataProxyProperties.DeserializeSynapseIntegrationRuntimeDataProxyProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edition = new SynapseIntegrationRuntimeEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressCustomSetupProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseCustomSetupBase> array = new List<SynapseCustomSetupBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseCustomSetupBase.DeserializeSynapseCustomSetupBase(item, options));
                    }
                    expressCustomSetupProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeSsisProperties(
                catalogInfo,
                licenseType,
                customSetupScriptProperties,
                dataProxyProperties,
                edition,
                expressCustomSetupProperties ?? new ChangeTrackingList<SynapseCustomSetupBase>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeSsisProperties IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeSsisProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeSsisProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
