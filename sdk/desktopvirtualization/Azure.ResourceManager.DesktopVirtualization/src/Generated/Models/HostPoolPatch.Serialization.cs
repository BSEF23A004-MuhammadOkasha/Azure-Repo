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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class HostPoolPatch : IUtf8JsonSerializable, IModelJsonSerializable<HostPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HostPoolPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HostPoolPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HostPoolPatch>(this, options.Format);

            writer.WriteStartObject();
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
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(CustomRdpProperty))
            {
                writer.WritePropertyName("customRdpProperty"u8);
                writer.WriteStringValue(CustomRdpProperty);
            }
            if (Optional.IsDefined(MaxSessionLimit))
            {
                writer.WritePropertyName("maxSessionLimit"u8);
                writer.WriteNumberValue(MaxSessionLimit.Value);
            }
            if (Optional.IsDefined(PersonalDesktopAssignmentType))
            {
                writer.WritePropertyName("personalDesktopAssignmentType"u8);
                writer.WriteStringValue(PersonalDesktopAssignmentType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerType))
            {
                writer.WritePropertyName("loadBalancerType"u8);
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Optional.IsDefined(Ring))
            {
                writer.WritePropertyName("ring"u8);
                writer.WriteNumberValue(Ring.Value);
            }
            if (Optional.IsDefined(IsValidationEnvironment))
            {
                writer.WritePropertyName("validationEnvironment"u8);
                writer.WriteBooleanValue(IsValidationEnvironment.Value);
            }
            if (Optional.IsDefined(RegistrationInfo))
            {
                writer.WritePropertyName("registrationInfo"u8);
                if (RegistrationInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HostPoolRegistrationInfoPatch>)RegistrationInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VmTemplate))
            {
                writer.WritePropertyName("vmTemplate"u8);
                writer.WriteStringValue(VmTemplate);
            }
            if (Optional.IsDefined(SsoAdfsAuthority))
            {
                writer.WritePropertyName("ssoadfsAuthority"u8);
                writer.WriteStringValue(SsoAdfsAuthority);
            }
            if (Optional.IsDefined(SsoClientId))
            {
                writer.WritePropertyName("ssoClientId"u8);
                writer.WriteStringValue(SsoClientId);
            }
            if (Optional.IsDefined(SsoClientSecretKeyVaultPath))
            {
                writer.WritePropertyName("ssoClientSecretKeyVaultPath"u8);
                writer.WriteStringValue(SsoClientSecretKeyVaultPath);
            }
            if (Optional.IsDefined(SsoSecretType))
            {
                writer.WritePropertyName("ssoSecretType"u8);
                writer.WriteStringValue(SsoSecretType.Value.ToString());
            }
            if (Optional.IsDefined(PreferredAppGroupType))
            {
                writer.WritePropertyName("preferredAppGroupType"u8);
                writer.WriteStringValue(PreferredAppGroupType.Value.ToString());
            }
            if (Optional.IsDefined(StartVmOnConnect))
            {
                writer.WritePropertyName("startVMOnConnect"u8);
                writer.WriteBooleanValue(StartVmOnConnect.Value);
            }
            if (Optional.IsDefined(AgentUpdate))
            {
                writer.WritePropertyName("agentUpdate"u8);
                if (AgentUpdate is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SessionHostAgentUpdatePatchProperties>)AgentUpdate).Serialize(writer, options);
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

        internal static HostPoolPatch DeserializeHostPoolPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> friendlyName = default;
            Optional<string> description = default;
            Optional<string> customRdpProperty = default;
            Optional<int> maxSessionLimit = default;
            Optional<PersonalDesktopAssignmentType> personalDesktopAssignmentType = default;
            Optional<HostPoolLoadBalancerType> loadBalancerType = default;
            Optional<int> ring = default;
            Optional<bool> validationEnvironment = default;
            Optional<HostPoolRegistrationInfoPatch> registrationInfo = default;
            Optional<string> vmTemplate = default;
            Optional<string> ssoadfsAuthority = default;
            Optional<string> ssoClientId = default;
            Optional<string> ssoClientSecretKeyVaultPath = default;
            Optional<HostPoolSsoSecretType> ssoSecretType = default;
            Optional<PreferredAppGroupType> preferredAppGroupType = default;
            Optional<bool> startVmOnConnect = default;
            Optional<SessionHostAgentUpdatePatchProperties> agentUpdate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customRdpProperty"u8))
                        {
                            customRdpProperty = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSessionLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSessionLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("personalDesktopAssignmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            personalDesktopAssignmentType = new PersonalDesktopAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerType = new HostPoolLoadBalancerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ring"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ring = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validationEnvironment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationEnvironment = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("registrationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationInfo = HostPoolRegistrationInfoPatch.DeserializeHostPoolRegistrationInfoPatch(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmTemplate"u8))
                        {
                            vmTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoadfsAuthority"u8))
                        {
                            ssoadfsAuthority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientId"u8))
                        {
                            ssoClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientSecretKeyVaultPath"u8))
                        {
                            ssoClientSecretKeyVaultPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoSecretType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssoSecretType = new HostPoolSsoSecretType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("preferredAppGroupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredAppGroupType = new PreferredAppGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startVmOnConnect = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("agentUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentUpdate = SessionHostAgentUpdatePatchProperties.DeserializeSessionHostAgentUpdatePatchProperties(property0.Value);
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
            return new HostPoolPatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), friendlyName.Value, description.Value, customRdpProperty.Value, Optional.ToNullable(maxSessionLimit), Optional.ToNullable(personalDesktopAssignmentType), Optional.ToNullable(loadBalancerType), Optional.ToNullable(ring), Optional.ToNullable(validationEnvironment), registrationInfo.Value, vmTemplate.Value, ssoadfsAuthority.Value, ssoClientId.Value, ssoClientSecretKeyVaultPath.Value, Optional.ToNullable(ssoSecretType), Optional.ToNullable(preferredAppGroupType), Optional.ToNullable(startVmOnConnect), agentUpdate.Value, rawData);
        }

        HostPoolPatch IModelJsonSerializable<HostPoolPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HostPoolPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHostPoolPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HostPoolPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HostPoolPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HostPoolPatch IModelSerializable<HostPoolPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HostPoolPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHostPoolPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HostPoolPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HostPoolPatch"/> to convert. </param>
        public static implicit operator RequestContent(HostPoolPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HostPoolPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HostPoolPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHostPoolPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
