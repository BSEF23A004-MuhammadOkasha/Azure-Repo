// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

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
            if (RevisionSuffix != null)
            {
                writer.WritePropertyName("revisionSuffix"u8);
                writer.WriteStringValue(RevisionSuffix);
            }
            if (TerminationGracePeriodSeconds.HasValue)
            {
                writer.WritePropertyName("terminationGracePeriodSeconds"u8);
                writer.WriteNumberValue(TerminationGracePeriodSeconds.Value);
            }
            if (!(InitContainers is ChangeTrackingList<ContainerAppInitContainer> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Containers is ChangeTrackingList<ContainerAppContainer> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Scale != null)
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue(Scale);
            }
            if (!(Volumes is ChangeTrackingList<ContainerAppVolume> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceBinds is ChangeTrackingList<ContainerAppServiceBind> collection2 && collection2.IsUndefined))
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
            string revisionSuffix = default;
            long? terminationGracePeriodSeconds = default;
            IList<ContainerAppInitContainer> initContainers = default;
            IList<ContainerAppContainer> containers = default;
            ContainerAppScale scale = default;
            IList<ContainerAppVolume> volumes = default;
            IList<ContainerAppServiceBind> serviceBinds = default;
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
            return new ContainerAppTemplate(
                revisionSuffix,
                terminationGracePeriodSeconds,
                initContainers ?? new ChangeTrackingList<ContainerAppInitContainer>(),
                containers ?? new ChangeTrackingList<ContainerAppContainer>(),
                scale,
                volumes ?? new ChangeTrackingList<ContainerAppVolume>(),
                serviceBinds ?? new ChangeTrackingList<ContainerAppServiceBind>(),
                serializedAdditionalRawData);
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
