using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// Delivery ticket returned by <c>/api/tickets</c>. Scalar fields are mapped
    /// explicitly; the richer nested structures are surfaced as raw JSON so the
    /// client stays forward compatible with the frequently changing API schema.
    /// </summary>
    public sealed class Ticket
    {
        /// <summary>Identifier of the ticket.</summary>
        public string? Id { get; set; }

        /// <summary>Ticket number. Required by the API.</summary>
        public string? TicketNumber { get; set; }

        /// <summary>Plant number. Required by the API.</summary>
        public string? PlantNumber { get; set; }

        /// <summary>Plant number the load was scheduled from.</summary>
        public string? SchedulePlantNumber { get; set; }

        /// <summary>Plant number the truck returned to.</summary>
        public string? ReturnPlantNumber { get; set; }

        /// <summary>Truck number carrying the load.</summary>
        public string? TruckNumber { get; set; }

        /// <summary>Previous truck number, when the load was reassigned.</summary>
        public string? PreviousTruckNumber { get; set; }

        /// <summary>Date and time of the ticket.</summary>
        public DateTimeOffset? TicketDate { get; set; }

        /// <summary>Date and time of the order.</summary>
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>Scheduled start time.</summary>
        public DateTimeOffset? ScheduleStartTime { get; set; }

        /// <summary>Driver number.</summary>
        public string? DriverNumber { get; set; }

        /// <summary>Driver name.</summary>
        public string? DriverName { get; set; }

        /// <summary>Customer purchase order number.</summary>
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>Order number.</summary>
        public string? OrderNumber { get; set; }

        /// <summary>Requested time on the job site.</summary>
        public string? TimeDueOnJob { get; set; }

        /// <summary>Tax code applied to the ticket.</summary>
        public string? TaxCode { get; set; }

        /// <summary>Ticket subtotal.</summary>
        public double? TicketSubTotal { get; set; }

        /// <summary>Ticket tax total.</summary>
        public double? TicketTaxTotal { get; set; }

        /// <summary>Ticket grand total.</summary>
        public double? TicketGrandTotal { get; set; }

        /// <summary>Running order total.</summary>
        public double? OrderSumTotal { get; set; }

        /// <summary>Currency code of the monetary amounts.</summary>
        public string? Currency { get; set; }

        /// <summary>Delivery zone.</summary>
        public string? Zone { get; set; }

        /// <summary>Special instructions printed on the ticket.</summary>
        public string? SpecialInstructions { get; set; }

        /// <summary>Whether weights are printed.</summary>
        public bool? PrintWeights { get; set; }

        /// <summary>Whether the ticket uses metric units.</summary>
        public bool? IsMetric { get; set; }

        /// <summary>Whether the ticket has been voided.</summary>
        public bool? Voided { get; set; }

        /// <summary>Reason the ticket was voided.</summary>
        public string? VoidedReason { get; set; }

        /// <summary>Last known truck position for the ticket.</summary>
        public GeoPoint? TruckLocation { get; set; }

        /// <summary>Truck telemetry associated with the ticket.</summary>
        public TruckMetrics? TruckMetrics { get; set; }

        /// <summary>Identifier of the truck.</summary>
        public string? TruckId { get; set; }

        /// <summary>Identifier of the device that produced the ticket.</summary>
        public string? DeviceId { get; set; }

        /// <summary>Identifier of the owning company.</summary>
        public string? CompanyId { get; set; }

        /// <summary>Identifier of the plant.</summary>
        public string? PlantId { get; set; }

        /// <summary>Identifier of the scheduling plant.</summary>
        public string? SchedulePlantId { get; set; }

        /// <summary>Identifier of the return plant.</summary>
        public string? ReturnPlantId { get; set; }

        /// <summary>Identifier of the customer.</summary>
        public string? CustomerId { get; set; }

        /// <summary>Identifier of the order.</summary>
        public string? OrderId { get; set; }

        /// <summary>Identifier of the project.</summary>
        public string? ProjectId { get; set; }

        /// <summary>Identifier of the employee.</summary>
        public string? EmployeeId { get; set; }

        /// <summary>Ticket status details.</summary>
        public JsonElement? Status { get; set; }

        /// <summary>Customer details captured on the ticket.</summary>
        public JsonElement? Customer { get; set; }

        /// <summary>Order details captured on the ticket.</summary>
        public JsonElement? Order { get; set; }

        /// <summary>Delivery details.</summary>
        public JsonElement? Delivery { get; set; }

        /// <summary>Mix details.</summary>
        public JsonElement? Mix { get; set; }

        /// <summary>Mix design details.</summary>
        public JsonElement? MixDesign { get; set; }

        /// <summary>Products on the ticket.</summary>
        public JsonElement? Products { get; set; }

        /// <summary>Water records.</summary>
        public JsonElement? Water { get; set; }

        /// <summary>On site activity.</summary>
        public JsonElement? OnSite { get; set; }

        /// <summary>At plant activity.</summary>
        public JsonElement? AtPlant { get; set; }

        /// <summary>In transit activity.</summary>
        public JsonElement? InTransit { get; set; }

        /// <summary>Batch results.</summary>
        public JsonElement? BatchResult { get; set; }

        /// <summary>Inspection details.</summary>
        public JsonElement? Inspection { get; set; }

        /// <summary>Ticket metrics.</summary>
        public JsonElement? Metrics { get; set; }

        /// <summary>Custom fields configured for the account.</summary>
        public JsonElement? CustomFields { get; set; }

        /// <summary>Creation timestamp.</summary>
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>Last update timestamp.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>Any additional fields returned by the API.</summary>
        [JsonExtensionData]
        public IDictionary<string, JsonElement>? AdditionalData { get; set; }
    }
}
