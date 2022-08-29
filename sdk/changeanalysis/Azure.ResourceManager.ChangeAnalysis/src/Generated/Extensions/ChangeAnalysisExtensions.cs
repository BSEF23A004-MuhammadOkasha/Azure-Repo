// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ChangeAnalysis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ChangeAnalysis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ChangeAnalysis. </summary>
    public static partial class ChangeAnalysisExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// List the changes of a resource within the specified time range. Customer data will be masked if the user doesn&apos;t have access.
        /// Request Path: /{resourceId}/providers/Microsoft.ChangeAnalysis/resourceChanges
        /// Operation Id: ResourceChanges_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        /// <returns> An async collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Change> GetResourceChangesAsync(this TenantResource tenantResource, string resourceId, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            return GetExtensionClient(tenantResource).GetResourceChangesAsync(resourceId, startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a resource within the specified time range. Customer data will be masked if the user doesn&apos;t have access.
        /// Request Path: /{resourceId}/providers/Microsoft.ChangeAnalysis/resourceChanges
        /// Operation Id: ResourceChanges_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        /// <returns> A collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<Change> GetResourceChanges(this TenantResource tenantResource, string resourceId, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceId, nameof(resourceId));

            return GetExtensionClient(tenantResource).GetResourceChanges(resourceId, startTime, endTime, skipToken, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes
        /// Operation Id: Changes_ListChangesBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Change> GetChangesBySubscriptionAsync(this SubscriptionResource subscriptionResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetChangesBySubscriptionAsync(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a subscription within the specified time range. Customer data will always be masked.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ChangeAnalysis/changes
        /// Operation Id: Changes_ListChangesBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<Change> GetChangesBySubscription(this SubscriptionResource subscriptionResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetChangesBySubscription(startTime, endTime, skipToken, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary>
        /// List the changes of a resource group within the specified time range. Customer data will always be masked.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ChangeAnalysis/changes
        /// Operation Id: Changes_ListChangesByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Change> GetChangesByResourceGroupAsync(this ResourceGroupResource resourceGroupResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetChangesByResourceGroupAsync(startTime, endTime, skipToken, cancellationToken);
        }

        /// <summary>
        /// List the changes of a resource group within the specified time range. Customer data will always be masked.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ChangeAnalysis/changes
        /// Operation Id: Changes_ListChangesByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="startTime"> Specifies the start time of the changes request. </param>
        /// <param name="endTime"> Specifies the end time of the changes request. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Change" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<Change> GetChangesByResourceGroup(this ResourceGroupResource resourceGroupResource, DateTimeOffset startTime, DateTimeOffset endTime, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetChangesByResourceGroup(startTime, endTime, skipToken, cancellationToken);
        }
    }
}
