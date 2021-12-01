// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class SearchModelFactory
    {
        /// <summary> Initializes a new instance of PolygonResult. </summary>
        /// <param name="polygons"> Results array. </param>
        /// <returns> A new <see cref="Models.PolygonResult"/> instance for mocking. </returns>
        public static PolygonResult PolygonResult(IEnumerable<Polygon> polygons = null)
        {
            polygons ??= new List<Polygon>();

            return new PolygonResult(polygons?.ToList());
        }

        /// <summary> Initializes a new instance of Polygon. </summary>
        /// <param name="providerID"> ID of the returned entity. </param>
        /// <param name="geometryData"> Geometry data in GeoJSON format. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946) for details. Present only if &quot;error&quot; is not present. </param>
        /// <returns> A new <see cref="Models.Polygon"/> instance for mocking. </returns>
        public static Polygon Polygon(string providerID = null, GeoJsonFeatureCollection geometryData = null)
        {
            return new Polygon(providerID, geometryData);
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.ErrorResponse"/> instance for mocking. </returns>
        public static ErrorResponse ErrorResponse(ErrorDetail error = null)
        {
            return new ErrorResponse(error);
        }

        /// <summary> Initializes a new instance of ErrorDetail. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The error additional info. </param>
        /// <returns> A new <see cref="Models.ErrorDetail"/> instance for mocking. </returns>
        public static ErrorDetail ErrorDetail(string code = null, string message = null, string target = null, IEnumerable<ErrorDetail> details = null, IEnumerable<ErrorAdditionalInfo> additionalInfo = null)
        {
            details ??= new List<ErrorDetail>();
            additionalInfo ??= new List<ErrorAdditionalInfo>();

            return new ErrorDetail(code, message, target, details?.ToList(), additionalInfo?.ToList());
        }

        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        /// <returns> A new <see cref="Models.ErrorAdditionalInfo"/> instance for mocking. </returns>
        public static ErrorAdditionalInfo ErrorAdditionalInfo(string type = null, object info = null)
        {
            return new ErrorAdditionalInfo(type, info);
        }

        /// <summary> Initializes a new instance of SearchAddressResult. </summary>
        /// <param name="summary"> Summary object for a Search API response. </param>
        /// <param name="results"> A list of Search API results. </param>
        /// <returns> A new <see cref="Models.SearchAddressResult"/> instance for mocking. </returns>
        public static SearchAddressResult SearchAddressResult(SearchSummary summary = null, IEnumerable<SearchAddressResultItem> results = null)
        {
            results ??= new List<SearchAddressResultItem>();

            return new SearchAddressResult(summary, results?.ToList());
        }

        /// <summary> Initializes a new instance of SearchSummary. </summary>
        /// <param name="query"> The query parameter that was used to produce these search results. </param>
        /// <param name="queryType"> The type of query being returned: NEARBY or NON_NEAR. </param>
        /// <param name="queryTime"> Time spent resolving the query, in milliseconds. </param>
        /// <param name="numResults"> Number of results in the response. </param>
        /// <param name="top"> Maximum number of responses that will be returned. </param>
        /// <param name="skip"> The starting offset of the returned Results within the full Result set. </param>
        /// <param name="totalResults"> The total number of Results found. </param>
        /// <param name="fuzzyLevel"> The maximum fuzzy level required to provide Results. </param>
        /// <param name="geoBias"> Indication when the internal search engine has applied a geospatial bias to improve the ranking of results.  In  some methods, this can be affected by setting the lat and lon parameters where available.  In other cases it is  purely internal. </param>
        /// <returns> A new <see cref="Models.SearchSummary"/> instance for mocking. </returns>
        public static SearchSummary SearchSummary(string query = null, QueryType? queryType = null, int? queryTime = null, int? numResults = null, int? top = null, int? skip = null, int? totalResults = null, int? fuzzyLevel = null, LatLong geoBias = null)
        {
            return new SearchSummary(query, queryType, queryTime, numResults, top, skip, totalResults, fuzzyLevel, geoBias);
        }

        /// <summary> Initializes a new instance of LatLong. </summary>
        /// <param name="lat"> Latitude property. </param>
        /// <param name="lon"> Longitude property. </param>
        /// <returns> A new <see cref="Models.LatLong"/> instance for mocking. </returns>
        public static LatLong LatLong(double lat = default, double lon = default)
        {
            return new LatLong(lat, lon);
        }

        /// <summary> Initializes a new instance of SearchAddressResultItem. </summary>
        /// <param name="type">
        /// One of:
        /// * POI
        /// * Street
        /// * Geography
        /// * Point Address
        /// * Address Range
        /// * Cross Street
        /// </param>
        /// <param name="id"> Id property. </param>
        /// <param name="score"> The value within a result set to indicate the relative matching score between results.  You can use this to  determine that result x is twice as likely to be as relevant as result y if the value of x is 2x the value of y.   The values vary between queries and is only meant as a relative value for one result set. </param>
        /// <param name="distanceInMeters"> Straight line distance between the result and geobias location in meters. </param>
        /// <param name="info"> Information about the original data source of the Result. Used for support requests. </param>
        /// <param name="entityType"></param>
        /// <param name="pointOfInterest"> Details of the returned POI including information such as the name, phone, url address, and classifications. </param>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="viewport"> The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport. </param>
        /// <param name="entryPoints"> Array of EntryPoints. Those describe the types of entrances available at the location. The type can be &quot;main&quot; for main entrances such as a front door, or a lobby, and &quot;minor&quot;, for side and back doors. </param>
        /// <param name="addressRanges"> Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included. </param>
        /// <param name="dataSources"> Optional section. Reference geometry id for use with the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API. </param>
        /// <param name="matchType">
        /// Information on the type of match.
        /// 
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </param>
        /// <param name="detourTime"> Detour time in seconds. Only returned for calls to the Search Along Route API. </param>
        /// <returns> A new <see cref="Models.SearchAddressResultItem"/> instance for mocking. </returns>
        public static SearchAddressResultItem SearchAddressResultItem(SearchAddressResultType? type = null, string id = null, double? score = null, double? distanceInMeters = null, string info = null, GeographicEntityType? entityType = null, PointOfInterest pointOfInterest = null, Address address = null, LatLong position = null, BoundingBox viewport = null, IEnumerable<EntryPoint> entryPoints = null, AddressRanges addressRanges = null, DataSource dataSources = null, MatchType? matchType = null, int? detourTime = null)
        {
            entryPoints ??= new List<EntryPoint>();

            return new SearchAddressResultItem(type, id, score, distanceInMeters, info, entityType, pointOfInterest, address, position, viewport, entryPoints?.ToList(), addressRanges, dataSources, matchType, detourTime);
        }

        /// <summary> Initializes a new instance of PointOfInterest. </summary>
        /// <param name="name"> Name of the POI property. </param>
        /// <param name="phone"> Telephone number property. </param>
        /// <param name="url"> Website URL property. </param>
        /// <param name="categorySet"> The list of the most specific POI categories. </param>
        /// <param name="classifications"> Classification array. </param>
        /// <param name="brands"> Brands array. The name of the brand for the POI being returned. </param>
        /// <param name="operatingHours"> Opening hours for a POI (Points of Interest). </param>
        /// <returns> A new <see cref="Models.PointOfInterest"/> instance for mocking. </returns>
        public static PointOfInterest PointOfInterest(string name = null, string phone = null, string url = null, IEnumerable<PointOfInterestCategorySet> categorySet = null, IEnumerable<Classification> classifications = null, IEnumerable<BrandName> brands = null, OperatingHours operatingHours = null)
        {
            categorySet ??= new List<PointOfInterestCategorySet>();
            classifications ??= new List<Classification>();
            brands ??= new List<BrandName>();

            return new PointOfInterest(name, phone, url, categorySet?.ToList(), classifications?.ToList(), brands?.ToList(), operatingHours);
        }

        /// <summary> Initializes a new instance of PointOfInterestCategorySet. </summary>
        /// <param name="id"> Category ID. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategorySet"/> instance for mocking. </returns>
        public static PointOfInterestCategorySet PointOfInterestCategorySet(int? id = null)
        {
            return new PointOfInterestCategorySet(id);
        }

        /// <summary> Initializes a new instance of Classification. </summary>
        /// <param name="code"> Code property. </param>
        /// <param name="names"> Names array. </param>
        /// <returns> A new <see cref="Models.Classification"/> instance for mocking. </returns>
        public static Classification Classification(string code = null, IEnumerable<ClassificationName> names = null)
        {
            names ??= new List<ClassificationName>();

            return new Classification(code, names?.ToList());
        }

        /// <summary> Initializes a new instance of ClassificationName. </summary>
        /// <param name="nameLocale"> Name Locale property. </param>
        /// <param name="name"> Name property. </param>
        /// <returns> A new <see cref="Models.ClassificationName"/> instance for mocking. </returns>
        public static ClassificationName ClassificationName(string nameLocale = null, string name = null)
        {
            return new ClassificationName(nameLocale, name);
        }

        /// <summary> Initializes a new instance of BrandName. </summary>
        /// <param name="name"> Name of the brand. </param>
        /// <returns> A new <see cref="Models.BrandName"/> instance for mocking. </returns>
        public static BrandName BrandName(string name = null)
        {
            return new BrandName(name);
        }

        /// <summary> Initializes a new instance of OperatingHours. </summary>
        /// <param name="mode"> Value used in the request: none or &quot;nextSevenDays&quot;. </param>
        /// <param name="timeRanges"> List of time ranges for the next 7 days. </param>
        /// <returns> A new <see cref="Models.OperatingHours"/> instance for mocking. </returns>
        public static OperatingHours OperatingHours(string mode = null, IEnumerable<OperatingHoursTimeRange> timeRanges = null)
        {
            timeRanges ??= new List<OperatingHoursTimeRange>();

            return new OperatingHours(mode, timeRanges?.ToList());
        }

        /// <summary> Initializes a new instance of OperatingHoursTimeRange. </summary>
        /// <param name="startTime"> The point in the next 7 days range when a given POI is being opened, or the beginning of the range if it was opened before the range. </param>
        /// <param name="endTime"> The point in the next 7 days range when a given POI is being closed, or the beginning of the range if it was closed before the range. </param>
        /// <returns> A new <see cref="Models.OperatingHoursTimeRange"/> instance for mocking. </returns>
        public static OperatingHoursTimeRange OperatingHoursTimeRange(OperatingHoursTime startTime = null, OperatingHoursTime endTime = null)
        {
            return new OperatingHoursTimeRange(startTime, endTime);
        }

        /// <summary> Initializes a new instance of OperatingHoursTime. </summary>
        /// <param name="date"> Represents current calendar date in POI time zone, e.g. &quot;2019-02-07&quot;. </param>
        /// <param name="hour"> Hours are in the 24 hour format in the local time of a POI; possible values are 0 - 23. </param>
        /// <param name="minute"> Minutes are in the local time of a POI; possible values are 0 - 59. </param>
        /// <returns> A new <see cref="Models.OperatingHoursTime"/> instance for mocking. </returns>
        public static OperatingHoursTime OperatingHoursTime(string date = null, int? hour = null, int? minute = null)
        {
            return new OperatingHoursTime(date, hour, minute);
        }

        /// <summary> Initializes a new instance of Address. </summary>
        /// <param name="buildingNumber"> The building number on the street. DEPRECATED, use streetNumber instead. </param>
        /// <param name="street"> The street name. DEPRECATED, use streetName instead. </param>
        /// <param name="crossStreet"> The name of the street being crossed. </param>
        /// <param name="streetNumber"> The building number on the street. </param>
        /// <param name="routeNumbers"> The codes used to unambiguously identify the street. </param>
        /// <param name="streetName"> The street name. </param>
        /// <param name="streetNameAndNumber"> The street name and number. </param>
        /// <param name="municipality"> City / Town. </param>
        /// <param name="municipalitySubdivision"> Sub / Super City. </param>
        /// <param name="countryTertiarySubdivision"> Named Area. </param>
        /// <param name="countrySecondarySubdivision"> County. </param>
        /// <param name="countrySubdivision"> State or Province. </param>
        /// <param name="postalCode"> Postal Code / Zip Code. </param>
        /// <param name="extendedPostalCode"> Extended postal code (availability is dependent on the region). </param>
        /// <param name="countryCode"> Country (Note: This is a two-letter code, not a country name.). </param>
        /// <param name="country"> Country name. </param>
        /// <param name="countryCodeISO3"> ISO alpha-3 country code. </param>
        /// <param name="freeformAddress"> An address line formatted according to the formatting rules of a Result&apos;s country of origin, or in the case of a country, its full country name. </param>
        /// <param name="countrySubdivisionName"> The full name of a first level of country administrative hierarchy. This field appears only in case countrySubdivision is presented in an abbreviated form. Only supported for USA, Canada, and Great Britain. </param>
        /// <param name="localName"> An address component which represents the name of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This field is used to build the `freeformAddress` property. </param>
        /// <param name="boundingBox"> Bounding box coordinates. </param>
        /// <returns> A new <see cref="Models.Address"/> instance for mocking. </returns>
        public static Address Address(string buildingNumber = null, string street = null, string crossStreet = null, string streetNumber = null, IEnumerable<int> routeNumbers = null, string streetName = null, string streetNameAndNumber = null, string municipality = null, string municipalitySubdivision = null, string countryTertiarySubdivision = null, string countrySecondarySubdivision = null, string countrySubdivision = null, string postalCode = null, string extendedPostalCode = null, string countryCode = null, string country = null, string countryCodeISO3 = null, string freeformAddress = null, string countrySubdivisionName = null, string localName = null, object boundingBox = null)
        {
            routeNumbers ??= new List<int>();

            return new Address(buildingNumber, street, crossStreet, streetNumber, routeNumbers?.ToList(), streetName, streetNameAndNumber, municipality, municipalitySubdivision, countryTertiarySubdivision, countrySecondarySubdivision, countrySubdivision, postalCode, extendedPostalCode, countryCode, country, countryCodeISO3, freeformAddress, countrySubdivisionName, localName, boundingBox);
        }

        /// <summary> Initializes a new instance of BoundingBox. </summary>
        /// <param name="topLeft"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="bottomRight"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <returns> A new <see cref="Models.BoundingBox"/> instance for mocking. </returns>
        public static BoundingBox BoundingBox(LatLong topLeft = null, LatLong bottomRight = null)
        {
            return new BoundingBox(topLeft, bottomRight);
        }

        /// <summary> Initializes a new instance of EntryPoint. </summary>
        /// <param name="type"> The type of entry point. Value can be either _main_ or _minor_. </param>
        /// <param name="position"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <returns> A new <see cref="Models.EntryPoint"/> instance for mocking. </returns>
        public static EntryPoint EntryPoint(EntryPointType? type = null, LatLong position = null)
        {
            return new EntryPoint(type, position);
        }

        /// <summary> Initializes a new instance of AddressRanges. </summary>
        /// <param name="rangeLeft"> Address range on the left side of the street. </param>
        /// <param name="rangeRight"> Address range on the right side of the street. </param>
        /// <param name="from"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="to"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <returns> A new <see cref="Models.AddressRanges"/> instance for mocking. </returns>
        public static AddressRanges AddressRanges(string rangeLeft = null, string rangeRight = null, LatLong @from = null, LatLong to = null)
        {
            return new AddressRanges(rangeLeft, rangeRight, @from, to);
        }

        /// <summary> Initializes a new instance of DataSource. </summary>
        /// <param name="geometry"> Information about the geometric shape of the result. Only present if type == Geography. </param>
        /// <returns> A new <see cref="Models.DataSource"/> instance for mocking. </returns>
        public static DataSource DataSource(GeometryIdentifier geometry = null)
        {
            return new DataSource(geometry);
        }

        /// <summary> Initializes a new instance of GeometryIdentifier. </summary>
        /// <param name="id"> Pass this as geometryId to the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API to fetch geometry information for this result. </param>
        /// <returns> A new <see cref="Models.GeometryIdentifier"/> instance for mocking. </returns>
        public static GeometryIdentifier GeometryIdentifier(string id = null)
        {
            return new GeometryIdentifier(id);
        }

        /// <summary> Initializes a new instance of PointOfInterestCategoryTreeResult. </summary>
        /// <param name="categories"> Categories array. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategoryTreeResult"/> instance for mocking. </returns>
        public static PointOfInterestCategoryTreeResult PointOfInterestCategoryTreeResult(IEnumerable<PointOfInterestCategory> categories = null)
        {
            categories ??= new List<PointOfInterestCategory>();

            return new PointOfInterestCategoryTreeResult(categories?.ToList());
        }

        /// <summary> Initializes a new instance of PointOfInterestCategory. </summary>
        /// <param name="id"> Unique ID for the category. ID can be used to restrict search results to specific categories through other Search Service APIs, like [Get Search POI](https://docs.microsoft.com/rest/api/maps/search/getsearchpoi). </param>
        /// <param name="name"> Name of the category. </param>
        /// <param name="childIds"> Array of child category ids. </param>
        /// <param name="synonyms"> Array of alternative names of the category. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategory"/> instance for mocking. </returns>
        public static PointOfInterestCategory PointOfInterestCategory(int? id = null, string name = null, IEnumerable<int> childIds = null, IEnumerable<string> synonyms = null)
        {
            childIds ??= new List<int>();
            synonyms ??= new List<string>();

            return new PointOfInterestCategory(id, name, childIds?.ToList(), synonyms?.ToList());
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressResult. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse response. </param>
        /// <param name="addresses"> Addresses array. </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressResult"/> instance for mocking. </returns>
        public static ReverseSearchAddressResult ReverseSearchAddressResult(SearchSummary summary = null, IEnumerable<ReverseSearchAddressResultItem> addresses = null)
        {
            addresses ??= new List<ReverseSearchAddressResultItem>();

            return new ReverseSearchAddressResult(summary, addresses?.ToList());
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressResultItem. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of &quot;{latitude},{longitude}&quot;. </param>
        /// <param name="roadUse"></param>
        /// <param name="matchType">
        /// Information on the type of match.
        /// 
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressResultItem"/> instance for mocking. </returns>
        public static ReverseSearchAddressResultItem ReverseSearchAddressResultItem(Address address = null, string position = null, IEnumerable<RoadUseType> roadUse = null, MatchType? matchType = null)
        {
            roadUse ??= new List<RoadUseType>();

            return new ReverseSearchAddressResultItem(address, position, roadUse?.ToList(), matchType);
        }

        /// <summary> Initializes a new instance of ReverseSearchCrossStreetAddressResult. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse Cross Street response. </param>
        /// <param name="addresses"> Addresses array. </param>
        /// <returns> A new <see cref="Models.ReverseSearchCrossStreetAddressResult"/> instance for mocking. </returns>
        public static ReverseSearchCrossStreetAddressResult ReverseSearchCrossStreetAddressResult(SearchSummary summary = null, IEnumerable<ReverseSearchCrossStreetAddressResultItem> addresses = null)
        {
            addresses ??= new List<ReverseSearchCrossStreetAddressResultItem>();

            return new ReverseSearchCrossStreetAddressResult(summary, addresses?.ToList());
        }

        /// <summary> Initializes a new instance of ReverseSearchCrossStreetAddressResultItem. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of &quot;{latitude},{longitude}&quot;. </param>
        /// <returns> A new <see cref="Models.ReverseSearchCrossStreetAddressResultItem"/> instance for mocking. </returns>
        public static ReverseSearchCrossStreetAddressResultItem ReverseSearchCrossStreetAddressResultItem(Address address = null, string position = null)
        {
            return new ReverseSearchCrossStreetAddressResultItem(address, position);
        }

        /// <summary> Initializes a new instance of SearchAddressBatchResult. </summary>
        /// <param name="batchSummary"> Summary of the results for the batch request. </param>
        /// <param name="batchItems"> Array containing the batch results. </param>
        /// <returns> A new <see cref="Models.SearchAddressBatchResult"/> instance for mocking. </returns>
        public static SearchAddressBatchResult SearchAddressBatchResult(BatchResultSummary batchSummary = null, IEnumerable<SearchAddressBatchItem> batchItems = null)
        {
            batchItems ??= new List<SearchAddressBatchItem>();

            return new SearchAddressBatchResult(batchSummary, batchItems?.ToList());
        }

        /// <summary> Initializes a new instance of SearchAddressBatchItem. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <param name="response"> The result of the query. SearchAddressResponse if the query completed successfully, ErrorResponse otherwise. </param>
        /// <returns> A new <see cref="Models.SearchAddressBatchItem"/> instance for mocking. </returns>
        public static SearchAddressBatchItem SearchAddressBatchItem(int? statusCode = null, SearchAddressBatchItemResponse response = null)
        {
            return new SearchAddressBatchItem(statusCode, response);
        }

        /// <summary> Initializes a new instance of SearchAddressBatchItemResponse. </summary>
        /// <param name="summary"> Summary object for a Search API response. </param>
        /// <param name="results"> A list of Search API results. </param>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.SearchAddressBatchItemResponse"/> instance for mocking. </returns>
        public static SearchAddressBatchItemResponse SearchAddressBatchItemResponse(SearchSummary summary = null, IEnumerable<SearchAddressResultItem> results = null, ErrorDetail error = null)
        {
            results ??= new List<SearchAddressResultItem>();

            return new SearchAddressBatchItemResponse(summary, results?.ToList(), error);
        }

        /// <summary> Initializes a new instance of BatchResultItem. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <returns> A new <see cref="Models.BatchResultItem"/> instance for mocking. </returns>
        public static BatchResultItem BatchResultItem(int? statusCode = null)
        {
            return new BatchResultItem(statusCode);
        }

        /// <summary> Initializes a new instance of BatchResult. </summary>
        /// <param name="batchSummary"> Summary of the results for the batch request. </param>
        /// <returns> A new <see cref="Models.BatchResult"/> instance for mocking. </returns>
        public static BatchResult BatchResult(BatchResultSummary batchSummary = null)
        {
            return new BatchResult(batchSummary);
        }

        /// <summary> Initializes a new instance of BatchResultSummary. </summary>
        /// <param name="successfulRequests"> Number of successful requests in the batch. </param>
        /// <param name="totalRequests"> Total number of requests in the batch. </param>
        /// <returns> A new <see cref="Models.BatchResultSummary"/> instance for mocking. </returns>
        public static BatchResultSummary BatchResultSummary(int? successfulRequests = null, int? totalRequests = null)
        {
            return new BatchResultSummary(successfulRequests, totalRequests);
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressBatchProcessResult. </summary>
        /// <param name="batchSummary"> Summary of the results for the batch request. </param>
        /// <param name="batchItems"> Array containing the batch results. </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressBatchProcessResult"/> instance for mocking. </returns>
        public static ReverseSearchAddressBatchProcessResult ReverseSearchAddressBatchProcessResult(BatchResultSummary batchSummary = null, IEnumerable<ReverseSearchAddressBatchItem> batchItems = null)
        {
            batchItems ??= new List<ReverseSearchAddressBatchItem>();

            return new ReverseSearchAddressBatchProcessResult(batchSummary, batchItems?.ToList());
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressBatchItem. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <param name="response"> The result of the query. SearchAddressReverseResponse if the query completed successfully, ErrorResponse otherwise. </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressBatchItem"/> instance for mocking. </returns>
        public static ReverseSearchAddressBatchItem ReverseSearchAddressBatchItem(int? statusCode = null, ReverseSearchAddressBatchItemResponse response = null)
        {
            return new ReverseSearchAddressBatchItem(statusCode, response);
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressBatchItemResponse. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse response. </param>
        /// <param name="addresses"> Addresses array. </param>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressBatchItemResponse"/> instance for mocking. </returns>
        public static ReverseSearchAddressBatchItemResponse ReverseSearchAddressBatchItemResponse(SearchSummary summary = null, IEnumerable<ReverseSearchAddressResultItem> addresses = null, ErrorDetail error = null)
        {
            addresses ??= new List<ReverseSearchAddressResultItem>();

            return new ReverseSearchAddressBatchItemResponse(summary, addresses?.ToList(), error);
        }
    }
}
