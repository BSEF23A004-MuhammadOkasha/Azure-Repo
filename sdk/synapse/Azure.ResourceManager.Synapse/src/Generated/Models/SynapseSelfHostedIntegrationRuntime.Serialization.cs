// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntime : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IntegrationRuntimeType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedInfo))
            {
                writer.WritePropertyName("linkedInfo"u8);
                writer.WriteObjectValue(LinkedInfo);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SynapseSelfHostedIntegrationRuntime DeserializeSynapseSelfHostedIntegrationRuntime(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> description = default;
            Optional<SynapseLinkedIntegrationRuntimeType> linkedInfo = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkedInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedInfo = SynapseLinkedIntegrationRuntimeType.DeserializeSynapseLinkedIntegrationRuntimeType(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntime(type, description.Value, additionalProperties, linkedInfo.Value);
        }
    }
}
