// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted table contained in a page. </summary>
    internal partial class DataTable_internal
    {
        /// <summary> Number of rows. </summary>
        public int Rows { get; set; }
        /// <summary> Number of columns. </summary>
        public int Columns { get; set; }
        /// <summary> List of cells contained in the table. </summary>
        public ICollection<DataTableCell_internal> Cells { get; set; } = new System.Collections.Generic.List<Azure.AI.FormRecognizer.Models.DataTableCell_internal>();
    }
}
