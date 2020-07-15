// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Encapsulates the result of a bulk registry operation. </summary>
    public partial class BulkRegistryOperationResponse
    {
        /// <summary> Initializes a new instance of BulkRegistryOperationResponse. </summary>
        internal BulkRegistryOperationResponse()
        {
        }

        /// <summary> Initializes a new instance of BulkRegistryOperationResponse. </summary>
        /// <param name="isSuccessful"> Whether or not the operation was successful. </param>
        /// <param name="errors"> If the operation was not successful, this contains an array of DeviceRegistryOperationError objects. </param>
        /// <param name="warnings"> If the operation was partially successful, this contains an array of DeviceRegistryOperationWarning objects. </param>
        internal BulkRegistryOperationResponse(bool? isSuccessful, IReadOnlyList<DeviceRegistryOperationError> errors, IReadOnlyList<DeviceRegistryOperationWarning> warnings)
        {
            IsSuccessful = isSuccessful;
            Errors = errors;
            Warnings = warnings;
        }

        /// <summary> Whether or not the operation was successful. </summary>
        public bool? IsSuccessful { get; }
        /// <summary> If the operation was not successful, this contains an array of DeviceRegistryOperationError objects. </summary>
        public IReadOnlyList<DeviceRegistryOperationError> Errors { get; }
        /// <summary> If the operation was partially successful, this contains an array of DeviceRegistryOperationWarning objects. </summary>
        public IReadOnlyList<DeviceRegistryOperationWarning> Warnings { get; }
    }
}
