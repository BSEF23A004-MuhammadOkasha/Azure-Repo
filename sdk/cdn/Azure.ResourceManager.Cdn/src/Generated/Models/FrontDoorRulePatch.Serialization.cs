// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorRulePatch : IUtf8JsonSerializable, IJsonModel<FrontDoorRulePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorRulePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorRulePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRulePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RuleSetName))
            {
                writer.WritePropertyName("ruleSetName"u8);
                writer.WriteStringValue(RuleSetName);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MatchProcessingBehavior))
            {
                writer.WritePropertyName("matchProcessingBehavior"u8);
                writer.WriteStringValue(MatchProcessingBehavior.Value.ToString());
            }
            writer.WriteEndObject();
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

        FrontDoorRulePatch IJsonModel<FrontDoorRulePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRulePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorRulePatch(document.RootElement, options);
        }

        internal static FrontDoorRulePatch DeserializeFrontDoorRulePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ruleSetName = default;
            Optional<int> order = default;
            Optional<IList<DeliveryRuleCondition>> conditions = default;
            Optional<IList<DeliveryRuleAction>> actions = default;
            Optional<MatchProcessingBehavior> matchProcessingBehavior = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ruleSetName"u8))
                        {
                            ruleSetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("order"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            order = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("conditions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryRuleCondition> array = new List<DeliveryRuleCondition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryRuleCondition.DeserializeDeliveryRuleCondition(item, options));
                            }
                            conditions = array;
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryRuleAction> array = new List<DeliveryRuleAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryRuleAction.DeserializeDeliveryRuleAction(item, options));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("matchProcessingBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            matchProcessingBehavior = new MatchProcessingBehavior(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorRulePatch(ruleSetName.Value, Optional.ToNullable(order), Optional.ToList(conditions), Optional.ToList(actions), Optional.ToNullable(matchProcessingBehavior), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorRulePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRulePatch)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorRulePatch IPersistableModel<FrontDoorRulePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorRulePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRulePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorRulePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
