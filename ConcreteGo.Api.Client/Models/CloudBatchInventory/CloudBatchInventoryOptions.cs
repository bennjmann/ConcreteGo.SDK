using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.CloudBatchInventory
{
    [XmlRoot(ElementName = "BatchInventoryQueryRq")]
    public class CloudBatchInventoryOptions
    {
        [XmlElement(ElementName = "ItemID")]
        public List<int>? ItemIDs { get; set; } = new List<int>();
        public bool ShouldSerializeItemIDs() => ItemIDs != null && ItemIDs.Count > 0;

        [XmlElement(ElementName = "ItemCode")]
        public List<string>? ItemCodes { get; set; } = new List<string>();
        public bool ShouldSerializeItemCodes() => ItemCodes != null && ItemCodes.Count > 0;

        [XmlElement(ElementName = "PlantID")]
        public List<int>? PlantIDs { get; set; } = new List<int>();
        public bool ShouldSerializePlantIDs() => PlantIDs != null && PlantIDs.Count > 0;

        [XmlElement(ElementName = "PlantCode")]
        public List<string>? PlantCodes { get; set; } = new List<string>();
        public bool ShouldSerializePlantCodes() => PlantCodes != null && PlantCodes.Count > 0;

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

        [XmlElement(ElementName = "TransactionType")]
        public List<string>? TransactionTypes { get; set; } = new List<string>();
        public bool ShouldSerializeTransactionTypes() => TransactionTypes != null && TransactionTypes.Count > 0;
    }
}
