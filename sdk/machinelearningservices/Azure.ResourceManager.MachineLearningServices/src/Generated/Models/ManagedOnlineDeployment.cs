// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Properties specific to a ManagedOnlineDeployment. </summary>
    public partial class ManagedOnlineDeployment : OnlineDeployment
    {
        /// <summary> Initializes a new instance of ManagedOnlineDeployment. </summary>
        public ManagedOnlineDeployment()
        {
            EndpointComputeType = EndpointComputeType.Managed;
        }

        /// <summary> Initializes a new instance of ManagedOnlineDeployment. </summary>
        /// <param name="appInsightsEnabled"> If true, enables Application Insights logging. </param>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="description"> Description of the endpoint deployment. </param>
        /// <param name="endpointComputeType"> The compute type of the endpoint. </param>
        /// <param name="environmentId"> ARM resource ID of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="instanceType"> Compute instance type. </param>
        /// <param name="livenessProbe"> Liveness probe monitors the health of the container regularly. </param>
        /// <param name="model"> The URI path to the model. </param>
        /// <param name="modelMountPath"> The path to mount the model in custom container. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="readinessProbe"> Readiness probe validates if the container is ready to serve traffic. The properties and defaults are the same as liveness probe. </param>
        /// <param name="requestSettings"> Request settings for the deployment. </param>
        /// <param name="scaleSettings"> Scale settings for the deployment. </param>
        internal ManagedOnlineDeployment(bool? appInsightsEnabled, CodeConfiguration codeConfiguration, string description, EndpointComputeType endpointComputeType, string environmentId, IDictionary<string, string> environmentVariables, string instanceType, ProbeSettings livenessProbe, string model, string modelMountPath, IDictionary<string, string> properties, DeploymentProvisioningState? provisioningState, ProbeSettings readinessProbe, OnlineRequestSettings requestSettings, OnlineScaleSettings scaleSettings) : base(appInsightsEnabled, codeConfiguration, description, endpointComputeType, environmentId, environmentVariables, instanceType, livenessProbe, model, modelMountPath, properties, provisioningState, readinessProbe, requestSettings, scaleSettings)
        {
            EndpointComputeType = endpointComputeType;
        }
    }
}
