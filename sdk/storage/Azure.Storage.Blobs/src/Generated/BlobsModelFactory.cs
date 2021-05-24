// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Model factory for AzureBlobStorage read-only models. </summary>
    public static partial class BlobsModelFactory
    {

        /// <summary> Initializes new instance of UserDelegationKey class. </summary>
        /// <param name="signedObjectId"> The Azure Active Directory object ID in GUID format. </param>
        /// <param name="signedTenantId"> The Azure Active Directory tenant ID in GUID format. </param>
        /// <param name="signedStartsOn"> The date-time the key is active. </param>
        /// <param name="signedExpiresOn"> The date-time the key expires. </param>
        /// <param name="signedService"> Abbreviation of the Azure Storage service that accepts the key. </param>
        /// <param name="signedVersion"> The service version that created the key. </param>
        /// <param name="value"> The key as a base64 string. </param>
        /// <returns> A new <see cref="Models.UserDelegationKey"/> instance for mocking. </returns>
        public static UserDelegationKey UserDelegationKey(string signedObjectId = default, string signedTenantId = default, DateTimeOffset signedStartsOn = default, DateTimeOffset signedExpiresOn = default, string signedService = default, string signedVersion = default, string value = default)
        {
            return new UserDelegationKey(signedObjectId, signedTenantId, signedStartsOn, signedExpiresOn, signedService, signedVersion, value);
        }
    }
}
