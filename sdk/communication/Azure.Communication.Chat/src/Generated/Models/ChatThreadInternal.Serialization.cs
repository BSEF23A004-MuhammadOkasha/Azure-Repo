// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatThreadInternal
    {
        internal static ChatThreadInternal DeserializeChatThreadInternal(JsonElement element)
        {
            string id = default;
            string topic = default;
            DateTimeOffset createdOn = default;
            CommunicationIdentifierModel createdBy = default;
            Optional<DateTimeOffset> deletedOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"))
                {
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("deletedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatThreadInternal(id, topic, createdOn, createdBy, Optional.ToNullable(deletedOn));
        }
    }
}
