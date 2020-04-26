// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AzureAccounts.
    /// </summary>
    public static partial class AzureAccountsExtensions
    {
            /// <summary>
            /// apps - Assign a LUIS Azure account to an application
            /// </summary>
            /// <remarks>
            /// Assigns an Azure account to the application.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='armToken'>
            /// The custom arm token header to use; containing the user's ARM token used to
            /// validate azure accounts information.
            /// </param>
            /// <param name='azureAccountInfoObject'>
            /// The Azure account information object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> AssignToAppAsync(this IAzureAccounts operations, System.Guid appId, string armToken = default(string), AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AssignToAppWithHttpMessagesAsync(appId, armToken, azureAccountInfoObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// apps - Get LUIS Azure accounts assigned to the application
            /// </summary>
            /// <remarks>
            /// Gets the LUIS Azure accounts assigned to the application for the user using
            /// his ARM token.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='armToken'>
            /// The custom arm token header to use; containing the user's ARM token used to
            /// validate azure accounts information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AzureAccountInfoObject>> GetAssignedAsync(this IAzureAccounts operations, System.Guid appId, string armToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAssignedWithHttpMessagesAsync(appId, armToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// apps - Removes an assigned LUIS Azure account from an application
            /// </summary>
            /// <remarks>
            /// Removes assigned Azure account from the application.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='armToken'>
            /// The custom arm token header to use; containing the user's ARM token used to
            /// validate azure accounts information.
            /// </param>
            /// <param name='azureAccountInfoObject'>
            /// The Azure account information object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> RemoveFromAppAsync(this IAzureAccounts operations, System.Guid appId, string armToken = default(string), AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveFromAppWithHttpMessagesAsync(appId, armToken, azureAccountInfoObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// user - Get LUIS Azure accounts
            /// </summary>
            /// <remarks>
            /// Gets the LUIS Azure accounts for the user using his ARM token.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='armToken'>
            /// The custom arm token header to use; containing the user's ARM token used to
            /// validate azure accounts information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AzureAccountInfoObject>> ListUserLUISAccountsAsync(this IAzureAccounts operations, string armToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUserLUISAccountsWithHttpMessagesAsync(armToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
