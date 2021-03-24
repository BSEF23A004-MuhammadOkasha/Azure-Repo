// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Logz.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LogzOrganizationProperties
    {
        /// <summary>
        /// Initializes a new instance of the LogzOrganizationProperties class.
        /// </summary>
        public LogzOrganizationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogzOrganizationProperties class.
        /// </summary>
        /// <param name="companyName">Name of the Logz organization.</param>
        /// <param name="id">Id of the Logz organization.</param>
        /// <param name="enterpriseAppId">The Id of the Enterprise App used for
        /// Single sign on.</param>
        public LogzOrganizationProperties(string companyName = default(string), string id = default(string), string enterpriseAppId = default(string))
        {
            CompanyName = companyName;
            Id = id;
            EnterpriseAppId = enterpriseAppId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Logz organization.
        /// </summary>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets id of the Logz organization.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the Id of the Enterprise App used for Single sign on.
        /// </summary>
        [JsonProperty(PropertyName = "enterpriseAppId")]
        public string EnterpriseAppId { get; set; }

    }
}
