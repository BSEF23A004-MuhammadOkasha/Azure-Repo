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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class MachineSkuSlot : IUtf8JsonSerializable, IModelJsonSerializable<MachineSkuSlot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineSkuSlot>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineSkuSlot>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineSkuSlot>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static MachineSkuSlot DeserializeMachineSkuSlot(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> rackSlot = default;
            Optional<BootstrapProtocol> bootstrapProtocol = default;
            Optional<long> cpuCores = default;
            Optional<long> cpuSockets = default;
            Optional<IReadOnlyList<MachineDisk>> disks = default;
            Optional<string> generation = default;
            Optional<string> hardwareVersion = default;
            Optional<long> memoryCapacityGB = default;
            Optional<string> model = default;
            Optional<IReadOnlyList<NetworkCloudNetworkInterface>> networkInterfaces = default;
            Optional<long> totalThreads = default;
            Optional<string> vendor = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rackSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rackSlot = property.Value.GetInt64();
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
                        if (property0.NameEquals("bootstrapProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootstrapProtocol = new BootstrapProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cpuCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCores = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuSockets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuSockets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("disks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineDisk> array = new List<MachineDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineDisk.DeserializeMachineDisk(item));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("generation"u8))
                        {
                            generation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareVersion"u8))
                        {
                            hardwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memoryCapacityGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memoryCapacityGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudNetworkInterface> array = new List<NetworkCloudNetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudNetworkInterface.DeserializeNetworkCloudNetworkInterface(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("totalThreads"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalThreads = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
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
            return new MachineSkuSlot(Optional.ToNullable(rackSlot), Optional.ToNullable(bootstrapProtocol), Optional.ToNullable(cpuCores), Optional.ToNullable(cpuSockets), Optional.ToList(disks), generation.Value, hardwareVersion.Value, Optional.ToNullable(memoryCapacityGB), model.Value, Optional.ToList(networkInterfaces), Optional.ToNullable(totalThreads), vendor.Value, rawData);
        }

        MachineSkuSlot IModelJsonSerializable<MachineSkuSlot>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineSkuSlot>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineSkuSlot(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineSkuSlot>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineSkuSlot>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineSkuSlot IModelSerializable<MachineSkuSlot>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineSkuSlot>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineSkuSlot(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineSkuSlot"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineSkuSlot"/> to convert. </param>
        public static implicit operator RequestContent(MachineSkuSlot model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineSkuSlot"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineSkuSlot(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineSkuSlot(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
