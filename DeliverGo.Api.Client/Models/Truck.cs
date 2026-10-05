using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Truck record returned by <c>/api/trucks</c>.
    /// </summary>
    public sealed class Truck
    {
        /// <summary>Identifier of the truck.</summary>
        public string? Id { get; set; }

        /// <summary>Truck number. Required by the API.</summary>
        public string? Number { get; set; }

        /// <summary>Free form description.</summary>
        public string? Description { get; set; }

        /// <summary>Last known position.</summary>
        public GeoPoint? Location { get; set; }

        /// <summary>Raw location payload reported by the device.</summary>
        public JsonElement? LocationData { get; set; }

        /// <summary>Whether the truck is in service.</summary>
        public bool? InService { get; set; }

        /// <summary>Whether the truck is inside the yard.</summary>
        public bool? InYard { get; set; }

        /// <summary>Deadhead state.</summary>
        public string? Deadhead { get; set; }

        /// <summary>Whether the truck has ended its day.</summary>
        public bool? EndOfDay { get; set; }

        /// <summary>Timestamp of the last device access.</summary>
        public DateTimeOffset? LastAccess { get; set; }

        /// <summary>External system identifier.</summary>
        public string? ExternalId { get; set; }

        /// <summary>Identifier of the owning company.</summary>
        public string? CompanyId { get; set; }

        /// <summary>Identifier of the division.</summary>
        public string? DivisionId { get; set; }

        /// <summary>Identifier of the home plant.</summary>
        public string? PlantId { get; set; }

        /// <summary>Identifier of the plant the truck is currently at.</summary>
        public string? CurrentPlantId { get; set; }

        /// <summary>Latest telemetry.</summary>
        public TruckMetrics? Metrics { get; set; }

        /// <summary>Preventative maintenance notification settings.</summary>
        public JsonElement? PreventativeNotifications { get; set; }

        /// <summary>Creation timestamp.</summary>
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>Last update timestamp.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>Any additional fields returned by the API.</summary>
        [JsonExtensionData]
        public IDictionary<string, JsonElement>? AdditionalData { get; set; }
    }
}
