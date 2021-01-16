// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.Administration;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    internal partial class CommunicationIdentityAccessTokenResult
    {
        internal static CommunicationIdentityAccessTokenResult DeserializeCommunicationIdentityAccessTokenResult(JsonElement element)
        {
            CommunicationIdentity identity = default;
            Optional<CommunicationUserToken> accessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    identity = CommunicationIdentity.DeserializeCommunicationIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("accessToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessToken = CommunicationUserToken.DeserializeCommunicationUserToken(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentityAccessTokenResult(identity, accessToken.Value);
        }
    }
}
