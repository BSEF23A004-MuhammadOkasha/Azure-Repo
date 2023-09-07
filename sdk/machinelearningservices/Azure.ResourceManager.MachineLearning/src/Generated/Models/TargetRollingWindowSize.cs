// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting target rolling window size.
    /// Please note <see cref="TargetRollingWindowSize"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutoTargetRollingWindowSize"/> and <see cref="CustomTargetRollingWindowSize"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownTargetRollingWindowSize))]
    public abstract partial class TargetRollingWindowSize
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TargetRollingWindowSize"/>. </summary>
        protected TargetRollingWindowSize()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TargetRollingWindowSize"/>. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetRollingWindowSize(TargetRollingWindowSizeMode mode, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] TargetRollingWindowSiz detection mode. </summary>
        internal TargetRollingWindowSizeMode Mode { get; set; }
    }
}
