// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for direct method calls.
    /// Please note <see cref="MethodRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LivePipelineActivateRequest"/>, <see cref="LivePipelineDeactivateRequest"/>, <see cref="LivePipelineDeleteRequest"/>, <see cref="LivePipelineGetRequest"/>, <see cref="LivePipelineListRequest"/>, <see cref="LivePipelineSetRequest"/>, <see cref="LivePipelineSetRequestBody"/>, <see cref="MethodRequestEmptyBodyBase"/>, <see cref="OnvifDeviceDiscoverRequest"/>, <see cref="OnvifDeviceGetRequest"/>, <see cref="PipelineTopologyDeleteRequest"/>, <see cref="PipelineTopologyGetRequest"/>, <see cref="PipelineTopologyListRequest"/>, <see cref="PipelineTopologySetRequest"/>, <see cref="PipelineTopologySetRequestBody"/>, <see cref="RemoteDeviceAdapterDeleteRequest"/>, <see cref="RemoteDeviceAdapterGetRequest"/>, <see cref="RemoteDeviceAdapterListRequest"/>, <see cref="RemoteDeviceAdapterSetRequest"/> and <see cref="RemoteDeviceAdapterSetRequestBody"/>.
    /// </summary>
    public abstract partial class MethodRequest
    {
        /// <summary> Initializes a new instance of MethodRequest. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        internal MethodRequest(string methodName, string apiVersion)
        {
            MethodName = methodName;
            ApiVersion = apiVersion;
        }
        /// <summary> Video Analyzer API version. </summary>
        public string ApiVersion { get; set; }
    }
}
