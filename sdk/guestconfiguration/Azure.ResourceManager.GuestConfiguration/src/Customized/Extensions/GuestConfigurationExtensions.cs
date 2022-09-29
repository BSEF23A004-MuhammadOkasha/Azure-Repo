// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Threading;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.GuestConfiguration. </summary>
    [CodeGenSuppress("GetGuestConfigurationAssignmentsAsync", typeof(SubscriptionResource), typeof(CancellationToken))]
    [CodeGenSuppress("GetGuestConfigurationAssignments", typeof(SubscriptionResource), typeof(CancellationToken))]
    [CodeGenSuppress("GetGuestConfigurationAssignmentsAsync", typeof(ResourceGroupResource), typeof(CancellationToken))]
    [CodeGenSuppress("GetGuestConfigurationAssignments", typeof(ResourceGroupResource), typeof(CancellationToken))]
    public static partial class GuestConfigurationExtensions
    {
        /// <summary>
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GuestConfigurationAssignmentData> GetAllGuestConfigurationAssignmentDataAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAllGuestConfigurationAssignmentDataAsync(cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GuestConfigurationAssignmentData> GetAllGuestConfigurationAssignmentData(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAllGuestConfigurationAssignmentData(cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GuestConfigurationAssignmentData> GetAllGuestConfigurationAssignmentDataAsync(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetAllGuestConfigurationAssignmentDataAsync(cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GuestConfigurationAssignmentData> GetAllGuestConfigurationAssignmentData(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetAllGuestConfigurationAssignmentData(cancellationToken);
        }
    }
}
