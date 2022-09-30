// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class LineRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelSecret))
            {
                writer.WritePropertyName("channelSecret");
                writer.WriteStringValue(ChannelSecret);
            }
            if (Optional.IsDefined(ChannelAccessToken))
            {
                writer.WritePropertyName("channelAccessToken");
                writer.WriteStringValue(ChannelAccessToken);
            }
            writer.WriteEndObject();
        }

        internal static LineRegistration DeserializeLineRegistration(JsonElement element)
        {
            Optional<string> generatedId = default;
            Optional<string> channelSecret = default;
            Optional<string> channelAccessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generatedId"))
                {
                    generatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelSecret"))
                {
                    channelSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelAccessToken"))
                {
                    channelAccessToken = property.Value.GetString();
                    continue;
                }
            }
            return new LineRegistration(generatedId.Value, channelSecret.Value, channelAccessToken.Value);
        }
    }
}
