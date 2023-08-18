// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceWorkerPool data model.
    /// Worker pool of an App Service Environment ARM resource.
    /// </summary>
    public partial class AppServiceWorkerPoolData : ResourceData
    {
        /// <summary> Initializes a new instance of AppServiceWorkerPoolData. </summary>
        public AppServiceWorkerPoolData()
        {
            InstanceNames = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppServiceWorkerPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="workerSizeId"> Worker size ID for referencing this worker pool. </param>
        /// <param name="computeMode"> Shared or dedicated app hosting. </param>
        /// <param name="workerSize"> VM size of the worker pool instances. </param>
        /// <param name="workerCount"> Number of instances in the worker pool. </param>
        /// <param name="instanceNames"> Names of all instances in the worker pool (read only). </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceWorkerPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppServiceSkuDescription sku, int? workerSizeId, ComputeModeOption? computeMode, string workerSize, int? workerCount, IReadOnlyList<string> instanceNames, string kind) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            WorkerSizeId = workerSizeId;
            ComputeMode = computeMode;
            WorkerSize = workerSize;
            WorkerCount = workerCount;
            InstanceNames = instanceNames;
            Kind = kind;
        }

        /// <summary> Description of a SKU for a scalable resource. </summary>
        public AppServiceSkuDescription Sku { get; set; }
        /// <summary> Worker size ID for referencing this worker pool. </summary>
        public int? WorkerSizeId { get; set; }
        /// <summary> Shared or dedicated app hosting. </summary>
        public ComputeModeOption? ComputeMode { get; set; }
        /// <summary> VM size of the worker pool instances. </summary>
        public string WorkerSize { get; set; }
        /// <summary> Number of instances in the worker pool. </summary>
        public int? WorkerCount { get; set; }
        /// <summary> Names of all instances in the worker pool (read only). </summary>
        public IReadOnlyList<string> InstanceNames { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
