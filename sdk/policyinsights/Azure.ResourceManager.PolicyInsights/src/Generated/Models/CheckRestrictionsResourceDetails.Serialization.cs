// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class CheckRestrictionsResourceDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceContent");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResourceContent);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(ResourceContent.ToString()).RootElement);
#endif
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            writer.WriteEndObject();
        }
    }
}
