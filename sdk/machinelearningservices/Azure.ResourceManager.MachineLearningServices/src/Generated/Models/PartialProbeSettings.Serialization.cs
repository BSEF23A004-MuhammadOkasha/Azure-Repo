// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PartialProbeSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold");
                writer.WriteNumberValue(FailureThreshold.Value);
            }
            if (Optional.IsDefined(InitialDelay))
            {
                if (InitialDelay != null)
                {
                    writer.WritePropertyName("initialDelay");
                    writer.WriteStringValue(InitialDelay.Value, "P");
                }
                else
                {
                    writer.WriteNull("initialDelay");
                }
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period");
                writer.WriteStringValue(Period.Value, "P");
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold");
                writer.WriteNumberValue(SuccessThreshold.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WriteEndObject();
        }
    }
}
