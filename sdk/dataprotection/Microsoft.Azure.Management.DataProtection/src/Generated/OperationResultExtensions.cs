// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OperationResult.
    /// </summary>
    public static partial class OperationResultExtensions
    {
            /// <summary>
            /// Gets the operation status for a resource.
            /// </summary>
            /// <remarks>
            /// Gets the operation result for a resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='location'>
            /// </param>
            public static void Get(this IOperationResult operations, string operationId, string location)
            {
                operations.GetAsync(operationId, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the operation status for a resource.
            /// </summary>
            /// <remarks>
            /// Gets the operation result for a resource
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync(this IOperationResult operations, string operationId, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(operationId, location, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
