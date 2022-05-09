// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container App Dapr configuration.
    /// </summary>
    public partial class Dapr
    {
        /// <summary>
        /// Initializes a new instance of the Dapr class.
        /// </summary>
        public Dapr()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dapr class.
        /// </summary>
        /// <param name="enabled">Boolean indicating if the Dapr side car is
        /// enabled</param>
        /// <param name="appId">Dapr application identifier</param>
        /// <param name="appProtocol">Tells Dapr which protocol your
        /// application is using. Valid options are http and grpc. Default is
        /// http. Possible values include: 'http', 'grpc'</param>
        /// <param name="appPort">Tells Dapr which port your application is
        /// listening on</param>
        public Dapr(bool? enabled = default(bool?), string appId = default(string), string appProtocol = default(string), int? appPort = default(int?))
        {
            Enabled = enabled;
            AppId = appId;
            AppProtocol = appProtocol;
            AppPort = appPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets boolean indicating if the Dapr side car is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets dapr application identifier
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets tells Dapr which protocol your application is using.
        /// Valid options are http and grpc. Default is http. Possible values
        /// include: 'http', 'grpc'
        /// </summary>
        [JsonProperty(PropertyName = "appProtocol")]
        public string AppProtocol { get; set; }

        /// <summary>
        /// Gets or sets tells Dapr which port your application is listening on
        /// </summary>
        [JsonProperty(PropertyName = "appPort")]
        public int? AppPort { get; set; }

    }
}
