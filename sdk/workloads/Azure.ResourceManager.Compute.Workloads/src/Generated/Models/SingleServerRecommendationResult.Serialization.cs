// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class SingleServerRecommendationResult
    {
        internal static SingleServerRecommendationResult DeserializeSingleServerRecommendationResult(JsonElement element)
        {
            Optional<string> vmSku = default;
            SAPDeploymentType deploymentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentType"))
                {
                    deploymentType = new SAPDeploymentType(property.Value.GetString());
                    continue;
                }
            }
            return new SingleServerRecommendationResult(deploymentType, vmSku.Value);
        }
    }
}
