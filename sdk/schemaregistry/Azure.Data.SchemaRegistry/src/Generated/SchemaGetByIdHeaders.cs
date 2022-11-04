// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Data.SchemaRegistry
{
    internal partial class SchemaGetByIdHeaders
    {
        private readonly Response _response;
        public SchemaGetByIdHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL location of schema, identified by schema group, schema name, and version. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> The content type for given schema. Each schema type has an associated content-type. </summary>
        public ContentTypeInternal? ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? new ContentTypeInternal(value) : (ContentTypeInternal?)null;
        /// <summary> References specific schema in registry namespace. </summary>
        public string SchemaId => _response.Headers.TryGetValue("Schema-Id", out string value) ? value : null;
        /// <summary> URL location of schema, identified by schema ID. </summary>
        public string SchemaIdLocation => _response.Headers.TryGetValue("Schema-Id-Location", out string value) ? value : null;
        /// <summary> References schema group. </summary>
        public string SchemaGroupName => _response.Headers.TryGetValue("Schema-Group-Name", out string value) ? value : null;
        /// <summary> References schema name. </summary>
        public string SchemaName => _response.Headers.TryGetValue("Schema-Name", out string value) ? value : null;
        /// <summary> Version of the returned schema. </summary>
        public int? SchemaVersion => _response.Headers.TryGetValue("Schema-Version", out int? value) ? value : null;
    }
}
