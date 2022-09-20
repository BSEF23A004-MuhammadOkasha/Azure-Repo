// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class AdlsGen2FolderDataSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("fileSystem");
            writer.WriteStringValue(FileSystem);
            writer.WritePropertyName("folderPath");
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("resourceGroup");
            writer.WriteStringValue(ResourceGroup);
            writer.WritePropertyName("storageAccountName");
            writer.WriteStringValue(StorageAccountName);
            writer.WritePropertyName("subscriptionId");
            writer.WriteStringValue(SubscriptionId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AdlsGen2FolderDataSet DeserializeAdlsGen2FolderDataSet(JsonElement element)
        {
            DataSetKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> dataSetId = default;
            string fileSystem = default;
            string folderPath = default;
            string resourceGroup = default;
            string storageAccountName = default;
            string subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataSetKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataSetId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("fileSystem"))
                        {
                            fileSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountName"))
                        {
                            storageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AdlsGen2FolderDataSet(id, name, type, systemData.Value, kind, Optional.ToNullable(dataSetId), fileSystem, folderPath, resourceGroup, storageAccountName, subscriptionId);
        }
    }
}
