// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Models;

    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataCollectionRules.
    /// </summary>
    public static partial class DataCollectionRulesExtensions
    {
        /// <summary>
        /// Lists all data collection rules in the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        public static Page<DataCollectionRuleResource> ListByResourceGroup(this IDataCollectionRules operations, string resourceGroupName)
        {
            return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all data collection rules in the specified resource group.
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
        public static async Task<Page<DataCollectionRuleResource>> ListByResourceGroupAsync(this IDataCollectionRules operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Lists all data collection rules in the specified subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Page<DataCollectionRuleResource> ListBySubscription(this IDataCollectionRules operations)
        {
            return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all data collection rules in the specified subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Page<DataCollectionRuleResource>> ListBySubscriptionAsync(this IDataCollectionRules operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Returns the specified data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        public static DataCollectionRuleResource Get(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName)
        {
            return operations.GetAsync(resourceGroupName, dataCollectionRuleName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Returns the specified data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DataCollectionRuleResource> GetAsync(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Creates or updates a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='body'>
        /// The payload
        /// </param>
        public static DataCollectionRuleResource Create(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, DataCollectionRuleResource body = default(DataCollectionRuleResource))
        {
            return operations.CreateAsync(resourceGroupName, dataCollectionRuleName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='body'>
        /// The payload
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DataCollectionRuleResource> CreateAsync(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, DataCollectionRuleResource body = default(DataCollectionRuleResource), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates part of a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='body'>
        /// The payload
        /// </param>
        public static DataCollectionRuleResource Update(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, ResourceForUpdate body = default(ResourceForUpdate))
        {
            return operations.UpdateAsync(resourceGroupName, dataCollectionRuleName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates part of a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='body'>
        /// The payload
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DataCollectionRuleResource> UpdateAsync(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, ResourceForUpdate body = default(ResourceForUpdate), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        public static void Delete(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName)
        {
            operations.DeleteAsync(resourceGroupName, dataCollectionRuleName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a data collection rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dataCollectionRuleName'>
        /// The name of the data collection rule. The name is case insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IDataCollectionRules operations, string resourceGroupName, string dataCollectionRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, dataCollectionRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
