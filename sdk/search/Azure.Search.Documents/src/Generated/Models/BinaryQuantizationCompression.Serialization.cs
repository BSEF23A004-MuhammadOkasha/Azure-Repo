// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class BinaryQuantizationCompression : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(CompressionName);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(RerankWithOriginalVectors))
            {
                writer.WritePropertyName("rerankWithOriginalVectors"u8);
                writer.WriteBooleanValue(RerankWithOriginalVectors.Value);
            }
            if (Optional.IsDefined(DefaultOversampling))
            {
                if (DefaultOversampling != null)
                {
                    writer.WritePropertyName("defaultOversampling"u8);
                    writer.WriteNumberValue(DefaultOversampling.Value);
                }
                else
                {
                    writer.WriteNull("defaultOversampling");
                }
            }
            if (Optional.IsDefined(TruncationDimension))
            {
                if (TruncationDimension != null)
                {
                    writer.WritePropertyName("truncationDimension"u8);
                    writer.WriteNumberValue(TruncationDimension.Value);
                }
                else
                {
                    writer.WriteNull("truncationDimension");
                }
            }
            writer.WriteEndObject();
        }

        internal static BinaryQuantizationCompression DeserializeBinaryQuantizationCompression(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            VectorSearchCompressionKind kind = default;
            bool? rerankWithOriginalVectors = default;
            double? defaultOversampling = default;
            int? truncationDimension = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorSearchCompressionKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rerankWithOriginalVectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rerankWithOriginalVectors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultOversampling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultOversampling = null;
                        continue;
                    }
                    defaultOversampling = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("truncationDimension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        truncationDimension = null;
                        continue;
                    }
                    truncationDimension = property.Value.GetInt32();
                    continue;
                }
            }
            return new BinaryQuantizationCompression(name, kind, rerankWithOriginalVectors, defaultOversampling, truncationDimension);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new BinaryQuantizationCompression FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBinaryQuantizationCompression(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
