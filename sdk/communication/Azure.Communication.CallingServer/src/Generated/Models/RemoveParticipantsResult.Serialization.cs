// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class RemoveParticipantsResult
    {
        internal static RemoveParticipantsResult DeserializeRemoveParticipantsResult(JsonElement element)
        {
            Optional<string> operationContext = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
            }
            return new RemoveParticipantsResult(operationContext.Value);
        }
    }
}
