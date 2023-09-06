// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Information about the content filtering category, if it has been detected. </summary>
    public partial class ContentFilterResults
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of ContentFilterResults. </summary>
        internal ContentFilterResults()
        {
        }

        /// <summary> Initializes a new instance of ContentFilterResults. </summary>
        /// <param name="sexual">
        /// Describes language related to anatomical organs and genitals, romantic relationships,
        ///  acts portrayed in erotic or affectionate terms, physical sexual acts, including
        ///  those portrayed as an assault or a forced sexual violent act against one’s will,
        ///  prostitution, pornography, and abuse.
        /// </param>
        /// <param name="violence">
        /// Describes language related to physical actions intended to hurt, injure, damage, or
        /// kill someone or something; describes weapons, etc.
        /// </param>
        /// <param name="hate">
        /// Describes language attacks or uses that include pejorative or discriminatory language
        /// with reference to a person or identity group on the basis of certain differentiating
        /// attributes of these groups including but not limited to race, ethnicity, nationality,
        /// gender identity and expression, sexual orientation, religion, immigration status, ability
        /// status, personal appearance, and body size.
        /// </param>
        /// <param name="selfHarm">
        /// Describes language related to physical actions intended to purposely hurt, injure,
        /// or damage one’s body, or kill oneself.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterResults(ContentFilterResult sexual, ContentFilterResult violence, ContentFilterResult hate, ContentFilterResult selfHarm, Dictionary<string, BinaryData> rawData)
        {
            Sexual = sexual;
            Violence = violence;
            Hate = hate;
            SelfHarm = selfHarm;
            _rawData = rawData;
        }

        /// <summary>
        /// Describes language related to anatomical organs and genitals, romantic relationships,
        ///  acts portrayed in erotic or affectionate terms, physical sexual acts, including
        ///  those portrayed as an assault or a forced sexual violent act against one’s will,
        ///  prostitution, pornography, and abuse.
        /// </summary>
        public ContentFilterResult Sexual { get; }
        /// <summary>
        /// Describes language related to physical actions intended to hurt, injure, damage, or
        /// kill someone or something; describes weapons, etc.
        /// </summary>
        public ContentFilterResult Violence { get; }
        /// <summary>
        /// Describes language attacks or uses that include pejorative or discriminatory language
        /// with reference to a person or identity group on the basis of certain differentiating
        /// attributes of these groups including but not limited to race, ethnicity, nationality,
        /// gender identity and expression, sexual orientation, religion, immigration status, ability
        /// status, personal appearance, and body size.
        /// </summary>
        public ContentFilterResult Hate { get; }
        /// <summary>
        /// Describes language related to physical actions intended to purposely hurt, injure,
        /// or damage one’s body, or kill oneself.
        /// </summary>
        public ContentFilterResult SelfHarm { get; }
    }
}
