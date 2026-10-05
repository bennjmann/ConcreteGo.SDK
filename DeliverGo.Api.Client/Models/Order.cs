using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Order record returned by <c>/api/orders</c>. Scalar fields are mapped
    /// explicitly; the richer nested structures are surfaced as raw JSON so the
    /// client stays forward compatible with the frequently changing API schema.
    /// </summary>
    public sealed class Order
    {
        /// <summary>Identifier of the order.</summary>
        public string? Id { get; set; }

        /// <summary>Order number. Required by the API.</summary>
        public string? Number { get; set; }

        /// <summary>Date and time of the order. Required by the API.</summary>
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>Delivery address of the order.</summary>
        public string? DeliveryAddress { get; set; }

        /// <summary>Delivery address as originally supplied, before geocoding.</summary>
        public string? OriginalDeliveryAddress { get; set; }

        /// <summary>Region details of the delivery address.</summary>
        public JsonElement? Region { get; set; }

        /// <summary>Whether geocoding of the delivery address is still running.</summary>
        public bool? GeocodingInProgress { get; set; }

        /// <summary>Delivery location.</summary>
        public GeoPoint? Location { get; set; }

        /// <summary>Geofence radius around the delivery location.</summary>
        public double? Radius { get; set; }

        /// <summary>Item code of the ordered product.</summary>
        public string? ItemCode { get; set; }

        /// <summary>Ordered quantity.</summary>
        public double? Qty { get; set; }

        /// <summary>Status of the order.</summary>
        public string? Status { get; set; }

        /// <summary>Form of payment.</summary>
        public string? PaymentForm { get; set; }

        /// <summary>Whether the order is taxable.</summary>
        public bool? Taxable { get; set; }

        /// <summary>Reason code used when the order is not taxable.</summary>
        public string? NonTaxableReasonCode { get; set; }

        /// <summary>Tax rate applied to the order.</summary>
        public double? TaxRate { get; set; }

        /// <summary>Original order payload, retained when the order is modified.</summary>
        public JsonElement? Original { get; set; }

        /// <summary>Salesman code.</summary>
        public string? SalesmanCode { get; set; }

        /// <summary>Salesman name.</summary>
        public string? SalesmanName { get; set; }

        /// <summary>Usage code.</summary>
        public string? UsageCode { get; set; }

        /// <summary>Usage name.</summary>
        public string? UsageName { get; set; }

        /// <summary>Routes associated with the order.</summary>
        public JsonElement? Routes { get; set; }

        /// <summary>External system identifier.</summary>
        public string? ExternalId { get; set; }

        /// <summary>Identifier of the owning company.</summary>
        public string? CompanyId { get; set; }

        /// <summary>Identifier of the customer.</summary>
        public string? CustomerId { get; set; }

        /// <summary>Identifier of the project.</summary>
        public string? ProjectId { get; set; }

        /// <summary>Identifier of the user who last updated the order.</summary>
        public string? UpdatedBy { get; set; }

        /// <summary>Creation timestamp.</summary>
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>Last update timestamp.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>Any additional fields returned by the API.</summary>
        [JsonExtensionData]
        public IDictionary<string, JsonElement>? AdditionalData { get; set; }
    }
}
