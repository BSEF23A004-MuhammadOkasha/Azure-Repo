// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderRegistrationProperties : IUtf8JsonSerializable, IJsonModel<ProviderRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderRegistrationProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ProviderRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderHubMetadata))
            {
                writer.WritePropertyName("providerHubMetadata"u8);
                writer.WriteObjectValue(ProviderHubMetadata);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionLifecycleNotificationSpecifications))
            {
                writer.WritePropertyName("subscriptionLifecycleNotificationSpecifications"u8);
                writer.WriteObjectValue(SubscriptionLifecycleNotificationSpecifications);
            }
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue(ProviderAuthentication);
            }
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue(Management);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TemplateDeploymentOptions))
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProviderRegistrationProperties IJsonModel<ProviderRegistrationProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderRegistrationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderRegistrationProperties(document.RootElement, options);
        }

        internal static ProviderRegistrationProperties DeserializeProviderRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProviderHubMetadata> providerHubMetadata = default;
            Optional<ProviderHubProvisioningState> provisioningState = default;
            Optional<SubscriptionLifecycleNotificationSpecifications> subscriptionLifecycleNotificationSpecifications = default;
            Optional<ResourceProviderAuthentication> providerAuthentication = default;
            Optional<IList<ResourceProviderAuthorization>> providerAuthorizations = default;
            Optional<string> @namespace = default;
            Optional<string> providerVersion = default;
            Optional<ResourceProviderType> providerType = default;
            Optional<IList<string>> requiredFeatures = default;
            Optional<FeaturesRule> featuresRule = default;
            Optional<RequestHeaderOptions> requestHeaderOptions = default;
            Optional<ResourceProviderManagement> management = default;
            Optional<IList<ResourceProviderCapabilities>> capabilities = default;
            Optional<BinaryData> metadata = default;
            Optional<TemplateDeploymentOptions> templateDeploymentOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerHubMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerHubMetadata = ProviderHubMetadata.DeserializeProviderHubMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProviderHubProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionLifecycleNotificationSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionLifecycleNotificationSpecifications = SubscriptionLifecycleNotificationSpecifications.DeserializeSubscriptionLifecycleNotificationSpecifications(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerType = new ResourceProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    management = ResourceProviderManagement.DeserializeResourceProviderManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderCapabilities> array = new List<ResourceProviderCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderCapabilities.DeserializeResourceProviderCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentOptions = TemplateDeploymentOptions.DeserializeTemplateDeploymentOptions(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProviderRegistrationProperties(providerAuthentication.Value, Optional.ToList(providerAuthorizations), @namespace.Value, providerVersion.Value, Optional.ToNullable(providerType), Optional.ToList(requiredFeatures), featuresRule.Value, requestHeaderOptions.Value, management.Value, Optional.ToList(capabilities), metadata.Value, templateDeploymentOptions.Value, serializedAdditionalRawData, providerHubMetadata.Value, Optional.ToNullable(provisioningState), subscriptionLifecycleNotificationSpecifications.Value);
        }

        BinaryData IModel<ProviderRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderRegistrationProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProviderRegistrationProperties IModel<ProviderRegistrationProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderRegistrationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProviderRegistrationProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ProviderRegistrationProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
