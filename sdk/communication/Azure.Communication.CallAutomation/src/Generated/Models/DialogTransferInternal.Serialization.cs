// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.CallAutomation;
using Azure.Core;

namespace Azure.Communication.CallAutomation.Models.Events
{
    internal partial class DialogTransferInternal
    {
        internal static DialogTransferInternal DeserializeDialogTransferInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> callConnectionId = default;
            Core.Optional<string> serverCallId = default;
            Core.Optional<string> correlationId = default;
            Core.Optional<string> operationContext = default;
            Core.Optional<ResultInformation> resultInformation = default;
            Core.Optional<DialogInputType> dialogInputType = default;
            Core.Optional<string> dialogId = default;
            Core.Optional<string> transferType = default;
            Core.Optional<string> transferDestination = default;
            Core.Optional<object> ivrContext = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("dialogInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dialogInputType = new DialogInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dialogId"u8))
                {
                    dialogId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferType"u8))
                {
                    transferType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferDestination"u8))
                {
                    transferDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ivrContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ivrContext = property.Value.GetObject();
                    continue;
                }
            }
            return new DialogTransferInternal(callConnectionId.Value, serverCallId.Value, correlationId.Value, operationContext.Value, resultInformation.Value, Core.Optional.ToNullable(dialogInputType), dialogId.Value, transferType.Value, transferDestination.Value, ivrContext.Value);
        }
    }
}
