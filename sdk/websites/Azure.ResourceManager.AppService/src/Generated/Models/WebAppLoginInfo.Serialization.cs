// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppLoginInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Core.Optional.IsDefined(TokenStore))
            {
                writer.WritePropertyName("tokenStore"u8);
                writer.WriteObjectValue(TokenStore);
            }
            if (Core.Optional.IsDefined(PreserveUrlFragmentsForLogins))
            {
                writer.WritePropertyName("preserveUrlFragmentsForLogins"u8);
                writer.WriteBooleanValue(PreserveUrlFragmentsForLogins.Value);
            }
            if (Core.Optional.IsCollectionDefined(AllowedExternalRedirectUrls))
            {
                writer.WritePropertyName("allowedExternalRedirectUrls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedExternalRedirectUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(CookieExpiration))
            {
                writer.WritePropertyName("cookieExpiration"u8);
                writer.WriteObjectValue(CookieExpiration);
            }
            if (Core.Optional.IsDefined(Nonce))
            {
                writer.WritePropertyName("nonce"u8);
                writer.WriteObjectValue(Nonce);
            }
            writer.WriteEndObject();
        }

        internal static WebAppLoginInfo DeserializeWebAppLoginInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<LoginRoutes> routes = default;
            Core.Optional<AppServiceTokenStore> tokenStore = default;
            Core.Optional<bool> preserveUrlFragmentsForLogins = default;
            Core.Optional<IList<string>> allowedExternalRedirectUrls = default;
            Core.Optional<WebAppCookieExpiration> cookieExpiration = default;
            Core.Optional<LoginFlowNonceSettings> nonce = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = LoginRoutes.DeserializeLoginRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("tokenStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenStore = AppServiceTokenStore.DeserializeAppServiceTokenStore(property.Value);
                    continue;
                }
                if (property.NameEquals("preserveUrlFragmentsForLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUrlFragmentsForLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedExternalRedirectUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedExternalRedirectUrls = array;
                    continue;
                }
                if (property.NameEquals("cookieExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cookieExpiration = WebAppCookieExpiration.DeserializeWebAppCookieExpiration(property.Value);
                    continue;
                }
                if (property.NameEquals("nonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonce = LoginFlowNonceSettings.DeserializeLoginFlowNonceSettings(property.Value);
                    continue;
                }
            }
            return new WebAppLoginInfo(routes.Value, tokenStore.Value, Core.Optional.ToNullable(preserveUrlFragmentsForLogins), Core.Optional.ToList(allowedExternalRedirectUrls), cookieExpiration.Value, nonce.Value);
        }
    }
}
