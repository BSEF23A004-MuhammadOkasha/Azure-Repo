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
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorWebApplicationFirewallPolicyData : IUtf8JsonSerializable, IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorWebApplicationFirewallPolicyData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FrontDoorSku>)Sku).Serialize(writer, options);
                }
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
                    ((IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicySettings>)PolicySettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CustomRuleList))
            {
                writer.WritePropertyName("customRules"u8);
                if (CustomRuleList is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CustomRuleList>)CustomRuleList).Serialize(writer, options);
                }
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
                    ((IModelJsonSerializable<ManagedRuleSetList>)ManagedRules).Serialize(writer, options);
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

        internal static FrontDoorWebApplicationFirewallPolicyData DeserializeFrontDoorWebApplicationFirewallPolicyData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<FrontDoorSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<FrontDoorWebApplicationFirewallPolicySettings> policySettings = default;
            Optional<CustomRuleList> customRules = default;
            Optional<ManagedRuleSetList> managedRules = default;
            Optional<IReadOnlyList<SubResource>> frontendEndpointLinks = default;
            Optional<IReadOnlyList<SubResource>> routingRuleLinks = default;
            Optional<IReadOnlyList<SubResource>> securityPolicyLinks = default;
            Optional<string> provisioningState = default;
            Optional<FrontDoorWebApplicationFirewallPolicyResourceState> resourceState = default;
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
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = FrontDoorSku.DeserializeFrontDoorSku(property.Value);
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                            policySettings = FrontDoorWebApplicationFirewallPolicySettings.DeserializeFrontDoorWebApplicationFirewallPolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customRules = CustomRuleList.DeserializeCustomRuleList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedRules = ManagedRuleSetList.DeserializeManagedRuleSetList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontendEndpointLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                            }
                            frontendEndpointLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("routingRuleLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                            }
                            routingRuleLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("securityPolicyLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                            }
                            securityPolicyLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorWebApplicationFirewallPolicyResourceState(property0.Value.GetString());
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
            return new FrontDoorWebApplicationFirewallPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), sku.Value, policySettings.Value, customRules.Value, managedRules.Value, Optional.ToList(frontendEndpointLinks), Optional.ToList(routingRuleLinks), Optional.ToList(securityPolicyLinks), provisioningState.Value, Optional.ToNullable(resourceState), rawData);
        }

        FrontDoorWebApplicationFirewallPolicyData IModelJsonSerializable<FrontDoorWebApplicationFirewallPolicyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorWebApplicationFirewallPolicyData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorWebApplicationFirewallPolicyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FrontDoorWebApplicationFirewallPolicyData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorWebApplicationFirewallPolicyData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FrontDoorWebApplicationFirewallPolicyData IModelSerializable<FrontDoorWebApplicationFirewallPolicyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorWebApplicationFirewallPolicyData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFrontDoorWebApplicationFirewallPolicyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FrontDoorWebApplicationFirewallPolicyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FrontDoorWebApplicationFirewallPolicyData"/> to convert. </param>
        public static implicit operator RequestContent(FrontDoorWebApplicationFirewallPolicyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FrontDoorWebApplicationFirewallPolicyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FrontDoorWebApplicationFirewallPolicyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFrontDoorWebApplicationFirewallPolicyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
