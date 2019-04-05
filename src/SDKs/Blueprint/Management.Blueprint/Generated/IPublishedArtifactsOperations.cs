// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PublishedArtifactsOperations operations.
    /// </summary>
    public partial interface IPublishedArtifactsOperations
    {
        /// <summary>
        /// Get an artifact for a published blueprint definition.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the resource. Valid scopes are: management group
        /// (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'). For
        /// blueprint assignments management group scope is reserved for future
        /// use.
        /// </param>
        /// <param name='blueprintName'>
        /// Name of the blueprint definition.
        /// </param>
        /// <param name='versionId'>
        /// Version of the published blueprint definition.
        /// </param>
        /// <param name='artifactName'>
        /// Name of the blueprint artifact.
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
        Task<AzureOperationResponse<Artifact>> GetWithHttpMessagesAsync(string scope, string blueprintName, string versionId, string artifactName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List artifacts for a version of a published blueprint definition.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the resource. Valid scopes are: management group
        /// (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'). For
        /// blueprint assignments management group scope is reserved for future
        /// use.
        /// </param>
        /// <param name='blueprintName'>
        /// Name of the blueprint definition.
        /// </param>
        /// <param name='versionId'>
        /// Version of the published blueprint definition.
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
        Task<AzureOperationResponse<IPage<Artifact>>> ListWithHttpMessagesAsync(string scope, string blueprintName, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List artifacts for a version of a published blueprint definition.
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
        Task<AzureOperationResponse<IPage<Artifact>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
