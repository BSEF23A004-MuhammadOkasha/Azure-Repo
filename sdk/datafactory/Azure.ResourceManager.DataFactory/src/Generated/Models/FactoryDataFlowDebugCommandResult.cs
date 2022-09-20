// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Response body structure of data flow result for data preview, statistics or expression preview. </summary>
    public partial class FactoryDataFlowDebugCommandResult
    {
        /// <summary> Initializes a new instance of FactoryDataFlowDebugCommandResult. </summary>
        internal FactoryDataFlowDebugCommandResult()
        {
        }

        /// <summary> Initializes a new instance of FactoryDataFlowDebugCommandResult. </summary>
        /// <param name="status"> The run status of data preview, statistics or expression preview. </param>
        /// <param name="data"> The result data of data preview, statistics or expression preview. </param>
        internal FactoryDataFlowDebugCommandResult(string status, string data)
        {
            Status = status;
            Data = data;
        }

        /// <summary> The run status of data preview, statistics or expression preview. </summary>
        public string Status { get; }
        /// <summary> The result data of data preview, statistics or expression preview. </summary>
        public string Data { get; }
    }
}
