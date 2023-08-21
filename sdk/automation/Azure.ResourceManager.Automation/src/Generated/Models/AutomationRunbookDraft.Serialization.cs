// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationRunbookDraft : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsInEditMode))
            {
                writer.WritePropertyName("inEdit"u8);
                writer.WriteBooleanValue(IsInEditMode.Value);
            }
            if (Optional.IsDefined(DraftContentLink))
            {
                writer.WritePropertyName("draftContentLink"u8);
                writer.WriteObjectValue(DraftContentLink);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(OutputTypes))
            {
                writer.WritePropertyName("outputTypes"u8);
                writer.WriteStartArray();
                foreach (var item in OutputTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AutomationRunbookDraft DeserializeAutomationRunbookDraft(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> inEdit = default;
            Optional<AutomationContentLink> draftContentLink = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<IDictionary<string, RunbookParameterDefinition>> parameters = default;
            Optional<IList<string>> outputTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inEdit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inEdit = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("draftContentLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    draftContentLink = AutomationContentLink.DeserializeAutomationContentLink(property.Value);
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RunbookParameterDefinition> dictionary = new Dictionary<string, RunbookParameterDefinition>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RunbookParameterDefinition.DeserializeRunbookParameterDefinition(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("outputTypes"u8))
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
                    outputTypes = array;
                    continue;
                }
            }
            return new AutomationRunbookDraft(Optional.ToNullable(inEdit), draftContentLink.Value, Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), Optional.ToDictionary(parameters), Optional.ToList(outputTypes));
        }
    }
}
