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

    public partial class UserInfo
    {
        /// <summary>
        /// Initializes a new instance of the UserInfo class.
        /// </summary>
        public UserInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInfo class.
        /// </summary>
        /// <param name="firstName">First Name of the user</param>
        /// <param name="lastName">Last Name of the user</param>
        /// <param name="emailAddress">Email of the user used by Logz for
        /// contacting them if needed</param>
        /// <param name="phoneNumber">Phone number of the user used by Logz for
        /// contacting them if needed</param>
        public UserInfo(string firstName = default(string), string lastName = default(string), string emailAddress = default(string), string phoneNumber = default(string))
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets first Name of the user
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last Name of the user
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets email of the user used by Logz for contacting them if
        /// needed
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets phone number of the user used by Logz for contacting
        /// them if needed
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

    }
}
