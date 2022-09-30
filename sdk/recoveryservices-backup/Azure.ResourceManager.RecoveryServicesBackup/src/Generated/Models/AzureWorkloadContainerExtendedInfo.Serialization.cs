// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureWorkloadContainerExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HostServerName))
            {
                writer.WritePropertyName("hostServerName");
                writer.WriteStringValue(HostServerName);
            }
            if (Optional.IsDefined(InquiryInfo))
            {
                writer.WritePropertyName("inquiryInfo");
                writer.WriteObjectValue(InquiryInfo);
            }
            if (Optional.IsCollectionDefined(NodesList))
            {
                writer.WritePropertyName("nodesList");
                writer.WriteStartArray();
                foreach (var item in NodesList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureWorkloadContainerExtendedInfo DeserializeAzureWorkloadContainerExtendedInfo(JsonElement element)
        {
            Optional<string> hostServerName = default;
            Optional<InquiryInfo> inquiryInfo = default;
            Optional<IList<DistributedNodesInfo>> nodesList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostServerName"))
                {
                    hostServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inquiryInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inquiryInfo = InquiryInfo.DeserializeInquiryInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("nodesList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DistributedNodesInfo> array = new List<DistributedNodesInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DistributedNodesInfo.DeserializeDistributedNodesInfo(item));
                    }
                    nodesList = array;
                    continue;
                }
            }
            return new AzureWorkloadContainerExtendedInfo(hostServerName.Value, inquiryInfo.Value, Optional.ToList(nodesList));
        }
    }
}
