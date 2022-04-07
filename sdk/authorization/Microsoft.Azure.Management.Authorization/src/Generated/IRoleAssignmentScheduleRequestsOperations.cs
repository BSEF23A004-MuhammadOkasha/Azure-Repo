// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RoleAssignmentScheduleRequestsOperations operations.
    /// </summary>
    public partial interface IRoleAssignmentScheduleRequestsOperations
    {
        /// <summary>
        /// Creates a role assignment schedule request.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the role assignment schedule request to create. The
        /// scope can be any REST resource instance. For example, use
        /// '/subscriptions/{subscription-id}/' for a subscription,
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}'
        /// for a resource group, and
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider}/{resource-type}/{resource-name}'
        /// for a resource.
        /// </param>
        /// <param name='roleAssignmentScheduleRequestName'>
        /// A GUID for the role assignment to create. The name must be unique
        /// and different for each role assignment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the role assignment schedule request.
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
        Task<AzureOperationResponse<RoleAssignmentScheduleRequest>> CreateWithHttpMessagesAsync(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the specified role assignment schedule request.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the role assignment schedule request.
        /// </param>
        /// <param name='roleAssignmentScheduleRequestName'>
        /// The name (guid) of the role assignment schedule request to get.
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
        Task<AzureOperationResponse<RoleAssignmentScheduleRequest>> GetWithHttpMessagesAsync(string scope, string roleAssignmentScheduleRequestName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets role assignment schedule requests for a scope.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the role assignments schedule requests.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<RoleAssignmentScheduleRequest>>> ListForScopeWithHttpMessagesAsync(string scope, ODataQuery<RoleAssignmentScheduleRequestFilter> odataQuery = default(ODataQuery<RoleAssignmentScheduleRequestFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels a pending role assignment schedule request.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the role assignment request to cancel.
        /// </param>
        /// <param name='roleAssignmentScheduleRequestName'>
        /// The name of the role assignment request to cancel.
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
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string scope, string roleAssignmentScheduleRequestName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates a new role assignment schedule request.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the role assignment request to validate.
        /// </param>
        /// <param name='roleAssignmentScheduleRequestName'>
        /// The name of the role assignment request to validate.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the role assignment schedule request.
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
        Task<AzureOperationResponse<RoleAssignmentScheduleRequest>> ValidateWithHttpMessagesAsync(string scope, string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets role assignment schedule requests for a scope.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<RoleAssignmentScheduleRequest>>> ListForScopeNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
