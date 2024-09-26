// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsPrivateCloudPatch : IUtf8JsonSerializable, IJsonModel<AvsPrivateCloudPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsPrivateCloudPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsPrivateCloudPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagementCluster))
            {
                writer.WritePropertyName("managementCluster"u8);
                writer.WriteObjectValue(ManagementCluster, options);
            }
            if (Optional.IsDefined(Internet))
            {
                writer.WritePropertyName("internet"u8);
                writer.WriteStringValue(Internet.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IdentitySources))
            {
                writer.WritePropertyName("identitySources"u8);
                writer.WriteStartArray();
                foreach (var item in IdentitySources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteObjectValue(Availability, options);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (Optional.IsCollectionDefined(ExtendedNetworkBlocks))
            {
                writer.WritePropertyName("extendedNetworkBlocks"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedNetworkBlocks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AvsPrivateCloudPatch IJsonModel<AvsPrivateCloudPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudPatch(document.RootElement, options);
        }

        internal static AvsPrivateCloudPatch DeserializeAvsPrivateCloudPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ManagedServiceIdentity identity = default;
            AvsManagementCluster managementCluster = default;
            InternetConnectivityState? internet = default;
            IList<SingleSignOnIdentitySource> identitySources = default;
            PrivateCloudAvailabilityProperties availability = default;
            CustomerManagedEncryption encryption = default;
            IList<string> extendedNetworkBlocks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("managementCluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementCluster = AvsManagementCluster.DeserializeAvsManagementCluster(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("internet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internet = new InternetConnectivityState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("identitySources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SingleSignOnIdentitySource> array = new List<SingleSignOnIdentitySource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SingleSignOnIdentitySource.DeserializeSingleSignOnIdentitySource(item, options));
                            }
                            identitySources = array;
                            continue;
                        }
                        if (property0.NameEquals("availability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availability = PrivateCloudAvailabilityProperties.DeserializePrivateCloudAvailabilityProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = CustomerManagedEncryption.DeserializeCustomerManagedEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("extendedNetworkBlocks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            extendedNetworkBlocks = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvsPrivateCloudPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                identity,
                managementCluster,
                internet,
                identitySources ?? new ChangeTrackingList<SingleSignOnIdentitySource>(),
                availability,
                encryption,
                extendedNetworkBlocks ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsPrivateCloudPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudPatch)} does not support writing '{options.Format}' format.");
            }
        }

        AvsPrivateCloudPatch IPersistableModel<AvsPrivateCloudPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsPrivateCloudPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsPrivateCloudPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
