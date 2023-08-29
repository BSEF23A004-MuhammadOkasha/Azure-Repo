// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// The base definition of the custom setup.
    /// Please note <see cref="CustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzPowerShellSetup"/>, <see cref="CmdkeySetup"/>, <see cref="ComponentSetup"/> and <see cref="EnvironmentVariableSetup"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownCustomSetupBase))]
    public abstract partial class CustomSetupBase
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomSetupBase"/>. </summary>
        protected CustomSetupBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomSetupBase"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomSetupBase(string customSetupBaseType, Dictionary<string, BinaryData> rawData)
        {
            CustomSetupBaseType = customSetupBaseType;
            _rawData = rawData;
        }

        /// <summary> The type of custom setup. </summary>
        internal string CustomSetupBaseType { get; set; }
    }
}
