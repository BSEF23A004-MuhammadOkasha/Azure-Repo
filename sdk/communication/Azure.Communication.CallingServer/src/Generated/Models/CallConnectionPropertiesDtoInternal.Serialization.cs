// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class CallConnectionPropertiesDtoInternal
    {
        internal static CallConnectionPropertiesDtoInternal DeserializeCallConnectionPropertiesDtoInternal(JsonElement element)
        {
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<CallSourceDto> source = default;
            Optional<IReadOnlyList<CommunicationIdentifierModel>> targets = default;
            Optional<CallConnectionState> callConnectionState = default;
            Optional<string> subject = default;
            Optional<string> callbackUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = CallSourceDto.DeserializeCallSourceDto(property.Value);
                    continue;
                }
                if (property.NameEquals("targets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("callConnectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
            }
            return new CallConnectionPropertiesDtoInternal(callConnectionId.Value, serverCallId.Value, source.Value, Optional.ToList(targets), Optional.ToNullable(callConnectionState), subject.Value, callbackUri.Value);
        }
    }
}
