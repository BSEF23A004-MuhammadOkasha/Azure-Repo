// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AzureKeyVaultSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("store");
            writer.WriteObjectValue(Store);
            writer.WritePropertyName("secretName");
            writer.WriteObjectValue(SecretName);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
                writer.WriteObjectValue(SecretVersion);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static AzureKeyVaultSecretReference DeserializeAzureKeyVaultSecretReference(JsonElement element)
        {
            LinkedServiceReference store = default;
            object secretName = default;
            Optional<object> secretVersion = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("store"))
                {
                    store = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("secretName"))
                {
                    secretName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    secretVersion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new AzureKeyVaultSecretReference(type, store, secretName, secretVersion.Value);
        }
    }
}
