﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using System.Threading.Tasks;
using System.Threading;

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    internal class FeaturesImpl : IFeatures
    {
        private IFeaturesOperations client;

        internal FeaturesImpl(IFeaturesOperations client)
        {
            this.client = client;
        }

        public IEnumerable<IFeature> List()
        {
            return client.ListAll()
                         .AsContinuousCollection(link => client.ListNext(link))
                         .Select(inner => WrapModel(inner));
        }

        public IFeature Register(string resourceProviderNamespace, string featureName)
        {
            return RegisterAsync(resourceProviderNamespace, featureName).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<IFeature> RegisterAsync(
            string resourceProviderNamespace, 
            string featureName, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return WrapModel(await client.RegisterAsync(resourceProviderNamespace, featureName, cancellationToken));
        }

        private IFeature WrapModel(FeatureResultInner innerModel)
        {
            return new FeatureImpl(innerModel);
        }
    }
}
