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
    public partial class RemediationDeploymentSummary : IUtf8JsonSerializable, IJsonModel<RemediationDeploymentSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemediationDeploymentSummary>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RemediationDeploymentSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RemediationDeploymentSummary>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RemediationDeploymentSummary>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TotalDeployments))
                {
                    writer.WritePropertyName("totalDeployments"u8);
                    writer.WriteNumberValue(TotalDeployments.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SuccessfulDeployments))
                {
                    writer.WritePropertyName("successfulDeployments"u8);
                    writer.WriteNumberValue(SuccessfulDeployments.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FailedDeployments))
                {
                    writer.WritePropertyName("failedDeployments"u8);
                    writer.WriteNumberValue(FailedDeployments.Value);
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

        RemediationDeploymentSummary IJsonModel<RemediationDeploymentSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemediationDeploymentSummary(document.RootElement, options);
        }

        internal static RemediationDeploymentSummary DeserializeRemediationDeploymentSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> totalDeployments = default;
            Optional<int> successfulDeployments = default;
            Optional<int> failedDeployments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successfulDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfulDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedDeployments = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RemediationDeploymentSummary(Optional.ToNullable(totalDeployments), Optional.ToNullable(successfulDeployments), Optional.ToNullable(failedDeployments), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RemediationDeploymentSummary>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RemediationDeploymentSummary IPersistableModel<RemediationDeploymentSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemediationDeploymentSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRemediationDeploymentSummary(document.RootElement, options);
        }

        string IPersistableModel<RemediationDeploymentSummary>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
