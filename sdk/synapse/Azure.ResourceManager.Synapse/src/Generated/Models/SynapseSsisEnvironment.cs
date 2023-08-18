// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Ssis environment. </summary>
    public partial class SynapseSsisEnvironment : SynapseSsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SynapseSsisEnvironment. </summary>
        internal SynapseSsisEnvironment()
        {
            Variables = new Core.ChangeTrackingList<SynapseSsisVariable>();
            MetadataType = SynapseSsisObjectMetadataType.Environment;
        }

        /// <summary> Initializes a new instance of SynapseSsisEnvironment. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="folderId"> Folder id which contains environment. </param>
        /// <param name="variables"> Variable in environment. </param>
        internal SynapseSsisEnvironment(SynapseSsisObjectMetadataType metadataType, long? id, string name, string description, long? folderId, IReadOnlyList<SynapseSsisVariable> variables) : base(metadataType, id, name, description)
        {
            FolderId = folderId;
            Variables = variables;
            MetadataType = metadataType;
        }

        /// <summary> Folder id which contains environment. </summary>
        public long? FolderId { get; }
        /// <summary> Variable in environment. </summary>
        public IReadOnlyList<SynapseSsisVariable> Variables { get; }
    }
}
