// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ManagedIntegrationRuntimeConverter))]
    public partial class ManagedIntegrationRuntime : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork"u8);
                writer.WriteObjectValue(ManagedVirtualNetwork);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ComputeProperties))
            {
                writer.WritePropertyName("computeProperties"u8);
                writer.WriteObjectValue(ComputeProperties);
            }
            if (Core.Optional.IsDefined(SsisProperties))
            {
                writer.WritePropertyName("ssisProperties"u8);
                writer.WriteObjectValue(SsisProperties);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedIntegrationRuntime DeserializeManagedIntegrationRuntime(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IntegrationRuntimeState> state = default;
            Core.Optional<ManagedVirtualNetworkReference> managedVirtualNetwork = default;
            IntegrationRuntimeType type = default;
            Core.Optional<string> description = default;
            Core.Optional<IntegrationRuntimeComputeProperties> computeProperties = default;
            Core.Optional<IntegrationRuntimeSsisProperties> ssisProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedVirtualNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedVirtualNetwork = ManagedVirtualNetworkReference.DeserializeManagedVirtualNetworkReference(property.Value);
                    continue;
                }
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
                        if (property0.NameEquals("computeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeProperties = IntegrationRuntimeComputeProperties.DeserializeIntegrationRuntimeComputeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ssisProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssisProperties = IntegrationRuntimeSsisProperties.DeserializeIntegrationRuntimeSsisProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntime(type, description.Value, additionalProperties, Core.Optional.ToNullable(state), managedVirtualNetwork.Value, computeProperties.Value, ssisProperties.Value);
        }

        internal partial class ManagedIntegrationRuntimeConverter : JsonConverter<ManagedIntegrationRuntime>
        {
            public override void Write(Utf8JsonWriter writer, ManagedIntegrationRuntime model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ManagedIntegrationRuntime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeManagedIntegrationRuntime(document.RootElement);
            }
        }
    }
}
