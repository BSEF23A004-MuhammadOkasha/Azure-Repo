// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SingleServerFullResourceNames : IUtf8JsonSerializable, IJsonModel<SingleServerFullResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleServerFullResourceNames>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SingleServerFullResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(VirtualMachine))
            {
                writer.WritePropertyName("virtualMachine"u8);
                writer.WriteObjectValue(VirtualMachine, options);
            }
        }

        SingleServerFullResourceNames IJsonModel<SingleServerFullResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleServerFullResourceNames(document.RootElement, options);
        }

        internal static SingleServerFullResourceNames DeserializeSingleServerFullResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualMachineResourceNames virtualMachine = default;
            SapNamingPatternType namingPatternType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachine = VirtualMachineResourceNames.DeserializeVirtualMachineResourceNames(property.Value, options);
                    continue;
                }
                if (property.NameEquals("namingPatternType"u8))
                {
                    namingPatternType = new SapNamingPatternType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SingleServerFullResourceNames(namingPatternType, serializedAdditionalRawData, virtualMachine);
        }

        BinaryData IPersistableModel<SingleServerFullResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support writing '{options.Format}' format.");
            }
        }

        SingleServerFullResourceNames IPersistableModel<SingleServerFullResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingleServerFullResourceNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingleServerFullResourceNames)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingleServerFullResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
