// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class CopyActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Inputs != null)
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Outputs != null)
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LinkedServiceName != null)
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Policy != null)
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (DependsOn != null)
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UserProperties != null)
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("source");
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("sink");
            writer.WriteObjectValue(Sink);
            if (Translator != null)
            {
                writer.WritePropertyName("translator");
                writer.WriteObjectValue(Translator);
            }
            if (EnableStaging != null)
            {
                writer.WritePropertyName("enableStaging");
                writer.WriteObjectValue(EnableStaging);
            }
            if (StagingSettings != null)
            {
                writer.WritePropertyName("stagingSettings");
                writer.WriteObjectValue(StagingSettings);
            }
            if (ParallelCopies != null)
            {
                writer.WritePropertyName("parallelCopies");
                writer.WriteObjectValue(ParallelCopies);
            }
            if (DataIntegrationUnits != null)
            {
                writer.WritePropertyName("dataIntegrationUnits");
                writer.WriteObjectValue(DataIntegrationUnits);
            }
            if (EnableSkipIncompatibleRow != null)
            {
                writer.WritePropertyName("enableSkipIncompatibleRow");
                writer.WriteObjectValue(EnableSkipIncompatibleRow);
            }
            if (RedirectIncompatibleRowSettings != null)
            {
                writer.WritePropertyName("redirectIncompatibleRowSettings");
                writer.WriteObjectValue(RedirectIncompatibleRowSettings);
            }
            if (PreserveRules != null)
            {
                writer.WritePropertyName("preserveRules");
                writer.WriteStartArray();
                foreach (var item in PreserveRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Preserve != null)
            {
                writer.WritePropertyName("preserve");
                writer.WriteStartArray();
                foreach (var item in Preserve)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CopyActivity DeserializeCopyActivity(JsonElement element)
        {
            IList<DatasetReference> inputs = default;
            IList<DatasetReference> outputs = default;
            LinkedServiceReference linkedServiceName = default;
            ActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            CopySource source = default;
            CopySink sink = default;
            object translator = default;
            object enableStaging = default;
            StagingSettings stagingSettings = default;
            object parallelCopies = default;
            object dataIntegrationUnits = default;
            object enableSkipIncompatibleRow = default;
            RedirectIncompatibleRowSettings redirectIncompatibleRowSettings = default;
            IList<object> preserveRules = default;
            IList<object> preserve = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DatasetReference.DeserializeDatasetReference(item));
                        }
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DatasetReference.DeserializeDatasetReference(item));
                        }
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ActivityDependency.DeserializeActivityDependency(item));
                        }
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(UserProperty.DeserializeUserProperty(item));
                        }
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"))
                        {
                            source = CopySource.DeserializeCopySource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sink"))
                        {
                            sink = CopySink.DeserializeCopySink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("translator"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            translator = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableStaging"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStaging = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("stagingSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stagingSettings = StagingSettings.DeserializeStagingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parallelCopies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parallelCopies = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("dataIntegrationUnits"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIntegrationUnits = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSkipIncompatibleRow"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableSkipIncompatibleRow = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("redirectIncompatibleRowSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectIncompatibleRowSettings = RedirectIncompatibleRowSettings.DeserializeRedirectIncompatibleRowSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("preserveRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            preserveRules = array;
                            continue;
                        }
                        if (property0.NameEquals("preserve"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            preserve = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CopyActivity(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy, inputs, outputs, source, sink, translator, enableStaging, stagingSettings, parallelCopies, dataIntegrationUnits, enableSkipIncompatibleRow, redirectIncompatibleRowSettings, preserveRules, preserve);
        }
    }
}
