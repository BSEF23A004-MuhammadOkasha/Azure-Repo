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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class WebApplicationFirewallPolicyData : IUtf8JsonSerializable, IModelJsonSerializable<WebApplicationFirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebApplicationFirewallPolicyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebApplicationFirewallPolicyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebApplicationFirewallPolicyData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings"u8);
                if (PolicySettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PolicySettings>)PolicySettings).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(CustomRules))
            {
                writer.WritePropertyName("customRules"u8);
                writer.WriteStartArray();
                foreach (var item in CustomRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<WebApplicationFirewallCustomRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules"u8);
                if (ManagedRules is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedRulesDefinition>)ManagedRules).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
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

        internal static WebApplicationFirewallPolicyData DeserializeWebApplicationFirewallPolicyData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<PolicySettings> policySettings = default;
            Optional<IList<WebApplicationFirewallCustomRule>> customRules = default;
            Optional<IReadOnlyList<ApplicationGatewayData>> applicationGateways = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<WebApplicationFirewallPolicyResourceState> resourceState = default;
            Optional<ManagedRulesDefinition> managedRules = default;
            Optional<IReadOnlyList<WritableSubResource>> httpListeners = default;
            Optional<IReadOnlyList<WritableSubResource>> pathBasedRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policySettings = PolicySettings.DeserializePolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebApplicationFirewallCustomRule> array = new List<WebApplicationFirewallCustomRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebApplicationFirewallCustomRule.DeserializeWebApplicationFirewallCustomRule(item));
                            }
                            customRules = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationGatewayData> array = new List<ApplicationGatewayData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayData.DeserializeApplicationGatewayData(item));
                            }
                            applicationGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new WebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedRules = ManagedRulesDefinition.DeserializeManagedRulesDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListeners"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            httpListeners = array;
                            continue;
                        }
                        if (property0.NameEquals("pathBasedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            pathBasedRules = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebApplicationFirewallPolicyData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), policySettings.Value, Optional.ToList(customRules), Optional.ToList(applicationGateways), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState), managedRules.Value, Optional.ToList(httpListeners), Optional.ToList(pathBasedRules), rawData);
        }

        WebApplicationFirewallPolicyData IModelJsonSerializable<WebApplicationFirewallPolicyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebApplicationFirewallPolicyData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallPolicyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebApplicationFirewallPolicyData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebApplicationFirewallPolicyData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebApplicationFirewallPolicyData IModelSerializable<WebApplicationFirewallPolicyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebApplicationFirewallPolicyData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebApplicationFirewallPolicyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebApplicationFirewallPolicyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebApplicationFirewallPolicyData"/> to convert. </param>
        public static implicit operator RequestContent(WebApplicationFirewallPolicyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebApplicationFirewallPolicyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebApplicationFirewallPolicyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebApplicationFirewallPolicyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
