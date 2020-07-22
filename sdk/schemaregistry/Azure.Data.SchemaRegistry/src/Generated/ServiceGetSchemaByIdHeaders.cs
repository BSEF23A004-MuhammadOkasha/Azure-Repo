// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Data.SchemaRegistry
{
    internal class ServiceGetSchemaByIdHeaders
    {
        private readonly Response _response;
        public ServiceGetSchemaByIdHeaders(Response response)
        {
            _response = response;
        }
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        public string XSchemaType => _response.Headers.TryGetValue("X-Schema-Type", out string value) ? value : null;
        /// <summary> unique schema identifier. </summary>
        public string XSchemaId => _response.Headers.TryGetValue("X-Schema-Id", out string value) ? value : null;
        /// <summary> location of schema resource. </summary>
        public Uri XSchemaIdLocation => _response.Headers.TryGetValue("X-Schema-Id-Location", out Uri value) ? value : null;
        /// <summary> version of returned schema. </summary>
        public int? XSchemaVersion => _response.Headers.TryGetValue("X-Schema-Version", out int? value) ? value : null;
    }
}
