// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    [ModelReaderProxy(typeof(UnknownFirewallPolicyRuleCollection))]
    public partial class FirewallPolicyRuleCollectionInfo : IUtf8JsonSerializable, IJsonModel<FirewallPolicyRuleCollectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyRuleCollectionInfo>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FirewallPolicyRuleCollectionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleCollectionType"u8);
            writer.WriteStringValue(RuleCollectionType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
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

        FirewallPolicyRuleCollectionInfo IJsonModel<FirewallPolicyRuleCollectionInfo>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallPolicyRuleCollectionInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyRuleCollectionInfo(document.RootElement, options);
        }

        internal static FirewallPolicyRuleCollectionInfo DeserializeFirewallPolicyRuleCollectionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleCollectionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FirewallPolicyFilterRuleCollection": return FirewallPolicyFilterRuleCollectionInfo.DeserializeFirewallPolicyFilterRuleCollectionInfo(element);
                    case "FirewallPolicyNatRuleCollection": return FirewallPolicyNatRuleCollectionInfo.DeserializeFirewallPolicyNatRuleCollectionInfo(element);
                }
            }
            return UnknownFirewallPolicyRuleCollection.DeserializeUnknownFirewallPolicyRuleCollection(element);
        }

        BinaryData IModel<FirewallPolicyRuleCollectionInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallPolicyRuleCollectionInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirewallPolicyRuleCollectionInfo IModel<FirewallPolicyRuleCollectionInfo>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallPolicyRuleCollectionInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirewallPolicyRuleCollectionInfo(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FirewallPolicyRuleCollectionInfo>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
