// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement error settings.
    /// </summary>
    public partial class AS2ErrorSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2ErrorSettings class.
        /// </summary>
        public AS2ErrorSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2ErrorSettings class.
        /// </summary>
        /// <param name="suspendDuplicateMessage">The value indicating whether
        /// to suspend duplicate message.</param>
        /// <param name="resendIfMDNNotReceived">The value indicating whether
        /// to resend message If MDN is not received.</param>
        public AS2ErrorSettings(bool suspendDuplicateMessage, bool resendIfMDNNotReceived)
        {
            SuspendDuplicateMessage = suspendDuplicateMessage;
            ResendIfMDNNotReceived = resendIfMDNNotReceived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to suspend duplicate
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "suspendDuplicateMessage")]
        public bool SuspendDuplicateMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to resend message If MDN
        /// is not received.
        /// </summary>
        [JsonProperty(PropertyName = "resendIfMDNNotReceived")]
        public bool ResendIfMDNNotReceived { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
