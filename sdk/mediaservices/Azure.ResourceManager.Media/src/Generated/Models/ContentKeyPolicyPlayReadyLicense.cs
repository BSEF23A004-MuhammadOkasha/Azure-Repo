// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The PlayReady license. </summary>
    public partial class ContentKeyPolicyPlayReadyLicense
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyLicense. </summary>
        /// <param name="allowTestDevices"> A flag indicating whether test devices can use the license. </param>
        /// <param name="licenseType"> The license type. </param>
        /// <param name="contentKeyLocation">
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </param>
        /// <param name="contentType"> The PlayReady content type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyLocation"/> is null. </exception>
        public ContentKeyPolicyPlayReadyLicense(bool allowTestDevices, ContentKeyPolicyPlayReadyLicenseType licenseType, ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation, ContentKeyPolicyPlayReadyContentType contentType)
        {
            if (contentKeyLocation == null)
            {
                throw new ArgumentNullException(nameof(contentKeyLocation));
            }

            AllowTestDevices = allowTestDevices;
            LicenseType = licenseType;
            ContentKeyLocation = contentKeyLocation;
            ContentType = contentType;
        }

        /// <summary> Initializes a new instance of ContentKeyPolicyPlayReadyLicense. </summary>
        /// <param name="allowTestDevices"> A flag indicating whether test devices can use the license. </param>
        /// <param name="securityLevel"> The security level. </param>
        /// <param name="beginOn"> The begin date of license. </param>
        /// <param name="expiresOn"> The expiration date of license. </param>
        /// <param name="relativeBeginDate"> The relative begin date of license. </param>
        /// <param name="relativeExpirationDate"> The relative expiration date of license. </param>
        /// <param name="gracePeriod"> The grace period of license. </param>
        /// <param name="playRight"> The license PlayRight. </param>
        /// <param name="licenseType"> The license type. </param>
        /// <param name="contentKeyLocation">
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </param>
        /// <param name="contentType"> The PlayReady content type. </param>
        internal ContentKeyPolicyPlayReadyLicense(bool allowTestDevices, ContentKeyPolicyPlayReadySecurityLevel? securityLevel, DateTimeOffset? beginOn, DateTimeOffset? expiresOn, TimeSpan? relativeBeginDate, TimeSpan? relativeExpirationDate, TimeSpan? gracePeriod, ContentKeyPolicyPlayReadyPlayRight playRight, ContentKeyPolicyPlayReadyLicenseType licenseType, ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation, ContentKeyPolicyPlayReadyContentType contentType)
        {
            AllowTestDevices = allowTestDevices;
            SecurityLevel = securityLevel;
            BeginOn = beginOn;
            ExpiresOn = expiresOn;
            RelativeBeginDate = relativeBeginDate;
            RelativeExpirationDate = relativeExpirationDate;
            GracePeriod = gracePeriod;
            PlayRight = playRight;
            LicenseType = licenseType;
            ContentKeyLocation = contentKeyLocation;
            ContentType = contentType;
        }

        /// <summary> A flag indicating whether test devices can use the license. </summary>
        public bool AllowTestDevices { get; set; }
        /// <summary> The security level. </summary>
        public ContentKeyPolicyPlayReadySecurityLevel? SecurityLevel { get; set; }
        /// <summary> The begin date of license. </summary>
        public DateTimeOffset? BeginOn { get; set; }
        /// <summary> The expiration date of license. </summary>
        public DateTimeOffset? ExpiresOn { get; set; }
        /// <summary> The relative begin date of license. </summary>
        public TimeSpan? RelativeBeginDate { get; set; }
        /// <summary> The relative expiration date of license. </summary>
        public TimeSpan? RelativeExpirationDate { get; set; }
        /// <summary> The grace period of license. </summary>
        public TimeSpan? GracePeriod { get; set; }
        /// <summary> The license PlayRight. </summary>
        public ContentKeyPolicyPlayReadyPlayRight PlayRight { get; set; }
        /// <summary> The license type. </summary>
        public ContentKeyPolicyPlayReadyLicenseType LicenseType { get; set; }
        /// <summary>
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </summary>
        public ContentKeyPolicyPlayReadyContentKeyLocation ContentKeyLocation { get; set; }
        /// <summary> The PlayReady content type. </summary>
        public ContentKeyPolicyPlayReadyContentType ContentType { get; set; }
    }
}
