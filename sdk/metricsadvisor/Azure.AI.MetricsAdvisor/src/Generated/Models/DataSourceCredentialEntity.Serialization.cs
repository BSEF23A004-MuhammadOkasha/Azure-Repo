// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class DataSourceCredentialEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(CredentialKind.ToString());
            writer.WritePropertyName("dataSourceCredentialName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }
    }
}
