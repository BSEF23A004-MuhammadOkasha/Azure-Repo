// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> A request to send a document notification. </summary>
    public partial class DocumentNotificationContent : NotificationContent
    {
        /// <summary> Initializes a new instance of <see cref="DocumentNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="mediaUri"/> is null. </exception>
        public DocumentNotificationContent(Guid channelRegistrationId, IEnumerable<string> to, Uri mediaUri) : base(channelRegistrationId, to)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(mediaUri, nameof(mediaUri));

            Kind = CommunicationMessageKind.Document;
            MediaUri = mediaUri;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="kind"> The type discriminator describing a notification type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="caption"> Optional text content. </param>
        /// <param name="fileName"> Optional name for the file. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        internal DocumentNotificationContent(Guid channelRegistrationId, IList<string> to, CommunicationMessageKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string caption, string fileName, Uri mediaUri) : base(channelRegistrationId, to, kind, serializedAdditionalRawData)
        {
            Caption = caption;
            FileName = fileName;
            MediaUri = mediaUri;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentNotificationContent"/> for deserialization. </summary>
        internal DocumentNotificationContent()
        {
        }

        /// <summary> Optional text content. </summary>
        public string Caption { get; set; }
        /// <summary> Optional name for the file. </summary>
        public string FileName { get; set; }
        /// <summary> A media url for the file. Required if the type is one of the supported media types, e.g. image. </summary>
        public Uri MediaUri { get; }
    }
}
