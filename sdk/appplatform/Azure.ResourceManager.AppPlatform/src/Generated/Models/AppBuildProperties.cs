// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build resource properties payload. </summary>
    public partial class AppBuildProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppBuildProperties"/>. </summary>
        public AppBuildProperties()
        {
            Env = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppBuildProperties"/>. </summary>
        /// <param name="relativePath"> The relative path of source code. </param>
        /// <param name="builder"> The resource id of builder to build the source code. </param>
        /// <param name="agentPool"> The resource id of agent pool. </param>
        /// <param name="provisioningState"> Provisioning state of the KPack build result. </param>
        /// <param name="env"> The environment variables for this build. </param>
        /// <param name="triggeredBuildResult"> The build result triggered by this build. </param>
        internal AppBuildProperties(string relativePath, string builder, string agentPool, AppBuildProvisioningState? provisioningState, IDictionary<string, string> env, SubResource triggeredBuildResult)
        {
            RelativePath = relativePath;
            Builder = builder;
            AgentPool = agentPool;
            ProvisioningState = provisioningState;
            Env = env;
            TriggeredBuildResult = triggeredBuildResult;
        }

        /// <summary> The relative path of source code. </summary>
        public string RelativePath { get; set; }
        /// <summary> The resource id of builder to build the source code. </summary>
        public string Builder { get; set; }
        /// <summary> The resource id of agent pool. </summary>
        public string AgentPool { get; set; }
        /// <summary> Provisioning state of the KPack build result. </summary>
        public AppBuildProvisioningState? ProvisioningState { get; }
        /// <summary> The environment variables for this build. </summary>
        public IDictionary<string, string> Env { get; }
        /// <summary> The build result triggered by this build. </summary>
        internal SubResource TriggeredBuildResult { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier TriggeredBuildResultId
        {
            get => TriggeredBuildResult?.Id;
        }
    }
}
