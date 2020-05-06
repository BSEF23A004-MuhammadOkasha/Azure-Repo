// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class StorageError
    {
        internal static StorageError DeserializeStorageError(JsonElement element)
        {
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new StorageError(message);
        }

        internal static StorageError DeserializeStorageError(XElement element)
        {
            string message = default;
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new StorageError(message);
        }
    }
}
