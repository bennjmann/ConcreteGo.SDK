using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Items
{
    [XmlRoot("ItemRet")]
    public class ItemRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() { return ShortDescription != null; }

        [XmlElement(ElementName = "CategoryCode")]
        public string? CategoryCode { get; set; }
        public bool ShouldSerializeCategoryCode() { return CategoryCode != null; }

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }
        public bool ShouldSerializeKeepInInventory() { return KeepInInventory.HasValue; }

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }
        public bool ShouldSerializeResaleable() { return Resaleable.HasValue; }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }
        public bool ShouldSerializeDoNotAllowTicketing() { return DoNotAllowTicketing.HasValue; }

        [XmlElement(ElementName = "Constituent")]
        public bool? Constituent { get; set; }
        public bool ShouldSerializeConstituent() { return Constituent.HasValue; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string? AccountLinkCode { get; set; }
        public bool ShouldSerializeAccountLinkCode() { return AccountLinkCode != null; }

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string? CategoryAccountLinkCode { get; set; }
        public bool ShouldSerializeCategoryAccountLinkCode() { return CategoryAccountLinkCode != null; }

        [XmlElement(ElementName = "ProductLink")]
        public string? ProductLink { get; set; }
        public bool ShouldSerializeProductLink() { return ProductLink != null; }

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeItemTypeID() { return ItemTypeID.HasValue; }

        [XmlElement(ElementName = "ItemType")]
        public string? ItemType { get; set; }
        public bool ShouldSerializeItemType() { return ItemType != null; }

        [XmlElement(ElementName = "UOM")]
        public ItemRetUOM? UOM { get; set; }
        public bool ShouldSerializeUOM() { return UOM != null; }

        [XmlElement(ElementName = "Sales")]
        public ItemRetSales? Sales { get; set; }
        public bool ShouldSerializeSales() { return Sales != null; }

        [XmlElement(ElementName = "Mix")]
        public ItemRetMix? Mix { get; set; }
        public bool ShouldSerializeMix() { return Mix != null; }

        [XmlElement(ElementName = "Locations")]
        public ItemRetLocations? Locations { get; set; }
        public bool ShouldSerializeLocations() { return Locations != null; }

        [XmlElement(ElementName = "TaxOverrides")]
        public ItemRetTaxOverrides? TaxOverrides { get; set; }
        public bool ShouldSerializeTaxOverrides() { return TaxOverrides != null; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() { return SetupDate.HasValue; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }
        public bool ShouldSerializeUpdateDate() { return UpdateDate.HasValue; }
    }

    [XmlRoot("TaxOverrides")]
    public class ItemRetTaxOverrides
    {
        [XmlElement("TaxOverride")]
        public List<ItemRetTaxOverride> TaxOverride { get; set; } = new List<ItemRetTaxOverride>();
    }

    [XmlRoot("TaxOverride")]
    public class ItemRetTaxOverride
    {
        [XmlElement("TaxAuthorityID")]
        public int TaxAuthorityID { get; set; }

        [XmlElement("TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; } = string.Empty;

        [XmlElement("TaxLocationID")]
        public int TaxLocationID { get; set; }

        [XmlElement("TaxLocationCode")]
        public string TaxLocationCode { get; set; } = string.Empty;

        [XmlElement("OverrideTaxable")]
        public bool OverrideTaxable { get; set; }

        [XmlElement("OverrideTaxRateLocationID")]
        public int OverrideTaxRateLocationID { get; set; }

        [XmlElement("OverrideTaxRateLocationCode")]
        public string OverrideTaxRateLocationCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "UOM")]
    public class ItemRetUOM
    {
        [XmlElement(ElementName = "OrderedQuantityUnitCode")]
        public string? OrderedQuantityUnitCode { get; set; }
        public bool ShouldSerializeOrderedQuantityUnitCode() { return OrderedQuantityUnitCode != null; }

        [XmlElement(ElementName = "OrderedQuantityUnit")]
        public string? OrderedQuantityUnit { get; set; }
        public bool ShouldSerializeOrderedQuantityUnit() { return OrderedQuantityUnit != null; }

        [XmlElement(ElementName = "OrderedExtensionCode")]
        public string? OrderedExtensionCode { get; set; }
        public bool ShouldSerializeOrderedExtensionCode() { return OrderedExtensionCode != null; }

        [XmlElement(ElementName = "DeliveredQuantityUnitCode")]
        public string? DeliveredQuantityUnitCode { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnitCode() { return DeliveredQuantityUnitCode != null; }

        [XmlElement(ElementName = "DeliveredQuantityUnit")]
        public string? DeliveredQuantityUnit { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnit() { return DeliveredQuantityUnit != null; }

        [XmlElement(ElementName = "TicketExtensionCode")]
        public string? TicketExtensionCode { get; set; }
        public bool ShouldSerializeTicketExtensionCode() { return TicketExtensionCode != null; }

        [XmlElement(ElementName = "PriceQuantityUnitCode")]
        public string? PriceQuantityUnitCode { get; set; }
        public bool ShouldSerializePriceQuantityUnitCode() { return PriceQuantityUnitCode != null; }

        [XmlElement(ElementName = "PriceQuantityUnit")]
        public string? PriceQuantityUnit { get; set; }
        public bool ShouldSerializePriceQuantityUnit() { return PriceQuantityUnit != null; }

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
        public bool ShouldSerializePriceExtensionCode() { return PriceExtensionCode != null; }

        [XmlElement(ElementName = "BatchUnitCode")]
        public string? BatchUnitCode { get; set; }
        public bool ShouldSerializeBatchUnitCode() { return BatchUnitCode != null; }

        [XmlElement(ElementName = "BatchUnit")]
        public string? BatchUnit { get; set; }
        public bool ShouldSerializeBatchUnit() { return BatchUnit != null; }

        [XmlElement(ElementName = "InventoryUnitCode")]
        public string? InventoryUnitCode { get; set; }
        public bool ShouldSerializeInventoryUnitCode() { return InventoryUnitCode != null; }

        [XmlElement(ElementName = "InventoryUnit")]
        public string? InventoryUnit { get; set; }
        public bool ShouldSerializeInventoryUnit() { return InventoryUnit != null; }

        [XmlElement(ElementName = "PurchaseUnitCode")]
        public string? PurchaseUnitCode { get; set; }
        public bool ShouldSerializePurchaseUnitCode() { return PurchaseUnitCode != null; }

        [XmlElement(ElementName = "PurchaseUnit")]
        public string? PurchaseUnit { get; set; }
        public bool ShouldSerializePurchaseUnit() { return PurchaseUnit != null; }

        [XmlElement(ElementName = "ReportingUnitCode")]
        public string? ReportingUnitCode { get; set; }
        public bool ShouldSerializeReportingUnitCode() { return ReportingUnitCode != null; }

        [XmlElement(ElementName = "ReportingUnit")]
        public string? ReportingUnit { get; set; }
        public bool ShouldSerializeReportingUnit() { return ReportingUnit != null; }

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() { return DosageQuantity.HasValue; }

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public int? PerCemWeightDivisor { get; set; }
        public bool ShouldSerializePerCemWeightDivisor() { return PerCemWeightDivisor.HasValue; }

        [XmlElement(ElementName = "UseDosageQuantityUOMInMixDesign")]
        public ItemRetUseDosageQuantityUOMInMixDesign UseDosageQuantityUOMInMixDesign { get; set; } = new ItemRetUseDosageQuantityUOMInMixDesign();
    }

    [XmlRoot(ElementName = "UseDosageQuantityUOMInMixDesign")]
    public class ItemRetUseDosageQuantityUOMInMixDesign
    {
        [XmlElement(ElementName = "Enable")]
        public bool Enable { get; set; }

        [XmlElement(ElementName = "DosageQuantityExtensionCode")]
        public string DosageQuantityExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public decimal PerCemWeightDivisor { get; set; }

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal DosageQuantity { get; set; }
    }

    [XmlRoot(ElementName = "Sales")]
    public class ItemRetSales
    {
        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }
        public bool ShouldSerializeTaxable() { return Taxable.HasValue; }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool? TradeDiscountable { get; set; }
        public bool ShouldSerializeTradeDiscountable() { return TradeDiscountable.HasValue; }

        [XmlElement(ElementName = "TermDiscountable")]
        public bool? TermDiscountable { get; set; }
        public bool ShouldSerializeTermDiscountable() { return TermDiscountable.HasValue; }

        [XmlElement(ElementName = "UsageCode")]
        public string? UsageCode { get; set; }
        public bool ShouldSerializeUsageCode() { return UsageCode != null; }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; }
        public bool ShouldSerializeNonTaxableReasonCode() { return NonTaxableReasonCode != null; }

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }
        public bool ShouldSerializeExpirationDate() { return ExpirationDate.HasValue; }
    }

    [XmlRoot(ElementName = "Mix")]
    public class ItemRetMix
    {
        [XmlElement(ElementName = "Strength")]
        public decimal? Strength { get; set; }
        public bool ShouldSerializeStrength() { return Strength.HasValue; }

        [XmlElement(ElementName = "StrengthUnit")]
        public string? StrengthUnit { get; set; }
        public bool ShouldSerializeStrengthUnit() { return StrengthUnit != null; }

        [XmlElement(ElementName = "Slump")]
        public decimal? Slump { get; set; }
        public bool ShouldSerializeSlump() { return Slump.HasValue; }

        [XmlElement(ElementName = "WaterCementRatio")]
        public decimal? WaterCementRatio { get; set; }
        public bool ShouldSerializeWaterCementRatio() { return WaterCementRatio.HasValue; }

        [XmlElement(ElementName = "AggregateSize")]
        public string? AggregateSize { get; set; }
        public bool ShouldSerializeAggregateSize() { return AggregateSize != null; }

        [XmlElement(ElementName = "CementType")]
        public string? CementType { get; set; }
        public bool ShouldSerializeCementType() { return CementType != null; }

        [XmlElement(ElementName = "DaysToStrength")]
        public int? DaysToStrength { get; set; }
        public bool ShouldSerializeDaysToStrength() { return DaysToStrength.HasValue; }

        [XmlElement(ElementName = "MaximumWater")]
        public decimal? MaximumWater { get; set; }
        public bool ShouldSerializeMaximumWater() { return MaximumWater.HasValue; }

        [XmlElement(ElementName = "MinCementContent")]
        public decimal? MinCementContent { get; set; }
        public bool ShouldSerializeMinCementContent() { return MinCementContent.HasValue; }

        [XmlElement(ElementName = "PercentAirVolume")]
        public decimal? PercentAirVolume { get; set; }
        public bool ShouldSerializePercentAirVolume() { return PercentAirVolume.HasValue; }

        [XmlElement(ElementName = "WaterHoldback")]
        public decimal? WaterHoldback { get; set; }
        public bool ShouldSerializeWaterHoldback() { return WaterHoldback.HasValue; }

        [XmlElement(ElementName = "LightweightCubicFeet")]
        public decimal? LightweightCubicFeet { get; set; }
        public bool ShouldSerializeLightweightCubicFeet() { return LightweightCubicFeet.HasValue; }
    }

    [XmlRoot(ElementName = "Location")]
    public class ItemRetLocation
    {
        [XmlElement(ElementName = "LocationID")]
        public int LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Batching")]
        public ItemRetBatching? Batching { get; set; }
        public bool ShouldSerializeBatching() { return Batching != null; }

        [XmlElement(ElementName = "MixDesign")]
        public ItemRetMixDesign? MixDesign { get; set; }
        public bool ShouldSerializeMixDesign() { return MixDesign != null; }

        [XmlElement(ElementName = "Cost")]
        public ItemRetCost? Cost { get; set; }
        public bool ShouldSerializeCost() { return Cost != null; }

        [XmlElement(ElementName = "Pricings")]
        public ItemRetPricings? Pricings { get; set; }
        public bool ShouldSerializePricings() { return Pricings != null; }

        [XmlElement(ElementName = "BatchCodes")]
        public ItemRetBatchCodes? BatchCodes { get; set; }
        public bool ShouldSerializeBatchCodes() { return BatchCodes != null; }

        [XmlElement(ElementName = "AutoProducts")]
        public ItemRetAutoProducts? AutoProducts { get; set; }
        public bool ShouldSerializeAutoProducts() { return AutoProducts != null; }
    }

    [XmlRoot("AutoProducts")]
    public class ItemRetAutoProducts
    {
        [XmlElement("AutoProduct")]
        public List<ItemRetAutoProduct> AutoProduct { get; set; } = new List<ItemRetAutoProduct>();
    }

    [XmlRoot("AutoProduct")]
    public class ItemRetAutoProduct
    {
        [XmlElement("Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() { return Code != null; }

        [XmlElement("Quantity")]
        public decimal? Quantity { get; set; }
        public bool ShouldSerializeQuantity() { return Quantity.HasValue; }

        [XmlElement("LoadQuantity")]
        public decimal? LoadQuantity { get; set; }
        public bool ShouldSerializeLoadQuantity() { return LoadQuantity.HasValue; }
    }

    [XmlRoot("BatchCodes")]
    public class ItemRetBatchCodes
    {
        [XmlElement("BatchCode")]
        public List<ItemRetBatchCode> BatchCode { get; set; } = new List<ItemRetBatchCode>();
    }

    [XmlRoot("BatchCode")]
    public class ItemRetBatchCode
    {
        [XmlElement("Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() { return Code != null; }

        [XmlElement("SortLineNumber")]
        public int? SortLineNumber { get; set; }
        public bool ShouldSerializeSortLineNumber() { return SortLineNumber.HasValue; }

        [XmlElement("Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() { return Description != null; }

        [XmlElement("ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() { return ShortDescription != null; }

        [XmlElement("UpdateDate")]
        public DateTime? UpdateDate { get; set; }
        public bool ShouldSerializeUpdateDate() { return UpdateDate.HasValue; }
    }

    [XmlRoot(ElementName = "Batching")]
    public class ItemRetBatching
    {
        [XmlElement("SpecificGravity")]
        public decimal? SpecificGravity { get; set; }
        public bool ShouldSerializeSpecificGravity() { return SpecificGravity.HasValue; }

        [XmlElement("MoisturePercent")]
        public decimal? MoisturePercent { get; set; }
        public bool ShouldSerializeMoisturePercent() { return MoisturePercent.HasValue; }

        [XmlElement("BatchUnit")]
        public string? BatchUnit { get; set; }
        public bool ShouldSerializeBatchUnit() { return BatchUnit != null; }

        [XmlElement("MaximumBatchSize")]
        public decimal? MaximumBatchSize { get; set; }
        public bool ShouldSerializeMaximumBatchSize() { return MaximumBatchSize.HasValue; }

        [XmlElement("MixerTime")]
        public int? MixerTime { get; set; }
        public bool ShouldSerializeMixerTime() { return MixerTime.HasValue; }

        [XmlElement("DownloadToBatchSystem")]
        public bool DownloadToBatchSystem { get; set; }
    }

    [XmlRoot(ElementName = "Pricings")]
    public class ItemRetPricings
    {
        [XmlElement(ElementName = "Pricing")]
        public List<ItemRetPricing> Pricing { get; set; } = new List<ItemRetPricing>();
    }

    [XmlRoot(ElementName = "Pricing")]
    public class ItemRetPricing
    {
        [XmlElement(ElementName = "PriceCategoryCode")]
        public string? PriceCategoryCode { get; set; }
        public bool ShouldSerializePriceCategoryCode() { return PriceCategoryCode != null; }

        [XmlElement(ElementName = "PriceCategoryName")]
        public string? PriceCategoryName { get; set; }
        public bool ShouldSerializePriceCategoryName() { return PriceCategoryName != null; }

        [XmlElement(ElementName = "Price")]
        public decimal? Price { get; set; }
        public bool ShouldSerializePrice() { return Price.HasValue; }

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
        public bool ShouldSerializePriceExtensionCode() { return PriceExtensionCode != null; }

        [XmlElement(ElementName = "PriceEffectiveDate")]
        public DateTime? PriceEffectiveDate { get; set; }
        public bool ShouldSerializePriceEffectiveDate() { return PriceEffectiveDate.HasValue; }

        [XmlElement(ElementName = "PreviousPrice")]
        public decimal? PreviousPrice { get; set; }
        public bool ShouldSerializePreviousPrice() { return PreviousPrice.HasValue; }

        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string? PreviousPriceExtensionCode { get; set; }
        public bool ShouldSerializePreviousPriceExtensionCode() { return PreviousPriceExtensionCode != null; }
    }

    [XmlRoot(ElementName = "MixDesign")]
    public class ItemRetMixDesign
    {
        [XmlElement(ElementName = "Material")]
        public List<ItemRetMaterial> Material { get; set; } = new List<ItemRetMaterial>();
    }

    [XmlRoot(ElementName = "Cost")]
    public class ItemRetCost
    {
        [XmlElement(ElementName = "StandardCost")]
        public decimal? StandardCost { get; set; }
        public bool ShouldSerializeStandardCost() { return StandardCost.HasValue; }

        [XmlElement(ElementName = "CostExtensionCode")]
        public string? CostExtensionCode { get; set; }
        public bool ShouldSerializeCostExtensionCode() { return CostExtensionCode != null; }

        [XmlElement(ElementName = "CostEffectiveDate")]
        public DateTime? CostEffectiveDate { get; set; }
        public bool ShouldSerializeCostEffectiveDate() { return CostEffectiveDate.HasValue; }

        [XmlElement(ElementName = "PreviousCost")]
        public decimal? PreviousCost { get; set; }
        public bool ShouldSerializePreviousCost() { return PreviousCost.HasValue; }

        [XmlElement(ElementName = "PreviousCostExtensionCode")]
        public string? PreviousCostExtensionCode { get; set; }
        public bool ShouldSerializePreviousCostExtensionCode() { return PreviousCostExtensionCode != null; }
    }

    [XmlRoot(ElementName = "Locations")]
    public class ItemRetLocations
    {
        [XmlElement(ElementName = "Location")]
        public List<ItemRetLocation> Location { get; set; } = new List<ItemRetLocation>();
    }

    [XmlRoot(ElementName = "Material")]
    public class ItemRetMaterial
    {
        [XmlElement(ElementName = "Sort")]
        public int Sort { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "Quantity")]
        public decimal Quantity { get; set; }

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal DosageQuantity { get; set; }

        [XmlElement(ElementName = "Unit")]
        public string Unit { get; set; } = string.Empty;
    }
}
