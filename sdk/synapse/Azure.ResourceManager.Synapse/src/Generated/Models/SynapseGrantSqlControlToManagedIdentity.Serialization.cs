// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseGrantSqlControlToManagedIdentity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SynapseGrantSqlControlToManagedIdentity DeserializeSynapseGrantSqlControlToManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<SynapseDesiredState> desiredState = default;
            Core.Optional<SynapseGrantSqlControlToManagedIdentityState> actualState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desiredState = property.Value.GetString().ToSynapseDesiredState();
                    continue;
                }
                if (property.NameEquals("actualState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actualState = property.Value.GetString().ToSynapseGrantSqlControlToManagedIdentityState();
                    continue;
                }
            }
            return new SynapseGrantSqlControlToManagedIdentity(Core.Optional.ToNullable(desiredState), Core.Optional.ToNullable(actualState));
        }
    }
}
