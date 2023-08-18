// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseWorkspacePatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SqlAdministratorLoginPassword))
            {
                writer.WritePropertyName("sqlAdministratorLoginPassword"u8);
                writer.WriteStringValue(SqlAdministratorLoginPassword);
            }
            if (Core.Optional.IsDefined(ManagedVirtualNetworkSettings))
            {
                writer.WritePropertyName("managedVirtualNetworkSettings"u8);
                writer.WriteObjectValue(ManagedVirtualNetworkSettings);
            }
            if (Core.Optional.IsDefined(WorkspaceRepositoryConfiguration))
            {
                writer.WritePropertyName("workspaceRepositoryConfiguration"u8);
                writer.WriteObjectValue(WorkspaceRepositoryConfiguration);
            }
            if (Core.Optional.IsDefined(PurviewConfiguration))
            {
                writer.WritePropertyName("purviewConfiguration"u8);
                writer.WriteObjectValue(PurviewConfiguration);
            }
            if (Core.Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Core.Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
