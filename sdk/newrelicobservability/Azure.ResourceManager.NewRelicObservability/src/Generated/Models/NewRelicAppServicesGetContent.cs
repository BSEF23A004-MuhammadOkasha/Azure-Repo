// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Request of a app services get Operation. </summary>
    public partial class NewRelicAppServicesGetContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicAppServicesGetContent"/>. </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        public NewRelicAppServicesGetContent(string userEmail)
        {
            if (userEmail == null)
            {
                throw new ArgumentNullException(nameof(userEmail));
            }

            AzureResourceIds = new ChangeTrackingList<ResourceIdentifier>();
            UserEmail = userEmail;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicAppServicesGetContent"/>. </summary>
        /// <param name="azureResourceIds"> Azure resource IDs. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicAppServicesGetContent(IList<ResourceIdentifier> azureResourceIds, string userEmail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureResourceIds = azureResourceIds;
            UserEmail = userEmail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicAppServicesGetContent"/> for deserialization. </summary>
        internal NewRelicAppServicesGetContent()
        {
        }

        /// <summary> Azure resource IDs. </summary>
        public IList<ResourceIdentifier> AzureResourceIds { get; }
        /// <summary> User Email. </summary>
        public string UserEmail { get; }
    }
}
