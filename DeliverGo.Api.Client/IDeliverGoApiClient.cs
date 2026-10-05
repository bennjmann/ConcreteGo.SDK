using DeliverGo.Api.Client.Models;

namespace DeliverGo.Api.Client
{
    /// <summary>
    /// Read access to the DeliverGo (iSTRADA.net) API.
    /// </summary>
    public interface IDeliverGoApiClient
    {
        /// <summary>Gets snail trail records.</summary>
        Task<IReadOnlyList<SnailTrail>> GetSnailTrailsAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets a single snail trail record by identifier.</summary>
        Task<SnailTrail?> GetSnailTrailAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets tickets.</summary>
        Task<IReadOnlyList<Ticket>> GetTicketsAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets a single ticket by identifier.</summary>
        Task<Ticket?> GetTicketAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets trucks.</summary>
        Task<IReadOnlyList<Truck>> GetTrucksAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets a single truck by identifier.</summary>
        Task<Truck?> GetTruckAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets orders.</summary>
        Task<IReadOnlyList<Order>> GetOrdersAsync(DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Gets a single order by identifier.</summary>
        Task<Order?> GetOrderAsync(string id, DeliverGoFilter? filter = null, CancellationToken cancellationToken = default);

        /// <summary>Creates a new order.</summary>
        Task<Order> CreateOrderAsync(Order order, CancellationToken cancellationToken = default);

        /// <summary>Updates the attributes of an existing order.</summary>
        Task<Order> UpdateOrderAsync(string id, Order order, CancellationToken cancellationToken = default);

        /// <summary>Deletes an order by identifier.</summary>
        Task DeleteOrderAsync(string id, CancellationToken cancellationToken = default);
    }
}
