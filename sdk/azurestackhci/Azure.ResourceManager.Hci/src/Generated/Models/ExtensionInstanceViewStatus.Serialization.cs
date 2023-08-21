// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ExtensionInstanceViewStatus
    {
        internal static ExtensionInstanceViewStatus DeserializeExtensionInstanceViewStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> code = default;
            Core.Optional<HciStatusLevelType> level = default;
            Core.Optional<string> displayStatus = default;
            Core.Optional<string> message = default;
            Core.Optional<DateTimeOffset> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new HciStatusLevelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ExtensionInstanceViewStatus(code.Value, Core.Optional.ToNullable(level), displayStatus.Value, message.Value, Core.Optional.ToNullable(time));
        }
    }
}
