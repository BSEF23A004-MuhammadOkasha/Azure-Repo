// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class RegionSpecEntity : IUtf8JsonSerializable, IJsonModel<RegionSpecEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegionSpecEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegionSpecEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionSpecEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionSpecEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Cloud != null)
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud);
            }
            if (RegionName != null)
            {
                writer.WritePropertyName("regionName"u8);
                writer.WriteStringValue(RegionName);
            }
            if (!(Packages is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("packages"u8);
                writer.WriteStartArray();
                foreach (var item in Packages)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        RegionSpecEntity IJsonModel<RegionSpecEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionSpecEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionSpecEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegionSpecEntity(document.RootElement, options);
        }

        internal static RegionSpecEntity DeserializeRegionSpecEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> cloud = default;
            Optional<string> regionName = default;
            IReadOnlyList<string> packages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionName"u8))
                {
                    regionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    packages = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegionSpecEntity(name.Value, cloud.Value, regionName.Value, packages ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegionSpecEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionSpecEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegionSpecEntity)} does not support '{options.Format}' format.");
            }
        }

        RegionSpecEntity IPersistableModel<RegionSpecEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionSpecEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegionSpecEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegionSpecEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegionSpecEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
