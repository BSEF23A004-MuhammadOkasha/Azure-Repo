// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster. </summary>
    public partial class Kustomization
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Kustomization"/>. </summary>
        public Kustomization()
        {
            DependsOn = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="Kustomization"/>. </summary>
        /// <param name="name"> Name of the Kustomization, matching the key in the Kustomizations object map. </param>
        /// <param name="path"> The path in the source reference to reconcile on the cluster. </param>
        /// <param name="dependsOn"> Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile until all dependencies have completed their reconciliation. </param>
        /// <param name="timeoutInSeconds"> The maximum time to attempt to reconcile the Kustomization on the cluster. </param>
        /// <param name="syncIntervalInSeconds"> The interval at which to re-reconcile the Kustomization on the cluster. </param>
        /// <param name="retryIntervalInSeconds"> The interval at which to re-reconcile the Kustomization on the cluster in the event of failure on reconciliation. </param>
        /// <param name="prune"> Enable/disable garbage collections of Kubernetes objects created by this Kustomization. </param>
        /// <param name="force"> Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field change. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Kustomization(string name, string path, IList<string> dependsOn, long? timeoutInSeconds, long? syncIntervalInSeconds, long? retryIntervalInSeconds, bool? prune, bool? force, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Path = path;
            DependsOn = dependsOn;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            Prune = prune;
            Force = force;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the Kustomization, matching the key in the Kustomizations object map. </summary>
        public string Name { get; }
        /// <summary> The path in the source reference to reconcile on the cluster. </summary>
        public string Path { get; set; }
        /// <summary> Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile until all dependencies have completed their reconciliation. </summary>
        public IList<string> DependsOn { get; set; }
        /// <summary> The maximum time to attempt to reconcile the Kustomization on the cluster. </summary>
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the Kustomization on the cluster. </summary>
        public long? SyncIntervalInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the Kustomization on the cluster in the event of failure on reconciliation. </summary>
        public long? RetryIntervalInSeconds { get; set; }
        /// <summary> Enable/disable garbage collections of Kubernetes objects created by this Kustomization. </summary>
        public bool? Prune { get; set; }
        /// <summary> Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field change. </summary>
        public bool? Force { get; set; }
    }
}
