// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    internal class PhoneNumbersSearchAvailablePhoneNumbersHeaders
    {
        private readonly Response _response;
        public PhoneNumbersSearchAvailablePhoneNumbersHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL to query for status of the operation. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
        /// <summary> Url to retrieve the final result after operation completes. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
