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
using Azure.ResourceManager.HealthcareApis.Mocking;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HealthcareApis. </summary>
    public static partial class HealthcareApisExtensions
    {
        private static MockableHealthcareApisArmClient GetMockableHealthcareApisArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHealthcareApisArmClient(client0));
        }

        private static MockableHealthcareApisResourceGroupResource GetMockableHealthcareApisResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthcareApisResourceGroupResource(client, resource.Id));
        }

        private static MockableHealthcareApisSubscriptionResource GetMockableHealthcareApisSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHealthcareApisSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServiceResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisServiceResource"/> object. </returns>
        public static HealthcareApisServiceResource GetHealthcareApisServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServicePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServicePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServicePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisServicePrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisServicePrivateEndpointConnectionResource"/> object. </returns>
        public static HealthcareApisServicePrivateEndpointConnectionResource GetHealthcareApisServicePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisServicePrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisWorkspacePrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisWorkspacePrivateEndpointConnectionResource"/> object. </returns>
        public static HealthcareApisWorkspacePrivateEndpointConnectionResource GetHealthcareApisWorkspacePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisWorkspacePrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisServicePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisServicePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisServicePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisServicePrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisServicePrivateLinkResource"/> object. </returns>
        public static HealthcareApisServicePrivateLinkResource GetHealthcareApisServicePrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisServicePrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspacePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspacePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspacePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisWorkspacePrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisWorkspacePrivateLinkResource"/> object. </returns>
        public static HealthcareApisWorkspacePrivateLinkResource GetHealthcareApisWorkspacePrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisWorkspacePrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisWorkspaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisWorkspaceResource"/> object. </returns>
        public static HealthcareApisWorkspaceResource GetHealthcareApisWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisWorkspaceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DicomServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DicomServiceResource.CreateResourceIdentifier" /> to create a <see cref="DicomServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetDicomServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DicomServiceResource"/> object. </returns>
        public static DicomServiceResource GetDicomServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetDicomServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisIotConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisIotConnectorResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisIotConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisIotConnectorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisIotConnectorResource"/> object. </returns>
        public static HealthcareApisIotConnectorResource GetHealthcareApisIotConnectorResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisIotConnectorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthcareApisIotFhirDestinationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthcareApisIotFhirDestinationResource.CreateResourceIdentifier" /> to create a <see cref="HealthcareApisIotFhirDestinationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetHealthcareApisIotFhirDestinationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HealthcareApisIotFhirDestinationResource"/> object. </returns>
        public static HealthcareApisIotFhirDestinationResource GetHealthcareApisIotFhirDestinationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetHealthcareApisIotFhirDestinationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FhirServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FhirServiceResource.CreateResourceIdentifier" /> to create a <see cref="FhirServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisArmClient.GetFhirServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FhirServiceResource"/> object. </returns>
        public static FhirServiceResource GetFhirServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHealthcareApisArmClient(client).GetFhirServiceResource(id);
        }

        /// <summary>
        /// Gets a collection of HealthcareApisServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HealthcareApisServiceResources and their operations over a HealthcareApisServiceResource. </returns>
        public static HealthcareApisServiceCollection GetHealthcareApisServices(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisServices();
        }

        /// <summary>
        /// Get the metadata of a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/services/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisServiceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthcareApisServiceResource>> GetHealthcareApisServiceAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisServiceAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/services/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisService(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HealthcareApisServiceResource> GetHealthcareApisService(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisService(resourceName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of HealthcareApisWorkspaceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisWorkspaces()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HealthcareApisWorkspaceResources and their operations over a HealthcareApisWorkspaceResource. </returns>
        public static HealthcareApisWorkspaceCollection GetHealthcareApisWorkspaces(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisWorkspaces();
        }

        /// <summary>
        /// Gets the properties of the specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisWorkspaceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthcareApisWorkspaceResource>> GetHealthcareApisWorkspaceAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisWorkspaceAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisResourceGroupResource.GetHealthcareApisWorkspace(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HealthcareApisWorkspaceResource> GetHealthcareApisWorkspace(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHealthcareApisResourceGroupResource(resourceGroupResource).GetHealthcareApisWorkspace(workspaceName, cancellationToken);
        }

        /// <summary>
        /// Get all the service instances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.GetHealthcareApisServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HealthcareApisServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HealthcareApisServiceResource> GetHealthcareApisServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthcareApisSubscriptionResource(subscriptionResource).GetHealthcareApisServicesAsync(cancellationToken);
        }

        /// <summary>
        /// Get all the service instances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.GetHealthcareApisServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HealthcareApisServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HealthcareApisServiceResource> GetHealthcareApisServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthcareApisSubscriptionResource(subscriptionResource).GetHealthcareApisServices(cancellationToken);
        }

        /// <summary>
        /// Check if a service instance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.CheckHealthcareApisNameAvailability(HealthcareApisNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the CheckNameAvailabilityParameters structure to the name of the service instance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<HealthcareApisNameAvailabilityResult>> CheckHealthcareApisNameAvailabilityAsync(this SubscriptionResource subscriptionResource, HealthcareApisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableHealthcareApisSubscriptionResource(subscriptionResource).CheckHealthcareApisNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a service instance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.CheckHealthcareApisNameAvailability(HealthcareApisNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the CheckNameAvailabilityParameters structure to the name of the service instance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<HealthcareApisNameAvailabilityResult> CheckHealthcareApisNameAvailability(this SubscriptionResource subscriptionResource, HealthcareApisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthcareApisSubscriptionResource(subscriptionResource).CheckHealthcareApisNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the available workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.GetHealthcareApisWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HealthcareApisWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HealthcareApisWorkspaceResource> GetHealthcareApisWorkspacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthcareApisSubscriptionResource(subscriptionResource).GetHealthcareApisWorkspacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHealthcareApisSubscriptionResource.GetHealthcareApisWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HealthcareApisWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HealthcareApisWorkspaceResource> GetHealthcareApisWorkspaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHealthcareApisSubscriptionResource(subscriptionResource).GetHealthcareApisWorkspaces(cancellationToken);
        }
    }
}
