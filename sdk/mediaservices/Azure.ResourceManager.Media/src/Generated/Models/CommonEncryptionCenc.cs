// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for envelope encryption scheme. </summary>
    public partial class CommonEncryptionCenc
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommonEncryptionCenc"/>. </summary>
        public CommonEncryptionCenc()
        {
            ClearTracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="CommonEncryptionCenc"/>. </summary>
        /// <param name="enabledProtocols"> Representing supported protocols. </param>
        /// <param name="clearTracks"> Representing which tracks should not be encrypted. </param>
        /// <param name="contentKeys"> Representing default content key for each encryption scheme and separate content keys for specific tracks. </param>
        /// <param name="drm"> Configuration of DRMs for CommonEncryptionCenc encryption scheme. </param>
        /// <param name="clearKeyEncryptionConfiguration"> Optional configuration supporting ClearKey in CommonEncryptionCenc encryption scheme. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommonEncryptionCenc(MediaEnabledProtocols enabledProtocols, IList<MediaTrackSelection> clearTracks, StreamingPolicyContentKeys contentKeys, CencDrmConfiguration drm, ClearKeyEncryptionConfiguration clearKeyEncryptionConfiguration, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnabledProtocols = enabledProtocols;
            ClearTracks = clearTracks;
            ContentKeys = contentKeys;
            Drm = drm;
            ClearKeyEncryptionConfiguration = clearKeyEncryptionConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols EnabledProtocols { get; set; }
        /// <summary> Representing which tracks should not be encrypted. </summary>
        public IList<MediaTrackSelection> ClearTracks { get; }
        /// <summary> Representing default content key for each encryption scheme and separate content keys for specific tracks. </summary>
        public StreamingPolicyContentKeys ContentKeys { get; set; }
        /// <summary> Configuration of DRMs for CommonEncryptionCenc encryption scheme. </summary>
        public CencDrmConfiguration Drm { get; set; }
        /// <summary> Optional configuration supporting ClearKey in CommonEncryptionCenc encryption scheme. </summary>
        internal ClearKeyEncryptionConfiguration ClearKeyEncryptionConfiguration { get; set; }
        /// <summary> Template for the URL of the custom service delivering content keys to end user players. Not required when using Azure Media Services for issuing licenses. The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token value is {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId. </summary>
        public string ClearKeyEncryptionCustomKeysAcquisitionUriTemplate
        {
            get => ClearKeyEncryptionConfiguration is null ? default : ClearKeyEncryptionConfiguration.CustomKeysAcquisitionUriTemplate;
            set
            {
                if (ClearKeyEncryptionConfiguration is null)
                    ClearKeyEncryptionConfiguration = new ClearKeyEncryptionConfiguration();
                ClearKeyEncryptionConfiguration.CustomKeysAcquisitionUriTemplate = value;
            }
        }
    }
}
