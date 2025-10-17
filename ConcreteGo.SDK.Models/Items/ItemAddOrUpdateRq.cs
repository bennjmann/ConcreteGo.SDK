using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Items
{
    [XmlRoot(ElementName = "ItemUpdate", Namespace = "")]
    public class ItemAddOrUpdateRq
    {
        [XmlElement(ElementName = "Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() => ID.HasValue;

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [XmlElement(ElementName = "CategoryCode")]
        public string? CategoryCode { get; set; }
        public bool ShouldSerializeCategoryCode() => !string.IsNullOrEmpty(CategoryCode);

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() => !string.IsNullOrEmpty(ShortDescription);

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeItemTypeID() => ItemTypeID.HasValue;

        [XmlElement(ElementName = "ItemType")]
        public string? ItemType { get; set; }
        public bool ShouldSerializeItemType() => !string.IsNullOrEmpty(ItemType);

        [XmlElement(ElementName = "Constituent")]
        public bool? Constituent { get; set; }
        public bool ShouldSerializeConstituent() => Constituent.HasValue;

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }
        public bool ShouldSerializeResaleable() => Resaleable.HasValue;

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }
        public bool ShouldSerializeKeepInInventory() => KeepInInventory.HasValue;

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }
        public bool ShouldSerializeDoNotAllowTicketing() => DoNotAllowTicketing.HasValue;

        [XmlElement(ElementName = "IsConstituent")]
        public bool? IsConstituent { get; set; }
        public bool ShouldSerializeIsConstituent() => IsConstituent.HasValue;

        [XmlElement(ElementName = "IsResaleable")]
        public bool? IsResaleable { get; set; }
        public bool ShouldSerializeIsResaleable() => IsResaleable.HasValue;

        [XmlElement(ElementName = "AccountLinkCode")]
        public string? AccountLinkCode { get; set; }
        public bool ShouldSerializeAccountLinkCode() => !string.IsNullOrEmpty(AccountLinkCode);

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string? CategoryAccountLinkCode { get; set; }
        public bool ShouldSerializeCategoryAccountLinkCode() => !string.IsNullOrEmpty(CategoryAccountLinkCode);

        [XmlElement(ElementName = "ProductLink")]
        public string? ProductLink { get; set; }
        public bool ShouldSerializeProductLink() => !string.IsNullOrEmpty(ProductLink);

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() => SetupDate.HasValue;

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }
        public bool ShouldSerializeUpdateDate() => UpdateDate.HasValue;

        [XmlElement(ElementName = "UOM")]
        public UOM? UOM { get; set; }
        public bool ShouldSerializeUOM() => UOM != null;

        [XmlElement(ElementName = "Sales")]
        public SalesRequest? Sales { get; set; }
        public bool ShouldSerializeSales() => Sales != null;

        [XmlElement(ElementName = "Mix")]
        public Mix? Mix { get; set; }
        public bool ShouldSerializeMix() => Mix != null;

        [XmlElement(ElementName = "Locations")]
        public Locations? Locations { get; set; }
        public bool ShouldSerializeLocations() => Locations != null;

        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides? TaxOverrides { get; set; }
        public bool ShouldSerializeTaxOverrides() => TaxOverrides != null;

        // Include Ret
        public List<string> IncludeRetElement { get; set; } = new List<string>();
        public bool ShouldSerializeIncludeRetElement() => IncludeRetElement.Count > 0;
    }

    [XmlRoot(ElementName = "Sales")]
    public class SalesRequest
    {
        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }
        public bool ShouldSerializeTaxable() => Taxable.HasValue;

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool? TradeDiscountable { get; set; }
        public bool ShouldSerializeTradeDiscountable() => TradeDiscountable.HasValue;

        [XmlElement(ElementName = "TermDiscountable")]
        public bool? TermDiscountable { get; set; }
        public bool ShouldSerializeTermDiscountable() => TermDiscountable.HasValue;

        [XmlElement(ElementName = "UsageCode")]
        public string? UsageCode { get; set; }
        public bool ShouldSerializeUsageCode() => !string.IsNullOrEmpty(UsageCode);

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; }
        public bool ShouldSerializeNonTaxableReasonCode() => !string.IsNullOrEmpty(NonTaxableReasonCode);

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }
        public bool ShouldSerializeExpirationDate() => ExpirationDate.HasValue;
    }
}
