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

namespace Azure.ResourceManager.VoiceServices
{
    internal class VoiceServicesTestLineOperationSource : Core.IOperationSource<VoiceServicesTestLineResource>
    {
        private readonly ArmClient _client;

        internal VoiceServicesTestLineOperationSource(ArmClient client)
        {
            _client = client;
        }

        VoiceServicesTestLineResource Core.IOperationSource<VoiceServicesTestLineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(document.RootElement);
            return new VoiceServicesTestLineResource(_client, data);
        }

        async ValueTask<VoiceServicesTestLineResource> Core.IOperationSource<VoiceServicesTestLineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(document.RootElement);
            return new VoiceServicesTestLineResource(_client, data);
        }
    }
}
