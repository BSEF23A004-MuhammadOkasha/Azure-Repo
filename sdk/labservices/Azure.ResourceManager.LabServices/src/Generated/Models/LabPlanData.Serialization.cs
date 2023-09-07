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
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabPlanData : IUtf8JsonSerializable, IModelJsonSerializable<LabPlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LabPlanData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LabPlanData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabPlanData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            if (Optional.IsDefined(DefaultConnectionProfile))
            {
                writer.WritePropertyName("defaultConnectionProfile"u8);
                if (DefaultConnectionProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LabConnectionProfile>)DefaultConnectionProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DefaultAutoShutdownProfile))
            {
                writer.WritePropertyName("defaultAutoShutdownProfile"u8);
                if (DefaultAutoShutdownProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LabAutoShutdownProfile>)DefaultAutoShutdownProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DefaultNetworkProfile))
            {
                writer.WritePropertyName("defaultNetworkProfile"u8);
                if (DefaultNetworkProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LabPlanNetworkProfile>)DefaultNetworkProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AllowedRegions))
            {
                writer.WritePropertyName("allowedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SharedGalleryId))
            {
                writer.WritePropertyName("sharedGalleryId"u8);
                writer.WriteStringValue(SharedGalleryId);
            }
            if (Optional.IsDefined(SupportInfo))
            {
                writer.WritePropertyName("supportInfo"u8);
                if (SupportInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LabPlanSupportInfo>)SupportInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LinkedLmsInstance))
            {
                writer.WritePropertyName("linkedLmsInstance"u8);
                writer.WriteStringValue(LinkedLmsInstance.AbsoluteUri);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static LabPlanData DeserializeLabPlanData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<LabConnectionProfile> defaultConnectionProfile = default;
            Optional<LabAutoShutdownProfile> defaultAutoShutdownProfile = default;
            Optional<LabPlanNetworkProfile> defaultNetworkProfile = default;
            Optional<IList<AzureLocation>> allowedRegions = default;
            Optional<ResourceIdentifier> sharedGalleryId = default;
            Optional<LabPlanSupportInfo> supportInfo = default;
            Optional<Uri> linkedLmsInstance = default;
            Optional<LabServicesProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("defaultConnectionProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultConnectionProfile = LabConnectionProfile.DeserializeLabConnectionProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultAutoShutdownProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAutoShutdownProfile = LabAutoShutdownProfile.DeserializeLabAutoShutdownProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultNetworkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultNetworkProfile = LabPlanNetworkProfile.DeserializeLabPlanNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowedRegions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureLocation> array = new List<AzureLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AzureLocation(item.GetString()));
                            }
                            allowedRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedGalleryId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedGalleryId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportInfo = LabPlanSupportInfo.DeserializeLabPlanSupportInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("linkedLmsInstance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedLmsInstance = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToLabServicesProvisioningState();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LabPlanData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, defaultConnectionProfile.Value, defaultAutoShutdownProfile.Value, defaultNetworkProfile.Value, Optional.ToList(allowedRegions), sharedGalleryId.Value, supportInfo.Value, linkedLmsInstance.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        LabPlanData IModelJsonSerializable<LabPlanData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabPlanData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLabPlanData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LabPlanData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabPlanData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LabPlanData IModelSerializable<LabPlanData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LabPlanData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLabPlanData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LabPlanData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LabPlanData"/> to convert. </param>
        public static implicit operator RequestContent(LabPlanData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LabPlanData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LabPlanData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLabPlanData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
