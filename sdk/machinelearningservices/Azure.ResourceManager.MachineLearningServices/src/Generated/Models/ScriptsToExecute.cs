// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Customized setup scripts. </summary>
    public partial class ScriptsToExecute
    {
        /// <summary> Initializes a new instance of ScriptsToExecute. </summary>
        public ScriptsToExecute()
        {
        }

        /// <summary> Initializes a new instance of ScriptsToExecute. </summary>
        /// <param name="startupScript"> Script that&apos;s run every time the machine starts. </param>
        /// <param name="creationScript"> Script that&apos;s run only once during provision of the compute. </param>
        internal ScriptsToExecute(ScriptReference startupScript, ScriptReference creationScript)
        {
            StartupScript = startupScript;
            CreationScript = creationScript;
        }

        /// <summary> Script that&apos;s run every time the machine starts. </summary>
        public ScriptReference StartupScript { get; set; }
        /// <summary> Script that&apos;s run only once during provision of the compute. </summary>
        public ScriptReference CreationScript { get; set; }
    }
}
