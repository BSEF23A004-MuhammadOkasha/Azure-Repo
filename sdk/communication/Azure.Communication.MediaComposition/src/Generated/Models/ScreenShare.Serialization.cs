// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class ScreenShare : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("call");
            writer.WriteStringValue(Call);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri");
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static ScreenShare DeserializeScreenShare(JsonElement element)
        {
            string call = default;
            MediaInputType kind = default;
            Optional<string> placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("call"))
                {
                    call = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new ScreenShare(kind, placeholderImageUri.Value, call);
        }
    }
}
