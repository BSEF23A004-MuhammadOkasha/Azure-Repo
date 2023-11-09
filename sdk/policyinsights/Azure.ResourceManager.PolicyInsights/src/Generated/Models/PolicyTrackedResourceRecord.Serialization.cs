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
    public partial class PolicyTrackedResourceRecord : IUtf8JsonSerializable, IJsonModel<PolicyTrackedResourceRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyTrackedResourceRecord>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PolicyTrackedResourceRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TrackedResourceId))
                {
                    writer.WritePropertyName("trackedResourceId"u8);
                    writer.WriteStringValue(TrackedResourceId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PolicyDetails))
                {
                    writer.WritePropertyName("policyDetails"u8);
                    writer.WriteObjectValue(PolicyDetails);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CreatedBy))
                {
                    writer.WritePropertyName("createdBy"u8);
                    writer.WriteObjectValue(CreatedBy);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastModifiedBy))
                {
                    writer.WritePropertyName("lastModifiedBy"u8);
                    writer.WriteObjectValue(LastModifiedBy);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastUpdateOn))
                {
                    writer.WritePropertyName("lastUpdateUtc"u8);
                    writer.WriteStringValue(LastUpdateOn.Value, "O");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        PolicyTrackedResourceRecord IJsonModel<PolicyTrackedResourceRecord>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyTrackedResourceRecord)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyTrackedResourceRecord(document.RootElement, options);
        }

        internal static PolicyTrackedResourceRecord DeserializePolicyTrackedResourceRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> trackedResourceId = default;
            Optional<PolicyDetails> policyDetails = default;
            Optional<TrackedResourceModificationDetails> createdBy = default;
            Optional<TrackedResourceModificationDetails> lastModifiedBy = default;
            Optional<DateTimeOffset> lastUpdateUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackedResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackedResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDetails = PolicyDetails.DeserializePolicyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyTrackedResourceRecord(trackedResourceId.Value, policyDetails.Value, createdBy.Value, lastModifiedBy.Value, Optional.ToNullable(lastUpdateUtc), serializedAdditionalRawData);
        }

        BinaryData IModel<PolicyTrackedResourceRecord>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyTrackedResourceRecord)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PolicyTrackedResourceRecord IModel<PolicyTrackedResourceRecord>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyTrackedResourceRecord)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePolicyTrackedResourceRecord(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PolicyTrackedResourceRecord>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
