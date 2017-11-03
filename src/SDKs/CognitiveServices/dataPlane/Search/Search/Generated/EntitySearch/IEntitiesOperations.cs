// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.EntitySearch
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// EntitiesOperations operations.
    /// </summary>
    public partial interface IEntitiesOperations
    {
        /// <summary>
        /// The Entity Search API lets you send a search query to Bing and get
        /// back search results that include entities and places. Place results
        /// include restaurants, hotel, or other local businesses. For places,
        /// the query can specify the name of the local business or it can ask
        /// for a list (for example, restaurants near me). Entity results
        /// include persons, places, or things. Place in this context is
        /// tourist attractions, states, countries, etc.
        /// </summary>
        /// <param name='query'>
        /// The user's search term.
        /// </param>
        /// <param name='acceptLanguage'>
        /// A comma-delimited list of one or more languages to use for user
        /// interface strings. The list is in decreasing order of preference.
        /// For additional information, including expected format, see
        /// [RFC2616](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
        /// This header and the setLang query parameter are mutually exclusive;
        /// do not specify both. If you set this header, you must also specify
        /// the cc query parameter. Bing will use the first supported language
        /// it finds from the list, and combine that language with the cc
        /// parameter value to determine the market to return results for. If
        /// the list does not include a supported language, Bing will find the
        /// closest language and market that supports the request, and may use
        /// an aggregated or default market for the results instead of a
        /// specified one. You should use this header and the cc query
        /// parameter only if you specify multiple languages; otherwise, you
        /// should use the mkt and setLang query parameters. A user interface
        /// string is a string that's used as a label in a user interface.
        /// There are very few user interface strings in the JSON response
        /// objects. Any links in the response objects to Bing.com properties
        /// will apply the specified language.
        /// </param>
        /// <param name='pragma'>
        /// By default, Bing returns cached content, if available. To prevent
        /// Bing from returning cached content, set the Pragma header to
        /// no-cache (for example, Pragma: no-cache).
        /// </param>
        /// <param name='userAgent'>
        /// The user agent originating the request. Bing uses the user agent to
        /// provide mobile users with an optimized experience. Although
        /// optional, you are strongly encouraged to always specify this
        /// header. The user-agent should be the same string that any commonly
        /// used browser would send. For information about user agents, see
        /// [RFC 2616](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
        /// </param>
        /// <param name='clientId'>
        /// Bing uses this header to provide users with consistent behavior
        /// across Bing API calls. Bing often flights new features and
        /// improvements, and it uses the client ID as a key for assigning
        /// traffic on different flights. If you do not use the same client ID
        /// for a user across multiple requests, then Bing may assign the user
        /// to multiple conflicting flights. Being assigned to multiple
        /// conflicting flights can lead to an inconsistent user experience.
        /// For example, if the second request has a different flight
        /// assignment than the first, the experience may be unexpected. Also,
        /// Bing can use the client ID to tailor web results to that client
        /// ID’s search history, providing a richer experience for the user.
        /// Bing also uses this header to help improve result rankings by
        /// analyzing the activity generated by a client ID. The relevance
        /// improvements help with better quality of results delivered by Bing
        /// APIs and in turn enables higher click-through rates for the API
        /// consumer. IMPORTANT: Although optional, you should consider this
        /// header required. Persisting the client ID across multiple requests
        /// for the same end user and device combination enables 1) the API
        /// consumer to receive a consistent user experience, and 2) higher
        /// click-through rates via better quality of results from the Bing
        /// APIs. Each user that uses your application on the device must have
        /// a unique, Bing generated client ID. If you do not include this
        /// header in the request, Bing generates an ID and returns it in the
        /// X-MSEdge-ClientID response header. The only time that you should
        /// NOT include this header in a request is the first time the user
        /// uses your app on that device. Use the client ID for each Bing API
        /// request that your app makes for this user on the device. Persist
        /// the client ID. To persist the ID in a browser app, use a persistent
        /// HTTP cookie to ensure the ID is used across all sessions. Do not
        /// use a session cookie. For other apps such as mobile apps, use the
        /// device's persistent storage to persist the ID. The next time the
        /// user uses your app on that device, get the client ID that you
        /// persisted. Bing responses may or may not include this header. If
        /// the response includes this header, capture the client ID and use it
        /// for all subsequent Bing requests for the user on that device. If
        /// you include the X-MSEdge-ClientID, you must not include cookies in
        /// the request.
        /// </param>
        /// <param name='clientIp'>
        /// The IPv4 or IPv6 address of the client device. The IP address is
        /// used to discover the user's location. Bing uses the location
        /// information to determine safe search behavior. Although optional,
        /// you are encouraged to always specify this header and the
        /// X-Search-Location header. Do not obfuscate the address (for
        /// example, by changing the last octet to 0). Obfuscating the address
        /// results in the location not being anywhere near the device's actual
        /// location, which may result in Bing serving erroneous results.
        /// </param>
        /// <param name='location'>
        /// A semicolon-delimited list of key/value pairs that describe the
        /// client's geographical location. Bing uses the location information
        /// to determine safe search behavior and to return relevant local
        /// content. Specify the key/value pair as &lt;key&gt;:&lt;value&gt;.
        /// The following are the keys that you use to specify the user's
        /// location. lat (required): The latitude of the client's location, in
        /// degrees. The latitude must be greater than or equal to -90.0 and
        /// less than or equal to +90.0. Negative values indicate southern
        /// latitudes and positive values indicate northern latitudes. long
        /// (required): The longitude of the client's location, in degrees. The
        /// longitude must be greater than or equal to -180.0 and less than or
        /// equal to +180.0. Negative values indicate western longitudes and
        /// positive values indicate eastern longitudes. re (required): The
        /// radius, in meters, which specifies the horizontal accuracy of the
        /// coordinates. Pass the value returned by the device's location
        /// service. Typical values might be 22m for GPS/Wi-Fi, 380m for cell
        /// tower triangulation, and 18,000m for reverse IP lookup. ts
        /// (optional): The UTC UNIX timestamp of when the client was at the
        /// location. (The UNIX timestamp is the number of seconds since
        /// January 1, 1970.) head (optional): The client's relative heading or
        /// direction of travel. Specify the direction of travel as degrees
        /// from 0 through 360, counting clockwise relative to true north.
        /// Specify this key only if the sp key is nonzero. sp (optional): The
        /// horizontal velocity (speed), in meters per second, that the client
        /// device is traveling. alt (optional): The altitude of the client
        /// device, in meters. are (optional): The radius, in meters, that
        /// specifies the vertical accuracy of the coordinates. Specify this
        /// key only if you specify the alt key. Although many of the keys are
        /// optional, the more information that you provide, the more accurate
        /// the location results are. Although optional, you are encouraged to
        /// always specify the user's geographical location. Providing the
        /// location is especially important if the client's IP address does
        /// not accurately reflect the user's physical location (for example,
        /// if the client uses VPN). For optimal results, you should include
        /// this header and the X-MSEdge-ClientIP header, but at a minimum, you
        /// should include this header.
        /// </param>
        /// <param name='countryCode'>
        /// A 2-character country code of the country where the results come
        /// from. This API supports only the United States market. If you
        /// specify this query parameter, it must be set to us. If you set this
        /// parameter, you must also specify the Accept-Language header. Bing
        /// uses the first supported language it finds from the languages list,
        /// and combine that language with the country code that you specify to
        /// determine the market to return results for. If the languages list
        /// does not include a supported language, Bing finds the closest
        /// language and market that supports the request, or it may use an
        /// aggregated or default market for the results instead of a specified
        /// one. You should use this query parameter and the Accept-Language
        /// query parameter only if you specify multiple languages; otherwise,
        /// you should use the mkt and setLang query parameters. This parameter
        /// and the mkt query parameter are mutually exclusive—do not specify
        /// both.
        /// </param>
        /// <param name='market'>
        /// The market where the results come from. You are strongly encouraged
        /// to always specify the market, if known. Specifying the market helps
        /// Bing route the request and return an appropriate and optimal
        /// response. This parameter and the cc query parameter are mutually
        /// exclusive—do not specify both.
        /// </param>
        /// <param name='responseFilter'>
        /// A comma-delimited list of answers to include in the response. If
        /// you do not specify this parameter, the response includes all search
        /// answers for which there's relevant data.
        /// </param>
        /// <param name='responseFormat'>
        /// The media type to use for the response. The following are the
        /// possible case-insensitive values: JSON, JSONLD. The default is
        /// JSON. If you specify JSONLD, the response body includes JSON-LD
        /// objects that contain the search results.
        /// </param>
        /// <param name='safeSearch'>
        /// A filter used to filter adult content. Off: Return webpages with
        /// adult text, images, or videos. Moderate: Return webpages with adult
        /// text, but not adult images or videos. Strict: Do not return
        /// webpages with adult text, images, or videos. The default is
        /// Moderate. If the request comes from a market that Bing's adult
        /// policy requires that safeSearch is set to Strict, Bing ignores the
        /// safeSearch value and uses Strict. If you use the site: query
        /// operator, there is the chance that the response may contain adult
        /// content regardless of what the safeSearch query parameter is set
        /// to. Use site: only if you are aware of the content on the site and
        /// your scenario supports the possibility of adult content. Possible
        /// values include: 'Off', 'Moderate', 'Strict'
        /// </param>
        /// <param name='setLang'>
        /// The language to use for user interface strings. Specify the
        /// language using the ISO 639-1 2-letter language code. For example,
        /// the language code for English is EN. The default is EN (English).
        /// Although optional, you should always specify the language.
        /// Typically, you set setLang to the same language specified by mkt
        /// unless the user wants the user interface strings displayed in a
        /// different language. This parameter and the Accept-Language header
        /// are mutually exclusive; do not specify both. A user interface
        /// string is a string that's used as a label in a user interface.
        /// There are few user interface strings in the JSON response objects.
        /// Also, any links to Bing.com properties in the response objects
        /// apply the specified language.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<SearchResponse>> SearchWithHttpMessagesAsync(string query, string acceptLanguage = default(string), string pragma = default(string), string userAgent = default(string), string clientId = default(string), string clientIp = default(string), string location = default(string), string countryCode = default(string), string market = default(string), IList<string> responseFilter = default(IList<string>), IList<string> responseFormat = default(IList<string>), string safeSearch = default(string), string setLang = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
