// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An email receiver. </summary>
    public partial class MonitorEmailReceiver
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorEmailReceiver"/>. </summary>
        /// <param name="name"> The name of the email receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="emailAddress"> The email address of this receiver. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="emailAddress"/> is null. </exception>
        public MonitorEmailReceiver(string name, string emailAddress)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(emailAddress, nameof(emailAddress));

            Name = name;
            EmailAddress = emailAddress;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorEmailReceiver"/>. </summary>
        /// <param name="name"> The name of the email receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="emailAddress"> The email address of this receiver. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        /// <param name="status"> The receiver status of the e-mail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorEmailReceiver(string name, string emailAddress, bool? useCommonAlertSchema, MonitorReceiverStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            EmailAddress = emailAddress;
            UseCommonAlertSchema = useCommonAlertSchema;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorEmailReceiver"/> for deserialization. </summary>
        internal MonitorEmailReceiver()
        {
        }

        /// <summary> The name of the email receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The email address of this receiver. </summary>
        public string EmailAddress { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
        /// <summary> The receiver status of the e-mail. </summary>
        public MonitorReceiverStatus? Status { get; }
    }
}
