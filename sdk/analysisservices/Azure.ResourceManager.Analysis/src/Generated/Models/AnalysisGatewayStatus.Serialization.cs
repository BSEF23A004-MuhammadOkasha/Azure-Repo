// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    public partial class AnalysisGatewayStatus
    {
        internal static AnalysisGatewayStatus DeserializeAnalysisGatewayStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AnalysisStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AnalysisStatus(property.Value.GetInt32());
                    continue;
                }
            }
            return new AnalysisGatewayStatus(Optional.ToNullable(status));
        }
    }
}
