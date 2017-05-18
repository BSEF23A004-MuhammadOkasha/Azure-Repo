// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The specification for a pool.
    /// </summary>
    public partial class PoolSpecification : ITransportObjectProvider<Models.PoolSpecification>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<IList<ApplicationPackageReference>> ApplicationPackageReferencesProperty;
            public readonly PropertyAccessor<bool?> AutoScaleEnabledProperty;
            public readonly PropertyAccessor<TimeSpan?> AutoScaleEvaluationIntervalProperty;
            public readonly PropertyAccessor<string> AutoScaleFormulaProperty;
            public readonly PropertyAccessor<IList<CertificateReference>> CertificateReferencesProperty;
            public readonly PropertyAccessor<CloudServiceConfiguration> CloudServiceConfigurationProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<bool?> InterComputeNodeCommunicationEnabledProperty;
            public readonly PropertyAccessor<int?> MaxTasksPerComputeNodeProperty;
            public readonly PropertyAccessor<IList<MetadataItem>> MetadataProperty;
            public readonly PropertyAccessor<NetworkConfiguration> NetworkConfigurationProperty;
            public readonly PropertyAccessor<TimeSpan?> ResizeTimeoutProperty;
            public readonly PropertyAccessor<StartTask> StartTaskProperty;
            public readonly PropertyAccessor<int?> TargetDedicatedProperty;
            public readonly PropertyAccessor<TaskSchedulingPolicy> TaskSchedulingPolicyProperty;
            public readonly PropertyAccessor<IList<UserAccount>> UserAccountsProperty;
            public readonly PropertyAccessor<VirtualMachineConfiguration> VirtualMachineConfigurationProperty;
            public readonly PropertyAccessor<string> VirtualMachineSizeProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor<IList<ApplicationPackageReference>>("ApplicationPackageReferences", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEnabledProperty = this.CreatePropertyAccessor<bool?>("AutoScaleEnabled", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEvaluationIntervalProperty = this.CreatePropertyAccessor<TimeSpan?>("AutoScaleEvaluationInterval", BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleFormulaProperty = this.CreatePropertyAccessor<string>("AutoScaleFormula", BindingAccess.Read | BindingAccess.Write);
                this.CertificateReferencesProperty = this.CreatePropertyAccessor<IList<CertificateReference>>("CertificateReferences", BindingAccess.Read | BindingAccess.Write);
                this.CloudServiceConfigurationProperty = this.CreatePropertyAccessor<CloudServiceConfiguration>("CloudServiceConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>("DisplayName", BindingAccess.Read | BindingAccess.Write);
                this.InterComputeNodeCommunicationEnabledProperty = this.CreatePropertyAccessor<bool?>("InterComputeNodeCommunicationEnabled", BindingAccess.Read | BindingAccess.Write);
                this.MaxTasksPerComputeNodeProperty = this.CreatePropertyAccessor<int?>("MaxTasksPerComputeNode", BindingAccess.Read | BindingAccess.Write);
                this.MetadataProperty = this.CreatePropertyAccessor<IList<MetadataItem>>("Metadata", BindingAccess.Read | BindingAccess.Write);
                this.NetworkConfigurationProperty = this.CreatePropertyAccessor<NetworkConfiguration>("NetworkConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.ResizeTimeoutProperty = this.CreatePropertyAccessor<TimeSpan?>("ResizeTimeout", BindingAccess.Read | BindingAccess.Write);
                this.StartTaskProperty = this.CreatePropertyAccessor<StartTask>("StartTask", BindingAccess.Read | BindingAccess.Write);
                this.TargetDedicatedProperty = this.CreatePropertyAccessor<int?>("TargetDedicated", BindingAccess.Read | BindingAccess.Write);
                this.TaskSchedulingPolicyProperty = this.CreatePropertyAccessor<TaskSchedulingPolicy>("TaskSchedulingPolicy", BindingAccess.Read | BindingAccess.Write);
                this.UserAccountsProperty = this.CreatePropertyAccessor<IList<UserAccount>>("UserAccounts", BindingAccess.Read | BindingAccess.Write);
                this.VirtualMachineConfigurationProperty = this.CreatePropertyAccessor<VirtualMachineConfiguration>("VirtualMachineConfiguration", BindingAccess.Read | BindingAccess.Write);
                this.VirtualMachineSizeProperty = this.CreatePropertyAccessor<string>("VirtualMachineSize", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.PoolSpecification protocolObject) : base(BindingState.Bound)
            {
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor(
                    ApplicationPackageReference.ConvertFromProtocolCollection(protocolObject.ApplicationPackageReferences),
                    "ApplicationPackageReferences",
                    BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEnabledProperty = this.CreatePropertyAccessor(
                    protocolObject.EnableAutoScale,
                    "AutoScaleEnabled",
                    BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleEvaluationIntervalProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoScaleEvaluationInterval,
                    "AutoScaleEvaluationInterval",
                    BindingAccess.Read | BindingAccess.Write);
                this.AutoScaleFormulaProperty = this.CreatePropertyAccessor(
                    protocolObject.AutoScaleFormula,
                    "AutoScaleFormula",
                    BindingAccess.Read | BindingAccess.Write);
                this.CertificateReferencesProperty = this.CreatePropertyAccessor(
                    CertificateReference.ConvertFromProtocolCollection(protocolObject.CertificateReferences),
                    "CertificateReferences",
                    BindingAccess.Read | BindingAccess.Write);
                this.CloudServiceConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.CloudServiceConfiguration, o => new CloudServiceConfiguration(o)),
                    "CloudServiceConfiguration",
                    BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    "DisplayName",
                    BindingAccess.Read | BindingAccess.Write);
                this.InterComputeNodeCommunicationEnabledProperty = this.CreatePropertyAccessor(
                    protocolObject.EnableInterNodeCommunication,
                    "InterComputeNodeCommunicationEnabled",
                    BindingAccess.Read);
                this.MaxTasksPerComputeNodeProperty = this.CreatePropertyAccessor(
                    protocolObject.MaxTasksPerNode,
                    "MaxTasksPerComputeNode",
                    BindingAccess.Read | BindingAccess.Write);
                this.MetadataProperty = this.CreatePropertyAccessor(
                    MetadataItem.ConvertFromProtocolCollection(protocolObject.Metadata),
                    "Metadata",
                    BindingAccess.Read | BindingAccess.Write);
                this.NetworkConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NetworkConfiguration, o => new NetworkConfiguration(o).Freeze()),
                    "NetworkConfiguration",
                    BindingAccess.Read);
                this.ResizeTimeoutProperty = this.CreatePropertyAccessor(
                    protocolObject.ResizeTimeout,
                    "ResizeTimeout",
                    BindingAccess.Read | BindingAccess.Write);
                this.StartTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.StartTask, o => new StartTask(o)),
                    "StartTask",
                    BindingAccess.Read | BindingAccess.Write);
                this.TargetDedicatedProperty = this.CreatePropertyAccessor(
                    protocolObject.TargetDedicated,
                    "TargetDedicated",
                    BindingAccess.Read | BindingAccess.Write);
                this.TaskSchedulingPolicyProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.TaskSchedulingPolicy, o => new TaskSchedulingPolicy(o)),
                    "TaskSchedulingPolicy",
                    BindingAccess.Read | BindingAccess.Write);
                this.UserAccountsProperty = this.CreatePropertyAccessor(
                    UserAccount.ConvertFromProtocolCollectionAndFreeze(protocolObject.UserAccounts),
                    "UserAccounts",
                    BindingAccess.Read);
                this.VirtualMachineConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.VirtualMachineConfiguration, o => new VirtualMachineConfiguration(o)),
                    "VirtualMachineConfiguration",
                    BindingAccess.Read | BindingAccess.Write);
                this.VirtualMachineSizeProperty = this.CreatePropertyAccessor(
                    protocolObject.VmSize,
                    "VirtualMachineSize",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolSpecification"/> class.
        /// </summary>
        public PoolSpecification()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal PoolSpecification(Models.PoolSpecification protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region PoolSpecification

        /// <summary>
        /// Gets or sets a list of application package references to be installed on each compute node in the pool.
        /// </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences
        {
            get { return this.propertyContainer.ApplicationPackageReferencesProperty.Value; }
            set
            {
                this.propertyContainer.ApplicationPackageReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<ApplicationPackageReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust over time.
        /// </summary>
        /// <remarks>
        /// <para>If false, the <see cref="TargetDedicated"/> property is required.</para> <para>If true, the <see cref="AutoScaleFormula"/> 
        /// property is required. The pool automatically resizes according to the formula.</para> <para>The default value 
        /// is false.</para>
        /// </remarks>
        public bool? AutoScaleEnabled
        {
            get { return this.propertyContainer.AutoScaleEnabledProperty.Value; }
            set { this.propertyContainer.AutoScaleEnabledProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a time interval at which to automatically adjust the pool size according to the <see cref="AutoScaleFormula"/>.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum allowed value is 5 minutes.
        /// </remarks>
        public TimeSpan? AutoScaleEvaluationInterval
        {
            get { return this.propertyContainer.AutoScaleEvaluationIntervalProperty.Value; }
            set { this.propertyContainer.AutoScaleEvaluationIntervalProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a formula for the desired number of compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// <para>For how to write autoscale formulas, see https://azure.microsoft.com/documentation/articles/batch-automatic-scaling/. 
        /// This property is required if <see cref="AutoScaleEnabled"/> is set to true. It must be null if AutoScaleEnabled 
        /// is false.</para><para>The formula is checked for validity before the pool is created. If the formula is not valid, 
        /// an exception is thrown when you try to commit the <see cref="PoolSpecification"/>.</para>
        /// </remarks>
        public string AutoScaleFormula
        {
            get { return this.propertyContainer.AutoScaleFormulaProperty.Value; }
            set { this.propertyContainer.AutoScaleFormulaProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each compute node in the pool.
        /// </summary>
        public IList<CertificateReference> CertificateReferences
        {
            get { return this.propertyContainer.CertificateReferencesProperty.Value; }
            set
            {
                this.propertyContainer.CertificateReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<CertificateReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="CloudServiceConfiguration"/> for the pool.
        /// </summary>
        /// <remarks>
        /// This property is mutually exclusive with <see cref="VirtualMachineConfiguration"/>.
        /// </remarks>
        public CloudServiceConfiguration CloudServiceConfiguration
        {
            get { return this.propertyContainer.CloudServiceConfigurationProperty.Value; }
            set { this.propertyContainer.CloudServiceConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the display name for the pool.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between its compute nodes.
        /// </summary>
        /// <remarks>
        /// Enabling inter-node communication limits the maximum size of the pool due to deployment restrictions on the nodes 
        /// of the pool. This may result in the pool not reaching its desired size.
        /// </remarks>
        public bool? InterComputeNodeCommunicationEnabled
        {
            get { return this.propertyContainer.InterComputeNodeCommunicationEnabledProperty.Value; }
            set { this.propertyContainer.InterComputeNodeCommunicationEnabledProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently on a single compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 1. The maximum value of this setting depends on the size of the compute nodes in the pool 
        /// (the <see cref="VirtualMachineSize"/> property).
        /// </remarks>
        public int? MaxTasksPerComputeNode
        {
            get { return this.propertyContainer.MaxTasksPerComputeNodeProperty.Value; }
            set { this.propertyContainer.MaxTasksPerComputeNodeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool as metadata.
        /// </summary>
        public IList<MetadataItem> Metadata
        {
            get { return this.propertyContainer.MetadataProperty.Value; }
            set
            {
                this.propertyContainer.MetadataProperty.Value = ConcurrentChangeTrackedModifiableList<MetadataItem>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the network configuration of the pool.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this.propertyContainer.NetworkConfigurationProperty.Value; }
            set { this.propertyContainer.NetworkConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the pool.
        /// </summary>
        /// <remarks>
        /// <para>This timeout applies only to manual scaling; it has no effect when <see cref="AutoScaleEnabled"/> is set 
        /// to true.</para><para>The default value is 15 minutes. The minimum value is 5 minutes.</para>
        /// </remarks>
        public TimeSpan? ResizeTimeout
        {
            get { return this.propertyContainer.ResizeTimeoutProperty.Value; }
            set { this.propertyContainer.ResizeTimeoutProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the pool. The task runs when the node is added to 
        /// the pool or when the node is restarted.
        /// </summary>
        public StartTask StartTask
        {
            get { return this.propertyContainer.StartTaskProperty.Value; }
            set { this.propertyContainer.StartTaskProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// This setting cannot be specified if <see cref="AutoScaleEnabled"/> is set to true. It is required if AutoScaleEnabled 
        /// is set to false.
        /// </remarks>
        public int? TargetDedicated
        {
            get { return this.propertyContainer.TargetDedicatedProperty.Value; }
            set { this.propertyContainer.TargetDedicatedProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets how tasks are distributed among compute nodes in the pool.
        /// </summary>
        public TaskSchedulingPolicy TaskSchedulingPolicy
        {
            get { return this.propertyContainer.TaskSchedulingPolicyProperty.Value; }
            set { this.propertyContainer.TaskSchedulingPolicyProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the list of user accounts to be created on each node in the pool.
        /// </summary>
        public IList<UserAccount> UserAccounts
        {
            get { return this.propertyContainer.UserAccountsProperty.Value; }
            set
            {
                this.propertyContainer.UserAccountsProperty.Value = ConcurrentChangeTrackedModifiableList<UserAccount>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="VirtualMachineConfiguration"/> of the pool.
        /// </summary>
        /// <remarks>
        /// This property is mutually exclusive with <see cref="CloudServiceConfiguration"/>.
        /// </remarks>
        public VirtualMachineConfiguration VirtualMachineConfiguration
        {
            get { return this.propertyContainer.VirtualMachineConfigurationProperty.Value; }
            set { this.propertyContainer.VirtualMachineConfigurationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the size of the virtual machines in the pool.  All virtual machines in a pool are the same size.
        /// </summary>
        /// <remarks>
        /// <para>For information about available sizes of virtual machines for Cloud Services pools (pools created with 
        /// a <see cref="CloudServiceConfiguration"/>), see https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/. 
        /// Batch supports all Cloud Services VM sizes except ExtraSmall.</para><para>For information about available VM 
        /// sizes for pools using images from the Virtual Machines Marketplace (pools created with a <see cref="VirtualMachineConfiguration"/>) 
        /// see https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/ or https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/. 
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (for example STANDARD_GS, 
        /// STANDARD_DS, and STANDARD_DSV2 series).</para>
        /// </remarks>
        public string VirtualMachineSize
        {
            get { return this.propertyContainer.VirtualMachineSizeProperty.Value; }
            set { this.propertyContainer.VirtualMachineSizeProperty.Value = value; }
        }

        #endregion // PoolSpecification

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.PoolSpecification ITransportObjectProvider<Models.PoolSpecification>.GetTransportObject()
        {
            Models.PoolSpecification result = new Models.PoolSpecification()
            {
                ApplicationPackageReferences = UtilitiesInternal.ConvertToProtocolCollection(this.ApplicationPackageReferences),
                EnableAutoScale = this.AutoScaleEnabled,
                AutoScaleEvaluationInterval = this.AutoScaleEvaluationInterval,
                AutoScaleFormula = this.AutoScaleFormula,
                CertificateReferences = UtilitiesInternal.ConvertToProtocolCollection(this.CertificateReferences),
                CloudServiceConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.CloudServiceConfiguration, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                EnableInterNodeCommunication = this.InterComputeNodeCommunicationEnabled,
                MaxTasksPerNode = this.MaxTasksPerComputeNode,
                Metadata = UtilitiesInternal.ConvertToProtocolCollection(this.Metadata),
                NetworkConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.NetworkConfiguration, (o) => o.GetTransportObject()),
                ResizeTimeout = this.ResizeTimeout,
                StartTask = UtilitiesInternal.CreateObjectWithNullCheck(this.StartTask, (o) => o.GetTransportObject()),
                TargetDedicated = this.TargetDedicated,
                TaskSchedulingPolicy = UtilitiesInternal.CreateObjectWithNullCheck(this.TaskSchedulingPolicy, (o) => o.GetTransportObject()),
                UserAccounts = UtilitiesInternal.ConvertToProtocolCollection(this.UserAccounts),
                VirtualMachineConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.VirtualMachineConfiguration, (o) => o.GetTransportObject()),
                VmSize = this.VirtualMachineSize,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}