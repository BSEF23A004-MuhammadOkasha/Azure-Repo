// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocationsOperations.
    /// </summary>
    public static partial class LocationsOperationsExtensions
    {
            /// <summary>
            /// Return trial status for subscription by region
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Azure region
            /// </param>
            public static Trial CheckTrialAvailability(this ILocationsOperations operations, string location)
            {
                return operations.CheckTrialAvailabilityAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return trial status for subscription by region
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Azure region
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Trial> CheckTrialAvailabilityAsync(this ILocationsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckTrialAvailabilityWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return quota for subscription by region
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Azure region
            /// </param>
            public static Quota CheckQuotaAvailability(this ILocationsOperations operations, string location)
            {
                return operations.CheckQuotaAvailabilityAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return quota for subscription by region
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Azure region
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Quota> CheckQuotaAvailabilityAsync(this ILocationsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckQuotaAvailabilityWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
