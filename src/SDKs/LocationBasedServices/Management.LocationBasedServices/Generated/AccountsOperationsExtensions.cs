// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LocationBasedServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AccountsOperations.
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
            /// <summary>
            /// Create or update a Location Based Services Account. A Location Based
            /// Services Account holds the keys which allow access to the Location Based
            /// Services REST APIs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='locationBasedServicesAccountCreateParameters'>
            /// The new or updated parameters for the Location Based Services Account.
            /// </param>
            public static LocationBasedServicesAccount CreateOrUpdate(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesAccountCreateParameters locationBasedServicesAccountCreateParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, locationBasedServicesAccountCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Location Based Services Account. A Location Based
            /// Services Account holds the keys which allow access to the Location Based
            /// Services REST APIs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='locationBasedServicesAccountCreateParameters'>
            /// The new or updated parameters for the Location Based Services Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationBasedServicesAccount> CreateOrUpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesAccountCreateParameters locationBasedServicesAccountCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, locationBasedServicesAccountCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Location Based Services Account. Only a subset of the parameters
            /// may be updated after creation, such as Sku and Tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='locationBasedServicesAccountUpdateParameters'>
            /// The updated parameters for the Location Based Services Account.
            /// </param>
            public static LocationBasedServicesAccount Update(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesAccountUpdateParameters locationBasedServicesAccountUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, locationBasedServicesAccountUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Location Based Services Account. Only a subset of the parameters
            /// may be updated after creation, such as Sku and Tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='locationBasedServicesAccountUpdateParameters'>
            /// The updated parameters for the Location Based Services Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationBasedServicesAccount> UpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesAccountUpdateParameters locationBasedServicesAccountUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, locationBasedServicesAccountUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Location Based Services Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            public static void Delete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Location Based Services Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get a Location Based Services Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            public static LocationBasedServicesAccount Get(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Location Based Services Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationBasedServicesAccount> GetAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all Location Based Services Accounts in a Resource Group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            public static IEnumerable<LocationBasedServicesAccount> ListByResourceGroup(this IAccountsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all Location Based Services Accounts in a Resource Group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LocationBasedServicesAccount>> ListByResourceGroupAsync(this IAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all Location Based Services Accounts in a Subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<LocationBasedServicesAccount> ListBySubscription(this IAccountsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all Location Based Services Accounts in a Subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LocationBasedServicesAccount>> ListBySubscriptionAsync(this IAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Moves Location Based Services Accounts from one ResourceGroup (or
            /// Subscription) to another
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains Location Based Services
            /// Account to move.
            /// </param>
            /// <param name='moveRequest'>
            /// The details of the Location Based Services Account move.
            /// </param>
            public static void Move(this IAccountsOperations operations, string resourceGroupName, LocationBasedServicesAccountsMoveRequest moveRequest)
            {
                operations.MoveAsync(resourceGroupName, moveRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Moves Location Based Services Accounts from one ResourceGroup (or
            /// Subscription) to another
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains Location Based Services
            /// Account to move.
            /// </param>
            /// <param name='moveRequest'>
            /// The details of the Location Based Services Account move.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MoveAsync(this IAccountsOperations operations, string resourceGroupName, LocationBasedServicesAccountsMoveRequest moveRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MoveWithHttpMessagesAsync(resourceGroupName, moveRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the keys to use with the Location Based Services APIs. A key is used to
            /// authenticate and authorize access to the Location Based Services REST APIs.
            /// Only one key is needed at a time; two are given to provide seamless key
            /// regeneration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            public static LocationBasedServicesAccountKeys ListKeys(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the keys to use with the Location Based Services APIs. A key is used to
            /// authenticate and authorize access to the Location Based Services REST APIs.
            /// Only one key is needed at a time; two are given to provide seamless key
            /// regeneration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationBasedServicesAccountKeys> ListKeysAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate either the primary or secondary key for use with the Location
            /// Based Services APIs. The old key will stop working immediately.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='keySpecification'>
            /// Which key to regenerate:  primary or secondary.
            /// </param>
            public static LocationBasedServicesAccountKeys RegenerateKeys(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesKeySpecification keySpecification)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, accountName, keySpecification).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate either the primary or secondary key for use with the Location
            /// Based Services APIs. The old key will stop working immediately.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure Resource Group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Location Based Services Account.
            /// </param>
            /// <param name='keySpecification'>
            /// Which key to regenerate:  primary or secondary.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocationBasedServicesAccountKeys> RegenerateKeysAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, LocationBasedServicesKeySpecification keySpecification, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, accountName, keySpecification, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List operations available for the Location Based Services Resource Provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<LocationBasedServicesOperationsValueItem> ListOperations(this IAccountsOperations operations)
            {
                return operations.ListOperationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List operations available for the Location Based Services Resource Provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LocationBasedServicesOperationsValueItem>> ListOperationsAsync(this IAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
