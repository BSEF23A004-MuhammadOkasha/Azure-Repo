// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecoveryServicesOperations.
    /// </summary>
    public static partial class RecoveryServicesOperationsExtensions
    {
            /// <summary>
            /// API to check for resource name availability.
            /// A name is available if no other resource exists that has the same
            /// SubscriptionId, Resource Name and Type
            /// or if one or more such resources exist, each of these must be GC'd and
            /// their time of deletion be more than 24 Hours Ago
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='location'>
            /// Location of the resource
            /// </param>
            /// <param name='input'>
            /// Contains information about Resource type and Resource name
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IRecoveryServicesOperations operations, string resourceGroupName, string location, CheckNameAvailabilityParameters input)
            {
                return operations.CheckNameAvailabilityAsync(resourceGroupName, location, input).GetAwaiter().GetResult();
            }

            /// <summary>
            /// API to check for resource name availability.
            /// A name is available if no other resource exists that has the same
            /// SubscriptionId, Resource Name and Type
            /// or if one or more such resources exist, each of these must be GC'd and
            /// their time of deletion be more than 24 Hours Ago
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='location'>
            /// Location of the resource
            /// </param>
            /// <param name='input'>
            /// Contains information about Resource type and Resource name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IRecoveryServicesOperations operations, string resourceGroupName, string location, CheckNameAvailabilityParameters input, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(resourceGroupName, location, input, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
