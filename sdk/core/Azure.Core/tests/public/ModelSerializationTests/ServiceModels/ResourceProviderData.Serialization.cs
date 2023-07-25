// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.Core.Tests.Public.ResourceManager.Resources.Models;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;

namespace Azure.Core.Tests.Public.ResourceManager.Resources
{
    public partial class ResourceProviderData : IUtf8JsonSerializable, IJsonModelSerializable
    {
        public static ResourceProviderData DeserializeResourceProviderData(JsonElement element, ModelSerializerOptions? options = default)
        {
            options ??= ModelSerializerOptions.AzureServiceDefault;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> @namespace = default;
            Optional<string> registrationState = default;
            Optional<string> registrationPolicy = default;
            Optional<IReadOnlyList<ProviderResourceType>> resourceTypes = default;
            Optional<ProviderAuthorizationConsentState> providerAuthorizationConsentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationState"u8))
                {
                    registrationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationPolicy"u8))
                {
                    registrationPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderResourceType> array = new List<ProviderResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderResourceType.DeserializeProviderResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("providerAuthorizationConsentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthorizationConsentState = new ProviderAuthorizationConsentState(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceProviderData(id.Value, @namespace.Value, registrationState.Value, registrationPolicy.Value, Optional.ToList(resourceTypes), Optional.ToNullable(providerAuthorizationConsentState));
        }

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceProviderData(doc.RootElement, options);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModelSerializable)this).Serialize(writer, ModelSerializerOptions.AzureServiceDefault);

        // only used for public access to internal serialize
        public void Serialize(Utf8JsonWriter writer) => ((IUtf8JsonSerializable)this).Write(writer);

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RegistrationState))
            {
                writer.WritePropertyName("registrationState"u8);
                writer.WriteStringValue(RegistrationState);
            }
            if (Optional.IsDefined(RegistrationPolicy))
            {
                writer.WritePropertyName("registrationPolicy"u8);
                writer.WriteStringValue(RegistrationPolicy);
            }
            if (Optional.IsDefined(ProviderAuthorizationConsentState))
            {
                writer.WritePropertyName("providerAuthorizationConsentState"u8);
                writer.WriteStringValue(ProviderAuthorizationConsentState.ToString());
            }
            writer.WriteEndObject();
        }

        private struct ResourceProviderDataProperties
        {
            public Optional<ResourceIdentifier> Id { get; set; }
            public Optional<string> Namespace { get; set; }
            public Optional<string> RegistrationState { get; set; }
            public Optional<string> RegistrationPolicy { get; set; }
            public Optional<IReadOnlyList<ProviderResourceType>> ResourceTypes { get; set; }
            public Optional<ProviderAuthorizationConsentState> ProviderAuthorizationConsentState { get; set; }
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (!reader.TryDeserialize< ResourceProviderDataProperties>(options, SetProperty, out var properties))
                return null;

            return new ResourceProviderData(
                properties.Id.Value,
                properties.Namespace.Value,
                properties.RegistrationState.Value,
                properties.RegistrationPolicy.Value,
                Optional.ToList(properties.ResourceTypes),
                Optional.ToNullable(properties.ProviderAuthorizationConsentState));
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ResourceProviderDataProperties properties, ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (propertyName.SequenceEqual("id"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Id = new ResourceIdentifier(reader.GetString());
                return;
            }
            if (propertyName.SequenceEqual("namespace"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Namespace = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("registrationState"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.RegistrationState = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("registrationPolicy"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.RegistrationPolicy = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("resourceTypes"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ResourceTypes = reader.GetList<ProviderResourceType>(options);
                return;
            }
            if (propertyName.SequenceEqual("providerAuthorizationConsentState"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ProviderAuthorizationConsentState = new ProviderAuthorizationConsentState(reader.GetString());
                return;
            }
            reader.Skip();
        }

        BinaryData IModelSerializable.Serialize(ModelSerializerOptions options)
        {
            return ModelSerializerHelper.SerializeToBinaryData((writer) => { Serialize(writer, options); });
        }
    }
}
