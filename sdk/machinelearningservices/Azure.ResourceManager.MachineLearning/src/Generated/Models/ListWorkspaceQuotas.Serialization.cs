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

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ListWorkspaceQuotas : IUtf8JsonSerializable, IJsonModel<ListWorkspaceQuotas>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ListWorkspaceQuotas>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ListWorkspaceQuotas>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ListWorkspaceQuotas>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ListWorkspaceQuotas>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Value))
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteStartArray();
                    foreach (var item in Value)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NextLink))
                {
                    writer.WritePropertyName("nextLink"u8);
                    writer.WriteStringValue(NextLink);
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

        ListWorkspaceQuotas IJsonModel<ListWorkspaceQuotas>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ListWorkspaceQuotas)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeListWorkspaceQuotas(document.RootElement, options);
        }

        internal static ListWorkspaceQuotas DeserializeListWorkspaceQuotas(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MachineLearningResourceQuota>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningResourceQuota> array = new List<MachineLearningResourceQuota>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningResourceQuota.DeserializeMachineLearningResourceQuota(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ListWorkspaceQuotas(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ListWorkspaceQuotas>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ListWorkspaceQuotas)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ListWorkspaceQuotas IPersistableModel<ListWorkspaceQuotas>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ListWorkspaceQuotas)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeListWorkspaceQuotas(document.RootElement, options);
        }

        string IPersistableModel<ListWorkspaceQuotas>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
