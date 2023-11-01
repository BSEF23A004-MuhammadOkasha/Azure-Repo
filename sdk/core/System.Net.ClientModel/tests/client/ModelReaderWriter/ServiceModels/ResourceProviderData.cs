// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Internal;

namespace System.Net.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ResourceProvider data model.
    /// Resource provider information.
    /// </summary>
    public partial class ResourceProviderData
    {
        /// <summary> Initializes a new instance of ProviderData. </summary>
        public ResourceProviderData()
        {
            ResourceTypes = new OptionalList<ProviderResourceType>();
        }

        /// <summary> Initializes a new instance of ProviderData. </summary>
        /// <param name="id"> The provider ID. </param>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="registrationState"> The registration state of the resource provider. </param>
        /// <param name="registrationPolicy"> The registration policy of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        /// <param name="providerAuthorizationConsentState"> The provider authorization consent state. </param>
        internal ResourceProviderData(string id, string @namespace, string registrationState, string registrationPolicy, IReadOnlyList<ProviderResourceType> resourceTypes, ProviderAuthorizationConsentState? providerAuthorizationConsentState)
        {
            Id = id;
            Namespace = @namespace;
            RegistrationState = registrationState;
            RegistrationPolicy = registrationPolicy;
            ResourceTypes = resourceTypes;
            ProviderAuthorizationConsentState = providerAuthorizationConsentState;
        }

        /// <summary> The provider ID. </summary>
        public string Id { get; }
        /// <summary> The namespace of the resource provider. </summary>
        public string Namespace { get; }
        /// <summary> The registration state of the resource provider. </summary>
        public string RegistrationState { get; }
        /// <summary> The registration policy of the resource provider. </summary>
        public string RegistrationPolicy { get; }
        /// <summary> The collection of provider resource types. </summary>
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
        /// <summary> The provider authorization consent state. </summary>
        public ProviderAuthorizationConsentState? ProviderAuthorizationConsentState { get; }
    }
}
