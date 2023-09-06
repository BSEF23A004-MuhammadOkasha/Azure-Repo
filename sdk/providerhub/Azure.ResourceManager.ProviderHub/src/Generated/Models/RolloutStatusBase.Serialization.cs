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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class RolloutStatusBase : IUtf8JsonSerializable, IModelJsonSerializable<RolloutStatusBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RolloutStatusBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RolloutStatusBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutStatusBase>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CompletedRegions))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailedOrSkippedRegions))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ExtendedErrorInfo>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static RolloutStatusBase DeserializeRolloutStatusBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AzureLocation>> completedRegions = default;
            Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RolloutStatusBase(Optional.ToList(completedRegions), Optional.ToDictionary(failedOrSkippedRegions), rawData);
        }

        RolloutStatusBase IModelJsonSerializable<RolloutStatusBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutStatusBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRolloutStatusBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RolloutStatusBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutStatusBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RolloutStatusBase IModelSerializable<RolloutStatusBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutStatusBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRolloutStatusBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RolloutStatusBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RolloutStatusBase"/> to convert. </param>
        public static implicit operator RequestContent(RolloutStatusBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RolloutStatusBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RolloutStatusBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRolloutStatusBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
