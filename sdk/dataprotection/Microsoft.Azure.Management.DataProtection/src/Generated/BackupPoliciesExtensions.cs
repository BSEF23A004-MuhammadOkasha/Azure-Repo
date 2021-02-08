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
    /// Extension methods for BackupPolicies.
    /// </summary>
    public static partial class BackupPoliciesExtensions
    {
            /// <summary>
            /// Returns list of backup policies belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            public static BaseBackupPolicyResourceList List(this IBackupPolicies operations, string vaultName, string resourceGroupName)
            {
                return operations.ListAsync(vaultName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns list of backup policies belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaseBackupPolicyResourceList> ListAsync(this IBackupPolicies operations, string vaultName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a backup policy belonging to a backup vault
            /// </summary>
            /// <remarks>
            /// Gets a backup policy belonging to a backup vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            public static BaseBackupPolicyResource Get(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName)
            {
                return operations.GetAsync(vaultName, resourceGroupName, backupPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a backup policy belonging to a backup vault
            /// </summary>
            /// <remarks>
            /// Gets a backup policy belonging to a backup vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaseBackupPolicyResource> GetAsync(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, backupPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a backup policy belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static BaseBackupPolicyResource Put(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName, BaseBackupPolicyResource parameters)
            {
                return operations.PutAsync(vaultName, resourceGroupName, backupPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a backup policy belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaseBackupPolicyResource> PutAsync(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName, BaseBackupPolicyResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(vaultName, resourceGroupName, backupPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a backup policy belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            public static void Delete(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName)
            {
                operations.DeleteAsync(vaultName, resourceGroupName, backupPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a backup policy belonging to a backup vault
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupPolicyName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBackupPolicies operations, string vaultName, string resourceGroupName, string backupPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(vaultName, resourceGroupName, backupPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
