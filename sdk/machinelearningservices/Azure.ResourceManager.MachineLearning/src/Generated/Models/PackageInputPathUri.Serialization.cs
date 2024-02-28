// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PackageInputPathUri : IUtf8JsonSerializable, IJsonModel<PackageInputPathUri>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PackageInputPathUri>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PackageInputPathUri>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathUri)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Uri != null)
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            writer.WritePropertyName("inputPathType"u8);
            writer.WriteStringValue(InputPathType.ToString());
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

        PackageInputPathUri IJsonModel<PackageInputPathUri>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathUri>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathUri)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePackageInputPathUri(document.RootElement, options);
        }

        internal static PackageInputPathUri DeserializePackageInputPathUri(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            InputPathType inputPathType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inputPathType"u8))
                {
                    inputPathType = new InputPathType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PackageInputPathUri(inputPathType, serializedAdditionalRawData, url);
        }

        BinaryData IPersistableModel<PackageInputPathUri>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathUri)} does not support '{options.Format}' format.");
            }
        }

        PackageInputPathUri IPersistableModel<PackageInputPathUri>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathUri>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePackageInputPathUri(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathUri)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PackageInputPathUri>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
