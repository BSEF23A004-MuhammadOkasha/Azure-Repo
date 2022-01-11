// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the ScriptLog data model. </summary>
    public partial class ScriptLogData : Resource
    {
        /// <summary> Initializes a new instance of ScriptLogData. </summary>
        public ScriptLogData()
        {
        }

        /// <summary> Initializes a new instance of ScriptLogData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="log"> Script execution logs in text format. </param>
        internal ScriptLogData(ResourceIdentifier id, string name, ResourceType type, string log) : base(id, name, type)
        {
            Log = log;
        }

        /// <summary> Script execution logs in text format. </summary>
        public string Log { get; }
    }
}
