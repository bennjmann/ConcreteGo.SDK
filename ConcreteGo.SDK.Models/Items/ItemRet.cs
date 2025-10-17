using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Items
{
    [XmlRoot("ItemRet")]
    public class ItemRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryCode")]
        public string CategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "Constituent")]
        public bool? Constituent { get; set; }

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; } = string.Empty;

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string CategoryAccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ProductLink")]
        public string ProductLink { get; set; } = string.Empty;

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }

        [XmlElement(ElementName = "UOM")]
        public UOM UOM { get; set; } = null!;

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;

        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides TaxOverrides { get; set; } = null!;

        [XmlElement(ElementName = "Action")]
        public string Action { get; set; } = string.Empty;
    }

    [XmlRoot("TaxOverrides")]
    public class TaxOverrides
    {
        [XmlElement("TaxOverride")]
        public List<TaxOverride> TaxOverride { get; set; } = null!;
    }

    [XmlRoot("TaxOverride")]
    public class TaxOverride
    {
        [XmlElement("TaxAuthorityID")]
        public int TaxAuthorityID { get; set; }

        [XmlElement("TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; } = string.Empty;

        [XmlElement("TaxLocationID")]
        public int? TaxLocationID { get; set; }

        [XmlElement("TaxLocationCode")]
        public string TaxLocationCode { get; set; } = string.Empty;

        [XmlElement("OverrideTaxable")]
        public bool? OverrideTaxable { get; set; }

        [XmlElement("OverrideTaxRateLocationID")]
        public int? OverrideTaxRateLocationID { get; set; }

        [XmlElement("OverrideTaxRateLocationCode")]
        public string OverrideTaxRateLocationCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "UOM")]
    public class UOM
    {
        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() => ID.HasValue;

        [XmlElement(ElementName = "OrderedQuantityUnitCode")]
        public string? OrderedQuantityUnitCode { get; set; }
        public bool ShouldSerializeOrderedQuantityUnitCode() => !string.IsNullOrEmpty(OrderedQuantityUnitCode);

        [XmlElement(ElementName = "OrderedQuantityUnit")]
        public string? OrderedQuantityUnit { get; set; }
        public bool ShouldSerializeOrderedQuantityUnit() => !string.IsNullOrEmpty(OrderedQuantityUnit);

        [XmlElement(ElementName = "OrderedExtensionCode")]
        public string? OrderedExtensionCode { get; set; }
        public bool ShouldSerializeOrderedExtensionCode() => !string.IsNullOrEmpty(OrderedExtensionCode);

        [XmlElement(ElementName = "DeliveredQuantityUnitCode")]
        public string? DeliveredQuantityUnitCode { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnitCode() => !string.IsNullOrEmpty(DeliveredQuantityUnitCode);

        [XmlElement(ElementName = "DeliveredQuantityUnit")]
        public string? DeliveredQuantityUnit { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnit() => !string.IsNullOrEmpty(DeliveredQuantityUnit);

        [XmlElement(ElementName = "TicketExtensionCode")]
        public string? TicketExtensionCode { get; set; }
        public bool ShouldSerializeTicketExtensionCode() => !string.IsNullOrEmpty(TicketExtensionCode);

        [XmlElement(ElementName = "PriceQuantityUnitCode")]
        public string? PriceQuantityUnitCode { get; set; }
        public bool ShouldSerializePriceQuantityUnitCode() => !string.IsNullOrEmpty(PriceQuantityUnitCode);

        [XmlElement(ElementName = "PriceQuantityUnit")]
        public string? PriceQuantityUnit { get; set; }
        public bool ShouldSerializePriceQuantityUnit() => !string.IsNullOrEmpty(PriceQuantityUnit);

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
        public bool ShouldSerializePriceExtensionCode() => !string.IsNullOrEmpty(PriceExtensionCode);

        [XmlElement(ElementName = "BatchUnitCode")]
        public string? BatchUnitCode { get; set; }
        public bool ShouldSerializeBatchUnitCode() => !string.IsNullOrEmpty(BatchUnitCode);

        [XmlElement(ElementName = "BatchUnit")]
        public string? BatchUnit { get; set; }
        public bool ShouldSerializeBatchUnit() => !string.IsNullOrEmpty(BatchUnit);

        [XmlElement(ElementName = "InventoryUnitCode")]
        public string? InventoryUnitCode { get; set; }
        public bool ShouldSerializeInventoryUnitCode() => !string.IsNullOrEmpty(InventoryUnitCode);

        [XmlElement(ElementName = "InventoryUnit")]
        public string? InventoryUnit { get; set; }
        public bool ShouldSerializeInventoryUnit() => !string.IsNullOrEmpty(InventoryUnit);

        [XmlElement(ElementName = "PurchaseUnitCode")]
        public string? PurchaseUnitCode { get; set; }
        public bool ShouldSerializePurchaseUnitCode() => !string.IsNullOrEmpty(PurchaseUnitCode);

        [XmlElement(ElementName = "PurchaseUnit")]
        public string? PurchaseUnit { get; set; }
        public bool ShouldSerializePurchaseUnit() => !string.IsNullOrEmpty(PurchaseUnit);

        [XmlElement(ElementName = "ReportingUnitCode")]
        public string? ReportingUnitCode { get; set; }
        public bool ShouldSerializeReportingUnitCode() => !string.IsNullOrEmpty(ReportingUnitCode);

        [XmlElement(ElementName = "ReportingUnit")]
        public string? ReportingUnit { get; set; }
        public bool ShouldSerializeReportingUnit() => !string.IsNullOrEmpty(ReportingUnit);

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() => DosageQuantity.HasValue;

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public decimal? PerCemWeightDivisor { get; set; }
        public bool ShouldSerializePerCemWeightDivisor() => PerCemWeightDivisor.HasValue;

        [XmlElement(ElementName = "UseDosageQuantityUOMInMixDesign")]
        public UseDosageQuantityUOMInMixDesign UseDosageQuantityUOMInMixDesign { get; set; } = null!;
        public bool ShouldSerializeUseDosageQuantityUOMInMixDesign() => UseDosageQuantityUOMInMixDesign != null;
    }

    [XmlRoot(ElementName = "UseDosageQuantityUOMInMixDesign")]
    public class UseDosageQuantityUOMInMixDesign
    {
        [XmlElement(ElementName = "Enable")]
        public bool? Enable { get; set; }
        public bool ShouldSerializeEnable() => Enable.HasValue;

        [XmlElement(ElementName = "DosageQuantityExtensionCode")]
        public string? DosageQuantityExtensionCode { get; set; }
        public bool ShouldSerializeDosageQuantityExtensionCode() => !string.IsNullOrEmpty(DosageQuantityExtensionCode);

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public decimal? PerCemWeightDivisor { get; set; }
        public bool ShouldSerializePerCemWeightDivisor() => PerCemWeightDivisor.HasValue;

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() => DosageQuantity.HasValue;
    }

    [XmlRoot(ElementName = "Sales")]
    public class Sales
    {
        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool? TradeDiscountable { get; set; }

        [XmlElement(ElementName = "TermDiscountable")]
        public bool? TermDiscountable { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }
    }

    [XmlRoot(ElementName = "Mix")]
    public class Mix
    {
        [XmlElement(ElementName = "Strength")]
        public decimal? Strength { get; set; }

        [XmlElement(ElementName = "StrengthUnit")]
        public string StrengthUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "Slump")]
        public decimal? Slump { get; set; }

        [XmlElement(ElementName = "WaterCementRatio")]
        public decimal? WaterCementRatio { get; set; }

        [XmlElement(ElementName = "AggregateSize")]
        public string? AggregateSize { get; set; }

        [XmlElement(ElementName = "CementType")]
        public string CementType { get; set; } = string.Empty;

        [XmlElement(ElementName = "DaysToStrength")]
        public decimal? DaysToStrength { get; set; }

        [XmlElement(ElementName = "MaximumWater")]
        public decimal? MaximumWater { get; set; }

        [XmlElement(ElementName = "MinCementContent")]
        public decimal? MinCementContent { get; set; }

        [XmlElement(ElementName = "PercentAirVolume")]
        public decimal? PercentAirVolume { get; set; }

        [XmlElement(ElementName = "WaterHoldback")]
        public decimal? WaterHoldback { get; set; }

        [XmlElement(ElementName = "LightweightCubicFeet")]
        public decimal? LightweightCubicFeet { get; set; }
    }

    [XmlRoot(ElementName = "Location")]
    public class Location
    {
        [XmlElement(ElementName = "LocationID")]
        public int? LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "MixDesign")]
        public MixDesign MixDesign { get; set; } = null!;

        [XmlElement(ElementName = "Cost")]
        public Cost Cost { get; set; } = null!;

        [XmlElement(ElementName = "Batching")]
        public Batching Batching { get; set; } = null!;

        [XmlElement(ElementName = "Pricings")]
        public Pricings Pricings { get; set; } = null!;

        [XmlElement(ElementName = "BatchCodes")]
        public BatchCodes BatchCodes { get; set; } = null!;

        [XmlAttribute(AttributeName = "Active")]
        public bool Active { get; set; } = true;

        [XmlElement(ElementName = "AutoProducts")]
        public AutoProducts AutoProducts { get; set; } = null!;
    }

    [XmlRoot("AutoProducts")]
    public class AutoProducts
    {
        [XmlElement("AutoProduct")]
        public List<AutoProduct> AutoProduct { get; set; } = null!;
    }

    [XmlRoot("AutoProduct")]
    public class AutoProduct
    {
        [XmlElement("Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement("Quantity")]
        public decimal? Quantity { get; set; }

        [XmlElement("LoadQuantity")]
        public decimal? LoadQuantity { get; set; }
    }

    [XmlRoot("BatchCodes")]
    public class BatchCodes
    {
        [XmlElement("BatchCode")]
        public List<BatchCode> BatchCode { get; set; } = null!;
    }

    [XmlRoot("BatchCode")]
    public class BatchCode
    {
        [XmlElement("Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement("SortLineNumber")]
        public int? SortLineNumber { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement("ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement("UpdateDate")]
        public DateTime? UpdateDate { get; set; }
    }

    [XmlRoot(ElementName = "Batching")]
    public class Batching
    {
        [XmlElement("SpecificGravity")]
        public decimal? SpecificGravity { get; set; }

        [XmlElement("MoisturePercent")]
        public decimal? MoisturePercent { get; set; }

        [XmlElement("BatchUnit")]
        public string BatchUnit { get; set; } = string.Empty;

        [XmlElement("MaximumBatchSize")]
        public decimal? MaximumBatchSize { get; set; }

        [XmlElement("MixerTime")]
        public int? MixerTime { get; set; }

        [XmlElement("DownloadToBatchSystem")]
        public bool DownloadToBatchSystem { get; set; }
    }

    [XmlRoot(ElementName = "Pricings")]
    public class Pricings
    {
        [XmlElement(ElementName = "Pricing")]
        public List<Pricing> Pricing { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Pricing")]
    public class Pricing
    {
        [XmlElement(ElementName = "PriceCategoryCode")]
        public string PriceCategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; } = string.Empty;

        [XmlElement(ElementName = "Price")]
        public decimal? Price { get; set; } 

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string PriceExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceEffectiveDate")]
        public DateTime? PriceEffectiveDate { get; set; }

        [XmlElement(ElementName = "PreviousPrice")]
        public decimal? PreviousPrice { get; set;}

        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string PreviousPriceExtensionCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "MixDesign")]
    public class MixDesign
    {
        [XmlElement(ElementName = "Material")]
        public List<Material> Material { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Cost")]
    public class Cost
    {
        [XmlElement(ElementName = "StandardCost")]
        public decimal? StandardCost { get; set; }

        [XmlElement(ElementName = "CostExtensionCode")]
        public string CostExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CostEffectiveDate")]
        public DateTime? CostEffectiveDate { get; set; }

        [XmlElement(ElementName = "PreviousCost")]
        public decimal? PreviousCost { get; set; } 

        [XmlElement(ElementName = "PreviousCostExtensionCode")]
        public string PreviousCostExtensionCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Locations")]
    public class Locations
    {
        [XmlElement(ElementName = "Location")]
        public List<Location> Location { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Material")]
    public class Material
    {
        [XmlElement(ElementName = "Sort")]
        public int? Sort { get; set; }
        public bool ShouldSerializeSort() => Sort.HasValue;

        [XmlElement(ElementName = "ItemID")]
        public int? ItemID { get; set; }
        public bool ShouldSerializeItemID() => ItemID.HasValue;

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "Quantity")]
        public decimal? Quantity { get; set; }
        public bool ShouldSerializeQuantity() => Quantity.HasValue;

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() => DosageQuantity.HasValue;

        [XmlElement(ElementName = "Unit")]
        public string? Unit { get; set; }
        public bool ShouldSerializeUnit() => !string.IsNullOrEmpty(Unit);
    }
}
