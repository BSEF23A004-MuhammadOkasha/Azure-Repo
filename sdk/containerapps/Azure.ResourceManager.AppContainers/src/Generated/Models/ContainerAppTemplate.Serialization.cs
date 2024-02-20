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
    public partial class ContainerAppTemplate : IUtf8JsonSerializable, IJsonModel<ContainerAppTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RevisionSuffix))
            {
                writer.WritePropertyName("revisionSuffix"u8);
                writer.WriteStringValue(RevisionSuffix);
            }
            if (Optional.IsDefined(TerminationGracePeriodSeconds))
            {
                writer.WritePropertyName("terminationGracePeriodSeconds"u8);
                writer.WriteNumberValue(TerminationGracePeriodSeconds.Value);
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Scale))
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue(Scale);
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceBinds))
            {
                writer.WritePropertyName("serviceBinds"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBinds)
                {
                    writer.WriteObjectValue(item);
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

        ContainerAppTemplate IJsonModel<ContainerAppTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppTemplate(document.RootElement, options);
        }

        internal static ContainerAppTemplate DeserializeContainerAppTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> revisionSuffix = default;
            Optional<long> terminationGracePeriodSeconds = default;
            Optional<IList<ContainerAppInitContainer>> initContainers = default;
            Optional<IList<ContainerAppContainer>> containers = default;
            Optional<ContainerAppScale> scale = default;
            Optional<IList<ContainerAppVolume>> volumes = default;
            Optional<IList<ContainerAppServiceBind>> serviceBinds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("revisionSuffix"u8))
                {
                    revisionSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terminationGracePeriodSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminationGracePeriodSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppInitContainer> array = new List<ContainerAppInitContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppInitContainer.DeserializeContainerAppInitContainer(item, options));
                    }
                    initContainers = array;
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppContainer> array = new List<ContainerAppContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppContainer.DeserializeContainerAppContainer(item, options));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = ContainerAppScale.DeserializeContainerAppScale(property.Value, options);
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolume> array = new List<ContainerAppVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolume.DeserializeContainerAppVolume(item, options));
                    }
                    volumes = array;
                    continue;
                }
                if (property.NameEquals("serviceBinds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppServiceBind> array = new List<ContainerAppServiceBind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppServiceBind.DeserializeContainerAppServiceBind(item, options));
                    }
                    serviceBinds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppTemplate(revisionSuffix.Value, Optional.ToNullable(terminationGracePeriodSeconds), Optional.ToList(initContainers), Optional.ToList(containers), scale.Value, Optional.ToList(volumes), Optional.ToList(serviceBinds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTemplate)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppTemplate IPersistableModel<ContainerAppTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
