// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ComputeInstanceContainer
    {
        internal static ComputeInstanceContainer DeserializeComputeInstanceContainer(JsonElement element)
        {
            Optional<string> name = default;
            Optional<Autosave> autosave = default;
            Optional<string> gpu = default;
            Optional<Network> network = default;
            Optional<ComputeInstanceEnvironmentInfo> environment = default;
            Optional<IReadOnlyList<BinaryData>> services = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autosave"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autosave = new Autosave(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gpu"))
                {
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("network"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    network = new Network(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environment = ComputeInstanceEnvironmentInfo.DeserializeComputeInstanceEnvironmentInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("services"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    services = array;
                    continue;
                }
            }
            return new ComputeInstanceContainer(name.Value, Optional.ToNullable(autosave), gpu.Value, Optional.ToNullable(network), environment.Value, Optional.ToList(services));
        }
    }
}
