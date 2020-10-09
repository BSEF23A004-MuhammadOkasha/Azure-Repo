// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class OperationStatus
    {
        internal static OperationStatus DeserializeOperationStatus(JsonElement element)
        {
            Optional<string> id = default;
            Optional<Status> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<float> percentComplete = default;
            Optional<ErrorResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new Status(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentComplete"))
                {
                    percentComplete = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("error"))
                        {
                            error = ErrorResponseError.DeserializeErrorResponseError(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new OperationStatus(id.Value, Optional.ToNullable(status), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(percentComplete), error.Value);
        }
    }
}
