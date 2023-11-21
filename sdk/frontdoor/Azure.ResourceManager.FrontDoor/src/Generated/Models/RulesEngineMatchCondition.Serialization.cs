// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RulesEngineMatchCondition : IUtf8JsonSerializable, IJsonModel<RulesEngineMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RulesEngineMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RulesEngineMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RulesEngineMatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("rulesEngineMatchVariable"u8);
            writer.WriteStringValue(RulesEngineMatchVariable.ToString());
            if (Optional.IsDefined(Selector))
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteStringValue(Selector);
            }
            writer.WritePropertyName("rulesEngineOperator"u8);
            writer.WriteStringValue(RulesEngineOperator.ToString());
            if (Optional.IsDefined(IsNegateCondition))
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(IsNegateCondition.Value);
            }
            writer.WritePropertyName("rulesEngineMatchValue"u8);
            writer.WriteStartArray();
            foreach (var item in RulesEngineMatchValue)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
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

        RulesEngineMatchCondition IJsonModel<RulesEngineMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RulesEngineMatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRulesEngineMatchCondition(document.RootElement, options);
        }

        internal static RulesEngineMatchCondition DeserializeRulesEngineMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RulesEngineMatchVariable rulesEngineMatchVariable = default;
            Optional<string> selector = default;
            RulesEngineOperator rulesEngineOperator = default;
            Optional<bool> negateCondition = default;
            IList<string> rulesEngineMatchValue = default;
            Optional<IList<RulesEngineMatchTransform>> transforms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rulesEngineMatchVariable"u8))
                {
                    rulesEngineMatchVariable = new RulesEngineMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rulesEngineOperator"u8))
                {
                    rulesEngineOperator = new RulesEngineOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rulesEngineMatchValue"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    rulesEngineMatchValue = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RulesEngineMatchTransform> array = new List<RulesEngineMatchTransform>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RulesEngineMatchTransform(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RulesEngineMatchCondition(rulesEngineMatchVariable, selector.Value, rulesEngineOperator, Optional.ToNullable(negateCondition), rulesEngineMatchValue, Optional.ToList(transforms), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RulesEngineMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RulesEngineMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        RulesEngineMatchCondition IPersistableModel<RulesEngineMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRulesEngineMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RulesEngineMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RulesEngineMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
