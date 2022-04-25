// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainRecommendationSearchContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Keywords))
            {
                writer.WritePropertyName("keywords");
                writer.WriteStringValue(Keywords);
            }
            if (Optional.IsDefined(MaxDomainRecommendations))
            {
                writer.WritePropertyName("maxDomainRecommendations");
                writer.WriteNumberValue(MaxDomainRecommendations.Value);
            }
            writer.WriteEndObject();
        }
    }
}
