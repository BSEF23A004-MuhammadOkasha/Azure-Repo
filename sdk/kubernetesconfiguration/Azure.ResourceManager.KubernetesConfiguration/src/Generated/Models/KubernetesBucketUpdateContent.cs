// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to reconcile to the Bucket source kind type. </summary>
    public partial class KubernetesBucketUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesBucketUpdateContent"/>. </summary>
        public KubernetesBucketUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesBucketUpdateContent"/>. </summary>
        /// <param name="uri"> The URL to sync for the flux configuration S3 bucket. </param>
        /// <param name="bucketName"> The bucket name to sync from the url endpoint for the flux configuration. </param>
        /// <param name="useInsecureCommunication"> Specify whether to use insecure communication when puling data from the S3 bucket. </param>
        /// <param name="timeoutInSeconds"> The maximum time to attempt to reconcile the cluster bucket source with the remote. </param>
        /// <param name="syncIntervalInSeconds"> The interval at which to re-reconcile the cluster bucket source with the remote. </param>
        /// <param name="accessKey"> Plaintext access key used to securely access the S3 bucket. </param>
        /// <param name="localAuthRef"> Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesBucketUpdateContent(Uri uri, string bucketName, bool? useInsecureCommunication, long? timeoutInSeconds, long? syncIntervalInSeconds, string accessKey, string localAuthRef, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            BucketName = bucketName;
            UseInsecureCommunication = useInsecureCommunication;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            AccessKey = accessKey;
            LocalAuthRef = localAuthRef;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URL to sync for the flux configuration S3 bucket. </summary>
        public Uri Uri { get; set; }
        /// <summary> The bucket name to sync from the url endpoint for the flux configuration. </summary>
        public string BucketName { get; set; }
        /// <summary> Specify whether to use insecure communication when puling data from the S3 bucket. </summary>
        public bool? UseInsecureCommunication { get; set; }
        /// <summary> The maximum time to attempt to reconcile the cluster bucket source with the remote. </summary>
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the cluster bucket source with the remote. </summary>
        public long? SyncIntervalInSeconds { get; set; }
        /// <summary> Plaintext access key used to securely access the S3 bucket. </summary>
        public string AccessKey { get; set; }
        /// <summary> Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets. </summary>
        public string LocalAuthRef { get; set; }
    }
}
