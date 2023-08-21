// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchResizeOperationStatus
    {
        internal static BatchResizeOperationStatus DeserializeBatchResizeOperationStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> targetDedicatedNodes = default;
            Core.Optional<int> targetLowPriorityNodes = default;
            Core.Optional<TimeSpan> resizeTimeout = default;
            Core.Optional<BatchNodeDeallocationOption> nodeDeallocationOption = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<IReadOnlyList<ResponseError>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDedicatedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetLowPriorityNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resizeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resizeTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("nodeDeallocationOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeDeallocationOption = property.Value.GetString().ToBatchNodeDeallocationOption();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errors = array;
                    continue;
                }
            }
            return new BatchResizeOperationStatus(Core.Optional.ToNullable(targetDedicatedNodes), Core.Optional.ToNullable(targetLowPriorityNodes), Core.Optional.ToNullable(resizeTimeout), Core.Optional.ToNullable(nodeDeallocationOption), Core.Optional.ToNullable(startTime), Core.Optional.ToList(errors));
        }
    }
}
