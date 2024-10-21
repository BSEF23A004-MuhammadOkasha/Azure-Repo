// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Properties of the Queue info for event subscription.
/// </summary>
public partial class QueueInfo : ProvisionableConstruct
{
    /// <summary>
    /// Maximum period in seconds in which once the message is in received (by
    /// the client) state and waiting to be accepted, released or rejected.
    /// If this time elapsed after a message has been received by
    /// the client and not transitioned into accepted (not processed),
    /// released or rejected,             the message is available for
    /// redelivery. This is an optional field, where default is 60 seconds,
    /// minimum is 60 seconds and maximum is 300 seconds.
    /// </summary>
    public BicepValue<int> ReceiveLockDurationInSeconds { get => _receiveLockDurationInSeconds; set => _receiveLockDurationInSeconds.Assign(value); }
    private readonly BicepValue<int> _receiveLockDurationInSeconds;

    /// <summary>
    /// The maximum delivery count of the events.
    /// </summary>
    public BicepValue<int> MaxDeliveryCount { get => _maxDeliveryCount; set => _maxDeliveryCount.Assign(value); }
    private readonly BicepValue<int> _maxDeliveryCount;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses the managed identity setup on the
    /// parent resource (namely, topic) to acquire the authentication tokens
    /// being used during delivery / dead-lettering.
    /// </summary>
    public BicepValue<DeadLetterWithResourceIdentity> DeadLetterDestinationWithResourceIdentity { get => _deadLetterDestinationWithResourceIdentity; set => _deadLetterDestinationWithResourceIdentity.Assign(value); }
    private readonly BicepValue<DeadLetterWithResourceIdentity> _deadLetterDestinationWithResourceIdentity;

    /// <summary>
    /// Time span duration in ISO 8601 format that determines how long messages
    /// are available to the subscription from the time the message was
    /// published.             This duration value is expressed using the
    /// following format: \&apos;P(n)Y(n)M(n)DT(n)H(n)M(n)S\&apos;, where:
    /// - (n) is replaced by the value of each time element
    /// that follows the (n).                 - P is the duration (or Period)
    /// designator and is always placed at the beginning of the duration.
    /// - Y is the year designator, and it follows the value
    /// for the number of years.                 - M is the month designator,
    /// and it follows the value for the number of months.                 - W
    /// is the week designator, and it follows the value for the number of
    /// weeks.                 - D is the day designator, and it follows the
    /// value for the number of days.                 - T is the time
    /// designator, and it precedes the time components.                 - H
    /// is the hour designator, and it follows the value for the number of
    /// hours.                 - M is the minute designator, and it follows
    /// the value for the number of minutes.                 - S is the second
    /// designator, and it follows the value for the number of seconds.
    /// This duration value cannot be set greater than the topic’s
    /// EventRetentionInDays. It is is an optional field where its minimum
    /// value is 1 minute, and its maximum is determined             by
    /// topic’s EventRetentionInDays value. The followings are examples of
    /// valid values:                 - \&apos;P0DT23H12M\&apos; or
    /// \&apos;PT23H12M\&apos;: for duration of 23 hours and 12 minutes.
    /// - \&apos;P1D\&apos; or \&apos;P1DT0H0M0S\&apos;: for
    /// duration of 1 day.
    /// </summary>
    public BicepValue<TimeSpan> EventTimeToLive { get => _eventTimeToLive; set => _eventTimeToLive.Assign(value); }
    private readonly BicepValue<TimeSpan> _eventTimeToLive;

    /// <summary>
    /// Creates a new QueueInfo.
    /// </summary>
    public QueueInfo()
    {
        _receiveLockDurationInSeconds = BicepValue<int>.DefineProperty(this, "ReceiveLockDurationInSeconds", ["receiveLockDurationInSeconds"]);
        _maxDeliveryCount = BicepValue<int>.DefineProperty(this, "MaxDeliveryCount", ["maxDeliveryCount"]);
        _deadLetterDestinationWithResourceIdentity = BicepValue<DeadLetterWithResourceIdentity>.DefineProperty(this, "DeadLetterDestinationWithResourceIdentity", ["deadLetterDestinationWithResourceIdentity"]);
        _eventTimeToLive = BicepValue<TimeSpan>.DefineProperty(this, "EventTimeToLive", ["eventTimeToLive"]);
    }
}
