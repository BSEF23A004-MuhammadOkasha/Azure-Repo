// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WorkspaceIdentityConverter))]
    public partial class WorkspaceIdentity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WriteEndObject();
        }

        internal static WorkspaceIdentity DeserializeWorkspaceIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WorkspaceIdentityType type = default;
            Core.Optional<string> principalId = default;
            Core.Optional<string> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new WorkspaceIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
            }
            return new WorkspaceIdentity(type, principalId.Value, tenantId.Value);
        }

        internal partial class WorkspaceIdentityConverter : JsonConverter<WorkspaceIdentity>
        {
            public override void Write(Utf8JsonWriter writer, WorkspaceIdentity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WorkspaceIdentity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWorkspaceIdentity(document.RootElement);
            }
        }
    }
}
