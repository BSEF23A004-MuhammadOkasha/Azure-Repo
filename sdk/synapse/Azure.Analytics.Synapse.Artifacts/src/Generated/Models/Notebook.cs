// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Notebook. </summary>
    public partial class Notebook
    {
        /// <summary> Initializes a new instance of Notebook. </summary>
        /// <param name="metadata"> Notebook root-level metadata. </param>
        /// <param name="nbformat"> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </param>
        /// <param name="nbformatMinor"> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </param>
        /// <param name="cells"> Array of cells of the current notebook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="cells"/> is null. </exception>
        public Notebook(NotebookMetadata metadata, int nbformat, int nbformatMinor, IEnumerable<NotebookCell> cells)
        {
            if (metadata == null)
            {
                throw new ArgumentNullException(nameof(metadata));
            }
            if (cells == null)
            {
                throw new ArgumentNullException(nameof(cells));
            }

            Metadata = metadata;
            Nbformat = nbformat;
            NbformatMinor = nbformatMinor;
            Cells = cells.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Notebook. </summary>
        /// <param name="description"> The description of the notebook. </param>
        /// <param name="bigDataPool"> Big data pool reference. </param>
        /// <param name="sessionProperties"> Session properties. </param>
        /// <param name="metadata"> Notebook root-level metadata. </param>
        /// <param name="nbformat"> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </param>
        /// <param name="nbformatMinor"> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </param>
        /// <param name="cells"> Array of cells of the current notebook. </param>
        /// <param name="folder"> The folder that this notebook is in. If not specified, this notebook will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal Notebook(string description, BigDataPoolReference bigDataPool, NotebookSessionProperties sessionProperties, NotebookMetadata metadata, int nbformat, int nbformatMinor, IList<NotebookCell> cells, NotebookFolder folder, IDictionary<string, object> additionalProperties)
        {
            Description = description;
            BigDataPool = bigDataPool;
            SessionProperties = sessionProperties;
            Metadata = metadata;
            Nbformat = nbformat;
            NbformatMinor = nbformatMinor;
            Cells = cells;
            Folder = folder;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the notebook. </summary>
        public string Description { get; set; }
        /// <summary> Big data pool reference. </summary>
        public BigDataPoolReference BigDataPool { get; set; }
        /// <summary> Session properties. </summary>
        public NotebookSessionProperties SessionProperties { get; set; }
        /// <summary> Notebook root-level metadata. </summary>
        public NotebookMetadata Metadata { get; set; }
        /// <summary> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </summary>
        public int Nbformat { get; set; }
        /// <summary> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </summary>
        public int NbformatMinor { get; set; }
        /// <summary> Array of cells of the current notebook. </summary>
        public IList<NotebookCell> Cells { get; }
        /// <summary> The folder that this notebook is in. If not specified, this notebook will appear at the root level. </summary>
        public NotebookFolder Folder { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
