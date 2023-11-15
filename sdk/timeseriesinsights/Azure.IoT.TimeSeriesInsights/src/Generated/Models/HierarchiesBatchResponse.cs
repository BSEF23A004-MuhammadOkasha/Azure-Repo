// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Response of a single operation on a batch of time series hierarchies. Only one of "get", "put" or "delete" will be set. </summary>
    internal partial class HierarchiesBatchResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HierarchiesBatchResponse"/>. </summary>
        internal HierarchiesBatchResponse()
        {
            Get = new ChangeTrackingList<TimeSeriesHierarchyOperationResult>();
            Put = new ChangeTrackingList<TimeSeriesHierarchyOperationResult>();
            Delete = new ChangeTrackingList<TimeSeriesOperationError>();
        }

        /// <summary> Initializes a new instance of <see cref="HierarchiesBatchResponse"/>. </summary>
        /// <param name="get"> List of hierarchy or error objects corresponding by position to the "get" array in the request. Hierarchy object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="put"> List of hierarchy or error object corresponding by position to the "put" array in the request. Hierarchy object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="delete"> List of error objects corresponding by position to the "delete" array in the request - null when the operation is successful. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HierarchiesBatchResponse(IReadOnlyList<TimeSeriesHierarchyOperationResult> @get, IReadOnlyList<TimeSeriesHierarchyOperationResult> put, IReadOnlyList<TimeSeriesOperationError> delete, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Get = @get;
            Put = put;
            Delete = delete;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of hierarchy or error objects corresponding by position to the "get" array in the request. Hierarchy object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<TimeSeriesHierarchyOperationResult> Get { get; }
        /// <summary> List of hierarchy or error object corresponding by position to the "put" array in the request. Hierarchy object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<TimeSeriesHierarchyOperationResult> Put { get; }
        /// <summary> List of error objects corresponding by position to the "delete" array in the request - null when the operation is successful. </summary>
        public IReadOnlyList<TimeSeriesOperationError> Delete { get; }
    }
}
