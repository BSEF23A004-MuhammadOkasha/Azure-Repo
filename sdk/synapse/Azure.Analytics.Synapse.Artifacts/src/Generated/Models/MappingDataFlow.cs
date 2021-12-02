// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Mapping data flow. </summary>
    public partial class MappingDataFlow : DataFlow
    {
        /// <summary> Initializes a new instance of MappingDataFlow. </summary>
        public MappingDataFlow()
        {
            Sources = new ChangeTrackingList<DataFlowSource>();
            Sinks = new ChangeTrackingList<DataFlowSink>();
            Transformations = new ChangeTrackingList<Transformation>();
            ScriptLines = new ChangeTrackingList<string>();
            Type = "MappingDataFlow";
        }

        /// <summary> Initializes a new instance of MappingDataFlow. </summary>
        /// <param name="type"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="sources"> List of sources in data flow. </param>
        /// <param name="sinks"> List of sinks in data flow. </param>
        /// <param name="transformations"> List of transformations in data flow. </param>
        /// <param name="script"> DataFlow script. </param>
        /// <param name="scriptLines"> Data flow script lines. </param>
        internal MappingDataFlow(string type, string description, IList<object> annotations, DataFlowFolder folder, IList<DataFlowSource> sources, IList<DataFlowSink> sinks, IList<Transformation> transformations, string script, IList<string> scriptLines) : base(type, description, annotations, folder)
        {
            Sources = sources;
            Sinks = sinks;
            Transformations = transformations;
            Script = script;
            ScriptLines = scriptLines;
            Type = type ?? "MappingDataFlow";
        }

        /// <summary> List of sources in data flow. </summary>
        public IList<DataFlowSource> Sources { get; }
        /// <summary> List of sinks in data flow. </summary>
        public IList<DataFlowSink> Sinks { get; }
        /// <summary> List of transformations in data flow. </summary>
        public IList<Transformation> Transformations { get; }
        /// <summary> DataFlow script. </summary>
        public string Script { get; set; }
        /// <summary> Data flow script lines. </summary>
        public IList<string> ScriptLines { get; }
    }
}
