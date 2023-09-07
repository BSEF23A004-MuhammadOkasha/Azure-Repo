// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Client options for OpenAIClient. </summary>
    public partial class OpenAIClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_08_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-12-01". </summary>
            V2022_12_01 = 1,
            /// <summary> Service version "2023-05-15". </summary>
            V2023_05_15 = 2,
            /// <summary> Service version "2023-06-01-preview". </summary>
            V2023_06_01_Preview = 3,
            /// <summary> Service version "2023-07-01-preview". </summary>
            V2023_07_01_Preview = 4,
            /// <summary> Service version "2023-08-01-preview". </summary>
            V2023_08_01_Preview = 5,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of OpenAIClientOptions. </summary>
        public OpenAIClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_12_01 => "2022-12-01",
                ServiceVersion.V2023_05_15 => "2023-05-15",
                ServiceVersion.V2023_06_01_Preview => "2023-06-01-preview",
                ServiceVersion.V2023_07_01_Preview => "2023-07-01-preview",
                ServiceVersion.V2023_08_01_Preview => "2023-08-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
