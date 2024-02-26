// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Staging settings. </summary>
    public partial class StagingSettings
    {
        /// <summary> Initializes a new instance of <see cref="StagingSettings"/>. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public StagingSettings(LinkedServiceReference linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="StagingSettings"/>. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        /// <param name="path"> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </param>
        /// <param name="enableCompression"> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal StagingSettings(LinkedServiceReference linkedServiceName, object path, object enableCompression, IDictionary<string, object> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            EnableCompression = enableCompression;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Staging linked service reference. </summary>
        public LinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
        /// <summary> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableCompression { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
