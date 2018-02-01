// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagementGroupsOperations.
    /// </summary>
    public static partial class ManagementGroupsOperationsExtensions
    {
            /// <summary>
            /// List management groups for the authenticated user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='skiptoken'>
            /// Page continuation token is only used if a previous operation returned a
            /// partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a token parameter that specifies a starting
            /// point to use for subsequent calls.
            ///
            /// </param>
            public static IPage<ManagementGroupInfo> List(this IManagementGroupsOperations operations, string cacheControl = "no-cache", string skiptoken = default(string))
            {
                return operations.ListAsync(cacheControl, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List management groups for the authenticated user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='skiptoken'>
            /// Page continuation token is only used if a previous operation returned a
            /// partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a token parameter that specifies a starting
            /// point to use for subsequent calls.
            ///
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagementGroupInfo>> ListAsync(this IManagementGroupsOperations operations, string cacheControl = "no-cache", string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(cacheControl, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the details of the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='expand'>
            /// The $expand=children query string parameter allows clients to request
            /// inclusion of children in the response payload. Possible values include:
            /// 'children'
            /// </param>
            /// <param name='recurse'>
            /// The $recurse=true query string parameter allows clients to request
            /// inclusion of entire hierarchy in the response payload.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static ManagementGroup Get(this IManagementGroupsOperations operations, string groupId, string expand = default(string), bool? recurse = default(bool?), string cacheControl = "no-cache")
            {
                return operations.GetAsync(groupId, expand, recurse, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the details of the management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='expand'>
            /// The $expand=children query string parameter allows clients to request
            /// inclusion of children in the response payload. Possible values include:
            /// 'children'
            /// </param>
            /// <param name='recurse'>
            /// The $recurse=true query string parameter allows clients to request
            /// inclusion of entire hierarchy in the response payload.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagementGroup> GetAsync(this IManagementGroupsOperations operations, string groupId, string expand = default(string), bool? recurse = default(bool?), string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groupId, expand, recurse, cacheControl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a management group.
            /// If a management group is already created and a subsequent create request is
            /// issued with different properties, the management group properties will be
            /// updated.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='createGroupRequest'>
            /// Management group creation parameters.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static ManagementGroup CreateOrUpdate(this IManagementGroupsOperations operations, string groupId, CreateGroupRequest createGroupRequest, string cacheControl = "no-cache")
            {
                return operations.CreateOrUpdateAsync(groupId, createGroupRequest, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a management group.
            /// If a management group is already created and a subsequent create request is
            /// issued with different properties, the management group properties will be
            /// updated.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='createGroupRequest'>
            /// Management group creation parameters.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagementGroup> CreateOrUpdateAsync(this IManagementGroupsOperations operations, string groupId, CreateGroupRequest createGroupRequest, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(groupId, createGroupRequest, cacheControl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='createGroupRequest'>
            /// Management group creation parameters.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static ManagementGroup Update(this IManagementGroupsOperations operations, string groupId, CreateGroupRequest createGroupRequest, string cacheControl = "no-cache")
            {
                return operations.UpdateAsync(groupId, createGroupRequest, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a management group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='createGroupRequest'>
            /// Management group creation parameters.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagementGroup> UpdateAsync(this IManagementGroupsOperations operations, string groupId, CreateGroupRequest createGroupRequest, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(groupId, createGroupRequest, cacheControl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete management group.
            /// If a management group contains child resources, the request will fail.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static void Delete(this IManagementGroupsOperations operations, string groupId, string cacheControl = "no-cache")
            {
                operations.DeleteAsync(groupId, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete management group.
            /// If a management group contains child resources, the request will fail.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// Management Group ID.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagementGroupsOperations operations, string groupId, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupId, cacheControl, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List management groups for the authenticated user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            public static IPage<ManagementGroupInfo> ListNext(this IManagementGroupsOperations operations, string nextPageLink, string cacheControl = "no-cache")
            {
                return operations.ListNextAsync(nextPageLink, cacheControl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List management groups for the authenticated user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cacheControl'>
            /// Indicates that the request shouldn't utilize any caches.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagementGroupInfo>> ListNextAsync(this IManagementGroupsOperations operations, string nextPageLink, string cacheControl = "no-cache", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, cacheControl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
