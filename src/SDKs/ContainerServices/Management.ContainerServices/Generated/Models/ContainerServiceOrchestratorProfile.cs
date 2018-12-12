// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile for the container service orchestrator.
    /// </summary>
    public partial class ContainerServiceOrchestratorProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceOrchestratorProfile class.
        /// </summary>
        public ContainerServiceOrchestratorProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceOrchestratorProfile class.
        /// </summary>
        /// <param name="orchestratorType">The orchestrator to use to manage
        /// container service cluster resources. Valid values are Kubernetes,
        /// Swarm, DCOS, DockerCE and Custom. Possible values include:
        /// 'Kubernetes', 'Swarm', 'DCOS', 'DockerCE', 'Custom'</param>
        /// <param name="orchestratorVersion">The version of the orchestrator
        /// to use. You can specify the major.minor.patch part of the actual
        /// version.For example, you can specify version as "1.6.11".</param>
        public ContainerServiceOrchestratorProfile(string orchestratorType, string orchestratorVersion = default(string))
        {
            OrchestratorType = orchestratorType;
            OrchestratorVersion = orchestratorVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the orchestrator to use to manage container service
        /// cluster resources. Valid values are Kubernetes, Swarm, DCOS,
        /// DockerCE and Custom. Possible values include: 'Kubernetes',
        /// 'Swarm', 'DCOS', 'DockerCE', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorType")]
        public string OrchestratorType { get; set; }

        /// <summary>
        /// Gets or sets the version of the orchestrator to use. You can
        /// specify the major.minor.patch part of the actual version.For
        /// example, you can specify version as "1.6.11".
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorVersion")]
        public string OrchestratorVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrchestratorType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrchestratorType");
            }
        }
    }
}
