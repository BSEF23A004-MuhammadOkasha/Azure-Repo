// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.Dns
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// RecordSetsOperations operations.
    /// </summary>
    public partial interface IRecordSetsOperations
    {
        /// <summary>
        /// Updates a record set within a DNS zone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='relativeRecordSetName'>
        /// The name of the record set, relative to the name of the zone.
        /// </param>
        /// <param name='recordType'>
        /// The type of DNS record in this record set. Possible values include:
        /// 'A', 'AAAA', 'CNAME', 'MX', 'NS', 'PTR', 'SOA', 'SRV', 'TXT'
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update operation.
        /// </param>
        /// <param name='ifMatch'>
        /// The etag of the record set. Omit this value to always overwrite the
        /// current record set. Specify the last-seen etag value to prevent
        /// accidentally overwritting concurrent changes.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<RecordSetInner>> UpdateWithHttpMessagesAsync(string resourceGroupName, string zoneName, string relativeRecordSetName, RecordType recordType, RecordSetInner parameters, string ifMatch = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a record set within a DNS zone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='relativeRecordSetName'>
        /// The name of the record set, relative to the name of the zone.
        /// </param>
        /// <param name='recordType'>
        /// The type of DNS record in this record set. Record sets of type SOA
        /// can be updated but not created (they are created when the DNS zone
        /// is created). Possible values include: 'A', 'AAAA', 'CNAME', 'MX',
        /// 'NS', 'PTR', 'SOA', 'SRV', 'TXT'
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='ifMatch'>
        /// The etag of the record set. Omit this value to always overwrite the
        /// current record set. Specify the last-seen etag value to prevent
        /// accidentally overwritting any concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new record set to be created, but to prevent
        /// updating an existing record set. Other values will be ignored.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<RecordSetInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string zoneName, string relativeRecordSetName, RecordType recordType, RecordSetInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a record set from a DNS zone. This operation cannot be
        /// undone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='relativeRecordSetName'>
        /// The name of the record set, relative to the name of the zone.
        /// </param>
        /// <param name='recordType'>
        /// The type of DNS record in this record set. Record sets of type SOA
        /// cannot be deleted (they are deleted when the DNS zone is deleted).
        /// Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'NS', 'PTR',
        /// 'SOA', 'SRV', 'TXT'
        /// </param>
        /// <param name='ifMatch'>
        /// The etag of the record set. Omit this value to always delete the
        /// current record set. Specify the last-seen etag value to prevent
        /// accidentally deleting any concurrent changes.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string zoneName, string relativeRecordSetName, RecordType recordType, string ifMatch = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a record set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='relativeRecordSetName'>
        /// The name of the record set, relative to the name of the zone.
        /// </param>
        /// <param name='recordType'>
        /// The type of DNS record in this record set. Possible values include:
        /// 'A', 'AAAA', 'CNAME', 'MX', 'NS', 'PTR', 'SOA', 'SRV', 'TXT'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<RecordSetInner>> GetWithHttpMessagesAsync(string resourceGroupName, string zoneName, string relativeRecordSetName, RecordType recordType, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the record sets of a specified type in a DNS zone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='recordType'>
        /// The type of record sets to enumerate. Possible values include: 'A',
        /// 'AAAA', 'CNAME', 'MX', 'NS', 'PTR', 'SOA', 'SRV', 'TXT'
        /// </param>
        /// <param name='top'>
        /// The maximum number of record sets to return. If not specified,
        /// returns up to 100 record sets.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<RecordSetInner>>> ListByTypeWithHttpMessagesAsync(string resourceGroupName, string zoneName, RecordType recordType, int? top = default(int?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all record sets in a DNS zone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='zoneName'>
        /// The name of the DNS zone (without a terminating dot).
        /// </param>
        /// <param name='top'>
        /// The maximum number of record sets to return. If not specified,
        /// returns up to 100 record sets.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<RecordSetInner>>> ListByDnsZoneWithHttpMessagesAsync(string resourceGroupName, string zoneName, int? top = default(int?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the record sets of a specified type in a DNS zone.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<RecordSetInner>>> ListByTypeNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all record sets in a DNS zone.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<RecordSetInner>>> ListByDnsZoneNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
