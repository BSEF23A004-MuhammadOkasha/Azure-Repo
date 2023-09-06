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

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class SharedAccessAuthorizationRuleProperties : IUtf8JsonSerializable, IModelJsonSerializable<SharedAccessAuthorizationRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SharedAccessAuthorizationRuleProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SharedAccessAuthorizationRuleProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharedAccessAuthorizationRuleProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rights))
            {
                writer.WritePropertyName("rights"u8);
                writer.WriteStartArray();
                foreach (var item in Rights)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        internal static SharedAccessAuthorizationRuleProperties DeserializeSharedAccessAuthorizationRuleProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AuthorizationRuleAccessRight>> rights = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            Optional<string> claimType = default;
            Optional<string> claimValue = default;
            Optional<DateTimeOffset> modifiedTime = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<int> revision = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizationRuleAccessRight> array = new List<AuthorizationRuleAccessRight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToAuthorizationRuleAccessRight());
                    }
                    rights = array;
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claimType"u8))
                {
                    claimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claimValue"u8))
                {
                    claimValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("revision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    revision = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SharedAccessAuthorizationRuleProperties(Optional.ToList(rights), primaryKey.Value, secondaryKey.Value, keyName.Value, claimType.Value, claimValue.Value, Optional.ToNullable(modifiedTime), Optional.ToNullable(createdTime), Optional.ToNullable(revision), rawData);
        }

        SharedAccessAuthorizationRuleProperties IModelJsonSerializable<SharedAccessAuthorizationRuleProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharedAccessAuthorizationRuleProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedAccessAuthorizationRuleProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SharedAccessAuthorizationRuleProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharedAccessAuthorizationRuleProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SharedAccessAuthorizationRuleProperties IModelSerializable<SharedAccessAuthorizationRuleProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharedAccessAuthorizationRuleProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSharedAccessAuthorizationRuleProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SharedAccessAuthorizationRuleProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SharedAccessAuthorizationRuleProperties"/> to convert. </param>
        public static implicit operator RequestContent(SharedAccessAuthorizationRuleProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SharedAccessAuthorizationRuleProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSharedAccessAuthorizationRuleProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
