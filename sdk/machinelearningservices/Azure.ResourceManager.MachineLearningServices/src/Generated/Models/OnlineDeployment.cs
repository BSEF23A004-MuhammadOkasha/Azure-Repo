// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The OnlineDeployment. </summary>
    public partial class OnlineDeployment : EndpointDeploymentPropertiesBase
    {
        /// <summary> Initializes a new instance of OnlineDeployment. </summary>
        public OnlineDeployment()
        {
            EndpointComputeType = new EndpointComputeType("OnlineDeployment");
        }

        /// <summary> Initializes a new instance of OnlineDeployment. </summary>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="description"> Description of the endpoint deployment. </param>
        /// <param name="environmentId"> ARM resource ID of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="appInsightsEnabled"> If true, enables Application Insights logging. </param>
        /// <param name="endpointComputeType"> The compute type of the endpoint. </param>
        /// <param name="instanceType"> Compute instance type. </param>
        /// <param name="livenessProbe"> Liveness probe monitors the health of the container regularly. </param>
        /// <param name="model"> The URI path to the model. </param>
        /// <param name="modelMountPath"> The path to mount the model in custom container. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="readinessProbe"> Readiness probe validates if the container is ready to serve traffic. The properties and defaults are the same as liveness probe. </param>
        /// <param name="requestSettings"> Request settings for the deployment. </param>
        /// <param name="scaleSettings">
        /// Scale settings for the deployment.
        /// If it is null or not provided,
        /// it defaults to TargetUtilizationScaleSettings for KubernetesOnlineDeployment
        /// and to DefaultScaleSettings for ManagedOnlineDeployment.
        /// </param>
        internal OnlineDeployment(CodeConfiguration codeConfiguration, string description, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, string> properties, bool? appInsightsEnabled, EndpointComputeType endpointComputeType, string instanceType, ProbeSettings livenessProbe, string model, string modelMountPath, DeploymentProvisioningState? provisioningState, ProbeSettings readinessProbe, OnlineRequestSettings requestSettings, OnlineScaleSettings scaleSettings) : base(codeConfiguration, description, environmentId, environmentVariables, properties)
        {
            AppInsightsEnabled = appInsightsEnabled;
            EndpointComputeType = endpointComputeType;
            InstanceType = instanceType;
            LivenessProbe = livenessProbe;
            Model = model;
            ModelMountPath = modelMountPath;
            ProvisioningState = provisioningState;
            ReadinessProbe = readinessProbe;
            RequestSettings = requestSettings;
            ScaleSettings = scaleSettings;
        }

        /// <summary> If true, enables Application Insights logging. </summary>
        public bool? AppInsightsEnabled { get; set; }
        /// <summary> The compute type of the endpoint. </summary>
        internal EndpointComputeType EndpointComputeType { get; set; }
        /// <summary> Compute instance type. </summary>
        public string InstanceType { get; set; }
        /// <summary> Liveness probe monitors the health of the container regularly. </summary>
        public ProbeSettings LivenessProbe { get; set; }
        /// <summary> The URI path to the model. </summary>
        public string Model { get; set; }
        /// <summary> The path to mount the model in custom container. </summary>
        public string ModelMountPath { get; set; }
        /// <summary> Provisioning state for the endpoint deployment. </summary>
        public DeploymentProvisioningState? ProvisioningState { get; }
        /// <summary> Readiness probe validates if the container is ready to serve traffic. The properties and defaults are the same as liveness probe. </summary>
        public ProbeSettings ReadinessProbe { get; set; }
        /// <summary> Request settings for the deployment. </summary>
        public OnlineRequestSettings RequestSettings { get; set; }
        /// <summary>
        /// Scale settings for the deployment.
        /// If it is null or not provided,
        /// it defaults to TargetUtilizationScaleSettings for KubernetesOnlineDeployment
        /// and to DefaultScaleSettings for ManagedOnlineDeployment.
        /// </summary>
        public OnlineScaleSettings ScaleSettings { get; set; }
    }
}
