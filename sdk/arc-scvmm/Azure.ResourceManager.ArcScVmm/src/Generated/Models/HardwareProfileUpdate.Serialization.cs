// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class HardwareProfileUpdate : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Core.Optional.IsDefined(CpuCount))
            {
                writer.WritePropertyName("cpuCount"u8);
                writer.WriteNumberValue(CpuCount.Value);
            }
            if (Core.Optional.IsDefined(LimitCpuForMigration))
            {
                writer.WritePropertyName("limitCpuForMigration"u8);
                writer.WriteStringValue(LimitCpuForMigration.Value.ToString());
            }
            if (Core.Optional.IsDefined(DynamicMemoryEnabled))
            {
                writer.WritePropertyName("dynamicMemoryEnabled"u8);
                writer.WriteStringValue(DynamicMemoryEnabled.Value.ToString());
            }
            if (Core.Optional.IsDefined(DynamicMemoryMaxMB))
            {
                writer.WritePropertyName("dynamicMemoryMaxMB"u8);
                writer.WriteNumberValue(DynamicMemoryMaxMB.Value);
            }
            if (Core.Optional.IsDefined(DynamicMemoryMinMB))
            {
                writer.WritePropertyName("dynamicMemoryMinMB"u8);
                writer.WriteNumberValue(DynamicMemoryMinMB.Value);
            }
            writer.WriteEndObject();
        }
    }
}
