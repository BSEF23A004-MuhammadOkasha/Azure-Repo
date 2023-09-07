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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class LoadBalancerProfile : IUtf8JsonSerializable, IModelJsonSerializable<LoadBalancerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBalancerProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBalancerProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LinuxProfile))
            {
                writer.WritePropertyName("linuxProfile"u8);
                if (LinuxProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LinuxProfileProperties>)LinuxProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(NodeImageVersion))
            {
                writer.WritePropertyName("nodeImageVersion"u8);
                writer.WriteStringValue(NodeImageVersion);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(CloudProviderProfile))
            {
                writer.WritePropertyName("cloudProviderProfile"u8);
                if (CloudProviderProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CloudProviderProfile>)CloudProviderProfile).Serialize(writer, options);
                }
            }
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

        internal static LoadBalancerProfile DeserializeLoadBalancerProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinuxProfileProperties> linuxProfile = default;
            Optional<string> name = default;
            Optional<int> count = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<int> maxCount = default;
            Optional<int> maxPods = default;
            Optional<int> minCount = default;
            Optional<Mode> mode = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<OSType> osType = default;
            Optional<string> nodeImageVersion = default;
            Optional<string> vmSize = default;
            Optional<CloudProviderProfile> cloudProviderProfile = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linuxProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxProfile = LinuxProfileProperties.DeserializeLinuxProfileProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
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
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new Mode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeLabels"u8))
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
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"u8))
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
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeImageVersion"u8))
                {
                    nodeImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudProviderProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudProviderProfile = CloudProviderProfile.DeserializeCloudProviderProfile(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadBalancerProfile(Optional.ToNullable(count), Optional.ToList(availabilityZones), Optional.ToNullable(maxCount), Optional.ToNullable(maxPods), Optional.ToNullable(minCount), Optional.ToNullable(mode), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), Optional.ToNullable(osType), nodeImageVersion.Value, vmSize.Value, cloudProviderProfile.Value, name.Value, linuxProfile.Value, serializedAdditionalRawData);
        }

        LoadBalancerProfile IModelJsonSerializable<LoadBalancerProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBalancerProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBalancerProfile IModelSerializable<LoadBalancerProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBalancerProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadBalancerProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadBalancerProfile"/> to convert. </param>
        public static implicit operator RequestContent(LoadBalancerProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadBalancerProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadBalancerProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBalancerProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
