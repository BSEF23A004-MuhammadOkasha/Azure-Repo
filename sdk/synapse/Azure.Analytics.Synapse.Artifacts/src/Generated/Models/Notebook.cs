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
        /// <param name="notebookFormat"> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </param>
        /// <param name="notebookFormatMinor"> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </param>
        /// <param name="cells"> Array of cells of the current notebook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="cells"/> is null. </exception>
        public Notebook(NotebookMetadata metadata, int notebookFormat, int notebookFormatMinor, IEnumerable<NotebookCell> cells)
        {
            Argument.AssertNotNull(metadata, nameof(metadata));
            Argument.AssertNotNull(cells, nameof(cells));

            Metadata = metadata;
            NotebookFormat = notebookFormat;
            NotebookFormatMinor = notebookFormatMinor;
            Cells = cells.ToList();
            AdditionalProperties = new Core.ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Notebook. </summary>
        /// <param name="description"> The description of the notebook. </param>
        /// <param name="bigDataPool"> Big data pool reference. </param>
        /// <param name="targetSparkConfiguration"> The spark configuration of the spark job. </param>
        /// <param name="sessionProperties"> Session properties. </param>
        /// <param name="metadata"> Notebook root-level metadata. </param>
        /// <param name="notebookFormat"> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </param>
        /// <param name="notebookFormatMinor"> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </param>
        /// <param name="cells"> Array of cells of the current notebook. </param>
        /// <param name="folder"> The folder that this notebook is in. If not specified, this notebook will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal Notebook(string description, BigDataPoolReference bigDataPool, SparkConfigurationReference targetSparkConfiguration, NotebookSessionProperties sessionProperties, NotebookMetadata metadata, int notebookFormat, int notebookFormatMinor, IList<NotebookCell> cells, NotebookFolder folder, IDictionary<string, object> additionalProperties)
        {
            Description = description;
            BigDataPool = bigDataPool;
            TargetSparkConfiguration = targetSparkConfiguration;
            SessionProperties = sessionProperties;
            Metadata = metadata;
            NotebookFormat = notebookFormat;
            NotebookFormatMinor = notebookFormatMinor;
            Cells = cells;
            Folder = folder;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the notebook. </summary>
        public string Description { get; set; }
        /// <summary> Big data pool reference. </summary>
        public BigDataPoolReference BigDataPool { get; set; }
        /// <summary> The spark configuration of the spark job. </summary>
        public SparkConfigurationReference TargetSparkConfiguration { get; set; }
        /// <summary> Session properties. </summary>
        public NotebookSessionProperties SessionProperties { get; set; }
        /// <summary> Notebook root-level metadata. </summary>
        public NotebookMetadata Metadata { get; set; }
        /// <summary> Notebook format (major number). Incremented between backwards incompatible changes to the notebook format. </summary>
        public int NotebookFormat { get; set; }
        /// <summary> Notebook format (minor number). Incremented for backward compatible changes to the notebook format. </summary>
        public int NotebookFormatMinor { get; set; }
        /// <summary> Array of cells of the current notebook. </summary>
        public IList<NotebookCell> Cells { get; }
        /// <summary> The folder that this notebook is in. If not specified, this notebook will appear at the root level. </summary>
        public NotebookFolder Folder { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
