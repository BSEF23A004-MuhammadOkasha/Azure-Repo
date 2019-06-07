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
    /// Settings which specify how to run a multi-instance task. Multi-instance tasks are commonly used to support MPI tasks. 
    /// In the MPI case, if any of the subtasks fail (for example due to exiting with a non-zero exit code) the entire multi-instance 
    /// task fails. The multi-instance task is then terminated and retried, up to its retry limit. For more information see 
    /// https://azure.microsoft.com/documentation/articles/batch-mpi/.
    /// </summary>
    public partial class MultiInstanceSettings : ITransportObjectProvider<Models.MultiInstanceSettings>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<IList<ResourceFile>> CommonResourceFilesProperty;
            public readonly PropertyAccessor<string> CoordinationCommandLineProperty;
            public readonly PropertyAccessor<int?> NumberOfInstancesProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CommonResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>(nameof(CommonResourceFiles), BindingAccess.Read | BindingAccess.Write);
                this.CoordinationCommandLineProperty = this.CreatePropertyAccessor<string>(nameof(CoordinationCommandLine), BindingAccess.Read | BindingAccess.Write);
                this.NumberOfInstancesProperty = this.CreatePropertyAccessor<int?>(nameof(NumberOfInstances), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.MultiInstanceSettings protocolObject) : base(BindingState.Bound)
            {
                this.CommonResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollectionAndFreeze(protocolObject.CommonResourceFiles),
                    nameof(CommonResourceFiles),
                    BindingAccess.Read);
                this.CoordinationCommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CoordinationCommandLine,
                    nameof(CoordinationCommandLine),
                    BindingAccess.Read);
                this.NumberOfInstancesProperty = this.CreatePropertyAccessor(
                    protocolObject.NumberOfInstances,
                    nameof(NumberOfInstances),
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInstanceSettings"/> class.
        /// </summary>
        /// <param name='coordinationCommandLine'>The command to run on the compute node instances for coordinating among the subtasks.</param>
        /// <param name='numberOfInstances'>The number of compute nodes required by the multi-instance task.</param>
        public MultiInstanceSettings(
            string coordinationCommandLine,
            int? numberOfInstances = default(int?))
        {
            this.propertyContainer = new PropertyContainer();
            this.CoordinationCommandLine = coordinationCommandLine;
            this.NumberOfInstances = numberOfInstances;
        }

        internal MultiInstanceSettings(Models.MultiInstanceSettings protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region MultiInstanceSettings

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download before running the coordination command line.
        /// </summary>
        /// <remarks>
        /// The difference between common resource files and task resource files is that common resource files are downloaded 
        /// for all subtasks including the primary, whereas task resource files are downloaded only for the primary. There 
        /// is a maximum size for the list of resource files. When the max size is exceeded, the request will fail and the 
        /// response error code will be RequestEntityTooLarge. If this occurs, the collection of resource files must be reduced 
        /// in size. This can be achieved using .zip files, Application Packages, or Docker Containers.
        /// </remarks>
        public IList<ResourceFile> CommonResourceFiles
        {
            get { return this.propertyContainer.CommonResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.CommonResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the command to run on the compute node instances for coordinating among the subtasks.
        /// </summary>
        public string CoordinationCommandLine
        {
            get { return this.propertyContainer.CoordinationCommandLineProperty.Value; }
            set { this.propertyContainer.CoordinationCommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the number of compute nodes required by the multi-instance task.
        /// </summary>
        public int? NumberOfInstances
        {
            get { return this.propertyContainer.NumberOfInstancesProperty.Value; }
            set { this.propertyContainer.NumberOfInstancesProperty.Value = value; }
        }

        #endregion // MultiInstanceSettings

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
        Models.MultiInstanceSettings ITransportObjectProvider<Models.MultiInstanceSettings>.GetTransportObject()
        {
            Models.MultiInstanceSettings result = new Models.MultiInstanceSettings()
            {
                CommonResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.CommonResourceFiles),
                CoordinationCommandLine = this.CoordinationCommandLine,
                NumberOfInstances = this.NumberOfInstances,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}