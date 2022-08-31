// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Nginx
{
    internal class NginxCertificateOperationSource : IOperationSource<NginxCertificateResource>
    {
        private readonly ArmClient _client;

        internal NginxCertificateOperationSource(ArmClient client)
        {
            _client = client;
        }

        NginxCertificateResource IOperationSource<NginxCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NginxCertificateData.DeserializeNginxCertificateData(document.RootElement);
            return new NginxCertificateResource(_client, data);
        }

        async ValueTask<NginxCertificateResource> IOperationSource<NginxCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NginxCertificateData.DeserializeNginxCertificateData(document.RootElement);
            return new NginxCertificateResource(_client, data);
        }
    }
}
