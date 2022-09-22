// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeClusterMemoryCapacity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterFreeMemoryInMB))
            {
                writer.WritePropertyName("clusterFreeMemoryMb");
                writer.WriteNumberValue(ClusterFreeMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterUsedMemoryInMB))
            {
                writer.WritePropertyName("clusterUsedMemoryMb");
                writer.WriteNumberValue(ClusterUsedMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFailoverMemoryInMB))
            {
                writer.WritePropertyName("clusterFailoverMemoryMb");
                writer.WriteNumberValue(ClusterFailoverMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFragmentationMemoryInMB))
            {
                writer.WritePropertyName("clusterFragmentationMemoryMb");
                writer.WriteNumberValue(ClusterFragmentationMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterHyperVReserveMemoryMb))
            {
                writer.WritePropertyName("clusterHypervReserveMemoryMb");
                writer.WriteNumberValue(ClusterHyperVReserveMemoryMb.Value);
            }
            if (Optional.IsDefined(ClusterInfraVmMemoryInMB))
            {
                writer.WritePropertyName("clusterInfraVmMemoryMb");
                writer.WriteNumberValue(ClusterInfraVmMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterTotalMemoryInMB))
            {
                writer.WritePropertyName("clusterTotalMemoryMb");
                writer.WriteNumberValue(ClusterTotalMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterNonFailoverVmInMB))
            {
                writer.WritePropertyName("clusterNonFailoverVmMb");
                writer.WriteNumberValue(ClusterNonFailoverVmInMB.Value);
            }
            if (Optional.IsDefined(ClusterMemoryUsedByVmsInMB))
            {
                writer.WritePropertyName("clusterMemoryUsedByVmsMb");
                writer.WriteNumberValue(ClusterMemoryUsedByVmsInMB.Value);
            }
            writer.WriteEndObject();
        }

        internal static EdgeClusterMemoryCapacity DeserializeEdgeClusterMemoryCapacity(JsonElement element)
        {
            Optional<double> clusterFreeMemoryMb = default;
            Optional<double> clusterUsedMemoryMb = default;
            Optional<double> clusterFailoverMemoryMb = default;
            Optional<double> clusterFragmentationMemoryMb = default;
            Optional<double> clusterHyperVReserveMemoryMb = default;
            Optional<double> clusterInfraVmMemoryMb = default;
            Optional<double> clusterTotalMemoryMb = default;
            Optional<double> clusterNonFailoverVmMb = default;
            Optional<double> clusterMemoryUsedByVmsMb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFreeMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterFreeMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterUsedMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterUsedMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFailoverMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterFailoverMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFragmentationMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterFragmentationMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterHypervReserveMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterHyperVReserveMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterInfraVmMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterInfraVmMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterTotalMemoryMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterTotalMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterNonFailoverVmMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterNonFailoverVmMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterMemoryUsedByVmsMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterMemoryUsedByVmsMb = property.Value.GetDouble();
                    continue;
                }
            }
            return new EdgeClusterMemoryCapacity(Optional.ToNullable(clusterFreeMemoryMb), Optional.ToNullable(clusterUsedMemoryMb), Optional.ToNullable(clusterFailoverMemoryMb), Optional.ToNullable(clusterFragmentationMemoryMb), Optional.ToNullable(clusterHyperVReserveMemoryMb), Optional.ToNullable(clusterInfraVmMemoryMb), Optional.ToNullable(clusterTotalMemoryMb), Optional.ToNullable(clusterNonFailoverVmMb), Optional.ToNullable(clusterMemoryUsedByVmsMb));
        }
    }
}
