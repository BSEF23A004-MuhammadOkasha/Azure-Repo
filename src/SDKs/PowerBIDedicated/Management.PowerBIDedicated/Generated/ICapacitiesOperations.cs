// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIDedicated
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CapacitiesOperations operations.
    /// </summary>
    public partial interface ICapacitiesOperations
    {
        /// <summary>
        /// Gets details about the specified dedicated capacity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the dedicated capacity. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DedicatedCapacity>> GetDetailsWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Dedicated capacity based on the
        /// configuration specified in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='capacityParameters'>
        /// Contains the information used to provision the Dedicated capacity.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DedicatedCapacity>> CreateWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, DedicatedCapacity capacityParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Dedicated capacity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the current state of the specified Dedicated capacity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='capacityUpdateParameters'>
        /// Request object that contains the updated information for the
        /// capacity.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DedicatedCapacity>> UpdateWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, DedicatedCapacityUpdateParameters capacityUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Suspends operation of the specified dedicated capacity instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SuspendWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes operation of the specified Dedicated capacity instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResumeWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the Dedicated capacities for the given resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<DedicatedCapacity>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the Dedicated capacities for the given subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<DedicatedCapacity>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists eligible SKUs for PowerBI Dedicated resource provider.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuEnumerationForNewResourceResult>> ListSkusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists eligible SKUs for a PowerBI Dedicated resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuEnumerationForExistingResourceResult>> ListSkusForCapacityWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Dedicated capacity based on the
        /// configuration specified in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='capacityParameters'>
        /// Contains the information used to provision the Dedicated capacity.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DedicatedCapacity>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, DedicatedCapacity capacityParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Dedicated capacity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the current state of the specified Dedicated capacity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='capacityUpdateParameters'>
        /// Request object that contains the updated information for the
        /// capacity.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DedicatedCapacity>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, DedicatedCapacityUpdateParameters capacityUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Suspends operation of the specified dedicated capacity instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginSuspendWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes operation of the specified Dedicated capacity instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given
        /// PowerBIDedicated capacity is part. This name must be at least 1
        /// character in length, and no more than 90.
        /// </param>
        /// <param name='dedicatedCapacityName'>
        /// The name of the Dedicated capacity. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginResumeWithHttpMessagesAsync(string resourceGroupName, string dedicatedCapacityName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
