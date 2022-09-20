// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterRunCommandContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("command");
            writer.WriteStringValue(Command);
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            if (Optional.IsDefined(ClusterToken))
            {
                writer.WritePropertyName("clusterToken");
                writer.WriteStringValue(ClusterToken);
            }
            writer.WriteEndObject();
        }
    }
}
