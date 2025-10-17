using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.InventoryTransactions
{
    [XmlRoot(ElementName = "InventoryTransactionRet")]
    public class InventoryTransactionRet
    {
        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }

        [XmlElement(ElementName = "DocumentNumber")]
        public string? DocumentNumber { get; set; }

        [XmlElement(ElementName = "LocationID")]
        public int? LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string? LocationCode { get; set; }

        [XmlElement(ElementName = "LocationName")]
        public string? LocationName { get; set; }

        [XmlElement(ElementName = "TransactionDate")]
        public DateTime? TransactionDate { get; set; }

        [XmlElement(ElementName = "TransactionType")]
        public string? TransactionType { get; set; }

        [XmlElement(ElementName = "PostStatus")]
        public string? PostStatus { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public int? ItemID { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public string? ItemCode { get; set; }

        [XmlElement(ElementName = "ItemDescription")]
        public string? ItemDescription { get; set; }

        [XmlElement(ElementName = "Quantity")]
        public decimal? Quantity { get; set; }

        [XmlElement(ElementName = "UnitOfMeasure")]
        public string? UnitOfMeasure { get; set; }

        [XmlElement(ElementName = "UnitCost")]
        public decimal? UnitCost { get; set; }

        [XmlElement(ElementName = "ExtendedCost")]
        public decimal? ExtendedCost { get; set; }

        [XmlElement(ElementName = "Reference")]
        public string? Reference { get; set; }

        [XmlElement(ElementName = "Notes")]
        public string? Notes { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }
    }
}