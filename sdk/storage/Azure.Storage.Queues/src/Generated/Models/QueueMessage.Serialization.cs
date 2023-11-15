// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueMessage : IXmlSerializable, IPersistableModel<QueueMessage>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "QueueMessage");
            writer.WriteStartElement("MessageText");
            writer.WriteValue(MessageText);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static QueueMessage DeserializeQueueMessage(XElement element, ModelReaderWriterOptions options = null)
        {
            string messageText = default;
            if (element.Element("MessageText") is XElement messageTextElement)
            {
                messageText = (string)messageTextElement;
            }
            return new QueueMessage(messageText, default);
        }

        BinaryData IPersistableModel<QueueMessage>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<QueueMessage>;
            bool isValid = options.Format == "J" && implementsJson || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            ((IXmlSerializable)this).Write(writer, null);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        QueueMessage IPersistableModel<QueueMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueMessage)} does not support '{options.Format}' format.");
            }

            return DeserializeQueueMessage(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<QueueMessage>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
