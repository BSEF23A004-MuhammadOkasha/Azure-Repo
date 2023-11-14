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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyEvaluationDetails : IUtf8JsonSerializable, IJsonModel<PolicyEvaluationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvaluationDetails>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PolicyEvaluationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PolicyEvaluationDetails>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PolicyEvaluationDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EvaluatedExpressions))
            {
                writer.WritePropertyName("evaluatedExpressions"u8);
                writer.WriteStartArray();
                foreach (var item in EvaluatedExpressions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IfNotExistsDetails))
            {
                writer.WritePropertyName("ifNotExistsDetails"u8);
                writer.WriteObjectValue(IfNotExistsDetails);
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

        PolicyEvaluationDetails IJsonModel<PolicyEvaluationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvaluationDetails(document.RootElement, options);
        }

        internal static PolicyEvaluationDetails DeserializePolicyEvaluationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExpressionEvaluationDetails>> evaluatedExpressions = default;
            Optional<IfNotExistsEvaluationDetails> ifNotExistsDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evaluatedExpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressionEvaluationDetails> array = new List<ExpressionEvaluationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressionEvaluationDetails.DeserializeExpressionEvaluationDetails(item));
                    }
                    evaluatedExpressions = array;
                    continue;
                }
                if (property.NameEquals("ifNotExistsDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ifNotExistsDetails = IfNotExistsEvaluationDetails.DeserializeIfNotExistsEvaluationDetails(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyEvaluationDetails(Optional.ToList(evaluatedExpressions), ifNotExistsDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyEvaluationDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PolicyEvaluationDetails IPersistableModel<PolicyEvaluationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePolicyEvaluationDetails(document.RootElement, options);
        }

        string IPersistableModel<PolicyEvaluationDetails>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
