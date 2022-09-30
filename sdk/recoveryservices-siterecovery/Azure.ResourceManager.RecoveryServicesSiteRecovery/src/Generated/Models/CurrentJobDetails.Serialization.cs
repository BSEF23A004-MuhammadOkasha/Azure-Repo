// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class CurrentJobDetails
    {
        internal static CurrentJobDetails DeserializeCurrentJobDetails(JsonElement element)
        {
            Optional<string> jobName = default;
            Optional<string> jobId = default;
            Optional<DateTimeOffset> startTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new CurrentJobDetails(jobName.Value, jobId.Value, Optional.ToNullable(startTime));
        }
    }
}
