// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="GroupQuotaLimitResource"/> and their operations.
    /// Each <see cref="GroupQuotaLimitResource"/> in the collection will belong to the same instance of <see cref="GroupQuotaEntityResource"/>.
    /// To get a <see cref="GroupQuotaLimitCollection"/> instance call the GetGroupQuotaLimits method from an instance of <see cref="GroupQuotaEntityResource"/>.
    /// </summary>
    public partial class GroupQuotaLimitCollection : ArmCollection
    {
        private readonly ClientDiagnostics _groupQuotaLimitClientDiagnostics;
        private readonly GroupQuotaLimitsRestOperations _groupQuotaLimitRestClient;
        private readonly string _resourceProviderName;

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaLimitCollection"/> class for mocking. </summary>
        protected GroupQuotaLimitCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaLimitCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        internal GroupQuotaLimitCollection(ArmClient client, ResourceIdentifier id, string resourceProviderName) : base(client, id)
        {
            _resourceProviderName = resourceProviderName;
            _groupQuotaLimitClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", GroupQuotaLimitResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GroupQuotaLimitResource.ResourceType, out string groupQuotaLimitApiVersion);
            _groupQuotaLimitRestClient = new GroupQuotaLimitsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupQuotaLimitApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GroupQuotaEntityResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GroupQuotaEntityResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the GroupQuotaLimits for the specific resource for a specific resource based on the resourceProviders, resourceName and $filter passed.
        /// The $filter=location eq {location} is required to location specific resources groupQuota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual async Task<Response<GroupQuotaLimitResource>> GetAsync(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.Get");
            scope.Start();
            try
            {
                var response = await _groupQuotaLimitRestClient.GetAsync(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the GroupQuotaLimits for the specific resource for a specific resource based on the resourceProviders, resourceName and $filter passed.
        /// The $filter=location eq {location} is required to location specific resources groupQuota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual Response<GroupQuotaLimitResource> Get(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.Get");
            scope.Start();
            try
            {
                var response = _groupQuotaLimitRestClient.Get(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the GroupQuotaLimits for the all resource for a specific  resourceProvider and $filter passed.
        /// The $filter=location eq {location} is required to location specific resources groupQuota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> An async collection of <see cref="GroupQuotaLimitResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GroupQuotaLimitResource> GetAllAsync(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _groupQuotaLimitRestClient.CreateListRequest(Id.Parent.Name, Id.Name, _resourceProviderName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _groupQuotaLimitRestClient.CreateListNextPageRequest(nextLink, Id.Parent.Name, Id.Name, _resourceProviderName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GroupQuotaLimitResource(Client, GroupQuotaLimitData.DeserializeGroupQuotaLimitData(e)), _groupQuotaLimitClientDiagnostics, Pipeline, "GroupQuotaLimitCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the GroupQuotaLimits for the all resource for a specific  resourceProvider and $filter passed.
        /// The $filter=location eq {location} is required to location specific resources groupQuota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> A collection of <see cref="GroupQuotaLimitResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GroupQuotaLimitResource> GetAll(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _groupQuotaLimitRestClient.CreateListRequest(Id.Parent.Name, Id.Name, _resourceProviderName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _groupQuotaLimitRestClient.CreateListNextPageRequest(nextLink, Id.Parent.Name, Id.Name, _resourceProviderName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GroupQuotaLimitResource(Client, GroupQuotaLimitData.DeserializeGroupQuotaLimitData(e)), _groupQuotaLimitClientDiagnostics, Pipeline, "GroupQuotaLimitCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.Exists");
            scope.Start();
            try
            {
                var response = await _groupQuotaLimitRestClient.GetAsync(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.Exists");
            scope.Start();
            try
            {
                var response = _groupQuotaLimitRestClient.Get(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual async Task<NullableResponse<GroupQuotaLimitResource>> GetIfExistsAsync(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _groupQuotaLimitRestClient.GetAsync(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GroupQuotaLimitResource>(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/resourceProviders/{resourceProviderName}/groupQuotaLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaLimitResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location}
        ///  Example: $filter=location eq eastus
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="filter"/> is null. </exception>
        public virtual NullableResponse<GroupQuotaLimitResource> GetIfExists(string resourceName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = _groupQuotaLimitClientDiagnostics.CreateScope("GroupQuotaLimitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _groupQuotaLimitRestClient.Get(Id.Parent.Name, Id.Name, _resourceProviderName, resourceName, filter, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GroupQuotaLimitResource>(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaLimitResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
