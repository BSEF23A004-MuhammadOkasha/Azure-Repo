// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Model asset version details. </summary>
    public partial class MachineLearningModelVersionProperties : MachineLearningAssetBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningModelVersionProperties"/>. </summary>
        public MachineLearningModelVersionProperties()
        {
            Flavors = new ChangeTrackingDictionary<string, MachineLearningFlavorData>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningModelVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="flavors"> Mapping of model flavors to their properties. </param>
        /// <param name="jobName"> Name of the training job which produced this model. </param>
        /// <param name="modelType"> The storage format for this entity. Used for NCD. </param>
        /// <param name="modelUri"> The URI path to the model contents. </param>
        /// <param name="provisioningState"> Provisioning state for the model version. </param>
        /// <param name="stage"> Stage in the model lifecycle assigned to this model. </param>
        internal MachineLearningModelVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isAnonymous, bool? isArchived, IDictionary<string, MachineLearningFlavorData> flavors, string jobName, string modelType, Uri modelUri, RegistryAssetProvisioningState? provisioningState, string stage) : base(description, properties, tags, serializedAdditionalRawData, isAnonymous, isArchived)
        {
            Flavors = flavors;
            JobName = jobName;
            ModelType = modelType;
            ModelUri = modelUri;
            ProvisioningState = provisioningState;
            Stage = stage;
        }

        /// <summary> Mapping of model flavors to their properties. </summary>
        public IDictionary<string, MachineLearningFlavorData> Flavors { get; set; }
        /// <summary> Name of the training job which produced this model. </summary>
        public string JobName { get; set; }
        /// <summary> The storage format for this entity. Used for NCD. </summary>
        public string ModelType { get; set; }
        /// <summary> The URI path to the model contents. </summary>
        public Uri ModelUri { get; set; }
        /// <summary> Provisioning state for the model version. </summary>
        public RegistryAssetProvisioningState? ProvisioningState { get; }
        /// <summary> Stage in the model lifecycle assigned to this model. </summary>
        public string Stage { get; set; }
    }
}
