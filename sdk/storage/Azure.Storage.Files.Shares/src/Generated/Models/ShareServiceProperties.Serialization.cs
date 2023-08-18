// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareServiceProperties : Core.IXmlSerializable
    {
        void Core.IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceProperties");
            if (Core.Optional.IsDefined(HourMetrics))
            {
                writer.WriteObjectValue(HourMetrics, "HourMetrics");
            }
            if (Core.Optional.IsDefined(MinuteMetrics))
            {
                writer.WriteObjectValue(MinuteMetrics, "MinuteMetrics");
            }
            if (Core.Optional.IsDefined(Protocol))
            {
                writer.WriteObjectValue(Protocol, "ProtocolSettings");
            }
            if (Core.Optional.IsCollectionDefined(Cors))
            {
                writer.WriteStartElement("Cors");
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item, "CorsRule");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static ShareServiceProperties DeserializeShareServiceProperties(XElement element)
        {
            ShareMetrics hourMetrics = default;
            ShareMetrics minuteMetrics = default;
            ShareProtocolSettings protocol = default;
            IList<ShareCorsRule> cors = default;
            if (element.Element("HourMetrics") is XElement hourMetricsElement)
            {
                hourMetrics = ShareMetrics.DeserializeShareMetrics(hourMetricsElement);
            }
            if (element.Element("MinuteMetrics") is XElement minuteMetricsElement)
            {
                minuteMetrics = ShareMetrics.DeserializeShareMetrics(minuteMetricsElement);
            }
            if (element.Element("ProtocolSettings") is XElement protocolSettingsElement)
            {
                protocol = ShareProtocolSettings.DeserializeShareProtocolSettings(protocolSettingsElement);
            }
            if (element.Element("Cors") is XElement corsElement)
            {
                var array = new List<ShareCorsRule>();
                foreach (var e in corsElement.Elements("CorsRule"))
                {
                    array.Add(ShareCorsRule.DeserializeShareCorsRule(e));
                }
                cors = array;
            }
            return new ShareServiceProperties(hourMetrics, minuteMetrics, cors, protocol);
        }
    }
}
