// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    internal partial class DownloadResponseComplianceDetailedPdfReport
    {
        internal static DownloadResponseComplianceDetailedPdfReport DeserializeDownloadResponseComplianceDetailedPdfReport(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> sasUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DownloadResponseComplianceDetailedPdfReport(sasUri.Value);
        }
    }
}
