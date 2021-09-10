// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class TrialComponent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CodeId))
            {
                if (CodeId != null)
                {
                    writer.WritePropertyName("codeId");
                    writer.WriteStringValue(CodeId);
                }
                else
                {
                    writer.WriteNull("codeId");
                }
            }
            writer.WritePropertyName("command");
            writer.WriteStringValue(Command);
            if (Optional.IsDefined(Distribution))
            {
                if (Distribution != null)
                {
                    writer.WritePropertyName("distribution");
                    writer.WriteObjectValue(Distribution);
                }
                else
                {
                    writer.WriteNull("distribution");
                }
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId");
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables");
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (Optional.IsDefined(Resources))
            {
                if (Resources != null)
                {
                    writer.WritePropertyName("resources");
                    writer.WriteObjectValue(Resources);
                }
                else
                {
                    writer.WriteNull("resources");
                }
            }
            writer.WriteEndObject();
        }

        internal static TrialComponent DeserializeTrialComponent(JsonElement element)
        {
            Optional<string> codeId = default;
            string command = default;
            Optional<DistributionConfiguration> distribution = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<ResourceConfiguration> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeId = null;
                        continue;
                    }
                    codeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distribution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distribution = null;
                        continue;
                    }
                    distribution = DistributionConfiguration.DeserializeDistributionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resources = null;
                        continue;
                    }
                    resources = ResourceConfiguration.DeserializeResourceConfiguration(property.Value);
                    continue;
                }
            }
            return new TrialComponent(codeId.Value, command, distribution.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), resources.Value);
        }
    }
}
