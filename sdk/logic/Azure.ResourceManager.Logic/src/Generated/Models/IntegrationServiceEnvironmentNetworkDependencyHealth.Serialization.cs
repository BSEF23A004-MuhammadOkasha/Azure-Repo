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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentNetworkDependencyHealth : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationServiceEnvironmentNetworkDependencyHealth>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationServiceErrorInfo>)Error).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        internal static IntegrationServiceEnvironmentNetworkDependencyHealth DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationServiceErrorInfo> error = default;
            Optional<IntegrationServiceEnvironmentNetworkDependencyHealthState> state = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = IntegrationServiceErrorInfo.DeserializeIntegrationServiceErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationServiceEnvironmentNetworkDependencyHealthState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentNetworkDependencyHealth(error.Value, Optional.ToNullable(state), serializedAdditionalRawData);
        }

        IntegrationServiceEnvironmentNetworkDependencyHealth IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationServiceEnvironmentNetworkDependencyHealth>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationServiceEnvironmentNetworkDependencyHealth>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationServiceEnvironmentNetworkDependencyHealth IModelSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IntegrationServiceEnvironmentNetworkDependencyHealth>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationServiceEnvironmentNetworkDependencyHealth"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationServiceEnvironmentNetworkDependencyHealth"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationServiceEnvironmentNetworkDependencyHealth model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationServiceEnvironmentNetworkDependencyHealth"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationServiceEnvironmentNetworkDependencyHealth(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
