// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Details of a single deployment created by the remediation. </summary>
    public partial class RemediationDeployment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemediationDeployment"/>. </summary>
        internal RemediationDeployment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemediationDeployment"/>. </summary>
        /// <param name="remediatedResourceId"> Resource ID of the resource that is being remediated by the deployment. </param>
        /// <param name="deploymentId"> Resource ID of the template deployment that will remediate the resource. </param>
        /// <param name="status"> Status of the remediation deployment. </param>
        /// <param name="resourceLocation"> Location of the resource that is being remediated. </param>
        /// <param name="error"> Error encountered while remediated the resource. </param>
        /// <param name="createdOn"> The time at which the remediation was created. </param>
        /// <param name="lastUpdatedOn"> The time at which the remediation deployment was last updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationDeployment(ResourceIdentifier remediatedResourceId, ResourceIdentifier deploymentId, string status, AzureLocation? resourceLocation, ResponseError error, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RemediatedResourceId = remediatedResourceId;
            DeploymentId = deploymentId;
            Status = status;
            ResourceLocation = resourceLocation;
            Error = error;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID of the resource that is being remediated by the deployment. </summary>
        public ResourceIdentifier RemediatedResourceId { get; }
        /// <summary> Resource ID of the template deployment that will remediate the resource. </summary>
        public ResourceIdentifier DeploymentId { get; }
        /// <summary> Status of the remediation deployment. </summary>
        public string Status { get; }
        /// <summary> Location of the resource that is being remediated. </summary>
        public AzureLocation? ResourceLocation { get; }
        /// <summary> Error encountered while remediated the resource. </summary>
        public ResponseError Error { get; }
        /// <summary> The time at which the remediation was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time at which the remediation deployment was last updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
