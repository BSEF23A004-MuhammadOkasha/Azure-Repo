// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningEndpointKeyRegenerateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToString());
            if (Optional.IsDefined(KeyValue))
            {
                if (KeyValue != null)
                {
                    writer.WritePropertyName("keyValue"u8);
                    writer.WriteStringValue(KeyValue);
                }
                else
                {
                    writer.WriteNull("keyValue");
                }
            }
            writer.WriteEndObject();
        }
    }
}
