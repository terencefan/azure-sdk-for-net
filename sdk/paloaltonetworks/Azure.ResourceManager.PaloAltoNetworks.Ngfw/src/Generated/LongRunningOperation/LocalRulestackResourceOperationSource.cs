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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class LocalRulestackResourceOperationSource : IOperationSource<LocalRulestackResource>
    {
        private readonly ArmClient _client;

        internal LocalRulestackResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulestackResource IOperationSource<LocalRulestackResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LocalRulestackResourceData.DeserializeLocalRulestackResourceData(document.RootElement);
            return new LocalRulestackResource(_client, data);
        }

        async ValueTask<LocalRulestackResource> IOperationSource<LocalRulestackResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LocalRulestackResourceData.DeserializeLocalRulestackResourceData(document.RootElement);
            return new LocalRulestackResource(_client, data);
        }
    }
}
