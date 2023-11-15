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

namespace Azure.Maps.Rendering
{
    public partial class RenderCopyright : IUtf8JsonSerializable, IJsonModel<RenderCopyright>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RenderCopyright>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RenderCopyright>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RenderCopyright>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RenderCopyright>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FormatVersion))
                {
                    writer.WritePropertyName("formatVersion"u8);
                    writer.WriteStringValue(FormatVersion);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(GeneralCopyrights))
                {
                    writer.WritePropertyName("generalCopyrights"u8);
                    writer.WriteStartArray();
                    foreach (var item in GeneralCopyrights)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(RegionalCopyrights))
                {
                    writer.WritePropertyName("regions"u8);
                    writer.WriteStartArray();
                    foreach (var item in RegionalCopyrights)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        RenderCopyright IJsonModel<RenderCopyright>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RenderCopyright)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRenderCopyright(document.RootElement, options);
        }

        internal static RenderCopyright DeserializeRenderCopyright(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> formatVersion = default;
            Optional<IReadOnlyList<string>> generalCopyrights = default;
            Optional<IReadOnlyList<RegionalCopyright>> regions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"u8))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generalCopyrights"u8))
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
                    generalCopyrights = array;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegionalCopyright> array = new List<RegionalCopyright>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalCopyright.DeserializeRegionalCopyright(item));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RenderCopyright(formatVersion.Value, Optional.ToList(generalCopyrights), Optional.ToList(regions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RenderCopyright>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RenderCopyright)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RenderCopyright IPersistableModel<RenderCopyright>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RenderCopyright)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRenderCopyright(document.RootElement, options);
        }

        string IPersistableModel<RenderCopyright>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
