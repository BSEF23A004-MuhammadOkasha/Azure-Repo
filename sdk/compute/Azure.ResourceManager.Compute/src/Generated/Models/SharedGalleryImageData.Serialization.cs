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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class SharedGalleryImageData : IUtf8JsonSerializable, IModelJsonSerializable<SharedGalleryImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SharedGalleryImageData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SharedGalleryImageData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SharedGalleryImageData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(OSState))
            {
                writer.WritePropertyName("osState"u8);
                writer.WriteStringValue(OSState.Value.ToSerialString());
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteObjectValue(Identifier);
            }
            if (Optional.IsDefined(Recommended))
            {
                writer.WritePropertyName("recommended"u8);
                writer.WriteObjectValue(Recommended);
            }
            if (Optional.IsDefined(Disallowed))
            {
                writer.WritePropertyName("disallowed"u8);
                writer.WriteObjectValue(Disallowed);
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration"u8);
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan"u8);
                writer.WriteObjectValue(PurchasePlan);
            }
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture.Value.ToString());
            }
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri"u8);
                writer.WriteStringValue(PrivacyStatementUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("identifier"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UniqueId))
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
            }
            writer.WriteEndObject();
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

        internal static SharedGalleryImageData DeserializeSharedGalleryImageData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<SupportedOperatingSystemType> osType = default;
            Optional<OperatingSystemStateType> osState = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<GalleryImageIdentifier> identifier = default;
            Optional<RecommendedMachineConfiguration> recommended = default;
            Optional<Disallowed> disallowed = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<IReadOnlyList<GalleryImageFeature>> features = default;
            Optional<ImagePurchasePlan> purchasePlan = default;
            Optional<ArchitectureType> architecture = default;
            Optional<Uri> privacyStatementUri = default;
            Optional<string> eula = default;
            Optional<string> uniqueId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("osState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osState = property0.Value.GetString().ToOperatingSystemStateType();
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = GalleryImageIdentifier.DeserializeGalleryImageIdentifier(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recommended"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommended = RecommendedMachineConfiguration.DeserializeRecommendedMachineConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disallowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowed = Disallowed.DeserializeDisallowed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("features"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GalleryImageFeature> array = new List<GalleryImageFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GalleryImageFeature.DeserializeGalleryImageFeature(item));
                            }
                            features = array;
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasePlan = ImagePurchasePlan.DeserializeImagePurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("architecture"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            architecture = new ArchitectureType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privacyStatementUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyStatementUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eula"u8))
                        {
                            eula = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SharedGalleryImageData(name.Value, Optional.ToNullable(location), uniqueId.Value, Optional.ToNullable(osType), Optional.ToNullable(osState), Optional.ToNullable(endOfLifeDate), identifier.Value, recommended.Value, disallowed.Value, Optional.ToNullable(hyperVGeneration), Optional.ToList(features), purchasePlan.Value, Optional.ToNullable(architecture), privacyStatementUri.Value, eula.Value, rawData);
        }

        SharedGalleryImageData IModelJsonSerializable<SharedGalleryImageData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SharedGalleryImageData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryImageData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SharedGalleryImageData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SharedGalleryImageData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SharedGalleryImageData IModelSerializable<SharedGalleryImageData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SharedGalleryImageData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSharedGalleryImageData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SharedGalleryImageData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SharedGalleryImageData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSharedGalleryImageData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
