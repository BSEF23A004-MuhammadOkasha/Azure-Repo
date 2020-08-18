// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class AzureFilesIdentityBasedAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("directoryServiceOptions");
            writer.WriteStringValue(DirectoryServiceOptions.ToString());
            if (Optional.IsDefined(ActiveDirectoryProperties))
            {
                writer.WritePropertyName("activeDirectoryProperties");
                writer.WriteObjectValue(ActiveDirectoryProperties);
            }
            writer.WriteEndObject();
        }

        internal static AzureFilesIdentityBasedAuthentication DeserializeAzureFilesIdentityBasedAuthentication(JsonElement element)
        {
            DirectoryServiceOptions directoryServiceOptions = default;
            Optional<ActiveDirectoryProperties> activeDirectoryProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directoryServiceOptions"))
                {
                    directoryServiceOptions = new DirectoryServiceOptions(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activeDirectoryProperties"))
                {
                    activeDirectoryProperties = ActiveDirectoryProperties.DeserializeActiveDirectoryProperties(property.Value);
                    continue;
                }
            }
            return new AzureFilesIdentityBasedAuthentication(directoryServiceOptions, activeDirectoryProperties.Value);
        }
    }
}
