// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExportJobs.
    /// </summary>
    public static partial class ExportJobsExtensions
    {
            /// <summary>
            /// Triggers export of jobs and returns an OperationID to track.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            public static ExportJobsTriggerHeaders Trigger(this IExportJobs operations, string resourceGroupName, string vaultName)
            {
                return operations.TriggerAsync(resourceGroupName, vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers export of jobs and returns an OperationID to track.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExportJobsTriggerHeaders> TriggerAsync(this IExportJobs operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TriggerWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
