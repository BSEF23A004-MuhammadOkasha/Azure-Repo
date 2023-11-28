// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Sms;
using Azure.Core;

namespace Azure.Communication.Sms.Models
{
    /// <summary> Represents the properties of a send message request. </summary>
    internal partial class SendMessageRequest
    {
        /// <summary> Initializes a new instance of <see cref="SendMessageRequest"/>. </summary>
        /// <param name="from"> The sender's phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="smsRecipients"> The recipient's phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/>, <paramref name="smsRecipients"/> or <paramref name="message"/> is null. </exception>
        public SendMessageRequest(string @from, IEnumerable<SmsRecipient> smsRecipients, string message)
        {
            Argument.AssertNotNull(@from, nameof(@from));
            Argument.AssertNotNull(smsRecipients, nameof(smsRecipients));
            Argument.AssertNotNull(message, nameof(message));

            From = @from;
            SmsRecipients = smsRecipients.ToList();
            Message = message;
        }

        /// <summary> The sender's phone number in E.164 format that is owned by the authenticated account. </summary>
        public string From { get; }
        /// <summary> The recipient's phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </summary>
        public IList<SmsRecipient> SmsRecipients { get; }
        /// <summary> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </summary>
        public string Message { get; }
        /// <summary> Optional configuration for sending SMS messages. </summary>
        public SmsSendOptions SmsSendOptions { get; set; }
    }
}
