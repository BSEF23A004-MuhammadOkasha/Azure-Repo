﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FormField<T>
    {
        /// <summary>
        /// </summary>
        public string Label { get; internal set; }

        /// <summary>
        /// </summary>
        public FieldText Name { get; internal set; }

        /// <summary>
        /// </summary>
        public FieldText ValueText { get; internal set; }

        /// <summary>
        /// </summary>
        public T Value { get; internal set; }

        /// <summary>
        /// </summary>
        public float? Confidence { get; }

        /// <summary>
        /// </summary>
        public int? PageNumber { get; internal set; }
    }
}
