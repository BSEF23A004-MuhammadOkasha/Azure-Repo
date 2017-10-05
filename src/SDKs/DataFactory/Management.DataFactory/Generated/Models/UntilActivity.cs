// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This activity executes inner activities until the specified boolean
    /// expression results to true or timeout is reached, whichever is earlier.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Until")]
    [Rest.Serialization.JsonTransformation]
    public partial class UntilActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the UntilActivity class.
        /// </summary>
        public UntilActivity()
        {
            Expression = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UntilActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="expression">An expression that would evaluate to
        /// Boolean. The loop will continue until this expression evaluates to
        /// true</param>
        /// <param name="activities">List of activities to execute.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="timeout">Specifies the timeout for the activity to
        /// run. If there is no value specified, it takes the value of
        /// TimeSpan.FromDays(7) which is 1 week as default. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        public UntilActivity(string name, Expression expression, IList<Activity> activities, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), object timeout = default(object))
            : base(name, description, dependsOn)
        {
            Expression = new Expression();
            Expression = expression;
            Timeout = timeout;
            Activities = activities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an expression that would evaluate to Boolean. The loop
        /// will continue until this expression evaluates to true
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.expression")]
        public Expression Expression { get; set; }

        /// <summary>
        /// Gets or sets specifies the timeout for the activity to run. If
        /// there is no value specified, it takes the value of
        /// TimeSpan.FromDays(7) which is 1 week as default. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public object Timeout { get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.activities")]
        public IList<Activity> Activities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Expression == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Expression");
            }
            if (Activities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Activities");
            }
            if (Expression != null)
            {
                Expression.Validate();
            }
            if (Activities != null)
            {
                foreach (var element in Activities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
