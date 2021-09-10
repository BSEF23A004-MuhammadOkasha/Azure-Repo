// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PartialTargetUtilizationScaleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxInstances))
            {
                writer.WritePropertyName("maxInstances");
                writer.WriteNumberValue(MaxInstances.Value);
            }
            if (Optional.IsDefined(MinInstances))
            {
                writer.WritePropertyName("minInstances");
                writer.WriteNumberValue(MinInstances.Value);
            }
            if (Optional.IsDefined(PollingInterval))
            {
                writer.WritePropertyName("pollingInterval");
                writer.WriteStringValue(PollingInterval.Value, "P");
            }
            if (Optional.IsDefined(TargetUtilizationPercentage))
            {
                writer.WritePropertyName("targetUtilizationPercentage");
                writer.WriteNumberValue(TargetUtilizationPercentage.Value);
            }
            writer.WritePropertyName("scaleType");
            writer.WriteStringValue(ScaleType.ToString());
            writer.WriteEndObject();
        }
    }
}
