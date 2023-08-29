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

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterWorkerAssignment : IUtf8JsonSerializable, IModelJsonSerializable<RouterWorkerAssignment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterWorkerAssignment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterWorkerAssignment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("assignmentId"u8);
            writer.WriteStringValue(AssignmentId);
            writer.WritePropertyName("jobId"u8);
            writer.WriteStringValue(JobId);
            writer.WritePropertyName("capacityCost"u8);
            writer.WriteNumberValue(CapacityCost);
            writer.WritePropertyName("assignedAt"u8);
            writer.WriteStringValue(AssignedAt, "O");
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

        internal static RouterWorkerAssignment DeserializeRouterWorkerAssignment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assignmentId = default;
            string jobId = default;
            int capacityCost = default;
            DateTimeOffset assignedAt = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCost"u8))
                {
                    capacityCost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("assignedAt"u8))
                {
                    assignedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt, rawData);
        }

        RouterWorkerAssignment IModelJsonSerializable<RouterWorkerAssignment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterWorkerAssignment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterWorkerAssignment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterWorkerAssignment IModelSerializable<RouterWorkerAssignment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterWorkerAssignment(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RouterWorkerAssignment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RouterWorkerAssignment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterWorkerAssignment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
