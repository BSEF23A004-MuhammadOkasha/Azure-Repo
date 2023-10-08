// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A class representing the MachineLearningWorkspaceConnection data model. </summary>
    public partial class MachineLearningWorkspaceConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceConnectionData. </summary>
        /// <param name="properties">
        /// Please note <see cref="MachineLearningWorkspaceConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccessKeyAuthTypeWorkspaceConnectionProperties"/>, <see cref="ApiKeyAuthWorkspaceConnectionProperties"/>, <see cref="CustomKeysWorkspaceConnectionProperties"/>, <see cref="MachineLearningManagedIdentityAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningNoneAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningPatAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningSasAuthTypeWorkspaceConnection"/>, <see cref="ServicePrincipalAuthTypeWorkspaceConnectionProperties"/> and <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningWorkspaceConnectionData(MachineLearningWorkspaceConnectionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Please note <see cref="MachineLearningWorkspaceConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccessKeyAuthTypeWorkspaceConnectionProperties"/>, <see cref="ApiKeyAuthWorkspaceConnectionProperties"/>, <see cref="CustomKeysWorkspaceConnectionProperties"/>, <see cref="MachineLearningManagedIdentityAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningNoneAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningPatAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningSasAuthTypeWorkspaceConnection"/>, <see cref="ServicePrincipalAuthTypeWorkspaceConnectionProperties"/> and <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/>.
        /// </param>
        internal MachineLearningWorkspaceConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningWorkspaceConnectionProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the properties
        /// Please note <see cref="MachineLearningWorkspaceConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AccessKeyAuthTypeWorkspaceConnectionProperties"/>, <see cref="ApiKeyAuthWorkspaceConnectionProperties"/>, <see cref="CustomKeysWorkspaceConnectionProperties"/>, <see cref="MachineLearningManagedIdentityAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningNoneAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningPatAuthTypeWorkspaceConnection"/>, <see cref="MachineLearningSasAuthTypeWorkspaceConnection"/>, <see cref="ServicePrincipalAuthTypeWorkspaceConnectionProperties"/> and <see cref="MachineLearningUsernamePasswordAuthTypeWorkspaceConnection"/>.
        /// </summary>
        public MachineLearningWorkspaceConnectionProperties Properties { get; set; }
    }
}
