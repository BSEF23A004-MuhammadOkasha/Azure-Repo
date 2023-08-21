// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing a collection of <see cref="ReportResource" /> and their operations.
    /// Each <see cref="ReportResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="ReportResourceCollection" /> instance call the GetReportResources method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class ReportResourceCollection : ArmCollection, IEnumerable<ReportResource>, IAsyncEnumerable<ReportResource>
    {
        private readonly ClientDiagnostics _reportResourceReportClientDiagnostics;
        private readonly ReportRestOperations _reportResourceReportRestClient;
        private readonly ClientDiagnostics _reportResourceReportsClientDiagnostics;
        private readonly ReportsRestOperations _reportResourceReportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReportResourceCollection"/> class for mocking. </summary>
        protected ReportResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReportResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ReportResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reportResourceReportClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ReportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReportResource.ResourceType, out string reportResourceReportApiVersion);
            _reportResourceReportRestClient = new ReportRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reportResourceReportApiVersion);
            _reportResourceReportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ReportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReportResource.ResourceType, out string reportResourceReportsApiVersion);
            _reportResourceReportsRestClient = new ReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reportResourceReportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new AppComplianceAutomation report or update an exiting AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ReportResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string reportName, ReportResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.CreateOrUpdateAsync(reportName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<ReportResource>(new ReportResourceOperationSource(Client), _reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateCreateOrUpdateRequest(reportName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new AppComplianceAutomation report or update an exiting AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ReportResource> CreateOrUpdate(WaitUntil waitUntil, string reportName, ReportResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.CreateOrUpdate(reportName, data, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<ReportResource>(new ReportResourceOperationSource(Client), _reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateCreateOrUpdateRequest(reportName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<ReportResource>> GetAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.GetAsync(reportName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<ReportResource> Get(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.Get(reportName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation report list for the tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReportResource> GetAllAsync(string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reportResourceReportsRestClient.CreateListRequest(skipToken, top, select, offerGuid, reportCreatorTenantId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reportResourceReportsRestClient.CreateListNextPageRequest(nextLink, skipToken, top, select, offerGuid, reportCreatorTenantId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReportResource(Client, ReportResourceData.DeserializeReportResourceData(e)), _reportResourceReportsClientDiagnostics, Pipeline, "ReportResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the AppComplianceAutomation report list for the tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reports_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReportResource> GetAll(string skipToken = null, int? top = null, string select = null, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reportResourceReportsRestClient.CreateListRequest(skipToken, top, select, offerGuid, reportCreatorTenantId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reportResourceReportsRestClient.CreateListNextPageRequest(nextLink, skipToken, top, select, offerGuid, reportCreatorTenantId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReportResource(Client, ReportResourceData.DeserializeReportResourceData(e)), _reportResourceReportsClientDiagnostics, Pipeline, "ReportResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.GetAsync(reportName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<bool> Exists(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.Get(reportName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReportResource> IEnumerable<ReportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReportResource> IAsyncEnumerable<ReportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
