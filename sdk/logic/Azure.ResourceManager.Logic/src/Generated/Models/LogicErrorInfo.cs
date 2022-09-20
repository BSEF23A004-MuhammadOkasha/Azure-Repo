// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The error info. </summary>
    public partial class LogicErrorInfo
    {
        /// <summary> Initializes a new instance of LogicErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal LogicErrorInfo(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            Code = code;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
    }
}
