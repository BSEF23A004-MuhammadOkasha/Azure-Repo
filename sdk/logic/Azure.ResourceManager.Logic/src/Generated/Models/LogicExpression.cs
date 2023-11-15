// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The expression. </summary>
    public partial class LogicExpression
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogicExpression"/>. </summary>
        internal LogicExpression()
        {
            Subexpressions = new ChangeTrackingList<LogicExpression>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicExpression"/>. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="value"> Anything. </param>
        /// <param name="subexpressions"> The sub expressions. </param>
        /// <param name="error"> The azure resource error info. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicExpression(string text, BinaryData value, IReadOnlyList<LogicExpression> subexpressions, LogicExpressionErrorInfo error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Value = value;
            Subexpressions = subexpressions;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The text. </summary>
        public string Text { get; }
        /// <summary>
        /// Anything
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Value { get; }
        /// <summary> The sub expressions. </summary>
        public IReadOnlyList<LogicExpression> Subexpressions { get; }
        /// <summary> The azure resource error info. </summary>
        public LogicExpressionErrorInfo Error { get; }
    }
}
