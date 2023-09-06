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
    public partial class TrackedResourceModificationDetails : IUtf8JsonSerializable, IModelJsonSerializable<TrackedResourceModificationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrackedResourceModificationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrackedResourceModificationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrackedResourceModificationDetails>(this, options.Format);

            writer.WriteStartObject();
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

        internal static TrackedResourceModificationDetails DeserializeTrackedResourceModificationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyDetails> policyDetails = default;
            Optional<ResourceIdentifier> deploymentId = default;
            Optional<DateTimeOffset> deploymentTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDetails = PolicyDetails.DeserializePolicyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("deploymentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrackedResourceModificationDetails(policyDetails.Value, deploymentId.Value, Optional.ToNullable(deploymentTime), rawData);
        }

        TrackedResourceModificationDetails IModelJsonSerializable<TrackedResourceModificationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrackedResourceModificationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrackedResourceModificationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrackedResourceModificationDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrackedResourceModificationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrackedResourceModificationDetails IModelSerializable<TrackedResourceModificationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrackedResourceModificationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrackedResourceModificationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrackedResourceModificationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrackedResourceModificationDetails"/> to convert. </param>
        public static implicit operator RequestContent(TrackedResourceModificationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrackedResourceModificationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrackedResourceModificationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrackedResourceModificationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
