// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary>
    /// The properties of a step resource.
    /// Please note <see cref="StepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HealthCheckStepProperties"/> and <see cref="WaitStepProperties"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownStepProperties))]
    public abstract partial class StepProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StepProperties"/>. </summary>
        protected StepProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StepProperties"/>. </summary>
        /// <param name="stepType"> The type of step. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StepProperties(StepType stepType, Dictionary<string, BinaryData> rawData)
        {
            StepType = stepType;
            _rawData = rawData;
        }

        /// <summary> The type of step. </summary>
        internal StepType StepType { get; set; }
    }
}
