namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Telemetry metrics reported by a truck.
    /// </summary>
    public sealed class TruckMetrics
    {
        /// <summary>Identifier of the metrics record.</summary>
        public string? Id { get; set; }

        /// <summary>Heading in degrees.</summary>
        public double? Course { get; set; }

        /// <summary>Speed reported by the device.</summary>
        public double? Speed { get; set; }

        /// <summary>Timestamp the metrics were captured.</summary>
        public DateTimeOffset? MetricsDate { get; set; }
    }
}
