﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.Messaging.EventHubs.Processor
{
    /// <summary>
    ///   Processes events received from the Azure Event Hubs service. A single instance of a class implementing this
    ///   interface will be created for every partition the associated <see cref="EventProcessor" /> owns.
    /// </summary>
    ///
    /// <remarks>
    ///   Every aforementioned instance is created by an <see cref="IPartitionProcessorFactory" /> provided by
    ///   the user in the <see cref="EventProcessor" /> constructor.
    /// </remarks>
    ///
    public interface IPartitionProcessor
    {
        /// <summary>
        ///   Initializes the partition processor.
        /// </summary>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public Task Initialize();

        /// <summary>
        ///   Closes the partition processor.
        /// </summary>
        ///
        /// <param name="reason">The reason why the partition processor is being closed.</param>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public Task Close(string reason);

        /// <summary>
        ///   Processes a set of received <see cref="EventData" />.
        /// </summary>
        ///
        /// <param name="events">The received events to be processed.</param>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public Task ProcessEvents(IEnumerable<EventData> events);

        /// <summary>
        ///   Processes an unexpected exception thrown when <see cref="EventProcessor" /> is running.
        /// </summary>
        ///
        /// <param name="exception">The exception to be processed.</param>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public Task ProcessError(Exception exception);
    }
}
