using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Items
{
    [XmlRoot(ElementName = "ItemQueryRq")]
    public class ItemRequestOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? IDs { get; set; } = new List<int>();
        public bool ShouldSerializeIDs() => IDs != null && IDs.Count > 0;

        [XmlElement(ElementName = "Code")]
        public List<string>? Codes { get; set; } = new List<string>();
        public bool ShouldSerializeCodes() => Codes != null && Codes.Count > 0;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

        [XmlElement(ElementName = "LocationCode")]
        public List<string>? LocationCodes { get; set; } = new List<string>();
        public bool ShouldSerializeLocationCodes() => LocationCodes != null && LocationCodes.Count > 0;

        [XmlElement(ElementName = "CategoryID")]
        public List<int>? CategoryIds { get; set; } = new List<int>();
        public bool ShouldSerializeCategoryIds() => CategoryIds != null && CategoryIds.Count > 0;

        [XmlElement(ElementName = "CategoryCode")]
        public List<string>? CategoryCodes { get; set; } = new List<string>();
        public bool ShouldSerializeCategoryCodes() => CategoryCodes != null && CategoryCodes.Count > 0;

        [XmlElement(ElementName = "ItemTypeID")]
        public List<int>? ItemTypeIds { get; set; } = new List<int>();
        public bool ShouldSerializeItemTypeIds() => ItemTypeIds != null && ItemTypeIds.Count > 0;

        [XmlElement(ElementName = "ItemType")]
        public List<string>? ItemTypes { get; set; } = new List<string>();
        public bool ShouldSerializeItemTypes() => ItemTypes != null && ItemTypes.Count > 0;

        [XmlElement(ElementName = "IsConstituent")]
        public bool? IsConstituent { get; set; }
        public bool ShouldSerializeIsConstituent() => IsConstituent.HasValue;

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }
        public bool ShouldSerializeKeepInInventory() => KeepInInventory.HasValue;

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }
        public bool ShouldSerializeResaleable() => Resaleable.HasValue;

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }
        public bool ShouldSerializeDoNotAllowTicketing() => DoNotAllowTicketing.HasValue;

        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }
        public bool ShouldSerializeTaxable() => Taxable.HasValue;

        [XmlElement(ElementName = "FromUpdateDate")]
        public DateTime? FromUpdateDate { get; set; }
        public bool ShouldSerializeFromUpdateDate() => FromUpdateDate.HasValue;

        [XmlElement(ElementName = "ToUpdateDate")]
        public DateTime? ToUpdateDate { get; set; }
        public bool ShouldSerializeToUpdateDate() => ToUpdateDate.HasValue;

        [XmlElement(ElementName = "FromCreateDate")]
        public DateTime? FromCreateDate { get; set; }
        public bool ShouldSerializeFromCreateDate() => FromCreateDate.HasValue;

        [XmlElement(ElementName = "ToCreateDate")]
        public DateTime? ToCreateDate { get; set; }
        public bool ShouldSerializeToCreateDate() => ToCreateDate.HasValue;

        [XmlElement(ElementName = "MaxReturned")]
        public int? MaxReturned { get; set; }
        public bool ShouldSerializeMaxReturned() => MaxReturned.HasValue;
        //OCATION|COST|PRICING|MIXDESIGN|BATCHING|TAXOVERRIDE|BATCHCODE|AUTOPRODUCT

        [XmlElement(ElementName = "IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; } = new List<string>();
        public bool ShouldSerializeIncludeRetElement() => IncludeRetElement != null && IncludeRetElement.Count > 0;
    }
}
