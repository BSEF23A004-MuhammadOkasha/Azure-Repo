// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class RunbookDraftUndoEditResult
    {
        internal static RunbookDraftUndoEditResult DeserializeRunbookDraftUndoEditResult(JsonElement element)
        {
            Optional<HttpStatusCode> statusCode = default;
            Optional<string> requestId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = new HttpStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
            }
            return new RunbookDraftUndoEditResult(Optional.ToNullable(statusCode), requestId.Value);
        }
    }
}
