// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceGetKeysResult. </summary>
    public partial class MachineLearningWorkspaceGetKeysResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceGetKeysResult"/>. </summary>
        internal MachineLearningWorkspaceGetKeysResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceGetKeysResult"/>. </summary>
        /// <param name="userStorageKey"></param>
        /// <param name="userStorageResourceId"></param>
        /// <param name="appInsightsInstrumentationKey"></param>
        /// <param name="containerRegistryCredentials"></param>
        /// <param name="notebookAccessKeys"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceGetKeysResult(string userStorageKey, string userStorageResourceId, string appInsightsInstrumentationKey, MachineLearningContainerRegistryCredentials containerRegistryCredentials, MachineLearningWorkspaceGetNotebookKeysResult notebookAccessKeys, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserStorageKey = userStorageKey;
            UserStorageResourceId = userStorageResourceId;
            AppInsightsInstrumentationKey = appInsightsInstrumentationKey;
            ContainerRegistryCredentials = containerRegistryCredentials;
            NotebookAccessKeys = notebookAccessKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the user storage key. </summary>
        public string UserStorageKey { get; }
        /// <summary> Gets the user storage resource id. </summary>
        public string UserStorageResourceId { get; }
        /// <summary> Gets the app insights instrumentation key. </summary>
        public string AppInsightsInstrumentationKey { get; }
        /// <summary> Gets the container registry credentials. </summary>
        public MachineLearningContainerRegistryCredentials ContainerRegistryCredentials { get; }
        /// <summary> Gets the notebook access keys. </summary>
        public MachineLearningWorkspaceGetNotebookKeysResult NotebookAccessKeys { get; }
    }
}
