// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesProperties : IUtf8JsonSerializable, IJsonModel<StorageSpacesProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSpacesProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StorageSpacesProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageSpacesProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageSpacesProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HciStorageProfile))
            {
                writer.WritePropertyName("hciStorageProfile"u8);
                writer.WriteObjectValue(HciStorageProfile);
            }
            if (Optional.IsDefined(VmwareStorageProfile))
            {
                writer.WritePropertyName("vmwareStorageProfile"u8);
                writer.WriteObjectValue(VmwareStorageProfile);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        StorageSpacesProperties IJsonModel<StorageSpacesProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageSpacesProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSpacesProperties(document.RootElement, options);
        }

        internal static StorageSpacesProperties DeserializeStorageSpacesProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSpacesPropertiesHciStorageProfile> hciStorageProfile = default;
            Optional<StorageSpacesPropertiesVmwareStorageProfile> vmwareStorageProfile = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<StorageSpacesPropertiesStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hciStorageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hciStorageProfile = StorageSpacesPropertiesHciStorageProfile.DeserializeStorageSpacesPropertiesHciStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("vmwareStorageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareStorageProfile = StorageSpacesPropertiesVmwareStorageProfile.DeserializeStorageSpacesPropertiesVmwareStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = StorageSpacesPropertiesStatus.DeserializeStorageSpacesPropertiesStatus(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSpacesProperties(hciStorageProfile.Value, vmwareStorageProfile.Value, Optional.ToNullable(provisioningState), status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSpacesProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageSpacesProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageSpacesProperties IPersistableModel<StorageSpacesProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageSpacesProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageSpacesProperties(document.RootElement, options);
        }

        string IPersistableModel<StorageSpacesProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
