// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The LinkedEntity. </summary>
    internal partial class LinkedEntity
    {
        /// <summary> Initializes a new instance of <see cref="LinkedEntity"/>. </summary>
        /// <param name="name"> Entity Linking formal name. </param>
        /// <param name="matches"> List of instances this entity appears in the text. </param>
        /// <param name="language"> Language used in the data source. </param>
        /// <param name="url"> URL for the entity's page from the data source. </param>
        /// <param name="dataSource"> Data source used to extract entity linking, such as Wiki/Bing etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="matches"/>, <paramref name="language"/>, <paramref name="url"/> or <paramref name="dataSource"/> is null. </exception>
        internal LinkedEntity(string name, IEnumerable<Match> matches, string language, string url, string dataSource)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (matches == null)
            {
                throw new ArgumentNullException(nameof(matches));
            }
            if (language == null)
            {
                throw new ArgumentNullException(nameof(language));
            }
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }

            Name = name;
            Matches = matches.ToList();
            Language = language;
            Url = url;
            DataSource = dataSource;
        }

        /// <summary> Initializes a new instance of <see cref="LinkedEntity"/>. </summary>
        /// <param name="name"> Entity Linking formal name. </param>
        /// <param name="matches"> List of instances this entity appears in the text. </param>
        /// <param name="language"> Language used in the data source. </param>
        /// <param name="id"> Unique identifier of the recognized entity from the data source. </param>
        /// <param name="url"> URL for the entity's page from the data source. </param>
        /// <param name="dataSource"> Data source used to extract entity linking, such as Wiki/Bing etc. </param>
        /// <param name="bingId"> Bing Entity Search API unique identifier of the recognized entity. </param>
        internal LinkedEntity(string name, IReadOnlyList<Match> matches, string language, string id, string url, string dataSource, string bingId)
        {
            Name = name;
            Matches = matches;
            Language = language;
            Id = id;
            Url = url;
            DataSource = dataSource;
            BingId = bingId;
        }

        /// <summary> Entity Linking formal name. </summary>
        public string Name { get; }
        /// <summary> List of instances this entity appears in the text. </summary>
        public IReadOnlyList<Match> Matches { get; }
        /// <summary> Language used in the data source. </summary>
        public string Language { get; }
        /// <summary> Unique identifier of the recognized entity from the data source. </summary>
        public string Id { get; }
        /// <summary> URL for the entity's page from the data source. </summary>
        public string Url { get; }
        /// <summary> Data source used to extract entity linking, such as Wiki/Bing etc. </summary>
        public string DataSource { get; }
        /// <summary> Bing Entity Search API unique identifier of the recognized entity. </summary>
        public string BingId { get; }
    }
}
