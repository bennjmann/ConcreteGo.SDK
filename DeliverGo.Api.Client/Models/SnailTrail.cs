using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Historical truck position record returned by <c>/api/snailTrails</c>.
    /// </summary>
    public sealed class SnailTrail
    {
        /// <summary>Identifier of the snail trail record.</summary>
        public string? Id { get; set; }

        /// <summary>Truck status at the time the record was captured.</summary>
        public string? Status { get; set; }

        /// <summary>Recorded position.</summary>
        public GeoPoint? Location { get; set; }

        /// <summary>Raw location payload reported by the device.</summary>
        public JsonElement? LocationData { get; set; }

        /// <summary>Whether the truck was in service.</summary>
        public bool? InService { get; set; }

        /// <summary>Whether the truck was inside the yard.</summary>
        public bool? InYard { get; set; }

        /// <summary>Deadhead state.</summary>
        public string? Deadhead { get; set; }

        /// <summary>Identifier of the truck.</summary>
        public string? TruckId { get; set; }

        /// <summary>Identifier of the associated ticket.</summary>
        public string? TicketId { get; set; }

        /// <summary>Identifier of the owning company.</summary>
        public string? CompanyId { get; set; }

        /// <summary>Telemetry captured with the record.</summary>
        public TruckMetrics? Metrics { get; set; }

        /// <summary>Creation timestamp.</summary>
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>Last update timestamp.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>Any additional fields returned by the API.</summary>
        [JsonExtensionData]
        public IDictionary<string, JsonElement>? AdditionalData { get; set; }
    }
}
