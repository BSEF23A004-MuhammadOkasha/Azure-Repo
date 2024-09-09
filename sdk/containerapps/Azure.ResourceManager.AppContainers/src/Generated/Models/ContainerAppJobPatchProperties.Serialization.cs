// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppJobPatchProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppJobPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppJobPatchProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppJobPatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobPatchProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration, options);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template"u8);
                writer.WriteObjectValue(Template, options);
            }
            if (Optional.IsCollectionDefined(OutboundIPAddresses))
            {
                writer.WritePropertyName("outboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EventStreamEndpoint))
            {
                writer.WritePropertyName("eventStreamEndpoint"u8);
                writer.WriteStringValue(EventStreamEndpoint);
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
        }

        ContainerAppJobPatchProperties IJsonModel<ContainerAppJobPatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppJobPatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobPatchProperties(document.RootElement, options);
        }

        internal static ContainerAppJobPatchProperties DeserializeContainerAppJobPatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string environmentId = default;
            ContainerAppJobConfiguration configuration = default;
            ContainerAppJobTemplate template = default;
            IList<string> outboundIPAddresses = default;
            string eventStreamEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ContainerAppJobConfiguration.DeserializeContainerAppJobConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = ContainerAppJobTemplate.DeserializeContainerAppJobTemplate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outboundIpAddresses"u8))
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
                    outboundIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("eventStreamEndpoint"u8))
                {
                    eventStreamEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppJobPatchProperties(
                environmentId,
                configuration,
                template,
                outboundIPAddresses ?? new ChangeTrackingList<string>(),
                eventStreamEndpoint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppJobPatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobPatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppJobPatchProperties IPersistableModel<ContainerAppJobPatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppJobPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppJobPatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppJobPatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppJobPatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
