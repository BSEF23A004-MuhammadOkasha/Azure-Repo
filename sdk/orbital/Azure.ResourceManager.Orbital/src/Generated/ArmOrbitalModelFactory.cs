// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmOrbitalModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Orbital.OrbitalSpacecraftData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The current state of the resource's creation, deletion, or modification. </param>
        /// <param name="noradId"> NORAD ID of the spacecraft. </param>
        /// <param name="titleLine"> Title line of the two-line element set (TLE). </param>
        /// <param name="tleLine1"> Line 1 of the two-line element set (TLE). </param>
        /// <param name="tleLine2"> Line 2 of the two-line element set (TLE). </param>
        /// <param name="links"> Immutable list of Spacecraft links. </param>
        /// <returns> A new <see cref="Orbital.OrbitalSpacecraftData"/> instance for mocking. </returns>
        public static OrbitalSpacecraftData OrbitalSpacecraftData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, OrbitalProvisioningState? provisioningState = null, string noradId = null, string titleLine = null, string tleLine1 = null, string tleLine2 = null, IEnumerable<OrbitalSpacecraftLink> links = null)
        {
            tags ??= new Dictionary<string, string>();
            links ??= new List<OrbitalSpacecraftLink>();

            return new OrbitalSpacecraftData(id, name, resourceType, systemData, tags, location, etag, provisioningState, noradId, titleLine, tleLine1, tleLine2, links?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.OrbitalSpacecraftLink"/>. </summary>
        /// <param name="name"> Link name. </param>
        /// <param name="centerFrequencyMHz"> Center Frequency in MHz. </param>
        /// <param name="bandwidthMHz"> Bandwidth in MHz. </param>
        /// <param name="direction"> Direction (uplink or downlink). </param>
        /// <param name="polarization"> Polarization. e.g. (RHCP, LHCP). </param>
        /// <param name="authorizations"> Authorized Ground Stations. </param>
        /// <returns> A new <see cref="Models.OrbitalSpacecraftLink"/> instance for mocking. </returns>
        public static OrbitalSpacecraftLink OrbitalSpacecraftLink(string name = null, float centerFrequencyMHz = default, float bandwidthMHz = default, OrbitalLinkDirection direction = default, OrbitalLinkPolarization polarization = default, IEnumerable<AuthorizedGroundStation> authorizations = null)
        {
            authorizations ??= new List<AuthorizedGroundStation>();

            return new OrbitalSpacecraftLink(name, centerFrequencyMHz, bandwidthMHz, direction, polarization, authorizations?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.AuthorizedGroundStation"/>. </summary>
        /// <param name="groundStationName"> Groundstation name. </param>
        /// <param name="expireOn"> Date of authorization expiration. </param>
        /// <returns> A new <see cref="Models.AuthorizedGroundStation"/> instance for mocking. </returns>
        public static AuthorizedGroundStation AuthorizedGroundStation(string groundStationName = null, DateTimeOffset? expireOn = null)
        {
            return new AuthorizedGroundStation(groundStationName, expireOn, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Orbital.OrbitalContactData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The current state of the resource's creation, deletion, or modification. </param>
        /// <param name="status"> Status of a contact. </param>
        /// <param name="reservationStartOn"> Reservation start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="reservationEndOn"> Reservation end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="rxStartOn"> Receive start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="rxEndOn"> Receive end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="txStartOn"> Transmit start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="txEndOn"> Transmit end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="errorMessage"> Any error message while scheduling a contact. </param>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="groundStationName"> Azure Ground Station name. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <param name="antennaConfiguration"> The configuration associated with the allocated antenna. </param>
        /// <param name="contactProfileId"> The reference to the contact profile resource. </param>
        /// <returns> A new <see cref="Orbital.OrbitalContactData"/> instance for mocking. </returns>
        public static OrbitalContactData OrbitalContactData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? etag = null, OrbitalProvisioningState? provisioningState = null, OrbitalContactStatus? status = null, DateTimeOffset? reservationStartOn = null, DateTimeOffset? reservationEndOn = null, DateTimeOffset? rxStartOn = null, DateTimeOffset? rxEndOn = null, DateTimeOffset? txStartOn = null, DateTimeOffset? txEndOn = null, string errorMessage = null, float? maximumElevationDegrees = null, float? startAzimuthDegrees = null, float? endAzimuthDegrees = null, string groundStationName = null, float? startElevationDegrees = null, float? endElevationDegrees = null, OrbitalContactAntennaConfiguration antennaConfiguration = null, ResourceIdentifier contactProfileId = null)
        {
            return new OrbitalContactData(id, name, resourceType, systemData, etag, provisioningState, status, reservationStartOn, reservationEndOn, rxStartOn, rxEndOn, txStartOn, txEndOn, errorMessage, maximumElevationDegrees, startAzimuthDegrees, endAzimuthDegrees, groundStationName, startElevationDegrees, endElevationDegrees, antennaConfiguration, contactProfileId != null ? ResourceManagerModelFactory.WritableSubResource(contactProfileId) : null, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.OrbitalContactAntennaConfiguration"/>. </summary>
        /// <param name="destinationIP"> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </param>
        /// <param name="sourceIPs"> List of Source IP. </param>
        /// <returns> A new <see cref="Models.OrbitalContactAntennaConfiguration"/> instance for mocking. </returns>
        public static OrbitalContactAntennaConfiguration OrbitalContactAntennaConfiguration(IPAddress destinationIP = null, IEnumerable<IPAddress> sourceIPs = null)
        {
            sourceIPs ??= new List<IPAddress>();

            return new OrbitalContactAntennaConfiguration(destinationIP, sourceIPs?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.OrbitalAvailableContactsResult"/>. </summary>
        /// <param name="values"> A list of available contacts. </param>
        /// <returns> A new <see cref="Models.OrbitalAvailableContactsResult"/> instance for mocking. </returns>
        public static OrbitalAvailableContactsResult OrbitalAvailableContactsResult(IEnumerable<OrbitalAvailableContact> values = null)
        {
            values ??= new List<OrbitalAvailableContact>();

            return new OrbitalAvailableContactsResult(values?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.OrbitalAvailableContact"/>. </summary>
        /// <param name="spacecraftId"> The reference to the spacecraft resource. </param>
        /// <param name="groundStationName"> Name of Azure Ground Station. </param>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="txStartOn"> Time at which antenna transmit will be enabled (ISO 8601 UTC standard). </param>
        /// <param name="txEndOn"> Time at which antenna transmit will be disabled (ISO 8601 UTC standard). </param>
        /// <param name="rxStartOn"> Earliest time to receive a signal (ISO 8601 UTC standard). </param>
        /// <param name="rxEndOn"> Time to lost receiving a signal (ISO 8601 UTC standard). </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <returns> A new <see cref="Models.OrbitalAvailableContact"/> instance for mocking. </returns>
        public static OrbitalAvailableContact OrbitalAvailableContact(ResourceIdentifier spacecraftId = null, string groundStationName = null, float? maximumElevationDegrees = null, DateTimeOffset? txStartOn = null, DateTimeOffset? txEndOn = null, DateTimeOffset? rxStartOn = null, DateTimeOffset? rxEndOn = null, float? startAzimuthDegrees = null, float? endAzimuthDegrees = null, float? startElevationDegrees = null, float? endElevationDegrees = null)
        {
            return new OrbitalAvailableContact(spacecraftId != null ? ResourceManagerModelFactory.WritableSubResource(spacecraftId) : null, groundStationName, maximumElevationDegrees, txStartOn, txEndOn, rxStartOn, rxEndOn, startAzimuthDegrees, endAzimuthDegrees, startElevationDegrees, endElevationDegrees, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Orbital.OrbitalContactProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The current state of the resource's creation, deletion, or modification. </param>
        /// <param name="minimumViableContactDuration"> Minimum viable contact duration in ISO 8601 format. Used for listing the available contacts with a spacecraft at a given ground station. </param>
        /// <param name="minimumElevationDegrees"> Minimum viable elevation for the contact in decimal degrees. Used for listing the available contacts with a spacecraft at a given ground station. </param>
        /// <param name="autoTrackingConfiguration"> Auto-tracking configuration. </param>
        /// <param name="eventHubUri"> ARM resource identifier of the Event Hub used for telemetry. Requires granting Orbital Resource Provider the rights to send telemetry into the hub. </param>
        /// <param name="networkSubnetId"> Network configuration of customer virtual network. </param>
        /// <param name="links"> Links of the Contact Profile. Describes RF links, modem processing, and IP endpoints. </param>
        /// <returns> A new <see cref="Orbital.OrbitalContactProfileData"/> instance for mocking. </returns>
        public static OrbitalContactProfileData OrbitalContactProfileData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? etag = null, OrbitalProvisioningState? provisioningState = null, TimeSpan? minimumViableContactDuration = null, float? minimumElevationDegrees = null, AutoTrackingConfiguration? autoTrackingConfiguration = null, Uri eventHubUri = null, ResourceIdentifier networkSubnetId = null, IEnumerable<OrbitalContactProfileLink> links = null)
        {
            tags ??= new Dictionary<string, string>();
            links ??= new List<OrbitalContactProfileLink>();

            return new OrbitalContactProfileData(id, name, resourceType, systemData, tags, location, etag, provisioningState, minimumViableContactDuration, minimumElevationDegrees, autoTrackingConfiguration, eventHubUri, networkSubnetId != null ? new ContactProfilesPropertiesNetworkConfiguration(networkSubnetId, new Dictionary<string, BinaryData>()) : null, links?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Orbital.AvailableGroundStationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Azure region. </param>
        /// <param name="city"> City of ground station. </param>
        /// <param name="providerName"> Ground station provider name. </param>
        /// <param name="longitudeDegrees"> Longitude of the ground station in decimal degrees. </param>
        /// <param name="latitudeDegrees"> Latitude of the ground station in decimal degrees. </param>
        /// <param name="altitudeMeters"> Altitude of the ground station. </param>
        /// <param name="releaseMode"> Release Status of a ground station. </param>
        /// <returns> A new <see cref="Orbital.AvailableGroundStationData"/> instance for mocking. </returns>
        public static AvailableGroundStationData AvailableGroundStationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, string city = null, string providerName = null, float? longitudeDegrees = null, float? latitudeDegrees = null, float? altitudeMeters = null, GroundStationReleaseMode? releaseMode = null)
        {
            return new AvailableGroundStationData(id, name, resourceType, systemData, location, city, providerName, longitudeDegrees, latitudeDegrees, altitudeMeters, releaseMode, new Dictionary<string, BinaryData>());
        }
    }
}
