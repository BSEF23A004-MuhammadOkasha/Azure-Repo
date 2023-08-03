// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.SelfHelp.Mocking;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SelfHelp. </summary>
    public static partial class SelfHelpExtensions
    {
        private static SelfHelpArmClientMockingExtension GetSelfHelpArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new SelfHelpArmClientMockingExtension(client);
            });
        }

        /// <summary> Gets a collection of SelfHelpDiagnosticResources in the ArmClient. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of SelfHelpDiagnosticResources and their operations over a SelfHelpDiagnosticResource. </returns>
        public static SelfHelpDiagnosticCollection GetSelfHelpDiagnostics(this ArmClient client, ResourceIdentifier scope)
        {
            return GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiagnostics(scope);
        }
        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticsResourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SelfHelpDiagnosticResource>> GetSelfHelpDiagnosticAsync(this ArmClient client, ResourceIdentifier scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            return await GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiagnosticAsync(scope, diagnosticsResourceName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/diagnostics/{diagnosticsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticsResourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SelfHelpDiagnosticResource> GetSelfHelpDiagnostic(this ArmClient client, ResourceIdentifier scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            return GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiagnostic(scope, diagnosticsResourceName, cancellationToken);
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic check.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<SelfHelpNameAvailabilityResult>> CheckSelfHelpNameAvailabilityAsync(this ArmClient client, ResourceIdentifier scope, SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            return await GetSelfHelpArmClientMockingExtension(client).CheckSelfHelpNameAvailabilityAsync(scope, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This API is used to check the uniqueness of a resource name used for a diagnostic check.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="content"> The required parameters for availability check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<SelfHelpNameAvailabilityResult> CheckSelfHelpNameAvailability(this ArmClient client, ResourceIdentifier scope, SelfHelpNameAvailabilityContent content = null, CancellationToken cancellationToken = default)
        {
            return GetSelfHelpArmClientMockingExtension(client).CheckSelfHelpNameAvailability(scope, content, cancellationToken);
        }

        /// <summary>
        /// Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static AsyncPageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutionsAsync(this ArmClient client, ResourceIdentifier scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiscoverySolutionsAsync(scope, filter, skiptoken, cancellationToken);
        }

        /// <summary>
        /// Solutions Discovery is the initial point of entry within Help API, which helps you identify the relevant solutions for your Azure issue.&lt;br/&gt;&lt;br/&gt; You can discover solutions using resourceUri OR resourceUri + problemClassificationId.&lt;br/&gt;&lt;br/&gt;We will do our best in returning relevant diagnostics for your Azure issue.&lt;br/&gt;&lt;br/&gt; Get the problemClassificationId(s) using this [reference](https://learn.microsoft.com/rest/api/support/problem-classifications/list?tabs=HTTP).&lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; ‘requiredParameterSets’ from Solutions Discovery API response must be passed via ‘additionalParameters’ as an input to Diagnostics API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/discoverySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolution_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="filter"> Can be used to filter solutionIds by 'ProblemClassificationId'. The filter supports only 'and' and 'eq' operators. Example: $filter=ProblemClassificationId eq '1ddda5b4-cf6c-4d4f-91ad-bc38ab0e811e' and ProblemClassificationId eq '0a9673c2-7af6-4e19-90d3-4ee2461076d9'. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Pageable<SelfHelpSolutionMetadata> GetSelfHelpDiscoverySolutions(this ArmClient client, ResourceIdentifier scope, string filter = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiscoverySolutions(scope, filter, skiptoken, cancellationToken);
        }

        #region SelfHelpDiagnosticResource
        /// <summary>
        /// Gets an object representing a <see cref="SelfHelpDiagnosticResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SelfHelpDiagnosticResource.CreateResourceIdentifier" /> to create a <see cref="SelfHelpDiagnosticResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SelfHelpDiagnosticResource" /> object. </returns>
        public static SelfHelpDiagnosticResource GetSelfHelpDiagnosticResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSelfHelpArmClientMockingExtension(client).GetSelfHelpDiagnosticResource(id);
        }
        #endregion
    }
}
