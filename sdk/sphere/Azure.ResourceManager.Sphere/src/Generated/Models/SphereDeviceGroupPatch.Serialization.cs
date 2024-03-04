// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class SphereDeviceGroupPatch : IUtf8JsonSerializable, IJsonModel<SphereDeviceGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SphereDeviceGroupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SphereDeviceGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereDeviceGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SphereDeviceGroupPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(OSFeedType))
            {
                writer.WritePropertyName("osFeedType"u8);
                writer.WriteStringValue(OSFeedType.Value.ToString());
            }
            if (Optional.IsDefined(UpdatePolicy))
            {
                writer.WritePropertyName("updatePolicy"u8);
                writer.WriteStringValue(UpdatePolicy.Value.ToString());
            }
            if (Optional.IsDefined(AllowCrashDumpsCollection))
            {
                writer.WritePropertyName("allowCrashDumpsCollection"u8);
                writer.WriteStringValue(AllowCrashDumpsCollection.Value.ToString());
            }
            if (Optional.IsDefined(RegionalDataBoundary))
            {
                writer.WritePropertyName("regionalDataBoundary"u8);
                writer.WriteStringValue(RegionalDataBoundary.Value.ToString());
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

        SphereDeviceGroupPatch IJsonModel<SphereDeviceGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereDeviceGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SphereDeviceGroupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSphereDeviceGroupPatch(document.RootElement, options);
        }

        internal static SphereDeviceGroupPatch DeserializeSphereDeviceGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            SphereOSFeedType? osFeedType = default;
            SphereUpdatePolicy? updatePolicy = default;
            SphereAllowCrashDumpCollectionStatus? allowCrashDumpsCollection = default;
            RegionalDataBoundary? regionalDataBoundary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osFeedType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osFeedType = new SphereOSFeedType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("updatePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatePolicy = new SphereUpdatePolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowCrashDumpsCollection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowCrashDumpsCollection = new SphereAllowCrashDumpCollectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("regionalDataBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            regionalDataBoundary = new RegionalDataBoundary(property0.Value.GetString());
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
            return new SphereDeviceGroupPatch(
                description,
                osFeedType,
                updatePolicy,
                allowCrashDumpsCollection,
                regionalDataBoundary,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SphereDeviceGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereDeviceGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SphereDeviceGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        SphereDeviceGroupPatch IPersistableModel<SphereDeviceGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereDeviceGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSphereDeviceGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SphereDeviceGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SphereDeviceGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
