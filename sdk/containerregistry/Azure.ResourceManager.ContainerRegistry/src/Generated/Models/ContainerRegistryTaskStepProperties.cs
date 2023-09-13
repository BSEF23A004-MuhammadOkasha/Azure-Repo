// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary>
    /// Base properties for any task step.
    /// Please note <see cref="ContainerRegistryTaskStepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContainerRegistryDockerBuildStep"/>, <see cref="ContainerRegistryEncodedTaskStep"/> and <see cref="ContainerRegistryFileTaskStep"/>.
    /// </summary>
    public abstract partial class ContainerRegistryTaskStepProperties
    {
        /// <summary> Initializes a new instance of ContainerRegistryTaskStepProperties. </summary>
        protected ContainerRegistryTaskStepProperties()
        {
            BaseImageDependencies = new ChangeTrackingList<ContainerRegistryBaseImageDependency>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryTaskStepProperties. </summary>
        /// <param name="stepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        internal ContainerRegistryTaskStepProperties(ContainerRegistryTaskStepType stepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken)
        {
            StepType = stepType;
            BaseImageDependencies = baseImageDependencies;
            ContextPath = contextPath;
            ContextAccessToken = contextAccessToken;
        }

        /// <summary> The type of the step. </summary>
        internal ContainerRegistryTaskStepType StepType { get; set; }
        /// <summary> List of base image dependencies for a step. </summary>
        public IReadOnlyList<ContainerRegistryBaseImageDependency> BaseImageDependencies { get; }
        /// <summary> The URL(absolute or relative) of the source context for the task step. </summary>
        public string ContextPath { get; set; }
        /// <summary> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </summary>
        public string ContextAccessToken { get; set; }
    }
}
