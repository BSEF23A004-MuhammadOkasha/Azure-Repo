// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LiveVideoAnalyticsEdgeClient.
    /// </summary>
    public static partial class LiveVideoAnalyticsEdgeClientExtensions
    {
            /// <summary>
            /// Retrieves a list of graph topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of graph topologies that have been added to the Live Video
            /// Analytics IoT Edge module.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static MediaGraphTopologyCollection GraphTopologyList(this ILiveVideoAnalyticsEdgeClient operations)
            {
                return operations.GraphTopologyListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of graph topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of graph topologies that have been added to the Live Video
            /// Analytics IoT Edge module.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphTopologyCollection> GraphTopologyListAsync(this ILiveVideoAnalyticsEdgeClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphTopologyListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a graph topology.
            /// </summary>
            /// <remarks>
            /// Creates a new topology or updates an existing one, with the given name. A
            /// topology is a blueprint defining what nodes are in a graph, and how they
            /// are interconnected.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='topology'>
            /// </param>
            public static MediaGraphTopology GraphTopologySet(this ILiveVideoAnalyticsEdgeClient operations, MediaGraphTopology topology)
            {
                return operations.GraphTopologySetAsync(topology).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a graph topology.
            /// </summary>
            /// <remarks>
            /// Creates a new topology or updates an existing one, with the given name. A
            /// topology is a blueprint defining what nodes are in a graph, and how they
            /// are interconnected.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='topology'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphTopology> GraphTopologySetAsync(this ILiveVideoAnalyticsEdgeClient operations, MediaGraphTopology topology, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphTopologySetWithHttpMessagesAsync(topology, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a graph topology by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a graph topology by name. If a topology with that name has been
            /// previously set, then the call will return the JSON representation of that
            /// topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph topology to be retrieved.
            /// </param>
            public static MediaGraphTopology GraphTopologyGet(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                return operations.GraphTopologyGetAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a graph topology by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a graph topology by name. If a topology with that name has been
            /// previously set, then the call will return the JSON representation of that
            /// topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph topology to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphTopology> GraphTopologyGetAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphTopologyGetWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a graph topology.
            /// </summary>
            /// <remarks>
            /// Deletes a graph topology with the given name. This method should be called
            /// after all instances of the topology have been stopped and deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph topology to be deleted.
            /// </param>
            public static void GraphTopologyDelete(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                operations.GraphTopologyDeleteAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a graph topology.
            /// </summary>
            /// <remarks>
            /// Deletes a graph topology with the given name. This method should be called
            /// after all instances of the topology have been stopped and deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph topology to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GraphTopologyDeleteAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GraphTopologyDeleteWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a list of graph instances.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of graph instances, if any, that have been created in the
            /// Live Video Analytics IoT Edge module.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static MediaGraphInstanceCollection GraphInstanceList(this ILiveVideoAnalyticsEdgeClient operations)
            {
                return operations.GraphInstanceListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of graph instances.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of graph instances, if any, that have been created in the
            /// Live Video Analytics IoT Edge module.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphInstanceCollection> GraphInstanceListAsync(this ILiveVideoAnalyticsEdgeClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphInstanceListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a graph instance.
            /// </summary>
            /// <remarks>
            /// Creates or updates a graph instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instance'>
            /// </param>
            public static MediaGraphInstance GraphInstanceSet(this ILiveVideoAnalyticsEdgeClient operations, MediaGraphInstance instance)
            {
                return operations.GraphInstanceSetAsync(instance).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a graph instance.
            /// </summary>
            /// <remarks>
            /// Creates or updates a graph instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instance'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphInstance> GraphInstanceSetAsync(this ILiveVideoAnalyticsEdgeClient operations, MediaGraphInstance instance, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphInstanceSetWithHttpMessagesAsync(instance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a graph instance by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a  graph instance by name. If a graph instance with that name has
            /// been previously created, then the direct method call will return the JSON
            /// representation of that instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be retrieved.
            /// </param>
            public static MediaGraphInstance GraphInstanceGet(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                return operations.GraphInstanceGetAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a graph instance by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a  graph instance by name. If a graph instance with that name has
            /// been previously created, then the direct method call will return the JSON
            /// representation of that instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MediaGraphInstance> GraphInstanceGetAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GraphInstanceGetWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a graph instance.
            /// </summary>
            /// <remarks>
            /// Deletes a graph instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be deleted.
            /// </param>
            public static void GraphInstanceDelete(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                operations.GraphInstanceDeleteAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a graph instance.
            /// </summary>
            /// <remarks>
            /// Deletes a graph instance.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GraphInstanceDeleteAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GraphInstanceDeleteWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Activate a given graph instance.
            /// </summary>
            /// <remarks>
            /// Activates a graph instance with the name provided, if it exists.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be activated.
            /// </param>
            public static void GraphInstanceActivate(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                operations.GraphInstanceActivateAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activate a given graph instance.
            /// </summary>
            /// <remarks>
            /// Activates a graph instance with the name provided, if it exists.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be activated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GraphInstanceActivateAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GraphInstanceActivateWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deactivate a graph instance.
            /// </summary>
            /// <remarks>
            /// Deactivates a graph instance with the name provided, if it is active.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be deactivated.
            /// </param>
            public static void GraphInstanceDeactivate(this ILiveVideoAnalyticsEdgeClient operations, string name)
            {
                operations.GraphInstanceDeactivateAsync(name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deactivate a graph instance.
            /// </summary>
            /// <remarks>
            /// Deactivates a graph instance with the name provided, if it is active.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the graph instance to be deactivated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GraphInstanceDeactivateAsync(this ILiveVideoAnalyticsEdgeClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GraphInstanceDeactivateWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
