// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionSafetyProfile : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionSafetyProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionSafetyProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryImageVersionSafetyProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsReportedForPolicyViolation))
            {
                writer.WritePropertyName("reportedForPolicyViolation"u8);
                writer.WriteBooleanValue(IsReportedForPolicyViolation.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PolicyViolations))
            {
                writer.WritePropertyName("policyViolations"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyViolations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowDeletionOfReplicatedLocations))
            {
                writer.WritePropertyName("allowDeletionOfReplicatedLocations"u8);
                writer.WriteBooleanValue(AllowDeletionOfReplicatedLocations.Value);
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

        GalleryImageVersionSafetyProfile IJsonModel<GalleryImageVersionSafetyProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionSafetyProfile(document.RootElement, options);
        }

        internal static GalleryImageVersionSafetyProfile DeserializeGalleryImageVersionSafetyProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? reportedForPolicyViolation = default;
            IReadOnlyList<GalleryImageVersionPolicyViolation> policyViolations = default;
            bool? allowDeletionOfReplicatedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reportedForPolicyViolation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportedForPolicyViolation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyViolations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryImageVersionPolicyViolation> array = new List<GalleryImageVersionPolicyViolation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryImageVersionPolicyViolation.DeserializeGalleryImageVersionPolicyViolation(item, options));
                    }
                    policyViolations = array;
                    continue;
                }
                if (property.NameEquals("allowDeletionOfReplicatedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowDeletionOfReplicatedLocations = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryImageVersionSafetyProfile(allowDeletionOfReplicatedLocations, serializedAdditionalRawData, reportedForPolicyViolation, policyViolations ?? new ChangeTrackingList<GalleryImageVersionPolicyViolation>());
        }

        BinaryData IPersistableModel<GalleryImageVersionSafetyProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{options.Format}' format.");
            }
        }

        GalleryImageVersionSafetyProfile IPersistableModel<GalleryImageVersionSafetyProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionSafetyProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryImageVersionSafetyProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionSafetyProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionSafetyProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
