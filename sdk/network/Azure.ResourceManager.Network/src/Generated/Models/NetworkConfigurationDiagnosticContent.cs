// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters to get network configuration diagnostic. </summary>
    public partial class NetworkConfigurationDiagnosticContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticContent"/>. </summary>
        /// <param name="targetResourceId"> The ID of the target resource to perform network configuration diagnostic. Valid options are VM, NetworkInterface, VMSS/NetworkInterface and Application Gateway. </param>
        /// <param name="profiles"> List of network configuration diagnostic profiles. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> or <paramref name="profiles"/> is null. </exception>
        public NetworkConfigurationDiagnosticContent(ResourceIdentifier targetResourceId, IEnumerable<NetworkConfigurationDiagnosticProfile> profiles)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));
            Argument.AssertNotNull(profiles, nameof(profiles));

            TargetResourceId = targetResourceId;
            Profiles = profiles.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticContent"/>. </summary>
        /// <param name="targetResourceId"> The ID of the target resource to perform network configuration diagnostic. Valid options are VM, NetworkInterface, VMSS/NetworkInterface and Application Gateway. </param>
        /// <param name="verbosityLevel"> Verbosity level. </param>
        /// <param name="profiles"> List of network configuration diagnostic profiles. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkConfigurationDiagnosticContent(ResourceIdentifier targetResourceId, VerbosityLevel? verbosityLevel, IList<NetworkConfigurationDiagnosticProfile> profiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetResourceId = targetResourceId;
            VerbosityLevel = verbosityLevel;
            Profiles = profiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticContent"/> for deserialization. </summary>
        internal NetworkConfigurationDiagnosticContent()
        {
        }

        /// <summary> The ID of the target resource to perform network configuration diagnostic. Valid options are VM, NetworkInterface, VMSS/NetworkInterface and Application Gateway. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> Verbosity level. </summary>
        public VerbosityLevel? VerbosityLevel { get; set; }
        /// <summary> List of network configuration diagnostic profiles. </summary>
        public IList<NetworkConfigurationDiagnosticProfile> Profiles { get; }
    }
}
