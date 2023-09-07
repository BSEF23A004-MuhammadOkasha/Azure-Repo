// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesAzureBlobUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesAzureBlobUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesAzureBlobUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesAzureBlobUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesAzureBlobUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(ContainerName))
            {
                if (ContainerName != null)
                {
                    writer.WritePropertyName("containerName"u8);
                    writer.WriteStringValue(ContainerName);
                }
                else
                {
                    writer.WriteNull("containerName");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                if (ServicePrincipal != null)
                {
                    writer.WritePropertyName("servicePrincipal"u8);
                    if (ServicePrincipal is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KubernetesServicePrincipalUpdateContent>)ServicePrincipal).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("servicePrincipal");
                }
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey"u8);
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken"u8);
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                if (ManagedIdentity != null)
                {
                    writer.WritePropertyName("managedIdentity"u8);
                    if (ManagedIdentity is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KubernetesAzureBlobManagedIdentityUpdateContent>)ManagedIdentity).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("managedIdentity");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static KubernetesAzureBlobUpdateContent DeserializeKubernetesAzureBlobUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> url = default;
            Optional<string> containerName = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<KubernetesServicePrincipalUpdateContent> servicePrincipal = default;
            Optional<string> accountKey = default;
            Optional<string> sasToken = default;
            Optional<KubernetesAzureBlobManagedIdentityUpdateContent> managedIdentity = default;
            Optional<string> localAuthRef = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerName = null;
                        continue;
                    }
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("servicePrincipal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        servicePrincipal = null;
                        continue;
                    }
                    servicePrincipal = KubernetesServicePrincipalUpdateContent.DeserializeKubernetesServicePrincipalUpdateContent(property.Value);
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountKey = null;
                        continue;
                    }
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasToken = null;
                        continue;
                    }
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managedIdentity = null;
                        continue;
                    }
                    managedIdentity = KubernetesAzureBlobManagedIdentityUpdateContent.DeserializeKubernetesAzureBlobManagedIdentityUpdateContent(property.Value);
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesAzureBlobUpdateContent(url.Value, containerName.Value, Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), servicePrincipal.Value, accountKey.Value, sasToken.Value, managedIdentity.Value, localAuthRef.Value, serializedAdditionalRawData);
        }

        KubernetesAzureBlobUpdateContent IModelJsonSerializable<KubernetesAzureBlobUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesAzureBlobUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesAzureBlobUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesAzureBlobUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesAzureBlobUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesAzureBlobUpdateContent IModelSerializable<KubernetesAzureBlobUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesAzureBlobUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesAzureBlobUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KubernetesAzureBlobUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KubernetesAzureBlobUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(KubernetesAzureBlobUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KubernetesAzureBlobUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KubernetesAzureBlobUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesAzureBlobUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
