// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class DiskExclusionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DiskLunList))
            {
                writer.WritePropertyName("diskLunList");
                writer.WriteStartArray();
                foreach (var item in DiskLunList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsInclusionList))
            {
                writer.WritePropertyName("isInclusionList");
                writer.WriteBooleanValue(IsInclusionList.Value);
            }
            writer.WriteEndObject();
        }

        internal static DiskExclusionProperties DeserializeDiskExclusionProperties(JsonElement element)
        {
            Optional<IList<int>> diskLunList = default;
            Optional<bool> isInclusionList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskLunList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    diskLunList = array;
                    continue;
                }
                if (property.NameEquals("isInclusionList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isInclusionList = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DiskExclusionProperties(Optional.ToList(diskLunList), Optional.ToNullable(isInclusionList));
        }
    }
}
