// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Specifies a configuration for PlayReady licenses. </summary>
    public partial class ContentKeyPolicyPlayReadyConfiguration : ContentKeyPolicyConfiguration
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyConfiguration. </summary>
        /// <param name="licenses"> The PlayReady licenses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="licenses"/> is null. </exception>
        public ContentKeyPolicyPlayReadyConfiguration(IEnumerable<ContentKeyPolicyPlayReadyLicense> licenses)
        {
            if (licenses == null)
            {
                throw new ArgumentNullException(nameof(licenses));
            }

            Licenses = licenses.ToList();
            OdataType = "#Microsoft.Media.ContentKeyPolicyPlayReadyConfiguration";
        }

        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyConfiguration. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="licenses"> The PlayReady licenses. </param>
        /// <param name="responseCustomData"> The custom response data. </param>
        internal ContentKeyPolicyPlayReadyConfiguration(string odataType, IList<ContentKeyPolicyPlayReadyLicense> licenses, BinaryData responseCustomData) : base(odataType)
        {
            Licenses = licenses;
            ResponseCustomData = responseCustomData;
            OdataType = odataType ?? "#Microsoft.Media.ContentKeyPolicyPlayReadyConfiguration";
        }

        /// <summary> The PlayReady licenses. </summary>
        public IList<ContentKeyPolicyPlayReadyLicense> Licenses { get; }
        /// <summary>
        /// The custom response data.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ResponseCustomData { get; set; }
    }
}
