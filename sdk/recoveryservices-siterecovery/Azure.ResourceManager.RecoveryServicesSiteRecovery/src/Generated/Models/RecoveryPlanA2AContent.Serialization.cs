// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanA2AContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanA2AContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanA2AContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPlanA2AContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanA2AContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PrimaryZone))
            {
                writer.WritePropertyName("primaryZone"u8);
                writer.WriteStringValue(PrimaryZone);
            }
            if (Optional.IsDefined(RecoveryZone))
            {
                writer.WritePropertyName("recoveryZone"u8);
                writer.WriteStringValue(RecoveryZone);
            }
            if (Optional.IsDefined(PrimaryExtendedLocation))
            {
                writer.WritePropertyName("primaryExtendedLocation"u8);
                writer.WriteObjectValue(PrimaryExtendedLocation, options);
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                writer.WriteObjectValue(RecoveryExtendedLocation, options);
            }
        }

        RecoveryPlanA2AContent IJsonModel<RecoveryPlanA2AContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanA2AContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanA2AContent(document.RootElement, options);
        }

        internal static RecoveryPlanA2AContent DeserializeRecoveryPlanA2AContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryZone = default;
            string recoveryZone = default;
            SiteRecoveryExtendedLocation primaryExtendedLocation = default;
            SiteRecoveryExtendedLocation recoveryExtendedLocation = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryZone"u8))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"u8))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPlanA2AContent(
                instanceType,
                serializedAdditionalRawData,
                primaryZone,
                recoveryZone,
                primaryExtendedLocation,
                recoveryExtendedLocation);
        }

        BinaryData IPersistableModel<RecoveryPlanA2AContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanA2AContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanA2AContent IPersistableModel<RecoveryPlanA2AContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanA2AContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanA2AContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanA2AContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanA2AContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
