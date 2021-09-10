// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ManagedOnlineDeployment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled");
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration");
                    writer.WriteObjectValue(CodeConfiguration);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("endpointComputeType");
            writer.WriteStringValue(EndpointComputeType.ToString());
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
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType");
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                if (LivenessProbe != null)
                {
                    writer.WritePropertyName("livenessProbe");
                    writer.WriteObjectValue(LivenessProbe);
                }
                else
                {
                    writer.WriteNull("livenessProbe");
                }
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model");
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(ModelMountPath))
            {
                if (ModelMountPath != null)
                {
                    writer.WritePropertyName("modelMountPath");
                    writer.WriteStringValue(ModelMountPath);
                }
                else
                {
                    writer.WriteNull("modelMountPath");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                if (ReadinessProbe != null)
                {
                    writer.WritePropertyName("readinessProbe");
                    writer.WriteObjectValue(ReadinessProbe);
                }
                else
                {
                    writer.WriteNull("readinessProbe");
                }
            }
            if (Optional.IsDefined(RequestSettings))
            {
                if (RequestSettings != null)
                {
                    writer.WritePropertyName("requestSettings");
                    writer.WriteObjectValue(RequestSettings);
                }
                else
                {
                    writer.WriteNull("requestSettings");
                }
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                if (ScaleSettings != null)
                {
                    writer.WritePropertyName("scaleSettings");
                    writer.WriteObjectValue(ScaleSettings);
                }
                else
                {
                    writer.WriteNull("scaleSettings");
                }
            }
            writer.WriteEndObject();
        }

        internal static ManagedOnlineDeployment DeserializeManagedOnlineDeployment(JsonElement element)
        {
            Optional<bool> appInsightsEnabled = default;
            Optional<CodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            EndpointComputeType endpointComputeType = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<string> instanceType = default;
            Optional<ProbeSettings> livenessProbe = default;
            Optional<string> model = default;
            Optional<string> modelMountPath = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<DeploymentProvisioningState> provisioningState = default;
            Optional<ProbeSettings> readinessProbe = default;
            Optional<OnlineRequestSettings> requestSettings = default;
            Optional<OnlineScaleSettings> scaleSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appInsightsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("codeConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = CodeConfiguration.DeserializeCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointComputeType"))
                {
                    endpointComputeType = new EndpointComputeType(property.Value.GetString());
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
                if (property.NameEquals("instanceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("livenessProbe"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessProbe = null;
                        continue;
                    }
                    livenessProbe = ProbeSettings.DeserializeProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("model"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelMountPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelMountPath = null;
                        continue;
                    }
                    modelMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
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
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new DeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readinessProbe"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessProbe = null;
                        continue;
                    }
                    readinessProbe = ProbeSettings.DeserializeProbeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("requestSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestSettings = null;
                        continue;
                    }
                    requestSettings = OnlineRequestSettings.DeserializeOnlineRequestSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaleSettings = null;
                        continue;
                    }
                    scaleSettings = OnlineScaleSettings.DeserializeOnlineScaleSettings(property.Value);
                    continue;
                }
            }
            return new ManagedOnlineDeployment(Optional.ToNullable(appInsightsEnabled), codeConfiguration.Value, description.Value, endpointComputeType, environmentId.Value, Optional.ToDictionary(environmentVariables), instanceType.Value, livenessProbe.Value, model.Value, modelMountPath.Value, Optional.ToDictionary(properties), Optional.ToNullable(provisioningState), readinessProbe.Value, requestSettings.Value, scaleSettings.Value);
        }
    }
}
