// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallTransferFailed
    {
        internal static CallTransferFailed DeserializeCallTransferFailed(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eventSource = default;
            Optional<string> operationContext = default;
            Optional<ResultInformation> resultInformation = default;
            Optional<string> version = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            Optional<string> publicEventType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSource"u8))
                {
                    eventSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicEventType"u8))
                {
                    publicEventType = property.Value.GetString();
                    continue;
                }
            }
            return new CallTransferFailed(eventSource.Value, operationContext.Value, resultInformation.Value, version.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, publicEventType.Value);
        }
    }
}
