// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertModificationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Modifications))
            {
                writer.WritePropertyName("modifications"u8);
                writer.WriteStartArray();
                foreach (var item in Modifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertModificationProperties DeserializeServiceAlertModificationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> alertId = default;
            Optional<IList<ServiceAlertModificationItemInfo>> modifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("modifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAlertModificationItemInfo> array = new List<ServiceAlertModificationItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAlertModificationItemInfo.DeserializeServiceAlertModificationItemInfo(item));
                    }
                    modifications = array;
                    continue;
                }
            }
            return new ServiceAlertModificationProperties(Optional.ToNullable(alertId), Optional.ToList(modifications));
        }
    }
}
