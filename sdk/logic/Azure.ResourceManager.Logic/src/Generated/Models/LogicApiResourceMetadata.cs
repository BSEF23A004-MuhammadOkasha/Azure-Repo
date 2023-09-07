// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The api resource metadata. </summary>
    public partial class LogicApiResourceMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogicApiResourceMetadata"/>. </summary>
        internal LogicApiResourceMetadata()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicApiResourceMetadata"/>. </summary>
        /// <param name="source"> The source. </param>
        /// <param name="brandColor"> The brand color. </param>
        /// <param name="hideKey"> The hide key. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="apiType"> The api type. </param>
        /// <param name="wsdlService"> The WSDL service. </param>
        /// <param name="wsdlImportMethod"> The WSDL import method. </param>
        /// <param name="connectionType"> The connection type. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="deploymentParameters"> The connector deployment parameters metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicApiResourceMetadata(string source, string brandColor, string hideKey, IReadOnlyDictionary<string, string> tags, LogicApiType? apiType, LogicWsdlService wsdlService, LogicWsdlImportMethod? wsdlImportMethod, string connectionType, LogicWorkflowProvisioningState? provisioningState, LogicApiDeploymentParameterMetadataSet deploymentParameters, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            BrandColor = brandColor;
            HideKey = hideKey;
            Tags = tags;
            ApiType = apiType;
            WsdlService = wsdlService;
            WsdlImportMethod = wsdlImportMethod;
            ConnectionType = connectionType;
            ProvisioningState = provisioningState;
            DeploymentParameters = deploymentParameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The source. </summary>
        public string Source { get; }
        /// <summary> The brand color. </summary>
        public string BrandColor { get; }
        /// <summary> The hide key. </summary>
        public string HideKey { get; }
        /// <summary> The tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> The api type. </summary>
        public LogicApiType? ApiType { get; }
        /// <summary> The WSDL service. </summary>
        public LogicWsdlService WsdlService { get; }
        /// <summary> The WSDL import method. </summary>
        public LogicWsdlImportMethod? WsdlImportMethod { get; }
        /// <summary> The connection type. </summary>
        public string ConnectionType { get; }
        /// <summary> The provisioning state. </summary>
        public LogicWorkflowProvisioningState? ProvisioningState { get; }
        /// <summary> The connector deployment parameters metadata. </summary>
        public LogicApiDeploymentParameterMetadataSet DeploymentParameters { get; }
    }
}
