// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationNavigation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                if (Kind != null)
                {
                    writer.WritePropertyName("kind"u8);
                    writer.WriteStringValue(Kind.Value.ToString());
                }
                else
                {
                    writer.WriteNull("kind");
                }
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ContentUri))
            {
                writer.WritePropertyName("contentUri"u8);
                writer.WriteStringValue(ContentUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ContentHash))
            {
                writer.WritePropertyName("contentHash"u8);
                writer.WriteStringValue(ContentHash);
            }
            if (Optional.IsDefined(AssignmentType))
            {
                if (AssignmentType != null)
                {
                    writer.WritePropertyName("assignmentType"u8);
                    writer.WriteStringValue(AssignmentType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("assignmentType");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationParameters))
            {
                writer.WritePropertyName("configurationParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedParameters))
            {
                writer.WritePropertyName("configurationProtectedParameter"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationProtectedParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationNavigation DeserializeGuestConfigurationNavigation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GuestConfigurationKind?> kind = default;
            Optional<string> name = default;
            Optional<string> version = default;
            Optional<Uri> contentUri = default;
            Optional<string> contentHash = default;
            Optional<GuestConfigurationAssignmentType?> assignmentType = default;
            Optional<string> assignmentSource = default;
            Optional<string> contentType = default;
            Optional<IList<GuestConfigurationParameter>> configurationParameter = default;
            Optional<IList<GuestConfigurationParameter>> configurationProtectedParameter = default;
            Optional<LcmConfigurationSetting> configurationSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kind = null;
                        continue;
                    }
                    kind = new GuestConfigurationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentHash"u8))
                {
                    contentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentType = null;
                        continue;
                    }
                    assignmentType = new GuestConfigurationAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentSource = null;
                        continue;
                    }
                    assignmentSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contentType = null;
                        continue;
                    }
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item));
                    }
                    configurationParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationProtectedParameter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuestConfigurationParameter> array = new List<GuestConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuestConfigurationParameter.DeserializeGuestConfigurationParameter(item));
                    }
                    configurationProtectedParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configurationSetting = null;
                        continue;
                    }
                    configurationSetting = LcmConfigurationSetting.DeserializeLcmConfigurationSetting(property.Value);
                    continue;
                }
            }
            return new GuestConfigurationNavigation(Optional.ToNullable(kind), name.Value, version.Value, contentUri.Value, contentHash.Value, Optional.ToNullable(assignmentType), assignmentSource.Value, contentType.Value, Optional.ToList(configurationParameter), Optional.ToList(configurationProtectedParameter), configurationSetting.Value);
        }
    }
}
