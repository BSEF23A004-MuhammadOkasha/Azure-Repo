// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> The recommended configuration for a three tier SAP system. </summary>
    public partial class ThreeTierRecommendationResult : SAPSizingRecommendationResult
    {
        /// <summary> Initializes a new instance of ThreeTierRecommendationResult. </summary>
        internal ThreeTierRecommendationResult()
        {
            DeploymentType = SAPDeploymentType.ThreeTier;
        }

        /// <summary> Initializes a new instance of ThreeTierRecommendationResult. </summary>
        /// <param name="deploymentType"> The deployment Type. </param>
        /// <param name="dbVmSku"> The database VM SKU. </param>
        /// <param name="databaseInstanceCount"> The database server instance count. </param>
        /// <param name="centralServerVmSku"> The central server VM SKU. </param>
        /// <param name="centralServerInstanceCount"> The central server instance count. </param>
        /// <param name="applicationServerVmSku"> The application server VM SKU. </param>
        /// <param name="applicationServerInstanceCount"> The application server instance count. </param>
        internal ThreeTierRecommendationResult(SAPDeploymentType deploymentType, string dbVmSku, long? databaseInstanceCount, string centralServerVmSku, long? centralServerInstanceCount, string applicationServerVmSku, long? applicationServerInstanceCount) : base(deploymentType)
        {
            DbVmSku = dbVmSku;
            DatabaseInstanceCount = databaseInstanceCount;
            CentralServerVmSku = centralServerVmSku;
            CentralServerInstanceCount = centralServerInstanceCount;
            ApplicationServerVmSku = applicationServerVmSku;
            ApplicationServerInstanceCount = applicationServerInstanceCount;
            DeploymentType = deploymentType;
        }

        /// <summary> The database VM SKU. </summary>
        public string DbVmSku { get; }
        /// <summary> The database server instance count. </summary>
        public long? DatabaseInstanceCount { get; }
        /// <summary> The central server VM SKU. </summary>
        public string CentralServerVmSku { get; }
        /// <summary> The central server instance count. </summary>
        public long? CentralServerInstanceCount { get; }
        /// <summary> The application server VM SKU. </summary>
        public string ApplicationServerVmSku { get; }
        /// <summary> The application server instance count. </summary>
        public long? ApplicationServerInstanceCount { get; }
    }
}
