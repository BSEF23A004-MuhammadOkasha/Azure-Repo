// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Diagnostics;
using Azure.Messaging.EventHubs.Tests;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Processor.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="PartitionLoadBalancer" />
    ///   class.
    /// </summary>
    ///
    [TestFixture]
    public class PartitionLoadBalancerTests
    {
        private const string FullyQualifiedNamespace = "fqns";
        private const string EventHubName = "name";
        private const string ConsumerGroup = "consumerGroup";

        /// <summary>
        ///   Verifies that partitions owned by an <see cref="PartitionLoadBalancer" /> are immediately available to be claimed by another loadbalancer
        ///   after StopAsync is called.
        /// </summary>
        ///
        [Test]
        public async Task RelinquishOwnershipAsyncRelinquishesPartitionOwnershipOtherClientsConsiderThemClaimableImmediately()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int NumberOfPartitions = 3;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer1 = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));
            var loadbalancer2 = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Ownership should start empty.

            var completeOwnership = await partitionManager.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup);
            Assert.That(completeOwnership.Count(), Is.EqualTo(0));

            // Start the loadbalancer so that it claims a random partition until none are left.

            for (int i = 0; i < NumberOfPartitions; i++)
            {
                await loadbalancer1.RunLoadBalancingAsync(partitionIds, tokenSource.Token);
            }

            completeOwnership = await partitionManager.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup);

            // All partitions are owned by loadbalancer1.

            Assert.That(completeOwnership.Count(p => p.OwnerIdentifier.Equals(loadbalancer1.Identifier)), Is.EqualTo(NumberOfPartitions));

            // Stopping the loadbalancer should relinquish all partition ownership.

            await loadbalancer1.RelinquishOwnershipAsync(tokenSource.Token);

            completeOwnership = await partitionManager.ListOwnershipAsync(loadbalancer1.FullyQualifiedNamespace, loadbalancer1.EventHubName, loadbalancer1.ConsumerGroup);

            // No partitions are owned by loadbalancer1.

            Assert.That(completeOwnership.Count(p => p.OwnerIdentifier.Equals(loadbalancer1.Identifier)), Is.EqualTo(0));

            // Start loadbalancer2 so that the loadbalancer claims a random partition until none are left.
            // All partitions should be immediately claimable even though they were just claimed by the loadbalancer1.

            for (int i = 0; i < NumberOfPartitions; i++)
            {
                await loadbalancer2.RunLoadBalancingAsync(partitionIds, tokenSource.Token);
            }

            completeOwnership = await partitionManager.ListOwnershipAsync(loadbalancer1.FullyQualifiedNamespace, loadbalancer1.EventHubName, loadbalancer1.ConsumerGroup);

            // All partitions are owned by loadbalancer2.

            Assert.That(completeOwnership.Count(p => p.OwnerIdentifier.Equals(loadbalancer2.Identifier)), Is.EqualTo(NumberOfPartitions));

            await loadbalancer2.RelinquishOwnershipAsync(tokenSource.Token);
        }

        /// <summary>
        ///   Verifies that claimable partitions are claimed by an <see cref="PartitionLoadBalancer" /> after RunAsync is called.
        /// </summary>
        ///
        [Test]
        public async Task RunLoadBalancingAsyncClaimsAllClaimablePartitions()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int NumberOfPartitions = 3;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Ownership should start empty.

            var completeOwnership = await partitionManager.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup);
            Assert.That(completeOwnership.Count(), Is.EqualTo(0));

            // Start the loadbalancer so that it claims a random partition until none are left.

            for (int i = 0; i < NumberOfPartitions; i++)
            {
                await loadbalancer.RunLoadBalancingAsync(partitionIds, tokenSource.Token);
            }

            completeOwnership = await partitionManager.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup);

            // All partitions are owned by loadbalancer2.

            Assert.That(completeOwnership.Count(), Is.EqualTo(NumberOfPartitions));

            await loadbalancer.RelinquishOwnershipAsync(tokenSource.Token);
        }

        /// <summary>
        ///   Verifies that partitions ownership load balancing will direct an <see cref="PartitionLoadBalancer" /> to claim ownership of a claimable partition
        ///   when it owns exactly the calculated MinimumOwnedPartitionsCount.
        /// </summary>
        ///
        [Test]
        public async Task RunLoadBalancingAsyncClaimsPartitionsWhenOwnedEqualsMinimumOwnedPartitionsCount()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int MinimumpartitionCount = 4;
            const int NumberOfPartitions = 13;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Create partitions owned by this loadbalancer.

            var loadbalancer1PartitionIds = Enumerable.Range(1, MinimumpartitionCount);
            var completeOwnership = CreatePartitionOwnership(loadbalancer1PartitionIds.Select(i => i.ToString()), loadbalancer.Identifier);

            // Create partitions owned by a different loadbalancer.

            var loadbalancer2Id = Guid.NewGuid().ToString();
            var loadbalancer2PartitionIds = Enumerable.Range(loadbalancer1PartitionIds.Max() + 1, MinimumpartitionCount);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(loadbalancer2PartitionIds.Select(i => i.ToString()), loadbalancer2Id));

            // Create partitions owned by a different loadbalancer.

            var loadbalancer3Id = Guid.NewGuid().ToString();
            var loadbalancer3PartitionIds = Enumerable.Range(loadbalancer2PartitionIds.Max() + 1, MinimumpartitionCount);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(loadbalancer3PartitionIds.Select(i => i.ToString()), loadbalancer3Id));

            // Seed the partitionManager with all partitions.

            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            var claimablePartitionIds = partitionIds.Except(completeOwnership.Select(p => p.PartitionId));

            // Get owned partitions.

            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            var ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);

            // Verify owned partitionIds match the owned partitions.

            Assert.That(ownedByloadbalancer1.Count(), Is.EqualTo(MinimumpartitionCount));
            Assert.That(ownedByloadbalancer1.Any(owned => claimablePartitionIds.Contains(owned.PartitionId)), Is.False);

            // Start the loadbalancer to claim owership from of a Partition even though ownedPartitionCount == MinimumOwnedPartitionsCount.

            await loadbalancer.RunLoadBalancingAsync(partitionIds, tokenSource.Token);

            // Get owned partitions.

            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);

            // Verify that we took ownership of the additional partition.

            Assert.That(ownedByloadbalancer1.Count(), Is.GreaterThan(MinimumpartitionCount));
            Assert.That(ownedByloadbalancer1.Any(owned => claimablePartitionIds.Contains(owned.PartitionId)), Is.True);

            await loadbalancer.RelinquishOwnershipAsync(tokenSource.Token);
        }

        /// <summary>
        ///   Verifies that partitions ownership load balancing will direct an <see cref="PartitionLoadBalancer" /> steal ownership of a partition
        ///   from another <see cref="PartitionLoadBalancer" /> the other loadbalancer owns greater than the calculated MaximumOwnedPartitionsCount.
        /// </summary>
        ///
        [Test]
        public async Task RunLoadBalancingAsyncStealsPartitionsWhenThisLoadbalancerOwnsMinPartitionsAndOtherLoadbalancerOwnsGreatherThanMaxPartitions()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int MinimumpartitionCount = 4;
            const int MaximumpartitionCount = 5;
            const int NumberOfPartitions = 14;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Create partitions owned by this loadbalancer.

            var loadbalancer1PartitionIds = Enumerable.Range(1, MinimumpartitionCount);
            var completeOwnership = CreatePartitionOwnership(loadbalancer1PartitionIds.Select(i => i.ToString()), loadbalancer.Identifier);

            // Create partitions owned by a different loadbalancer.

            var loadbalancer2Id = Guid.NewGuid().ToString();
            var loadbalancer2PartitionIds = Enumerable.Range(loadbalancer1PartitionIds.Max() + 1, MinimumpartitionCount);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(loadbalancer2PartitionIds.Select(i => i.ToString()), loadbalancer2Id));

            // Create partitions owned by a different loadbalancer above the MaximumPartitionCount.

            var loadbalancer3Id = Guid.NewGuid().ToString();
            var stealablePartitionIds = Enumerable.Range(loadbalancer2PartitionIds.Max() + 1, MaximumpartitionCount + 1);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(stealablePartitionIds.Select(i => i.ToString()), loadbalancer3Id));

            // Seed the partitionManager with the owned partitions.

            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            // Get owned partitions.

            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            var ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);
            var ownedByloadbalancer3 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer3Id);

            // Verify owned partitionIds match the owned partitions.

            Assert.That(ownedByloadbalancer1.Any(owned => stealablePartitionIds.Contains(int.Parse(owned.PartitionId))), Is.False);

            // Verify loadbalancer 3 has stealable partitions.

            Assert.That(ownedByloadbalancer3.Count(), Is.GreaterThan(MaximumpartitionCount));

            // Start the loadbalancer to steal owership from of a when ownedPartitionCount == MinimumOwnedPartitionsCount but a loadbalancer owns > MaximumPartitionCount.

            await loadbalancer.RunLoadBalancingAsync(partitionIds, tokenSource.Token);

            // Get owned partitions.

            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);
            ownedByloadbalancer3 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer3Id);

            // Verify that we took ownership of the additional partition.

            Assert.That(ownedByloadbalancer1.Any(owned => stealablePartitionIds.Contains(int.Parse(owned.PartitionId))), Is.True);

            // Verify loadbalancer 3 now does not own > MaximumPartitionCount.

            Assert.That(ownedByloadbalancer3.Count(), Is.EqualTo(MaximumpartitionCount));

            await loadbalancer.RelinquishOwnershipAsync(tokenSource.Token);
        }

        /// <summary>
        ///   Verifies that partitions ownership load balancing will direct an <see cref="PartitionLoadBalancer" /> steal ownership of a partition
        ///   from another <see cref="PartitionLoadBalancer" /> the other loadbalancer owns exactly the calculated MaximumOwnedPartitionsCount.
        /// </summary>
        ///
        [Test]
        public async Task RunLoadBalancingAsyncStealsPartitionsWhenThisLoadbalancerOwnsLessThanMinPartitionsAndOtherLoadbalancerOwnsMaxPartitions()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int MinimumpartitionCount = 4;
            const int MaximumpartitionCount = 5;
            const int NumberOfPartitions = 12;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Create more partitions owned by this loadbalancer.

            var loadbalancer1PartitionIds = Enumerable.Range(1, MinimumpartitionCount - 1);
            var completeOwnership = CreatePartitionOwnership(loadbalancer1PartitionIds.Select(i => i.ToString()), loadbalancer.Identifier);

            // Create more partitions owned by a different loadbalancer.

            var loadbalancer2Id = Guid.NewGuid().ToString();
            var loadbalancer2PartitionIds = Enumerable.Range(loadbalancer1PartitionIds.Max() + 1, MinimumpartitionCount);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(loadbalancer2PartitionIds.Select(i => i.ToString()), loadbalancer2Id));

            // Create more partitions owned by a different loadbalancer above the MaximumPartitionCount.

            var loadbalancer3Id = Guid.NewGuid().ToString();
            var stealablePartitionIds = Enumerable.Range(loadbalancer2PartitionIds.Max() + 1, MaximumpartitionCount);
            completeOwnership = completeOwnership
                .Concat(CreatePartitionOwnership(stealablePartitionIds.Select(i => i.ToString()), loadbalancer3Id));

            // Seed the partitionManager with the owned partitions.

            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            // Get owned partitions.

            var totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            var ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);
            var ownedByloadbalancer3 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer3Id);

            // Verify owned partitionIds match the owned partitions.

            Assert.That(ownedByloadbalancer1.Any(owned => stealablePartitionIds.Contains(int.Parse(owned.PartitionId))), Is.False);

            // Verify loadbalancer 3 has stealable partitions.

            Assert.That(ownedByloadbalancer3.Count(), Is.EqualTo(MaximumpartitionCount));

            // Start the loadbalancer to steal owership from of a when ownedPartitionCount == MinimumOwnedPartitionsCount but a loadbalancer owns > MaximumPartitionCount.

            await loadbalancer.RunLoadBalancingAsync(partitionIds, tokenSource.Token);

            // Get owned partitions.

            totalOwnedPartitions = await partitionManager.ListOwnershipAsync(loadbalancer.FullyQualifiedNamespace, loadbalancer.EventHubName, loadbalancer.ConsumerGroup);
            ownedByloadbalancer1 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer.Identifier);
            ownedByloadbalancer3 = totalOwnedPartitions.Where(p => p.OwnerIdentifier == loadbalancer3Id);

            // Verify that we took ownership of the additional partition.

            Assert.That(ownedByloadbalancer1.Any(owned => stealablePartitionIds.Contains(int.Parse(owned.PartitionId))), Is.True);

            // Verify loadbalancer 3 now does not own > MaximumPartitionCount.

            Assert.That(ownedByloadbalancer3.Count(), Is.LessThan(MaximumpartitionCount));

            await loadbalancer.RelinquishOwnershipAsync(tokenSource.Token);
        }

        /// <summary>
        ///   Verify logs for the <see cref="PartitionLoadBalancer" />.
        /// </summary>
        ///
        [Test]
        public async Task VerifiesEventProcessorLogs()
        {
            using CancellationTokenSource tokenSource = new CancellationTokenSource();
            const int NumberOfPartitions = 4;
            const int MinimumpartitionCount = NumberOfPartitions / 2;
            var partitionIds = Enumerable.Range(1, NumberOfPartitions).Select(p => p.ToString()).ToArray();
            var partitionManager = new MockCheckPointStorage((s) => Console.WriteLine(s));
            var loadbalancer = new PartitionLoadBalancer(
                partitionManager, Guid.NewGuid().ToString(), ConsumerGroup, FullyQualifiedNamespace, EventHubName, TimeSpan.FromMinutes(1));

            // Create more partitions owned by a different loadbalancer.

            var loadbalancer2Id = Guid.NewGuid().ToString();
            var completeOwnership = CreatePartitionOwnership(partitionIds.Skip(1), loadbalancer2Id);

            // Seed the partitionManager with the owned partitions.

            await partitionManager.ClaimOwnershipAsync(completeOwnership);

            var mockLog = new Mock<PartitionLoadBalancerEventSource>();
            loadbalancer.Logger = mockLog.Object;

            for (int i = 0; i < NumberOfPartitions; i++)
            {
                await loadbalancer.RunLoadBalancingAsync(partitionIds, tokenSource.Token);
            }

            await loadbalancer.RelinquishOwnershipAsync(tokenSource.Token);

            mockLog.Verify(m => m.RenewOwnershipStart(loadbalancer.Identifier));
            mockLog.Verify(m => m.RenewOwnershipComplete(loadbalancer.Identifier));
            mockLog.Verify(m => m.ClaimOwnershipStart(It.Is<string>(p => partitionIds.Contains(p))));
            mockLog.Verify(m => m.MinimumPartitionsPerEventProcessor(MinimumpartitionCount));
            mockLog.Verify(m => m.CurrentOwnershipCount(MinimumpartitionCount, loadbalancer.Identifier));
            mockLog.Verify(m => m.StealPartition(loadbalancer.Identifier));
            mockLog.Verify(m => m.ShouldStealPartition(loadbalancer.Identifier));
            mockLog.Verify(m => m.UnclaimedPartitions(It.Is<HashSet<string>>(p => p.Overlaps(partitionIds))));
        }

        /// <summary>
        ///   Creates a collection of <see cref="PartitionOwnership" /> based on the specified arguments.
        /// </summary>
        ///
        /// <param name="partitionIds">A collection of partition identifiers that the collection will be associated with.</param>
        /// <param name="identifier">The owner identifier of the EventProcessorClient owning the collection.</param>
        ///
        /// <returns>A collection of <see cref="PartitionOwnership" />.</returns>
        ///
        private IEnumerable<PartitionOwnership> CreatePartitionOwnership(IEnumerable<string> partitionIds,
                                                                          string identifier)
        {
            return partitionIds
                .Select(partitionId =>
                    new PartitionOwnership
                        (
                            FullyQualifiedNamespace,
                            EventHubName,
                            ConsumerGroup,
                            identifier,
                            partitionId,
                            DateTimeOffset.UtcNow,
                            Guid.NewGuid().ToString()
                        )).ToList();
        }
    }
}
