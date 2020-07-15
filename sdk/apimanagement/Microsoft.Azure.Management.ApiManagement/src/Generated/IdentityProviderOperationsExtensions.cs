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
    /// Extension methods for IdentityProviderOperations.
    /// </summary>
    public static partial class IdentityProviderOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of Identity Provider configured in the specified service
            /// instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-aad#how-to-authorize-developer-accounts-using-azure-active-directory" />
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
            public static IPage<IdentityProviderContract> ListByService(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of Identity Provider configured in the specified service
            /// instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-aad#how-to-authorize-developer-accounts-using-azure-active-directory" />
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
            public static async Task<IPage<IdentityProviderContract>> ListByServiceAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the identityProvider specified by
            /// its identifier.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            public static IdentityProviderGetEntityTagHeaders GetEntityTag(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, identityProviderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the identityProvider specified by
            /// its identifier.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IdentityProviderGetEntityTagHeaders> GetEntityTagAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the configuration details of the identity Provider configured in
            /// specified service instance.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            public static IdentityProviderContract Get(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, identityProviderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the configuration details of the identity Provider configured in
            /// specified service instance.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IdentityProviderContract> GetAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates the IdentityProvider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static IdentityProviderContract CreateOrUpdate(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, IdentityProviderCreateContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, identityProviderName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates the IdentityProvider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IdentityProviderContract> CreateOrUpdateAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, IdentityProviderCreateContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing IdentityProvider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, IdentityProviderUpdateParameters parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, identityProviderName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing IdentityProvider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, IdentityProviderUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the specified identity provider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, identityProviderName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified identity provider configuration.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the client secret details of the Identity Provider.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            public static ClientSecretContract ListSecrets(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName)
            {
                return operations.ListSecretsAsync(resourceGroupName, serviceName, identityProviderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the client secret details of the Identity Provider.
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
            /// <param name='identityProviderName'>
            /// Identity Provider Type identifier. Possible values include: 'facebook',
            /// 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClientSecretContract> ListSecretsAsync(this IIdentityProviderOperations operations, string resourceGroupName, string serviceName, string identityProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSecretsWithHttpMessagesAsync(resourceGroupName, serviceName, identityProviderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of Identity Provider configured in the specified service
            /// instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-aad#how-to-authorize-developer-accounts-using-azure-active-directory" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IdentityProviderContract> ListByServiceNext(this IIdentityProviderOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of Identity Provider configured in the specified service
            /// instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-aad#how-to-authorize-developer-accounts-using-azure-active-directory" />
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
            public static async Task<IPage<IdentityProviderContract>> ListByServiceNextAsync(this IIdentityProviderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
