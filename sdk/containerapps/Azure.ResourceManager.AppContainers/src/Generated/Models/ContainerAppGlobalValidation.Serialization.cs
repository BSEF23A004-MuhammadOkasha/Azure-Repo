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
    public partial class ContainerAppGlobalValidation : IUtf8JsonSerializable, IJsonModel<ContainerAppGlobalValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppGlobalValidation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppGlobalValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGlobalValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppGlobalValidation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UnauthenticatedClientAction))
            {
                writer.WritePropertyName("unauthenticatedClientAction"u8);
                writer.WriteStringValue(UnauthenticatedClientAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(RedirectToProvider))
            {
                writer.WritePropertyName("redirectToProvider"u8);
                writer.WriteStringValue(RedirectToProvider);
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
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

        ContainerAppGlobalValidation IJsonModel<ContainerAppGlobalValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGlobalValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppGlobalValidation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppGlobalValidation(document.RootElement, options);
        }

        internal static ContainerAppGlobalValidation DeserializeContainerAppGlobalValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppUnauthenticatedClientActionV2? unauthenticatedClientAction = default;
            string redirectToProvider = default;
            IList<string> excludedPaths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unauthenticatedClientAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unauthenticatedClientAction = property.Value.GetString().ToContainerAppUnauthenticatedClientActionV2();
                    continue;
                }
                if (property.NameEquals("redirectToProvider"u8))
                {
                    redirectToProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
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
                    excludedPaths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppGlobalValidation(unauthenticatedClientAction, redirectToProvider, excludedPaths ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppGlobalValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGlobalValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppGlobalValidation)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppGlobalValidation IPersistableModel<ContainerAppGlobalValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGlobalValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppGlobalValidation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppGlobalValidation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppGlobalValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
