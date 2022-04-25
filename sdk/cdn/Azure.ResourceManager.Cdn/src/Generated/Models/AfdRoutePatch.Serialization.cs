// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdRoutePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains");
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginGroup))
            {
                writer.WritePropertyName("originGroup");
                JsonSerializer.Serialize(writer, OriginGroup);
            }
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath");
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(RuleSets))
            {
                writer.WritePropertyName("ruleSets");
                writer.WriteStartArray();
                foreach (var item in RuleSets)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedProtocols))
            {
                writer.WritePropertyName("supportedProtocols");
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch");
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CacheConfiguration))
            {
                if (CacheConfiguration != null)
                {
                    writer.WritePropertyName("cacheConfiguration");
                    writer.WriteObjectValue(CacheConfiguration);
                }
                else
                {
                    writer.WriteNull("cacheConfiguration");
                }
            }
            if (Optional.IsDefined(ForwardingProtocol))
            {
                writer.WritePropertyName("forwardingProtocol");
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            if (Optional.IsDefined(LinkToDefaultDomain))
            {
                writer.WritePropertyName("linkToDefaultDomain");
                writer.WriteStringValue(LinkToDefaultDomain.Value.ToString());
            }
            if (Optional.IsDefined(HttpsRedirect))
            {
                writer.WritePropertyName("httpsRedirect");
                writer.WriteStringValue(HttpsRedirect.Value.ToString());
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
