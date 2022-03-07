// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Deployments in the Deployment. </summary>
        /// <returns> An object representing collection of Deployments and their operations over a Deployment. </returns>
        public virtual DeploymentCollection GetDeployments()
        {
            return new DeploymentCollection(Client, Id);
        }

        /// <summary> Gets a collection of ArmApplications in the ArmApplication. </summary>
        /// <returns> An object representing collection of ArmApplications and their operations over a ArmApplication. </returns>
        public virtual ArmApplicationCollection GetArmApplications()
        {
            return new ArmApplicationCollection(Client, Id);
        }

        /// <summary> Gets a collection of ApplicationDefinitions in the ApplicationDefinition. </summary>
        /// <returns> An object representing collection of ApplicationDefinitions and their operations over a ApplicationDefinition. </returns>
        public virtual ApplicationDefinitionCollection GetApplicationDefinitions()
        {
            return new ApplicationDefinitionCollection(Client, Id);
        }

        /// <summary> Gets a collection of JitRequests in the JitRequest. </summary>
        /// <returns> An object representing collection of JitRequests and their operations over a JitRequest. </returns>
        public virtual JitRequestCollection GetJitRequests()
        {
            return new JitRequestCollection(Client, Id);
        }

        /// <summary> Gets a collection of DeploymentScripts in the DeploymentScript. </summary>
        /// <returns> An object representing collection of DeploymentScripts and their operations over a DeploymentScript. </returns>
        public virtual DeploymentScriptCollection GetDeploymentScripts()
        {
            return new DeploymentScriptCollection(Client, Id);
        }

        /// <summary> Gets a collection of TemplateSpecs in the TemplateSpec. </summary>
        /// <returns> An object representing collection of TemplateSpecs and their operations over a TemplateSpec. </returns>
        public virtual TemplateSpecCollection GetTemplateSpecs()
        {
            return new TemplateSpecCollection(Client, Id);
        }
    }
}
