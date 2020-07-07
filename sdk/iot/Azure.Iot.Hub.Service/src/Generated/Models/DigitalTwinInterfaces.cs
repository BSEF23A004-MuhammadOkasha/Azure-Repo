// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The DigitalTwinInterfaces. </summary>
    internal partial class DigitalTwinInterfaces
    {
        /// <summary> Initializes a new instance of DigitalTwinInterfaces. </summary>
        internal DigitalTwinInterfaces()
        {
        }

        /// <summary> Initializes a new instance of DigitalTwinInterfaces. </summary>
        /// <param name="interfaces"> Interface(s) data on the digital twin. </param>
        /// <param name="version"> Version of digital twin. </param>
        internal DigitalTwinInterfaces(IReadOnlyDictionary<string, PnpInterface> interfaces, long? version)
        {
            Interfaces = interfaces;
            Version = version;
        }

        /// <summary> Interface(s) data on the digital twin. </summary>
        public IReadOnlyDictionary<string, PnpInterface> Interfaces { get; }
        /// <summary> Version of digital twin. </summary>
        public long? Version { get; }
    }
}
