// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class LineChannelProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lineRegistrations"u8);
            writer.WriteStartArray();
            foreach (var item in LineRegistrations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static LineChannelProperties DeserializeLineChannelProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LineRegistration> lineRegistrations = default;
            Core.Optional<Uri> callbackUrl = default;
            Core.Optional<bool> isValidated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lineRegistrations"u8))
                {
                    List<LineRegistration> array = new List<LineRegistration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LineRegistration.DeserializeLineRegistration(item));
                    }
                    lineRegistrations = array;
                    continue;
                }
                if (property.NameEquals("callbackUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isValidated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isValidated = property.Value.GetBoolean();
                    continue;
                }
            }
            return new LineChannelProperties(lineRegistrations, callbackUrl.Value, Core.Optional.ToNullable(isValidated));
        }
    }
}
