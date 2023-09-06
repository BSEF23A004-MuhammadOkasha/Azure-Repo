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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRedirectConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayRedirectConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayRedirectConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayRedirectConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRedirectConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RedirectType))
            {
                writer.WritePropertyName("redirectType"u8);
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (Optional.IsDefined(TargetListener))
            {
                writer.WritePropertyName("targetListener"u8);
                JsonSerializer.Serialize(writer, TargetListener);
            }
            if (Optional.IsDefined(TargetUri))
            {
                writer.WritePropertyName("targetUrl"u8);
                writer.WriteStringValue(TargetUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IncludePath))
            {
                writer.WritePropertyName("includePath"u8);
                writer.WriteBooleanValue(IncludePath.Value);
            }
            if (Optional.IsDefined(IncludeQueryString))
            {
                writer.WritePropertyName("includeQueryString"u8);
                writer.WriteBooleanValue(IncludeQueryString.Value);
            }
            if (Optional.IsCollectionDefined(RequestRoutingRules))
            {
                writer.WritePropertyName("requestRoutingRules"u8);
                writer.WriteStartArray();
                foreach (var item in RequestRoutingRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UrlPathMaps))
            {
                writer.WritePropertyName("urlPathMaps"u8);
                writer.WriteStartArray();
                foreach (var item in UrlPathMaps)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PathRules))
            {
                writer.WritePropertyName("pathRules"u8);
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static ApplicationGatewayRedirectConfiguration DeserializeApplicationGatewayRedirectConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ApplicationGatewayRedirectType> redirectType = default;
            Optional<WritableSubResource> targetListener = default;
            Optional<Uri> targetUrl = default;
            Optional<bool> includePath = default;
            Optional<bool> includeQueryString = default;
            Optional<IList<WritableSubResource>> requestRoutingRules = default;
            Optional<IList<WritableSubResource>> urlPathMaps = default;
            Optional<IList<WritableSubResource>> pathRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("redirectType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectType = new ApplicationGatewayRedirectType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetListener"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetListener = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("targetUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("includePath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            includePath = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("includeQueryString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            includeQueryString = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requestRoutingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            requestRoutingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("urlPathMaps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            urlPathMaps = array;
                            continue;
                        }
                        if (property0.NameEquals("pathRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            pathRules = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayRedirectConfiguration(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(redirectType), targetListener, targetUrl.Value, Optional.ToNullable(includePath), Optional.ToNullable(includeQueryString), Optional.ToList(requestRoutingRules), Optional.ToList(urlPathMaps), Optional.ToList(pathRules), rawData);
        }

        ApplicationGatewayRedirectConfiguration IModelJsonSerializable<ApplicationGatewayRedirectConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRedirectConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRedirectConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayRedirectConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRedirectConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayRedirectConfiguration IModelSerializable<ApplicationGatewayRedirectConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRedirectConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayRedirectConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationGatewayRedirectConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationGatewayRedirectConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationGatewayRedirectConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationGatewayRedirectConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationGatewayRedirectConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayRedirectConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
