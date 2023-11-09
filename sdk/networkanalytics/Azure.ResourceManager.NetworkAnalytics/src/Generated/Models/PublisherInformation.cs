// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Details for Publisher Information. </summary>
    public partial class PublisherInformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PublisherInformation"/>. </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="dataProducts"> Data product information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> or <paramref name="dataProducts"/> is null. </exception>
        public PublisherInformation(string publisherName, IEnumerable<DataProductInformation> dataProducts)
        {
            Argument.AssertNotNull(publisherName, nameof(publisherName));
            Argument.AssertNotNull(dataProducts, nameof(dataProducts));

            PublisherName = publisherName;
            DataProducts = dataProducts.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PublisherInformation"/>. </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="dataProducts"> Data product information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublisherInformation(string publisherName, IList<DataProductInformation> dataProducts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublisherName = publisherName;
            DataProducts = dataProducts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PublisherInformation"/> for deserialization. </summary>
        internal PublisherInformation()
        {
        }

        /// <summary> Name of the publisher. </summary>
        public string PublisherName { get; set; }
        /// <summary> Data product information. </summary>
        public IList<DataProductInformation> DataProducts { get; }
    }
}
