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
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    internal partial class ScopeAssignmentListResult : IUtf8JsonSerializable, IModelJsonSerializable<ScopeAssignmentListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScopeAssignmentListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScopeAssignmentListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScopeAssignmentListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ScopeAssignmentData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static ScopeAssignmentListResult DeserializeScopeAssignmentListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ScopeAssignmentData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScopeAssignmentData> array = new List<ScopeAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScopeAssignmentData.DeserializeScopeAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScopeAssignmentListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        ScopeAssignmentListResult IModelJsonSerializable<ScopeAssignmentListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScopeAssignmentListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScopeAssignmentListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScopeAssignmentListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScopeAssignmentListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScopeAssignmentListResult IModelSerializable<ScopeAssignmentListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScopeAssignmentListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScopeAssignmentListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScopeAssignmentListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScopeAssignmentListResult"/> to convert. </param>
        public static implicit operator RequestContent(ScopeAssignmentListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScopeAssignmentListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScopeAssignmentListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScopeAssignmentListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
