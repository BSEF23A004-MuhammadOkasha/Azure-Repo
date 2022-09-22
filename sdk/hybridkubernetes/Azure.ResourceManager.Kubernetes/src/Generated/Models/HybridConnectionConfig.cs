// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> Contains the REP (rendezvous endpoint) and “Sender” access token. </summary>
    public partial class HybridConnectionConfig
    {
        /// <summary> Initializes a new instance of HybridConnectionConfig. </summary>
        internal HybridConnectionConfig()
        {
        }

        /// <summary> Initializes a new instance of HybridConnectionConfig. </summary>
        /// <param name="expirationTime"> Timestamp when this token will be expired. </param>
        /// <param name="hybridConnectionName"> Name of the connection. </param>
        /// <param name="relay"> Name of the relay. </param>
        /// <param name="token"> Sender access token. </param>
        internal HybridConnectionConfig(long? expirationTime, string hybridConnectionName, string relay, string token)
        {
            ExpirationTime = expirationTime;
            HybridConnectionName = hybridConnectionName;
            Relay = relay;
            Token = token;
        }

        /// <summary> Timestamp when this token will be expired. </summary>
        public long? ExpirationTime { get; }
        /// <summary> Name of the connection. </summary>
        public string HybridConnectionName { get; }
        /// <summary> Name of the relay. </summary>
        public string Relay { get; }
        /// <summary> Sender access token. </summary>
        public string Token { get; }
    }
}
