// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ACSChatThreadPropertiesUpdatedPerUserEventData
    {
        internal static ACSChatThreadPropertiesUpdatedPerUserEventData DeserializeACSChatThreadPropertiesUpdatedPerUserEventData(JsonElement element)
        {
            Optional<string> editedBy = default;
            Optional<DateTimeOffset> editTime = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<string> recipientId = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("editedBy"))
                {
                    editedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("editTime"))
                {
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("createTime"))
                {
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientId"))
                {
                    recipientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new ACSChatThreadPropertiesUpdatedPerUserEventData(recipientId.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), editedBy.Value, Optional.ToNullable(editTime), Optional.ToDictionary(properties));
        }
    }
}
