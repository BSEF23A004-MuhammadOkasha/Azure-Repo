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

namespace Azure.ResourceManager.Network.Models
{
    public partial class PolicySettingsLogScrubbing : IUtf8JsonSerializable, IJsonModel<PolicySettingsLogScrubbing>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySettingsLogScrubbing>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PolicySettingsLogScrubbing>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScrubbingRules))
            {
                writer.WritePropertyName("scrubbingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ScrubbingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PolicySettingsLogScrubbing IJsonModel<PolicySettingsLogScrubbing>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySettingsLogScrubbing(document.RootElement, options);
        }

        internal static PolicySettingsLogScrubbing DeserializePolicySettingsLogScrubbing(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WebApplicationFirewallScrubbingState> state = default;
            Optional<IList<WebApplicationFirewallScrubbingRules>> scrubbingRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new WebApplicationFirewallScrubbingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scrubbingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebApplicationFirewallScrubbingRules> array = new List<WebApplicationFirewallScrubbingRules>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationFirewallScrubbingRules.DeserializeWebApplicationFirewallScrubbingRules(item));
                    }
                    scrubbingRules = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicySettingsLogScrubbing(Optional.ToNullable(state), Optional.ToList(scrubbingRules), serializedAdditionalRawData);
        }

        BinaryData IModel<PolicySettingsLogScrubbing>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PolicySettingsLogScrubbing IModel<PolicySettingsLogScrubbing>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePolicySettingsLogScrubbing(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PolicySettingsLogScrubbing>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
