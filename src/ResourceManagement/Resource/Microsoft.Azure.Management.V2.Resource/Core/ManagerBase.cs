﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.V2.Resource.Core
{
    public interface IManagerBase
    {
        IResourceManager ResourceManager { get; }
        string SubscriptionId { get;  }
    }

    public abstract class ManagerBase : IManagerBase
    {

        public ManagerBase(RestClient restClient, string subscriptionId)
        {
            SubscriptionId = subscriptionId;
            if (restClient != null)
            {
                ResourceManager = ResourceManager2
                    .Authenticate(restClient)
                    .WithSubscription(subscriptionId);
            }
        }

        public IResourceManager ResourceManager {
            get; protected set;
        }

        public string SubscriptionId
        {
            get; private set;
        }
    }
}
