namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Geographic coordinate pair.
    /// </summary>
    public sealed class GeoPoint
    {
        /// <summary>Latitude.</summary>
        public double? Lat { get; set; }

        /// <summary>Longitude.</summary>
        public double? Lng { get; set; }
    }
}
