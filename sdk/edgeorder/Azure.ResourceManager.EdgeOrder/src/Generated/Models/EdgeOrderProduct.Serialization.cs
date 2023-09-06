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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProduct : IUtf8JsonSerializable, IModelJsonSerializable<EdgeOrderProduct>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeOrderProduct>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeOrderProduct>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderProduct>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static EdgeOrderProduct DeserializeEdgeOrderProduct(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<ProductDescription> description = default;
            Optional<IReadOnlyList<EdgeOrderProductImageInformation>> imageInformation = default;
            Optional<EdgeOrderProductCostInformation> costInformation = default;
            Optional<ProductAvailabilityInformation> availabilityInformation = default;
            Optional<HierarchyInformation> hierarchyInformation = default;
            Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Optional<IReadOnlyList<ProductConfiguration>> configurations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = ProductDescription.DeserializeProductDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("imageInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EdgeOrderProductImageInformation> array = new List<EdgeOrderProductImageInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EdgeOrderProductImageInformation.DeserializeEdgeOrderProductImageInformation(item));
                            }
                            imageInformation = array;
                            continue;
                        }
                        if (property0.NameEquals("costInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInformation = EdgeOrderProductCostInformation.DeserializeEdgeOrderProductCostInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityInformation = ProductAvailabilityInformation.DeserializeProductAvailabilityInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterableProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FilterableProperty> array = new List<FilterableProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("configurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProductConfiguration> array = new List<ProductConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProductConfiguration.DeserializeProductConfiguration(item));
                            }
                            configurations = array;
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
            return new EdgeOrderProduct(displayName.Value, description.Value, Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Optional.ToList(filterableProperties), Optional.ToList(configurations), rawData);
        }

        EdgeOrderProduct IModelJsonSerializable<EdgeOrderProduct>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderProduct>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProduct(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeOrderProduct>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderProduct>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeOrderProduct IModelSerializable<EdgeOrderProduct>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeOrderProduct>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeOrderProduct(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeOrderProduct"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeOrderProduct"/> to convert. </param>
        public static implicit operator RequestContent(EdgeOrderProduct model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeOrderProduct"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeOrderProduct(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeOrderProduct(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
