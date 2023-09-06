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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceProviderAuthorization : IUtf8JsonSerializable, IModelJsonSerializable<ResourceProviderAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceProviderAuthorization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceProviderAuthorization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceProviderAuthorization>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(ManagedByRoleDefinitionId))
            {
                writer.WritePropertyName("managedByRoleDefinitionId"u8);
                writer.WriteStringValue(ManagedByRoleDefinitionId);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static ResourceProviderAuthorization DeserializeResourceProviderAuthorization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> applicationId = default;
            Optional<string> roleDefinitionId = default;
            Optional<string> managedByRoleDefinitionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByRoleDefinitionId"u8))
                {
                    managedByRoleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceProviderAuthorization(applicationId.Value, roleDefinitionId.Value, managedByRoleDefinitionId.Value, rawData);
        }

        ResourceProviderAuthorization IModelJsonSerializable<ResourceProviderAuthorization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceProviderAuthorization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderAuthorization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceProviderAuthorization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceProviderAuthorization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceProviderAuthorization IModelSerializable<ResourceProviderAuthorization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceProviderAuthorization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceProviderAuthorization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceProviderAuthorization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceProviderAuthorization"/> to convert. </param>
        public static implicit operator RequestContent(ResourceProviderAuthorization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceProviderAuthorization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceProviderAuthorization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceProviderAuthorization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
