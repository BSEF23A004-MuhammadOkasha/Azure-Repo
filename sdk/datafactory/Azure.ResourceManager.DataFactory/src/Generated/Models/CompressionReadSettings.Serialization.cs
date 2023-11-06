// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CompressionReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CompressionReadSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        internal static CompressionReadSettings DeserializeCompressionReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "TarGZipReadSettings": return TarGzipReadSettings.DeserializeTarGzipReadSettings(element);
                    case "TarReadSettings": return TarReadSettings.DeserializeTarReadSettings(element);
                    case "ZipDeflateReadSettings": return ZipDeflateReadSettings.DeserializeZipDeflateReadSettings(element);
                }
            }
            return UnknownCompressionReadSettings.DeserializeUnknownCompressionReadSettings(element);
        }
    }
}
