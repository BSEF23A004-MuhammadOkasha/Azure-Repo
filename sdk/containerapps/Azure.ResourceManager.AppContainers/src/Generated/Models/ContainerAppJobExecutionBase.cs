// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App's Job execution name. </summary>
    public partial class ContainerAppJobExecutionBase
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobExecutionBase"/>. </summary>
        internal ContainerAppJobExecutionBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobExecutionBase"/>. </summary>
        /// <param name="name"> Job execution name. </param>
        /// <param name="id"> Job execution Id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppJobExecutionBase(string name, string id, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Job execution name. </summary>
        public string Name { get; }
        /// <summary> Job execution Id. </summary>
        public string Id { get; }
    }
}
