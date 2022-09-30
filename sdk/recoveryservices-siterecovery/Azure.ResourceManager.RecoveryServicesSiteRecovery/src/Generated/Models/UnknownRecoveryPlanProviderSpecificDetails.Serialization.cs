// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownRecoveryPlanProviderSpecificDetails
    {
        internal static UnknownRecoveryPlanProviderSpecificDetails DeserializeUnknownRecoveryPlanProviderSpecificDetails(JsonElement element)
        {
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownRecoveryPlanProviderSpecificDetails(instanceType);
        }
    }
}
