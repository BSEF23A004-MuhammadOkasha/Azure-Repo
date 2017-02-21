// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of an IoT hub.
    /// </summary>
    public partial class IotHubProperties
    {
        /// <summary>
        /// Initializes a new instance of the IotHubProperties class.
        /// </summary>
        public IotHubProperties()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IotHubProperties class.
        /// </summary>
        public IotHubProperties(IList<SharedAccessSignatureAuthorizationRule> authorizationPolicies = default(IList<SharedAccessSignatureAuthorizationRule>), IList<IpFilterRule> ipFilterRules = default(IList<IpFilterRule>), string provisioningState = default(string), string hostName = default(string), IDictionary<string, EventHubProperties> eventHubEndpoints = default(IDictionary<string, EventHubProperties>), RoutingProperties routing = default(RoutingProperties), IDictionary<string, StorageEndpointProperties> storageEndpoints = default(IDictionary<string, StorageEndpointProperties>), IDictionary<string, MessagingEndpointProperties> messagingEndpoints = default(IDictionary<string, MessagingEndpointProperties>), bool? enableFileUploadNotifications = default(bool?), CloudToDeviceProperties cloudToDevice = default(CloudToDeviceProperties), string comments = default(string), OperationsMonitoringProperties operationsMonitoringProperties = default(OperationsMonitoringProperties), string features = default(string))
        {
            AuthorizationPolicies = authorizationPolicies;
            IpFilterRules = ipFilterRules;
            ProvisioningState = provisioningState;
            HostName = hostName;
            EventHubEndpoints = eventHubEndpoints;
            Routing = routing;
            StorageEndpoints = storageEndpoints;
            MessagingEndpoints = messagingEndpoints;
            EnableFileUploadNotifications = enableFileUploadNotifications;
            CloudToDevice = cloudToDevice;
            Comments = comments;
            OperationsMonitoringProperties = operationsMonitoringProperties;
            Features = features;
        }

        /// <summary>
        /// The shared access policies you can use to secure a connection to
        /// the IoT hub.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationPolicies")]
        public IList<SharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get; set; }

        /// <summary>
        /// The IP filter rules.
        /// </summary>
        [JsonProperty(PropertyName = "ipFilterRules")]
        public IList<IpFilterRule> IpFilterRules { get; set; }

        /// <summary>
        /// The provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// The Event Hub-compatible endpoint properties. The possible keys to
        /// this dictionary are events and operationsMonitoringEvents. Both
        /// of these keys have to be present in the dictionary while making
        /// create or update calls for the IoT hub.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubEndpoints")]
        public IDictionary<string, EventHubProperties> EventHubEndpoints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "routing")]
        public RoutingProperties Routing { get; set; }

        /// <summary>
        /// The list of Azure Storage endpoints where you can upload files.
        /// Currently you can configure only one Azure Storage account and
        /// that MUST have its key as $default. Specifying more than one
        /// storage account causes an error to be thrown. Not specifying a
        /// value for this property when the enableFileUploadNotifications
        /// property is set to True, causes an error to be thrown.
        /// </summary>
        [JsonProperty(PropertyName = "storageEndpoints")]
        public IDictionary<string, StorageEndpointProperties> StorageEndpoints { get; set; }

        /// <summary>
        /// The messaging endpoint properties for the file upload notification
        /// queue.
        /// </summary>
        [JsonProperty(PropertyName = "messagingEndpoints")]
        public IDictionary<string, MessagingEndpointProperties> MessagingEndpoints { get; set; }

        /// <summary>
        /// If True, file upload notifications are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableFileUploadNotifications")]
        public bool? EnableFileUploadNotifications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloudToDevice")]
        public CloudToDeviceProperties CloudToDevice { get; set; }

        /// <summary>
        /// Comments.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationsMonitoringProperties")]
        public OperationsMonitoringProperties OperationsMonitoringProperties { get; set; }

        /// <summary>
        /// The capabilities and features enabled for the IoT hub. Possible
        /// values include: 'None', 'DeviceManagement'
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public string Features { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.AuthorizationPolicies != null)
            {
                foreach (var element in this.AuthorizationPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.IpFilterRules != null)
            {
                foreach (var element1 in this.IpFilterRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Routing != null)
            {
                this.Routing.Validate();
            }
            if (this.StorageEndpoints != null)
            {
                foreach (var valueElement in this.StorageEndpoints.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (this.MessagingEndpoints != null)
            {
                foreach (var valueElement1 in this.MessagingEndpoints.Values)
                {
                    if (valueElement1 != null)
                    {
                        valueElement1.Validate();
                    }
                }
            }
            if (this.CloudToDevice != null)
            {
                this.CloudToDevice.Validate();
            }
        }
    }
}
