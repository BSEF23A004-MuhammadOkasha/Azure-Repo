// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupsOperations.
    /// </summary>
    public static partial class BackupsOperationsExtensions
    {
            /// <summary>
            /// List Backups
            /// </summary>
            /// <remarks>
            /// List all backups for a volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            public static IEnumerable<Backup> List(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName)
            {
                return operations.ListAsync(resourceGroupName, accountName, poolName, volumeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Backups
            /// </summary>
            /// <remarks>
            /// List all backups for a volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Backup>> ListAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a backup
            /// </summary>
            /// <remarks>
            /// Get a particular backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            public static Backup Get(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName)
            {
                return operations.GetAsync(resourceGroupName, accountName, poolName, volumeName, backupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a backup
            /// </summary>
            /// <remarks>
            /// Get a particular backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Backup> GetAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a backup
            /// </summary>
            /// <remarks>
            /// Create a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            public static Backup Create(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, Backup body)
            {
                return operations.CreateAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a backup
            /// </summary>
            /// <remarks>
            /// Create a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Backup> CreateAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, Backup body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch a backup
            /// </summary>
            /// <remarks>
            /// Patch a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            public static Backup Update(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, BackupPatch body = default(BackupPatch))
            {
                return operations.UpdateAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch a backup
            /// </summary>
            /// <remarks>
            /// Patch a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Backup> UpdateAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, BackupPatch body = default(BackupPatch), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete backup
            /// </summary>
            /// <remarks>
            /// Delete a backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            public static void Delete(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, poolName, volumeName, backupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete backup
            /// </summary>
            /// <remarks>
            /// Delete a backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a backup
            /// </summary>
            /// <remarks>
            /// Create a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            public static Backup BeginCreate(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, Backup body)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a backup
            /// </summary>
            /// <remarks>
            /// Create a backup for the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='body'>
            /// Backup object supplied in the body of the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Backup> BeginCreateAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, Backup body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete backup
            /// </summary>
            /// <remarks>
            /// Delete a backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            public static void BeginDelete(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName, poolName, volumeName, backupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete backup
            /// </summary>
            /// <remarks>
            /// Delete a backup of the volume
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='backupName'>
            /// The name of the backup
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IBackupsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string backupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, backupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
