﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Base type for results of Text Analytics Actions executed in a set of documents.
    /// </summary>
    public class TextAnalyticsActionResult
    {
        internal TextAnalyticsActionResult (DateTimeOffset completedOn, string actionName, TextAnalyticsErrorInternal error)
        {
            CompletedOn = completedOn;
            ActionName = actionName;
            Error = error != null ? Transforms.ConvertToError(error) : default;
        }

        internal TextAnalyticsActionResult(DateTimeOffset completedOn, string actionName)
        {
            CompletedOn = completedOn;
            ActionName = actionName;
        }

        /// <summary>
        /// Indicates the time at which the action was last updated on.
        /// </summary>
        public DateTimeOffset CompletedOn { get; }

        /// <summary>
        /// Determines the TextAnalyticsError object for an action result.
        /// </summary>
        public TextAnalyticsError Error { get; }

        /// <summary>
        /// Indicates that the document was not successfully processed and an error was returned for this document.
        /// </summary>
        public bool HasError => Error.ErrorCode != default;

        /// <summary>
        /// Gets the name for this action.
        /// </summary>
        public string ActionName { get; }
    }
}
