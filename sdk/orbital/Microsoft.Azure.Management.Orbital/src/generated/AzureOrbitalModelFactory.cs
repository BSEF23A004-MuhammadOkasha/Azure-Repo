// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace AzureOrbital.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AzureOrbitalModelFactory
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="name"> Operation name: {provider}/{resource}/{operation}. </param>
        /// <param name="isDataAction"> Indicates whether the operation applies to data-plane. </param>
        /// <param name="display"> Display metadata associated with the operation. </param>
        /// <param name="origin"> The origin of operations. </param>
        /// <returns> A new <see cref="Models.Operation"/> instance for mocking. </returns>
        public static Operation Operation(string name = null, bool? isDataAction = null, OperationDisplay display = null, string origin = null)
        {
            return new Operation(name, isDataAction, display, origin);
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> Service provider: Microsoft Orbital. </param>
        /// <param name="resource"> Resource on which the operation is performed etc. </param>
        /// <param name="operation"> Type of operation: get, read, delete, etc. </param>
        /// <param name="description"> Description of the operation. </param>
        /// <returns> A new <see cref="Models.OperationDisplay"/> instance for mocking. </returns>
        public static OperationDisplay OperationDisplay(string provider = null, string resource = null, string operation = null, string description = null)
        {
            return new OperationDisplay(provider, resource, operation, description);
        }

        /// <summary> Initializes a new instance of GroundStationListResult. </summary>
        /// <param name="value"> A list of ground station resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <returns> A new <see cref="Models.GroundStationListResult"/> instance for mocking. </returns>
        public static GroundStationListResult GroundStationListResult(IEnumerable<GroundStation> value = null, string nextLink = null)
        {
            value ??= new List<GroundStation>();

            return new GroundStationListResult(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of GroundStation. </summary>
        /// <param name="name"> Name of the ground station. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="city"> city of ground station. </param>
        /// <param name="providerName"> Ground station provider name. </param>
        /// <param name="longitudeDegrees"> Longitude of the ground station in decimal degrees. </param>
        /// <param name="latitudeDegrees"> Latitude of the ground station in decimal degrees. </param>
        /// <param name="altitudeMeters"> Altitude of the ground station. </param>
        /// <returns> A new <see cref="Models.GroundStation"/> instance for mocking. </returns>
        public static GroundStation GroundStation(string name = null, string location = null, string city = null, string providerName = null, float? longitudeDegrees = null, float? latitudeDegrees = null, float? altitudeMeters = null)
        {
            return new GroundStation(name, location, city, providerName, longitudeDegrees, latitudeDegrees, altitudeMeters);
        }

        /// <summary> Initializes a new instance of SpacecraftListResult. </summary>
        /// <param name="value"> A list of spacecraft resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <returns> A new <see cref="Models.SpacecraftListResult"/> instance for mocking. </returns>
        public static SpacecraftListResult SpacecraftListResult(IEnumerable<Spacecraft> value = null, string nextLink = null)
        {
            value ??= new List<Spacecraft>();

            return new SpacecraftListResult(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <returns> A new <see cref="Models.Resource"/> instance for mocking. </returns>
        public static Resource Resource(string id = null, string name = null, string type = null, string location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new Resource(id, name, type, location, tags);
        }

        /// <summary> Initializes a new instance of Spacecraft. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="noradId"> NORAD ID of the spacecraft. </param>
        /// <param name="authorizationStatus"> Authorization status of spacecraft. </param>
        /// <param name="authorizationStatusExtended"> Details of the authorization status. </param>
        /// <param name="titleLine"> Title line of Two Line Element (TLE). </param>
        /// <param name="tleLine1"> Line 1 of Two Line Element (TLE). </param>
        /// <param name="tleLine2"> Line 2 of Two Line Element (TLE). </param>
        /// <param name="links"></param>
        /// <returns> A new <see cref="Models.Spacecraft"/> instance for mocking. </returns>
        public static Spacecraft Spacecraft(string id = null, string name = null, string type = null, string location = null, IReadOnlyDictionary<string, string> tags = null, string etag = null, string noradId = null, SpacecraftsPropertiesAuthorizationStatus? authorizationStatus = null, string authorizationStatusExtended = null, string titleLine = null, string tleLine1 = null, string tleLine2 = null, IEnumerable<SpacecraftLink> links = null)
        {
            tags ??= new Dictionary<string, string>();
            links ??= new List<SpacecraftLink>();

            return new Spacecraft(id, name, type, location, tags, etag, noradId, authorizationStatus, authorizationStatusExtended, titleLine, tleLine1, tleLine2, links?.ToList());
        }

        /// <summary> Initializes a new instance of ContactListResult. </summary>
        /// <param name="value"> A list of contact resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <returns> A new <see cref="Models.ContactListResult"/> instance for mocking. </returns>
        public static ContactListResult ContactListResult(IEnumerable<Contact> value = null, string nextLink = null)
        {
            value ??= new List<Contact>();

            return new ContactListResult(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of ProxyResource. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="type"> Azure resource type. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <returns> A new <see cref="Models.ProxyResource"/> instance for mocking. </returns>
        public static ProxyResource ProxyResource(string id = null, string type = null, string name = null)
        {
            return new ProxyResource(id, type, name);
        }

        /// <summary> Initializes a new instance of Contact. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="type"> Azure resource type. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <param name="properties"> Properties of the Contact Resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <returns> A new <see cref="Models.Contact"/> instance for mocking. </returns>
        public static Contact Contact(string id = null, string type = null, string name = null, ContactProperties properties = null, string etag = null)
        {
            return new Contact(id, type, name, properties, etag);
        }

        /// <summary> Initializes a new instance of ContactProperties. </summary>
        /// <param name="status"> Status of a contact. </param>
        /// <param name="reservationStartTime"> Reservation start time of a contact. </param>
        /// <param name="reservationEndTime"> Reservation end time of a contact. </param>
        /// <param name="rxStartTime"> Receive start time of a contact. </param>
        /// <param name="rxEndTime"> Receive end time of a contact. </param>
        /// <param name="txStartTime"> Transmit start time of a contact. </param>
        /// <param name="txEndTime"> Transmit end time of a contact. </param>
        /// <param name="errorMessage"> Any error message while scheduling a contact. </param>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="groundStationName"> Azure Ground Station name. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <param name="contactProfile"> The reference to the contact profile resource. </param>
        /// <returns> A new <see cref="Models.ContactProperties"/> instance for mocking. </returns>
        public static ContactProperties ContactProperties(ContactPropertiesStatus? status = null, DateTimeOffset reservationStartTime = default, DateTimeOffset reservationEndTime = default, DateTimeOffset? rxStartTime = null, DateTimeOffset? rxEndTime = null, DateTimeOffset? txStartTime = null, DateTimeOffset? txEndTime = null, string errorMessage = null, float? maximumElevationDegrees = null, float? startAzimuthDegrees = null, float? endAzimuthDegrees = null, string groundStationName = null, float? startElevationDegrees = null, float? endElevationDegrees = null, ContactPropertiesContactProfile contactProfile = null)
        {
            return new ContactProperties(status, reservationStartTime, reservationEndTime, rxStartTime, rxEndTime, txStartTime, txEndTime, errorMessage, maximumElevationDegrees, startAzimuthDegrees, endAzimuthDegrees, groundStationName, startElevationDegrees, endElevationDegrees, contactProfile);
        }

        /// <summary> Initializes a new instance of AvailableContactsListResult. </summary>
        /// <param name="value"> A list of available contacts. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <returns> A new <see cref="Models.AvailableContactsListResult"/> instance for mocking. </returns>
        public static AvailableContactsListResult AvailableContactsListResult(IEnumerable<AvailableContacts> value = null, string nextLink = null)
        {
            value ??= new List<AvailableContacts>();

            return new AvailableContactsListResult(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of AvailableContacts. </summary>
        /// <param name="spacecraft"> The reference to the spacecraft resource. </param>
        /// <param name="groundStationName"> Name of Azure Ground Station. </param>
        /// <param name="properties"> Properties of Contact resource. </param>
        /// <returns> A new <see cref="Models.AvailableContacts"/> instance for mocking. </returns>
        public static AvailableContacts AvailableContacts(AvailableContactsSpacecraft spacecraft = null, string groundStationName = null, AvailableContactsProperties properties = null)
        {
            return new AvailableContacts(spacecraft, groundStationName, properties);
        }

        /// <summary> Initializes a new instance of ContactInstanceProperties. </summary>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="txStartTime"> Time at which antenna transmit will be enabled. </param>
        /// <param name="txEndTime"> Time at which antenna transmit will be disabled. </param>
        /// <param name="rxStartTime"> Earliest time to receive a signal. </param>
        /// <param name="rxEndTime"> Time to lost receiving a signal. </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <returns> A new <see cref="Models.ContactInstanceProperties"/> instance for mocking. </returns>
        public static ContactInstanceProperties ContactInstanceProperties(float? maximumElevationDegrees = null, DateTimeOffset? txStartTime = null, DateTimeOffset? txEndTime = null, DateTimeOffset? rxStartTime = null, DateTimeOffset? rxEndTime = null, float? startAzimuthDegrees = null, float? endAzimuthDegrees = null, float? startElevationDegrees = null, float? endElevationDegrees = null)
        {
            return new ContactInstanceProperties(maximumElevationDegrees, txStartTime, txEndTime, rxStartTime, rxEndTime, startAzimuthDegrees, endAzimuthDegrees, startElevationDegrees, endElevationDegrees);
        }

        /// <summary> Initializes a new instance of ContactProfile. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="minimumViableContactDuration"> Minimum viable contact duration in ISO 8601 format. </param>
        /// <param name="minimumElevationDegrees"> Minimum viable elevation for the contact in decimal degrees. </param>
        /// <param name="autoTrackingConfiguration"> Auto track configuration. </param>
        /// <param name="links"></param>
        /// <returns> A new <see cref="Models.ContactProfile"/> instance for mocking. </returns>
        public static ContactProfile ContactProfile(string id = null, string name = null, string type = null, string location = null, IReadOnlyDictionary<string, string> tags = null, string etag = null, string minimumViableContactDuration = null, float? minimumElevationDegrees = null, ContactProfilesPropertiesAutoTrackingConfiguration? autoTrackingConfiguration = null, IEnumerable<ContactProfileLink> links = null)
        {
            tags ??= new Dictionary<string, string>();
            links ??= new List<ContactProfileLink>();

            return new ContactProfile(id, name, type, location, tags, etag, minimumViableContactDuration, minimumElevationDegrees, autoTrackingConfiguration, links?.ToList());
        }

        /// <summary> Initializes a new instance of ContactProfileListResult. </summary>
        /// <param name="value"> A list of contact profile resources in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <returns> A new <see cref="Models.ContactProfileListResult"/> instance for mocking. </returns>
        public static ContactProfileListResult ContactProfileListResult(IEnumerable<ContactProfile> value = null, string nextLink = null)
        {
            value ??= new List<ContactProfile>();

            return new ContactProfileListResult(value?.ToList(), nextLink);
        }
    }
}
