// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> An instance of Remote Dependency represents an interaction of the monitored component with a remote component/service like SQL or an HTTP endpoint. </summary>
    public partial class RemoteDependencyData : Domain
    {
        /// <summary> Initializes a new instance of RemoteDependencyData. </summary>
        /// <param name="ver"> Schema version. </param>
        /// <param name="name"> Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RemoteDependencyData(int ver, string name, TimeSpan duration)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Ver = ver;
            Name = name;
            Duration = duration;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of RemoteDependencyData. </summary>
        /// <param name="test"> Ignored value. </param>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a dependency call instance. Used for correlation with the request telemetry item corresponding to this dependency call. </param>
        /// <param name="name"> Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template. </param>
        /// <param name="resultCode"> Result code of a dependency call. Examples are SQL error code and HTTP status code. </param>
        /// <param name="data"> Command initiated by this dependency call. Examples are SQL statement and HTTP URL&apos;s with all query parameters. </param>
        /// <param name="type"> Dependency type name. Very low cardinality value for logical grouping of dependencies and interpretation of other fields like commandName and resultCode. Examples are SQL, Azure table, and HTTP. </param>
        /// <param name="target"> Target site of a dependency call. Examples are server name, host address. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Indication of successfull or unsuccessfull call. </param>
        /// <param name="properties"> Collection of custom properties. TODO: max key length validate. </param>
        /// <param name="measurements"> Collection of custom measurements. TODO: max key length validate. </param>
        internal RemoteDependencyData(string test, int ver, string id, string name, string resultCode, string data, string type, string target, TimeSpan duration, bool? success, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(test)
        {
            Ver = ver;
            Id = id;
            Name = name;
            ResultCode = resultCode;
            Data = data;
            Type = type;
            Target = target;
            Duration = duration;
            Success = success;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Schema version. </summary>
        public int Ver { get; set; }
        /// <summary> Identifier of a dependency call instance. Used for correlation with the request telemetry item corresponding to this dependency call. </summary>
        public string Id { get; set; }
        /// <summary> Name of the command initiated with this dependency call. Low cardinality value. Examples are stored procedure name and URL path template. </summary>
        public string Name { get; set; }
        /// <summary> Result code of a dependency call. Examples are SQL error code and HTTP status code. </summary>
        public string ResultCode { get; set; }
        /// <summary> Command initiated by this dependency call. Examples are SQL statement and HTTP URL&apos;s with all query parameters. </summary>
        public string Data { get; set; }
        /// <summary> Dependency type name. Very low cardinality value for logical grouping of dependencies and interpretation of other fields like commandName and resultCode. Examples are SQL, Azure table, and HTTP. </summary>
        public string Type { get; set; }
        /// <summary> Target site of a dependency call. Examples are server name, host address. </summary>
        public string Target { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </summary>
        public TimeSpan Duration { get; set; }
        /// <summary> Indication of successfull or unsuccessfull call. </summary>
        public bool? Success { get; set; }
        /// <summary> Collection of custom properties. TODO: max key length validate. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Collection of custom measurements. TODO: max key length validate. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
