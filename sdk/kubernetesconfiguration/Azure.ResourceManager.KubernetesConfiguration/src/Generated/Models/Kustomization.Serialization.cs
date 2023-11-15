// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class Kustomization : IUtf8JsonSerializable, IJsonModel<Kustomization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Kustomization>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<Kustomization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<Kustomization>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<Kustomization>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                if (DependsOn != null)
                {
                    writer.WritePropertyName("dependsOn"u8);
                    writer.WriteStartArray();
                    foreach (var item in DependsOn)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dependsOn");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(RetryIntervalInSeconds))
            {
                if (RetryIntervalInSeconds != null)
                {
                    writer.WritePropertyName("retryIntervalInSeconds"u8);
                    writer.WriteNumberValue(RetryIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("retryIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(Prune))
            {
                writer.WritePropertyName("prune"u8);
                writer.WriteBooleanValue(Prune.Value);
            }
            if (Optional.IsDefined(Force))
            {
                writer.WritePropertyName("force"u8);
                writer.WriteBooleanValue(Force.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        Kustomization IJsonModel<Kustomization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Kustomization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustomization(document.RootElement, options);
        }

        internal static Kustomization DeserializeKustomization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> path = default;
            Optional<IList<string>> dependsOn = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<long?> retryIntervalInSeconds = default;
            Optional<bool> prune = default;
            Optional<bool> force = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dependsOn = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retryIntervalInSeconds = null;
                        continue;
                    }
                    retryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("prune"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prune = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("force"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    force = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Kustomization(name.Value, path.Value, Optional.ToList(dependsOn), Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), Optional.ToNullable(retryIntervalInSeconds), Optional.ToNullable(prune), Optional.ToNullable(force), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Kustomization>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Kustomization)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        Kustomization IPersistableModel<Kustomization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(Kustomization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKustomization(document.RootElement, options);
        }

        string IPersistableModel<Kustomization>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
