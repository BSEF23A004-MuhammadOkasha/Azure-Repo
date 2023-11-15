// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    [PersistableModelProxy(typeof(UnknownThreeTierCustomResourceNames))]
    public partial class ThreeTierCustomResourceNames : IUtf8JsonSerializable, IJsonModel<ThreeTierCustomResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreeTierCustomResourceNames>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ThreeTierCustomResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ThreeTierCustomResourceNames>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ThreeTierCustomResourceNames>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("namingPatternType"u8);
            writer.WriteStringValue(NamingPatternType.ToString());
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

        ThreeTierCustomResourceNames IJsonModel<ThreeTierCustomResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ThreeTierCustomResourceNames)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreeTierCustomResourceNames(document.RootElement, options);
        }

        internal static ThreeTierCustomResourceNames DeserializeThreeTierCustomResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("namingPatternType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FullResourceName": return ThreeTierFullResourceNames.DeserializeThreeTierFullResourceNames(element);
                }
            }
            return UnknownThreeTierCustomResourceNames.DeserializeUnknownThreeTierCustomResourceNames(element);
        }

        BinaryData IPersistableModel<ThreeTierCustomResourceNames>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ThreeTierCustomResourceNames)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ThreeTierCustomResourceNames IPersistableModel<ThreeTierCustomResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ThreeTierCustomResourceNames)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeThreeTierCustomResourceNames(document.RootElement, options);
        }

        string IPersistableModel<ThreeTierCustomResourceNames>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
