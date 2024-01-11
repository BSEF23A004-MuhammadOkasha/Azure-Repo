// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownJobBase. </summary>
    internal partial class UnknownJobBase : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJobBase"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="secretsConfiguration"> Configuration for secrets to be made available during runtime. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        internal UnknownJobBase(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, SecretConfiguration> secretsConfiguration, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status) : base(description, properties, tags, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, secretsConfiguration, services, status)
        {
            JobType = jobType;
        }
    }
}
