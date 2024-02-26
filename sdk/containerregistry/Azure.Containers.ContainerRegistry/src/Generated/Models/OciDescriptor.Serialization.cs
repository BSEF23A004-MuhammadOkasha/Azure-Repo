// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class OciDescriptor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MediaType != null)
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (SizeInBytes.HasValue)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (Digest != null)
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
            }
            if (!(Urls is ChangeTrackingList<Uri> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("urls"u8);
                writer.WriteStartArray();
                foreach (var item in Urls)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Annotations != null)
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations"u8);
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            writer.WriteEndObject();
        }

        internal static OciDescriptor DeserializeOciDescriptor(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<long> size = default;
            Optional<string> digest = default;
            IList<Uri> urls = default;
            Optional<OciAnnotations> annotations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    urls = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
            }
            return new OciDescriptor(mediaType.Value, Optional.ToNullable(size), digest.Value, urls ?? new ChangeTrackingList<Uri>(), annotations.Value);
        }
    }
}
