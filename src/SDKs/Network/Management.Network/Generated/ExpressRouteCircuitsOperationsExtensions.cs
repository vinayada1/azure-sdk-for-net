// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace compositeNetworkClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteCircuitsOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            public static void Delete(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName)
            {
                operations.DeleteAsync(resourceGroupName, circuitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of express route circuit.
            /// </param>
            public static ExpressRouteCircuit Get(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName)
            {
                return operations.GetAsync(resourceGroupName, circuitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of express route circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuit> GetAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update express route circuit
            /// operation.
            /// </param>
            public static ExpressRouteCircuit CreateOrUpdate(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, ExpressRouteCircuit parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, circuitName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update express route circuit
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuit> CreateOrUpdateAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsArpTableListResult ListArpTable(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.ListArpTableAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsArpTableListResult> ListArpTableAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListArpTableWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableListResult ListRoutesTable(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.ListRoutesTableAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResult> ListRoutesTableAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRoutesTableWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table summary associated with the
            /// express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableSummaryListResult ListRoutesTableSummary(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.ListRoutesTableSummaryAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table summary associated with the
            /// express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableSummaryListResult> ListRoutesTableSummaryAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRoutesTableSummaryWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the stats from an express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            public static ExpressRouteCircuitStats GetStats(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName)
            {
                return operations.GetStatsAsync(resourceGroupName, circuitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the stats from an express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitStats> GetStatsAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatsWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all stats from an express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static ExpressRouteCircuitStats GetPeeringStats(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                return operations.GetPeeringStatsAsync(resourceGroupName, circuitName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all stats from an express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitStats> GetPeeringStatsAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPeeringStatsWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the express route circuits in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ExpressRouteCircuit> List(this IExpressRouteCircuitsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the express route circuits in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuit>> ListAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the express route circuits in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ExpressRouteCircuit> ListAll(this IExpressRouteCircuitsOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the express route circuits in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuit>> ListAllAsync(this IExpressRouteCircuitsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            public static void BeginDelete(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName)
            {
                operations.BeginDeleteAsync(resourceGroupName, circuitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update express route circuit
            /// operation.
            /// </param>
            public static ExpressRouteCircuit BeginCreateOrUpdate(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, ExpressRouteCircuit parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, circuitName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update express route circuit
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuit> BeginCreateOrUpdateAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsArpTableListResult BeginListArpTable(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.BeginListArpTableAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised ARP table associated with the express route
            /// circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsArpTableListResult> BeginListArpTableAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListArpTableWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableListResult BeginListRoutesTable(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.BeginListRoutesTableAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResult> BeginListRoutesTableAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListRoutesTableWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table summary associated with the
            /// express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableSummaryListResult BeginListRoutesTableSummary(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath)
            {
                return operations.BeginListRoutesTableSummaryAsync(resourceGroupName, circuitName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table summary associated with the
            /// express route circuit in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableSummaryListResult> BeginListRoutesTableSummaryAsync(this IExpressRouteCircuitsOperations operations, string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListRoutesTableSummaryWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the express route circuits in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRouteCircuit> ListNext(this IExpressRouteCircuitsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the express route circuits in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuit>> ListNextAsync(this IExpressRouteCircuitsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the express route circuits in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRouteCircuit> ListAllNext(this IExpressRouteCircuitsOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the express route circuits in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuit>> ListAllNextAsync(this IExpressRouteCircuitsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
