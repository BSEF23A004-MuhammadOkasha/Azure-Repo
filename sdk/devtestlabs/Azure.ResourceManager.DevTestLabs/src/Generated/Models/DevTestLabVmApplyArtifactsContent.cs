// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for applying artifacts to a virtual machine. </summary>
    public partial class DevTestLabVmApplyArtifactsContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmApplyArtifactsContent"/>. </summary>
        public DevTestLabVmApplyArtifactsContent()
        {
            Artifacts = new ChangeTrackingList<DevTestLabArtifactInstallInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmApplyArtifactsContent"/>. </summary>
        /// <param name="artifacts"> The list of artifacts to apply. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabVmApplyArtifactsContent(IList<DevTestLabArtifactInstallInfo> artifacts, Dictionary<string, BinaryData> rawData)
        {
            Artifacts = artifacts;
            _rawData = rawData;
        }

        /// <summary> The list of artifacts to apply. </summary>
        public IList<DevTestLabArtifactInstallInfo> Artifacts { get; }
    }
}
