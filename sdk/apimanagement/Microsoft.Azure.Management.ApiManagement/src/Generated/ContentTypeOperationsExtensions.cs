// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ContentTypeOperations.
    /// </summary>
    public static partial class ContentTypeOperationsExtensions
    {
            /// <summary>
            /// Lists the developer portal's content types. Content types describe content
            /// items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ContentTypeContract> ListByService(this IContentTypeOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the developer portal's content types. Content types describe content
            /// items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContentTypeContract>> ListByServiceAsync(this IContentTypeOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of the developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            public static ContentTypeContract Get(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, contentTypeId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContentTypeContract> GetAsync(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, contentTypeId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// Custom content types' identifiers need to start with the `c-` prefix.
            /// Built-in content types can't be modified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static ContentTypeContract CreateOrUpdate(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, contentTypeId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// Custom content types' identifiers need to start with the `c-` prefix.
            /// Built-in content types can't be modified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContentTypeContract> CreateOrUpdateAsync(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, contentTypeId, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes the specified developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// Built-in content types (with identifiers starting with the `c-` prefix)
            /// can't be removed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, contentTypeId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes the specified developer portal's content type. Content types
            /// describe content items' properties, validation rules, and constraints.
            /// Built-in content types (with identifiers starting with the `c-` prefix)
            /// can't be removed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='contentTypeId'>
            /// Content type identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IContentTypeOperations operations, string resourceGroupName, string serviceName, string contentTypeId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, contentTypeId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the developer portal's content types. Content types describe content
            /// items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ContentTypeContract> ListByServiceNext(this IContentTypeOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the developer portal's content types. Content types describe content
            /// items' properties, validation rules, and constraints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContentTypeContract>> ListByServiceNextAsync(this IContentTypeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
