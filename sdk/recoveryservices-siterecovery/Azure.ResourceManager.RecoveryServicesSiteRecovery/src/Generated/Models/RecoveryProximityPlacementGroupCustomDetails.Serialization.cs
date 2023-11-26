// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryProximityPlacementGroupCustomDetails))]
    public partial class RecoveryProximityPlacementGroupCustomDetails : IUtf8JsonSerializable, IJsonModel<RecoveryProximityPlacementGroupCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryProximityPlacementGroupCustomDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryProximityPlacementGroupCustomDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecoveryProximityPlacementGroupCustomDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        RecoveryProximityPlacementGroupCustomDetails IJsonModel<RecoveryProximityPlacementGroupCustomDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecoveryProximityPlacementGroupCustomDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryProximityPlacementGroupCustomDetails(document.RootElement, options);
        }

        internal static RecoveryProximityPlacementGroupCustomDetails DeserializeRecoveryProximityPlacementGroupCustomDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryProximityPlacementGroup.DeserializeExistingRecoveryProximityPlacementGroup(element);
                }
            }
            return UnknownRecoveryProximityPlacementGroupCustomDetails.DeserializeUnknownRecoveryProximityPlacementGroupCustomDetails(element);
        }

        BinaryData IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RecoveryProximityPlacementGroupCustomDetails)} does not support '{options.Format}' format.");
            }
        }

        RecoveryProximityPlacementGroupCustomDetails IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryProximityPlacementGroupCustomDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RecoveryProximityPlacementGroupCustomDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryProximityPlacementGroupCustomDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
