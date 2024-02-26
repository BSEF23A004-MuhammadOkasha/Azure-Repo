// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesClusterRestoreCriteria : IUtf8JsonSerializable, IJsonModel<KubernetesClusterRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesClusterRestoreCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesClusterRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("includeClusterScopeResources"u8);
            writer.WriteBooleanValue(IsClusterScopeResourcesIncluded);
            if (!(IncludedNamespaces is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("includedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExcludedNamespaces is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("excludedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(IncludedResourceTypes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("includedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExcludedResourceTypes is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("excludedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LabelSelectors is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("labelSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in LabelSelectors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (PersistentVolumeRestoreMode.HasValue)
            {
                writer.WritePropertyName("persistentVolumeRestoreMode"u8);
                writer.WriteStringValue(PersistentVolumeRestoreMode.Value.ToString());
            }
            if (ConflictPolicy.HasValue)
            {
                writer.WritePropertyName("conflictPolicy"u8);
                writer.WriteStringValue(ConflictPolicy.Value.ToString());
            }
            if (!(NamespaceMappings is ChangeTrackingDictionary<string, string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("namespaceMappings"u8);
                writer.WriteStartObject();
                foreach (var item in NamespaceMappings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(RestoreHookReferences is ChangeTrackingList<NamespacedName> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("restoreHookReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreHookReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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
            writer.WriteEndObject();
        }

        KubernetesClusterRestoreCriteria IJsonModel<KubernetesClusterRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterRestoreCriteria(document.RootElement, options);
        }

        internal static KubernetesClusterRestoreCriteria DeserializeKubernetesClusterRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool includeClusterScopeResources = default;
            IList<string> includedNamespaces = default;
            IList<string> excludedNamespaces = default;
            IList<string> includedResourceTypes = default;
            IList<string> excludedResourceTypes = default;
            IList<string> labelSelectors = default;
            Optional<PersistentVolumeRestoreMode> persistentVolumeRestoreMode = default;
            Optional<KubernetesClusterRestoreExistingResourcePolicy> conflictPolicy = default;
            IDictionary<string, string> namespaceMappings = default;
            IList<NamespacedName> restoreHookReferences = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includeClusterScopeResources"u8))
                {
                    includeClusterScopeResources = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includedNamespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("excludedNamespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("includedResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("excludedResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("labelSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labelSelectors = array;
                    continue;
                }
                if (property.NameEquals("persistentVolumeRestoreMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    persistentVolumeRestoreMode = new PersistentVolumeRestoreMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conflictPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictPolicy = new KubernetesClusterRestoreExistingResourcePolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("namespaceMappings"u8))
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
                    namespaceMappings = dictionary;
                    continue;
                }
                if (property.NameEquals("restoreHookReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamespacedName> array = new List<NamespacedName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamespacedName.DeserializeNamespacedName(item, options));
                    }
                    restoreHookReferences = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesClusterRestoreCriteria(objectType, serializedAdditionalRawData, includeClusterScopeResources, includedNamespaces ?? new ChangeTrackingList<string>(), excludedNamespaces ?? new ChangeTrackingList<string>(), includedResourceTypes ?? new ChangeTrackingList<string>(), excludedResourceTypes ?? new ChangeTrackingList<string>(), labelSelectors ?? new ChangeTrackingList<string>(), Optional.ToNullable(persistentVolumeRestoreMode), Optional.ToNullable(conflictPolicy), namespaceMappings ?? new ChangeTrackingDictionary<string, string>(), restoreHookReferences ?? new ChangeTrackingList<NamespacedName>());
        }

        BinaryData IPersistableModel<KubernetesClusterRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        KubernetesClusterRestoreCriteria IPersistableModel<KubernetesClusterRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesClusterRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesClusterRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
