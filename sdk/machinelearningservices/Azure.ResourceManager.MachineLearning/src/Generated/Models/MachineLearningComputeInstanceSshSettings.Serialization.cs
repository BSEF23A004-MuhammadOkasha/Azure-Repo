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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceSshSettings : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningComputeInstanceSshSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningComputeInstanceSshSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningComputeInstanceSshSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceSshSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SshPublicAccess))
            {
                writer.WritePropertyName("sshPublicAccess"u8);
                writer.WriteStringValue(SshPublicAccess.Value.ToString());
            }
            if (Optional.IsDefined(AdminPublicKey))
            {
                writer.WritePropertyName("adminPublicKey"u8);
                writer.WriteStringValue(AdminPublicKey);
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

        internal static MachineLearningComputeInstanceSshSettings DeserializeMachineLearningComputeInstanceSshSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningSshPublicAccess> sshPublicAccess = default;
            Optional<string> adminUserName = default;
            Optional<int> sshPort = default;
            Optional<string> adminPublicKey = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshPublicAccess = new MachineLearningSshPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adminUserName"u8))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adminPublicKey"u8))
                {
                    adminPublicKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningComputeInstanceSshSettings(Optional.ToNullable(sshPublicAccess), adminUserName.Value, Optional.ToNullable(sshPort), adminPublicKey.Value, serializedAdditionalRawData);
        }

        MachineLearningComputeInstanceSshSettings IModelJsonSerializable<MachineLearningComputeInstanceSshSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceSshSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceSshSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningComputeInstanceSshSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceSshSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningComputeInstanceSshSettings IModelSerializable<MachineLearningComputeInstanceSshSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningComputeInstanceSshSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningComputeInstanceSshSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningComputeInstanceSshSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningComputeInstanceSshSettings"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningComputeInstanceSshSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningComputeInstanceSshSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningComputeInstanceSshSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningComputeInstanceSshSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
