// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RecoveryPoints operations.
    /// </summary>
    public partial interface IRecoveryPoints
    {
        /// <summary>
        /// Returns a list of Recovery Points for a DataSource in a vault.
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AzureBackupRecoveryPointResourceList>> GetListWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
