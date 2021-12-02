// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// KustoPoolDatabasePrincipalAssignmentsOperations operations.
    /// </summary>
    public partial interface IKustoPoolDatabasePrincipalAssignmentsOperations
    {
        /// <summary>
        /// Checks that the database principal assignment is valid and is not
        /// already in use.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckNameResult>> CheckNameAvailabilityWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string resourceGroupName, DatabasePrincipalAssignmentCheckNameRequest principalAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all Kusto pool database principalAssignments.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<DatabasePrincipalAssignment>>> ListWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a Kusto pool database principalAssignment.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the Kusto principalAssignment.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DatabasePrincipalAssignment>> GetWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a Kusto pool database principalAssignment.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the Kusto principalAssignment.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// The Kusto principalAssignments parameters supplied for the
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DatabasePrincipalAssignment>> CreateOrUpdateWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, string resourceGroupName, DatabasePrincipalAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Kusto pool principalAssignment.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the Kusto principalAssignment.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a Kusto pool database principalAssignment.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the Kusto principalAssignment.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// The Kusto principalAssignments parameters supplied for the
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DatabasePrincipalAssignment>> BeginCreateOrUpdateWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, string resourceGroupName, DatabasePrincipalAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Kusto pool principalAssignment.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto pool.
        /// </param>
        /// <param name='principalAssignmentName'>
        /// The name of the Kusto principalAssignment.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string databaseName, string principalAssignmentName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
