using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.InventoryTransactions
{
    [XmlRoot(ElementName = "InventoryTransactionQueryRq")]
    public class InventoryTransactionOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? IDs { get; set; } = new List<int>();
        public bool ShouldSerializeIDs() => IDs != null && IDs.Count > 0;

        [XmlElement(ElementName = "DocumentNumber")]
        public List<string>? DocumentNumbers { get; set; } = new List<string>();
        public bool ShouldSerializeDocumentNumbers() => DocumentNumbers != null && DocumentNumbers.Count > 0;

        [XmlElement(ElementName = "LocationID")]
        public List<int>? LocationIDs { get; set; } = new List<int>();
        public bool ShouldSerializeLocationIDs() => LocationIDs != null && LocationIDs.Count > 0;

        [XmlElement(ElementName = "LocationCode")]
        public List<string>? LocationCodes { get; set; } = new List<string>();
        public bool ShouldSerializeLocationCodes() => LocationCodes != null && LocationCodes.Count > 0;

        [XmlElement(ElementName = "FromTransactionDate")]
        public DateTime? FromTransactionDate { get; set; }
        public bool ShouldSerializeFromTransactionDate() => FromTransactionDate.HasValue;

        [XmlElement(ElementName = "ToTransactionDate")]
        public DateTime? ToTransactionDate { get; set; }
        public bool ShouldSerializeToTransactionDate() => ToTransactionDate.HasValue;

        // RAWMATERIALRECEIPT|PURCHASEORDERRECEIPT|USAGE|TRANSFER|ITEMCONVERSION|QUANTITYADJUSTMENT
        [XmlElement(ElementName = "TransactionType")]
        public List<string>? TransactionTypes { get; set; } = new List<string>();
        public bool ShouldSerializeTransactionTypes() => TransactionTypes != null && TransactionTypes.Count > 0;

        // QUANTITYPOSTED|RELEASED|ONHOLD|POSTED|ABORTEDORREJECTED
        [XmlElement(ElementName = "PostStatus")]
        public List<string>? PostStatuses { get; set; } = new List<string>();
        public bool ShouldSerializePostStatuses() => PostStatuses != null && PostStatuses.Count > 0;
    }
}
