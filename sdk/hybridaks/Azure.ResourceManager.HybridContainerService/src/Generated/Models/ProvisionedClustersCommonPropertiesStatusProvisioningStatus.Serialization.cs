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
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatus : IUtf8JsonSerializable, IJsonModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(Phase))
            {
                writer.WritePropertyName("phase"u8);
                writer.WriteStringValue(Phase);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        ProvisionedClustersCommonPropertiesStatusProvisioningStatus IJsonModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesStatusProvisioningStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatus(document.RootElement, options);
        }

        internal static ProvisionedClustersCommonPropertiesStatusProvisioningStatus DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError> error = default;
            Optional<string> operationId = default;
            Optional<string> phase = default;
            Optional<string> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ProvisionedClustersCommonPropertiesStatusProvisioningStatusError.DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"u8))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClustersCommonPropertiesStatusProvisioningStatus(error.Value, operationId.Value, phase.Value, status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesStatusProvisioningStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProvisionedClustersCommonPropertiesStatusProvisioningStatus IPersistableModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersCommonPropertiesStatusProvisioningStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatus(document.RootElement, options);
        }

        string IPersistableModel<ProvisionedClustersCommonPropertiesStatusProvisioningStatus>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
