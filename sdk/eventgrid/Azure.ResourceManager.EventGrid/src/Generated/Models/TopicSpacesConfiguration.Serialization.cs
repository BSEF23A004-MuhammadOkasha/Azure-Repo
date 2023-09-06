// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class TopicSpacesConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<TopicSpacesConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TopicSpacesConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TopicSpacesConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TopicSpacesConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(RouteTopicResourceId))
            {
                writer.WritePropertyName("routeTopicResourceId"u8);
                writer.WriteStringValue(RouteTopicResourceId);
            }
            if (Optional.IsDefined(RoutingEnrichments))
            {
                writer.WritePropertyName("routingEnrichments"u8);
                if (RoutingEnrichments is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingEnrichments>)RoutingEnrichments).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                if (ClientAuthentication is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClientAuthenticationSettings>)ClientAuthentication).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MaximumSessionExpiryInHours))
            {
                writer.WritePropertyName("maximumSessionExpiryInHours"u8);
                writer.WriteNumberValue(MaximumSessionExpiryInHours.Value);
            }
            if (Optional.IsDefined(MaximumClientSessionsPerAuthenticationName))
            {
                writer.WritePropertyName("maximumClientSessionsPerAuthenticationName"u8);
                writer.WriteNumberValue(MaximumClientSessionsPerAuthenticationName.Value);
            }
            if (Optional.IsDefined(RoutingIdentityInfo))
            {
                writer.WritePropertyName("routingIdentityInfo"u8);
                if (RoutingIdentityInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingIdentityInfo>)RoutingIdentityInfo).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static TopicSpacesConfiguration DeserializeTopicSpacesConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TopicSpacesConfigurationState> state = default;
            Optional<string> routeTopicResourceId = default;
            Optional<string> hostname = default;
            Optional<RoutingEnrichments> routingEnrichments = default;
            Optional<ClientAuthenticationSettings> clientAuthentication = default;
            Optional<int> maximumSessionExpiryInHours = default;
            Optional<int> maximumClientSessionsPerAuthenticationName = default;
            Optional<RoutingIdentityInfo> routingIdentityInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TopicSpacesConfigurationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routeTopicResourceId"u8))
                {
                    routeTopicResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingEnrichments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingEnrichments = RoutingEnrichments.DeserializeRoutingEnrichments(property.Value);
                    continue;
                }
                if (property.NameEquals("clientAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAuthentication = ClientAuthenticationSettings.DeserializeClientAuthenticationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("maximumSessionExpiryInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumSessionExpiryInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumClientSessionsPerAuthenticationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumClientSessionsPerAuthenticationName = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("routingIdentityInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingIdentityInfo = RoutingIdentityInfo.DeserializeRoutingIdentityInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TopicSpacesConfiguration(Optional.ToNullable(state), routeTopicResourceId.Value, hostname.Value, routingEnrichments.Value, clientAuthentication.Value, Optional.ToNullable(maximumSessionExpiryInHours), Optional.ToNullable(maximumClientSessionsPerAuthenticationName), routingIdentityInfo.Value, rawData);
        }

        TopicSpacesConfiguration IModelJsonSerializable<TopicSpacesConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TopicSpacesConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicSpacesConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TopicSpacesConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TopicSpacesConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TopicSpacesConfiguration IModelSerializable<TopicSpacesConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TopicSpacesConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTopicSpacesConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TopicSpacesConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TopicSpacesConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(TopicSpacesConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TopicSpacesConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TopicSpacesConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTopicSpacesConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
