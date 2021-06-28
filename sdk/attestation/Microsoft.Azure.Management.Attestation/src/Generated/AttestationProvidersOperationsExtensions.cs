// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AttestationProvidersOperations.
    /// </summary>
    public static partial class AttestationProvidersOperationsExtensions
    {
            /// <summary>
            /// Get the status of Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            public static AttestationProvider Get(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName)
            {
                return operations.GetAsync(resourceGroupName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the status of Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProvider> GetAsync(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, providerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            /// <param name='creationParams'>
            /// Client supplied parameters.
            /// </param>
            public static AttestationProvider Create(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, AttestationServiceCreationParams creationParams)
            {
                return operations.CreateAsync(resourceGroupName, providerName, creationParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            /// <param name='creationParams'>
            /// Client supplied parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProvider> CreateAsync(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, AttestationServiceCreationParams creationParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, providerName, creationParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            /// <param name='updateParams'>
            /// Client supplied parameters.
            /// </param>
            public static AttestationProvider Update(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, AttestationServicePatchParams updateParams)
            {
                return operations.UpdateAsync(resourceGroupName, providerName, updateParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Attestation Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation provider.
            /// </param>
            /// <param name='updateParams'>
            /// Client supplied parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProvider> UpdateAsync(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, AttestationServicePatchParams updateParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, providerName, updateParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete Attestation Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation service
            /// </param>
            public static void Delete(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName)
            {
                operations.DeleteAsync(resourceGroupName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Attestation Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='providerName'>
            /// Name of the attestation service
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAttestationProvidersOperations operations, string resourceGroupName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, providerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of attestation providers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AttestationProviderListResult List(this IAttestationProvidersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of attestation providers in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProviderListResult> ListAsync(this IAttestationProvidersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns attestation providers list in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static AttestationProviderListResult ListByResourceGroup(this IAttestationProvidersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns attestation providers list in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProviderListResult> ListByResourceGroupAsync(this IAttestationProvidersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the default provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AttestationProviderListResult ListDefault(this IAttestationProvidersOperations operations)
            {
                return operations.ListDefaultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the default provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProviderListResult> ListDefaultAsync(this IAttestationProvidersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDefaultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the default provider by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the default provider.
            /// </param>
            public static AttestationProvider GetDefaultByLocation(this IAttestationProvidersOperations operations, string location)
            {
                return operations.GetDefaultByLocationAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the default provider by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the default provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationProvider> GetDefaultByLocationAsync(this IAttestationProvidersOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefaultByLocationWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
