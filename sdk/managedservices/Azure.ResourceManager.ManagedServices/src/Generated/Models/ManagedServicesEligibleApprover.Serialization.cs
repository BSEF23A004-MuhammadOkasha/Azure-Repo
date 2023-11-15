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

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesEligibleApprover : IUtf8JsonSerializable, IJsonModel<ManagedServicesEligibleApprover>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesEligibleApprover>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ManagedServicesEligibleApprover>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagedServicesEligibleApprover>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagedServicesEligibleApprover>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsDefined(PrincipalIdDisplayName))
            {
                writer.WritePropertyName("principalIdDisplayName"u8);
                writer.WriteStringValue(PrincipalIdDisplayName);
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

        ManagedServicesEligibleApprover IJsonModel<ManagedServicesEligibleApprover>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesEligibleApprover)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesEligibleApprover(document.RootElement, options);
        }

        internal static ManagedServicesEligibleApprover DeserializeManagedServicesEligibleApprover(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            Optional<string> principalIdDisplayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalIdDisplayName"u8))
                {
                    principalIdDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedServicesEligibleApprover(principalId, principalIdDisplayName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServicesEligibleApprover>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesEligibleApprover)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedServicesEligibleApprover IPersistableModel<ManagedServicesEligibleApprover>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesEligibleApprover)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedServicesEligibleApprover(document.RootElement, options);
        }

        string IPersistableModel<ManagedServicesEligibleApprover>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
