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

namespace Azure.ResourceManager.Grafana.Models
{
    internal partial class GrafanaIntegrations : IUtf8JsonSerializable, IModelJsonSerializable<GrafanaIntegrations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GrafanaIntegrations>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GrafanaIntegrations>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GrafanaIntegrations>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(MonitorWorkspaceIntegrations))
            {
                writer.WritePropertyName("azureMonitorWorkspaceIntegrations"u8);
                writer.WriteStartArray();
                foreach (var item in MonitorWorkspaceIntegrations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MonitorWorkspaceIntegration>)item).Serialize(writer, options);
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

        internal static GrafanaIntegrations DeserializeGrafanaIntegrations(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MonitorWorkspaceIntegration>> azureMonitorWorkspaceIntegrations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureMonitorWorkspaceIntegrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorWorkspaceIntegration> array = new List<MonitorWorkspaceIntegration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorWorkspaceIntegration.DeserializeMonitorWorkspaceIntegration(item));
                    }
                    azureMonitorWorkspaceIntegrations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GrafanaIntegrations(Optional.ToList(azureMonitorWorkspaceIntegrations), rawData);
        }

        GrafanaIntegrations IModelJsonSerializable<GrafanaIntegrations>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GrafanaIntegrations>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGrafanaIntegrations(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GrafanaIntegrations>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GrafanaIntegrations>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GrafanaIntegrations IModelSerializable<GrafanaIntegrations>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GrafanaIntegrations>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGrafanaIntegrations(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GrafanaIntegrations"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GrafanaIntegrations"/> to convert. </param>
        public static implicit operator RequestContent(GrafanaIntegrations model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GrafanaIntegrations"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GrafanaIntegrations(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGrafanaIntegrations(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
