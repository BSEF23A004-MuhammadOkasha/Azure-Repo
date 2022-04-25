// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Resource validation request content. </summary>
    public partial class ValidateContent
    {
        /// <summary> Initializes a new instance of ValidateContent. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="validateResourceType"> Resource type used for verification. </param>
        /// <param name="location"> Expected location of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="location"/> is null. </exception>
        public ValidateContent(string name, ValidateResourceTypes validateResourceType, string location)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Name = name;
            ValidateResourceType = validateResourceType;
            Location = location;
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public ValidateResourceTypes ValidateResourceType { get; }
        /// <summary> Expected location of the resource. </summary>
        public string Location { get; }
        /// <summary> ARM resource ID of an App Service plan that would host the app. </summary>
        public string ServerFarmId { get; set; }
        /// <summary> Name of the target SKU for the App Service plan. </summary>
        public string SkuName { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if App Service plan is for Linux workers; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? NeedLinuxWorkers { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if App Service plan is for Spot instances; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsSpot { get; set; }
        /// <summary> Target capacity of the App Service plan (number of VMs). </summary>
        public int? Capacity { get; set; }
        /// <summary> Name of App Service Environment where app or App Service plan should be created. </summary>
        public string HostingEnvironment { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if App Service plan is running as a windows container. </summary>
        public bool? IsXenon { get; set; }
        /// <summary> Base URL of the container registry. </summary>
        public Uri ContainerRegistryBaseUri { get; set; }
        /// <summary> Username for to access the container registry. </summary>
        public string ContainerRegistryUsername { get; set; }
        /// <summary> Password for to access the container registry. </summary>
        public string ContainerRegistryPassword { get; set; }
        /// <summary> Repository name (image name). </summary>
        public string ContainerImageRepository { get; set; }
        /// <summary> Image tag. </summary>
        public string ContainerImageTag { get; set; }
        /// <summary> Platform (windows or linux). </summary>
        public string ContainerImagePlatform { get; set; }
        /// <summary> App Service Environment Properties. </summary>
        public AppServiceEnvironmentAutoGenerated AppServiceEnvironment { get; set; }
    }
}
