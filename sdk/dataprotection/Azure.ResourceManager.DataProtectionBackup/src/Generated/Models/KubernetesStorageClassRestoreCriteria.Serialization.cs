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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesStorageClassRestoreCriteria : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesStorageClassRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesStorageClassRestoreCriteria>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesStorageClassRestoreCriteria>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesStorageClassRestoreCriteria>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SelectedStorageClassName))
            {
                writer.WritePropertyName("selectedStorageClassName"u8);
                writer.WriteStringValue(SelectedStorageClassName);
            }
            if (Optional.IsDefined(Provisioner))
            {
                writer.WritePropertyName("provisioner"u8);
                writer.WriteStringValue(Provisioner);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static KubernetesStorageClassRestoreCriteria DeserializeKubernetesStorageClassRestoreCriteria(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> selectedStorageClassName = default;
            Optional<string> provisioner = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedStorageClassName"u8))
                {
                    selectedStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioner"u8))
                {
                    provisioner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesStorageClassRestoreCriteria(objectType, selectedStorageClassName.Value, provisioner.Value, rawData);
        }

        KubernetesStorageClassRestoreCriteria IModelJsonSerializable<KubernetesStorageClassRestoreCriteria>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesStorageClassRestoreCriteria>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesStorageClassRestoreCriteria(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesStorageClassRestoreCriteria>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesStorageClassRestoreCriteria>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesStorageClassRestoreCriteria IModelSerializable<KubernetesStorageClassRestoreCriteria>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KubernetesStorageClassRestoreCriteria>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesStorageClassRestoreCriteria(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KubernetesStorageClassRestoreCriteria"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KubernetesStorageClassRestoreCriteria"/> to convert. </param>
        public static implicit operator RequestContent(KubernetesStorageClassRestoreCriteria model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KubernetesStorageClassRestoreCriteria"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KubernetesStorageClassRestoreCriteria(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesStorageClassRestoreCriteria(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
