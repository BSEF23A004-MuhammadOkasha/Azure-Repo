﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.Provisioning.ResourceManager
{
    /// <summary>
    /// Resource group resource.
    /// </summary>
    public class ResourceGroup : Resource<ResourceGroupData>
    {
        internal static readonly ResourceType ResourceType = "Microsoft.Resources/resourceGroups";

        /// <summary>
        /// Whether the resource group is anonymous.
        /// </summary>
        internal bool IsAnonymous { get; }

        internal ResourceGroup(IConstruct scope, string? name = "rg", string version = "2023-07-01", AzureLocation? location = default, bool isAnonymous = false, Subscription? parent = default)
            : this(scope, isAnonymous ? "resourceGroup()" : name, version, location, parent)
        {
            IsAnonymous = isAnonymous;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroup"/>.
        /// </summary>
        /// <param name="scope">The scope the resourceGroup belongs to.</param>
        /// <param name="name">The name of the resourceGroup.</param>
        /// <param name="version">The version of the resourceGroup.</param>
        /// <param name="location">The location of the resourceGroup.</param>
        /// <param name="parent">The parent of the resourceGroup.</param>
        public ResourceGroup(IConstruct scope, string? name = "rg", string version = "2023-07-01", AzureLocation? location = default, Subscription? parent = default)
            : base(scope, parent, name!, ResourceType, version, (name) => ResourceManagerModelFactory.ResourceGroupData(
                name: name,
                resourceType: ResourceType,
                tags: new Dictionary<string, string> { { "azd-env-name", scope.EnvironmentName } },
                location: location ?? Environment.GetEnvironmentVariable("AZURE_LOCATION") ?? AzureLocation.WestUS))
        {
        }

        /// <inheritdoc/>
        protected override Resource? FindParentInScope(IConstruct scope)
        {
            var result = base.FindParentInScope(scope);
            if (result is null)
            {
                result = scope.GetOrCreateSubscription();
            }
            return result;
        }

        /// <inheritdoc/>
        protected override string GetAzureName(IConstruct scope, string resourceName)
        {
            // we can't use IsAnonymous here because this is called from the Resource constructor (before IsAnonymous is set)
            return resourceName == "resourceGroup()" ? resourceName : base.GetAzureName(scope, resourceName);
        }
    }
}
