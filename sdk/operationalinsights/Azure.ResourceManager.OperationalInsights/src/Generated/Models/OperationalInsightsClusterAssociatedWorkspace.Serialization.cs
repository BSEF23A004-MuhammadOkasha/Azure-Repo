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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsClusterAssociatedWorkspace : IUtf8JsonSerializable, IJsonModel<OperationalInsightsClusterAssociatedWorkspace>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsClusterAssociatedWorkspace>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<OperationalInsightsClusterAssociatedWorkspace>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WorkspaceId))
                {
                    writer.WritePropertyName("workspaceId"u8);
                    writer.WriteStringValue(WorkspaceId.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WorkspaceName))
                {
                    writer.WritePropertyName("workspaceName"u8);
                    writer.WriteStringValue(WorkspaceName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ResourceId))
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(AssociatedOn))
                {
                    writer.WritePropertyName("associateDate"u8);
                    writer.WriteStringValue(AssociatedOn.Value, "R");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        OperationalInsightsClusterAssociatedWorkspace IJsonModel<OperationalInsightsClusterAssociatedWorkspace>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsClusterAssociatedWorkspace)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsClusterAssociatedWorkspace(document.RootElement, options);
        }

        internal static OperationalInsightsClusterAssociatedWorkspace DeserializeOperationalInsightsClusterAssociatedWorkspace(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> workspaceId = default;
            Optional<string> workspaceName = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<DateTimeOffset> associateDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("associateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    associateDate = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsClusterAssociatedWorkspace(Optional.ToNullable(workspaceId), workspaceName.Value, resourceId.Value, Optional.ToNullable(associateDate), serializedAdditionalRawData);
        }

        BinaryData IModel<OperationalInsightsClusterAssociatedWorkspace>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsClusterAssociatedWorkspace)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationalInsightsClusterAssociatedWorkspace IModel<OperationalInsightsClusterAssociatedWorkspace>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsClusterAssociatedWorkspace)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsClusterAssociatedWorkspace(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<OperationalInsightsClusterAssociatedWorkspace>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
