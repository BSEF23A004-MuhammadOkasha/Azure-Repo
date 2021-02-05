// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Property updates for a phone number. </summary>
    internal partial class PhoneNumberUpdateRequest
    {
        /// <summary> Initializes a new instance of PhoneNumberUpdateRequest. </summary>
        public PhoneNumberUpdateRequest()
        {
        }

        /// <summary>
        /// The webhook for receiving incoming events.
        /// 
        /// e.g. &quot;https://{{site-name}}.azurewebsites.net/api/updates&quot;.
        /// 
        /// Please read https://docs.microsoft.com/en-us/azure/communication-services/concepts/event-handling
        /// 
        /// for integration with Azure Event Grid to deliver real-time event notifications.
        /// </summary>
        public string CallbackUri { get; set; }
        /// <summary> The application id of the application to which to configure. </summary>
        public string ApplicationId { get; set; }
    }
}
