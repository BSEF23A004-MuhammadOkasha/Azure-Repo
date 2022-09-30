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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.CustomerInsights. </summary>
    public static partial class CustomerInsightsExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs
        /// Operation Id: Hubs_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HubResource> GetHubsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetHubsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs
        /// Operation Id: Hubs_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HubResource> GetHubs(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetHubs(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of HubResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HubResources and their operations over a HubResource. </returns>
        public static HubCollection GetHubs(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetHubs();
        }

        /// <summary>
        /// Gets information about the specified hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}
        /// Operation Id: Hubs_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HubResource>> GetHubAsync(this ResourceGroupResource resourceGroupResource, string hubName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetHubs().GetAsync(hubName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}
        /// Operation Id: Hubs_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HubResource> GetHub(this ResourceGroupResource resourceGroupResource, string hubName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetHubs().Get(hubName, cancellationToken);
        }

        #region HubResource
        /// <summary>
        /// Gets an object representing a <see cref="HubResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HubResource.CreateResourceIdentifier" /> to create a <see cref="HubResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HubResource" /> object. </returns>
        public static HubResource GetHubResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HubResource.ValidateResourceId(id);
                return new HubResource(client, id);
            }
            );
        }
        #endregion

        #region ProfileResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="ProfileResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProfileResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ProfileResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProfileResourceFormatResource" /> object. </returns>
        public static ProfileResourceFormatResource GetProfileResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ProfileResourceFormatResource.ValidateResourceId(id);
                return new ProfileResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region InteractionResourceFormatResource
        /// <summary>
        /// Gets an object representing an <see cref="InteractionResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InteractionResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="InteractionResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InteractionResourceFormatResource" /> object. </returns>
        public static InteractionResourceFormatResource GetInteractionResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                InteractionResourceFormatResource.ValidateResourceId(id);
                return new InteractionResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region RelationshipResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="RelationshipResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipResourceFormatResource" /> object. </returns>
        public static RelationshipResourceFormatResource GetRelationshipResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelationshipResourceFormatResource.ValidateResourceId(id);
                return new RelationshipResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region RelationshipLinkResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="RelationshipLinkResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipLinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipLinkResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipLinkResourceFormatResource" /> object. </returns>
        public static RelationshipLinkResourceFormatResource GetRelationshipLinkResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelationshipLinkResourceFormatResource.ValidateResourceId(id);
                return new RelationshipLinkResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region AuthorizationPolicyResourceFormatResource
        /// <summary>
        /// Gets an object representing an <see cref="AuthorizationPolicyResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AuthorizationPolicyResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="AuthorizationPolicyResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationPolicyResourceFormatResource" /> object. </returns>
        public static AuthorizationPolicyResourceFormatResource GetAuthorizationPolicyResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AuthorizationPolicyResourceFormatResource.ValidateResourceId(id);
                return new AuthorizationPolicyResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region ConnectorResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="ConnectorResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorResourceFormatResource" /> object. </returns>
        public static ConnectorResourceFormatResource GetConnectorResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConnectorResourceFormatResource.ValidateResourceId(id);
                return new ConnectorResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region ConnectorMappingResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="ConnectorMappingResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorMappingResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorMappingResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorMappingResourceFormatResource" /> object. </returns>
        public static ConnectorMappingResourceFormatResource GetConnectorMappingResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConnectorMappingResourceFormatResource.ValidateResourceId(id);
                return new ConnectorMappingResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region KpiResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="KpiResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KpiResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="KpiResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KpiResourceFormatResource" /> object. </returns>
        public static KpiResourceFormatResource GetKpiResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                KpiResourceFormatResource.ValidateResourceId(id);
                return new KpiResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region WidgetTypeResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="WidgetTypeResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WidgetTypeResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="WidgetTypeResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WidgetTypeResourceFormatResource" /> object. </returns>
        public static WidgetTypeResourceFormatResource GetWidgetTypeResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WidgetTypeResourceFormatResource.ValidateResourceId(id);
                return new WidgetTypeResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region ViewResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="ViewResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ViewResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ViewResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ViewResourceFormatResource" /> object. </returns>
        public static ViewResourceFormatResource GetViewResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ViewResourceFormatResource.ValidateResourceId(id);
                return new ViewResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region LinkResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="LinkResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="LinkResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LinkResourceFormatResource" /> object. </returns>
        public static LinkResourceFormatResource GetLinkResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LinkResourceFormatResource.ValidateResourceId(id);
                return new LinkResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region RoleAssignmentResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="RoleAssignmentResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RoleAssignmentResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RoleAssignmentResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleAssignmentResourceFormatResource" /> object. </returns>
        public static RoleAssignmentResourceFormatResource GetRoleAssignmentResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RoleAssignmentResourceFormatResource.ValidateResourceId(id);
                return new RoleAssignmentResourceFormatResource(client, id);
            }
            );
        }
        #endregion

        #region PredictionResourceFormatResource
        /// <summary>
        /// Gets an object representing a <see cref="PredictionResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PredictionResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="PredictionResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PredictionResourceFormatResource" /> object. </returns>
        public static PredictionResourceFormatResource GetPredictionResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PredictionResourceFormatResource.ValidateResourceId(id);
                return new PredictionResourceFormatResource(client, id);
            }
            );
        }
        #endregion
    }
}
