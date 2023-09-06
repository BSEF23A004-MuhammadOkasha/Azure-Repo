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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class CheckManagementGroupPolicyRestrictionsContent : IUtf8JsonSerializable, IModelJsonSerializable<CheckManagementGroupPolicyRestrictionsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CheckManagementGroupPolicyRestrictionsContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CheckManagementGroupPolicyRestrictionsContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckManagementGroupPolicyRestrictionsContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceDetails))
            {
                writer.WritePropertyName("resourceDetails"u8);
                if (ResourceDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CheckRestrictionsResourceDetails>)ResourceDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(PendingFields))
            {
                writer.WritePropertyName("pendingFields"u8);
                writer.WriteStartArray();
                foreach (var item in PendingFields)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PendingField>)item).Serialize(writer, options);
                    }
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

        internal static CheckManagementGroupPolicyRestrictionsContent DeserializeCheckManagementGroupPolicyRestrictionsContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CheckRestrictionsResourceDetails> resourceDetails = default;
            Optional<IList<PendingField>> pendingFields = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDetails = CheckRestrictionsResourceDetails.DeserializeCheckRestrictionsResourceDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("pendingFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PendingField> array = new List<PendingField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PendingField.DeserializePendingField(item));
                    }
                    pendingFields = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CheckManagementGroupPolicyRestrictionsContent(resourceDetails.Value, Optional.ToList(pendingFields), rawData);
        }

        CheckManagementGroupPolicyRestrictionsContent IModelJsonSerializable<CheckManagementGroupPolicyRestrictionsContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckManagementGroupPolicyRestrictionsContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckManagementGroupPolicyRestrictionsContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CheckManagementGroupPolicyRestrictionsContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckManagementGroupPolicyRestrictionsContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CheckManagementGroupPolicyRestrictionsContent IModelSerializable<CheckManagementGroupPolicyRestrictionsContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckManagementGroupPolicyRestrictionsContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCheckManagementGroupPolicyRestrictionsContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CheckManagementGroupPolicyRestrictionsContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CheckManagementGroupPolicyRestrictionsContent"/> to convert. </param>
        public static implicit operator RequestContent(CheckManagementGroupPolicyRestrictionsContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CheckManagementGroupPolicyRestrictionsContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CheckManagementGroupPolicyRestrictionsContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCheckManagementGroupPolicyRestrictionsContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
