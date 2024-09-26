// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownAssetReferenceBase))]
    public partial class MachineLearningAssetReferenceBase : IUtf8JsonSerializable, IJsonModel<MachineLearningAssetReferenceBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAssetReferenceBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningAssetReferenceBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssetReferenceBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssetReferenceBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("referenceType"u8);
            writer.WriteStringValue(ReferenceType.ToString());
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
        }

        MachineLearningAssetReferenceBase IJsonModel<MachineLearningAssetReferenceBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssetReferenceBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAssetReferenceBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAssetReferenceBase(document.RootElement, options);
        }

        internal static MachineLearningAssetReferenceBase DeserializeMachineLearningAssetReferenceBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("referenceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataPath": return MachineLearningDataPathAssetReference.DeserializeMachineLearningDataPathAssetReference(element, options);
                    case "Id": return MachineLearningIdAssetReference.DeserializeMachineLearningIdAssetReference(element, options);
                    case "OutputPath": return MachineLearningOutputPathAssetReference.DeserializeMachineLearningOutputPathAssetReference(element, options);
                }
            }
            return UnknownAssetReferenceBase.DeserializeUnknownAssetReferenceBase(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReferenceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  referenceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  referenceType: ");
                builder.AppendLine($"'{ReferenceType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningAssetReferenceBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssetReferenceBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssetReferenceBase)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAssetReferenceBase IPersistableModel<MachineLearningAssetReferenceBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAssetReferenceBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAssetReferenceBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAssetReferenceBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAssetReferenceBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
