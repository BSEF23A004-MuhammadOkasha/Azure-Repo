// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace System.Net.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ResourceProviderData : IJsonModel<ResourceProviderData>
    {
        public static ResourceProviderData DeserializeResourceProviderData(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> id = default;
            OptionalProperty<string> @namespace = default;
            OptionalProperty<string> registrationState = default;
            OptionalProperty<string> registrationPolicy = default;
            OptionalProperty<IReadOnlyList<ProviderResourceType>> resourceTypes = default;
            OptionalProperty<ProviderAuthorizationConsentState> providerAuthorizationConsentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
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
                        array.Add(ProviderResourceType.DeserializeProviderResourceType(item, options));
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
            return new ResourceProviderData(id.Value, @namespace.Value, registrationState.Value, registrationPolicy.Value, OptionalProperty.ToList(resourceTypes), OptionalProperty.ToNullable(providerAuthorizationConsentState));
        }

        ResourceProviderData IModel<ResourceProviderData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceProviderData(doc.RootElement, options);
        }

        void IJsonModel<ResourceProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            Serialize(writer, options);
        }

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (OptionalProperty.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (OptionalProperty.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(RegistrationState))
            {
                writer.WritePropertyName("registrationState"u8);
                writer.WriteStringValue(RegistrationState);
            }
            if (OptionalProperty.IsDefined(RegistrationPolicy))
            {
                writer.WritePropertyName("registrationPolicy"u8);
                writer.WriteStringValue(RegistrationPolicy);
            }
            if (OptionalProperty.IsDefined(ProviderAuthorizationConsentState))
            {
                writer.WritePropertyName("providerAuthorizationConsentState"u8);
                writer.WriteStringValue(ProviderAuthorizationConsentState.ToString());
            }
            writer.WriteEndObject();
        }

        private struct ResourceProviderDataProperties
        {
            public OptionalProperty<string> Id { get; set; }
            public OptionalProperty<string> Namespace { get; set; }
            public OptionalProperty<string> RegistrationState { get; set; }
            public OptionalProperty<string> RegistrationPolicy { get; set; }
            public OptionalProperty<IReadOnlyList<ProviderResourceType>> ResourceTypes { get; set; }
            public OptionalProperty<ProviderAuthorizationConsentState> ProviderAuthorizationConsentState { get; set; }
        }

        ResourceProviderData IJsonModel<ResourceProviderData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderData(doc.RootElement, options);
        }

        BinaryData IModel<ResourceProviderData>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        ModelReaderWriterFormat IModel<ResourceProviderData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
