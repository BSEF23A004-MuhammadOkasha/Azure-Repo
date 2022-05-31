// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class SAPSizingRecommendationResult
    {
        internal static SAPSizingRecommendationResult DeserializeSAPSizingRecommendationResult(JsonElement element)
        {
            if (element.TryGetProperty("deploymentType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SingleServer": return SingleServerRecommendationResult.DeserializeSingleServerRecommendationResult(element);
                    case "ThreeTier": return ThreeTierRecommendationResult.DeserializeThreeTierRecommendationResult(element);
                }
            }
            SAPDeploymentType deploymentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"))
                {
                    deploymentType = new SAPDeploymentType(property.Value.GetString());
                    continue;
                }
            }
            return new SAPSizingRecommendationResult(deploymentType);
        }
    }
}
