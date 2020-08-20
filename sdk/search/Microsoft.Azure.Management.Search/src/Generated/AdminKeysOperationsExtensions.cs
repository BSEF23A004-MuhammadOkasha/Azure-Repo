// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AdminKeysOperations.
    /// </summary>
    public static partial class AdminKeysOperationsExtensions
    {
            /// <summary>
            /// Gets the primary and secondary admin API keys for the specified Azure
            /// Cognitive Search service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static AdminKeyResult Get(this IAdminKeysOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.GetAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the primary and secondary admin API keys for the specified Azure
            /// Cognitive Search service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdminKeyResult> GetAsync(this IAdminKeysOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates either the primary or secondary admin API key. You can only
            /// regenerate one key at a time.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='keyKind'>
            /// Specifies which key to regenerate. Valid values include 'primary' and
            /// 'secondary'. Possible values include: 'primary', 'secondary'
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static AdminKeyResult Regenerate(this IAdminKeysOperations operations, string resourceGroupName, string searchServiceName, AdminKeyKind keyKind, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.RegenerateAsync(resourceGroupName, searchServiceName, keyKind, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates either the primary or secondary admin API key. You can only
            /// regenerate one key at a time.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='keyKind'>
            /// Specifies which key to regenerate. Valid values include 'primary' and
            /// 'secondary'. Possible values include: 'primary', 'secondary'
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdminKeyResult> RegenerateAsync(this IAdminKeysOperations operations, string resourceGroupName, string searchServiceName, AdminKeyKind keyKind, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateWithHttpMessagesAsync(resourceGroupName, searchServiceName, keyKind, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
