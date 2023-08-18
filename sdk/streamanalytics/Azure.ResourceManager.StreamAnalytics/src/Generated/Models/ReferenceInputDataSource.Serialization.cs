// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ReferenceInputDataSource : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WriteEndObject();
        }

        internal static ReferenceInputDataSource DeserializeReferenceInputDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Sql/Server/Database": return SqlReferenceInputDataSource.DeserializeSqlReferenceInputDataSource(element);
                    case "Microsoft.Storage/Blob": return BlobReferenceInputDataSource.DeserializeBlobReferenceInputDataSource(element);
                    case "Raw": return RawReferenceInputDataSource.DeserializeRawReferenceInputDataSource(element);
                }
            }
            return UnknownReferenceInputDataSource.DeserializeUnknownReferenceInputDataSource(element);
        }
    }
}
