// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerExecRequestTerminalSize : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Rows))
            {
                writer.WritePropertyName("rows"u8);
                writer.WriteNumberValue(Rows.Value);
            }
            if (Optional.IsDefined(Cols))
            {
                writer.WritePropertyName("cols"u8);
                writer.WriteNumberValue(Cols.Value);
            }
            writer.WriteEndObject();
        }
    }
}
