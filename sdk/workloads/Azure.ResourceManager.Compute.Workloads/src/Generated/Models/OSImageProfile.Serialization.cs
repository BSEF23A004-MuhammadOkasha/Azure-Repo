// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class OSImageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher.Value.ToString());
            }
            if (Optional.IsDefined(Offer))
            {
                writer.WritePropertyName("offer");
                writer.WriteStringValue(Offer.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku.Value.ToString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static OSImageProfile DeserializeOSImageProfile(JsonElement element)
        {
            Optional<OSImagePublisher> publisher = default;
            Optional<OSImageOffer> offer = default;
            Optional<OSImageSku> sku = default;
            Optional<OSImageVersion> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publisher = new OSImagePublisher(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("offer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offer = new OSImageOffer(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = new OSImageSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = new OSImageVersion(property.Value.GetString());
                    continue;
                }
            }
            return new OSImageProfile(Optional.ToNullable(publisher), Optional.ToNullable(offer), Optional.ToNullable(sku), Optional.ToNullable(version));
        }
    }
}
