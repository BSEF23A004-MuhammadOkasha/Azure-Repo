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

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsServiceBusProperties : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsServiceBusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsServiceBusProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsServiceBusProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsServiceBusProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryConnectionString))
            {
                if (PrimaryConnectionString != null)
                {
                    writer.WritePropertyName("primaryConnectionString"u8);
                    writer.WriteStringValue(PrimaryConnectionString);
                }
                else
                {
                    writer.WriteNull("primaryConnectionString");
                }
            }
            if (Optional.IsDefined(SecondaryConnectionString))
            {
                if (SecondaryConnectionString != null)
                {
                    writer.WritePropertyName("secondaryConnectionString"u8);
                    writer.WriteStringValue(SecondaryConnectionString);
                }
                else
                {
                    writer.WriteNull("secondaryConnectionString");
                }
            }
            if (Optional.IsDefined(EndpointUri))
            {
                if (EndpointUri != null)
                {
                    writer.WritePropertyName("endpointUri"u8);
                    writer.WriteStringValue(EndpointUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("endpointUri");
                }
            }
            if (Optional.IsDefined(EntityPath))
            {
                if (EntityPath != null)
                {
                    writer.WritePropertyName("entityPath"u8);
                    writer.WriteStringValue(EntityPath);
                }
                else
                {
                    writer.WriteNull("entityPath");
                }
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(DeadLetterSecret))
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (Optional.IsDefined(DeadLetterUri))
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    if (Identity is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DigitalTwinsManagedIdentityReference>)Identity).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        internal static DigitalTwinsServiceBusProperties DeserializeDigitalTwinsServiceBusProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryConnectionString = default;
            Optional<string> secondaryConnectionString = default;
            Optional<Uri> endpointUri = default;
            Optional<string> entityPath = default;
            EndpointType endpointType = default;
            Optional<DigitalTwinsEndpointProvisioningState?> provisioningState = default;
            Optional<DateTimeOffset?> createdTime = default;
            Optional<DigitalTwinsAuthenticationType> authenticationType = default;
            Optional<string> deadLetterSecret = default;
            Optional<Uri> deadLetterUri = default;
            Optional<DigitalTwinsManagedIdentityReference> identity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryConnectionString = null;
                        continue;
                    }
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secondaryConnectionString = null;
                        continue;
                    }
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpointUri = null;
                        continue;
                    }
                    endpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entityPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entityPath = null;
                        continue;
                    }
                    entityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DigitalTwinsServiceBusProperties(endpointType, Optional.ToNullable(provisioningState), Optional.ToNullable(createdTime), Optional.ToNullable(authenticationType), deadLetterSecret.Value, deadLetterUri.Value, identity.Value, primaryConnectionString.Value, secondaryConnectionString.Value, endpointUri.Value, entityPath.Value, rawData);
        }

        DigitalTwinsServiceBusProperties IModelJsonSerializable<DigitalTwinsServiceBusProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsServiceBusProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsServiceBusProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsServiceBusProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsServiceBusProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsServiceBusProperties IModelSerializable<DigitalTwinsServiceBusProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsServiceBusProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsServiceBusProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsServiceBusProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsServiceBusProperties"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsServiceBusProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsServiceBusProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsServiceBusProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsServiceBusProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
