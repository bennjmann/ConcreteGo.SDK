using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Items
{
    [XmlRoot(ElementName = "ItemUpdateRq", Namespace = "")]
    public class ItemAddOrUpdateRequest
    {
        [XmlElement(ElementName = "ItemUpdate")]
        public List<ItemUpdate>? ItemUpdate { get; set; }
        public bool ShouldSerializeItemUpdate() => ItemUpdate != null && ItemUpdate.Count > 0;
    }

    [XmlRoot(ElementName = "ItemUpdate", Namespace = "")]
    public class ItemUpdate
    {
        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() => ID.HasValue;

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [XmlElement(ElementName = "Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() => !string.IsNullOrEmpty(ShortDescription);

        [XmlElement(ElementName = "IsResaleable")]
        public bool? IsResaleable { get; set; }
        public bool ShouldSerializeIsResaleable() => IsResaleable.HasValue;

        [XmlElement(ElementName = "CategoryCode")]
        public string? CategoryCode { get; set; }
        public bool ShouldSerializeCategoryCode() => !string.IsNullOrEmpty(CategoryCode);

        [XmlElement(ElementName = "ItemType")]
        public string? ItemType { get; set; }
        public bool ShouldSerializeItemType() => !string.IsNullOrEmpty(ItemType);

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeStrength() => ItemTypeID.HasValue;

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }
        public bool ShouldSerializeKeepInInventory() => KeepInInventory.HasValue;

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }
        public bool ShouldSerializeResaleable() => Resaleable.HasValue;

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }
        public bool ShouldSerializeDoNotAllowTicketing() => DoNotAllowTicketing.HasValue;

        [XmlElement(ElementName = "IsConstituent")]
        public bool? IsConstituent { get; set; }
        public bool ShouldSerializeIsConstituent() => IsConstituent.HasValue;

        [XmlElement(ElementName = "AccountLinkCode")]
        public string? AccountLinkCode { get; set; }
        public bool ShouldSerializeAccountLinkCode() => !string.IsNullOrEmpty(AccountLinkCode);

        [XmlElement(ElementName = "UOM")]
        public ItemUpdateUOM? UOM { get; set; }
        public bool ShouldSerializeUOM() => UOM != null;

        [XmlElement(ElementName = "Sales")]
        public ItemUpdateSales? Sales { get; set; }
        public bool ShouldSerializeSales() => Sales != null;

        [XmlElement(ElementName = "Mix")]
        public ItemUpdateMix? Mix { get; set; }
        public bool ShouldSerializeMix() => Mix != null;

        [XmlElement(ElementName = "Locations")]
        public ItemUpdateLocations? Locations { get; set; }
        public bool ShouldSerializeLocations() => Locations != null;

        [XmlElement(ElementName = "TaxOverrides")]
        public ItemUpdateTaxOverrides? TaxOverrides { get; set; }
        public bool ShouldSerializeTaxOverrides() => TaxOverrides != null;
    }

    [XmlRoot(ElementName = "UOM")]
    public class ItemUpdateUOM
    {
        [XmlElement(ElementName = "OrderedQuantityUnitCode")]
        public string? OrderedQuantityUnitCode { get; set; }
        public bool ShouldSerializeOrderedQuantityUnitCode() => !string.IsNullOrEmpty(OrderedQuantityUnitCode);

        [XmlElement(ElementName = "OrderedQuantityUnit")]
        public string? OrderedQuantityUnit { get; set; }
        public bool ShouldSerializeOrderedQuantityUnit() => !string.IsNullOrEmpty(OrderedQuantityUnit);

        [XmlElement(ElementName = "OrderedQuantityExtCode")]
        public string? OrderedQuantityExtCode { get; set; }
        public bool ShouldSerializeOrderedQuantityExtCode() => !string.IsNullOrEmpty(OrderedQuantityExtCode);

        [XmlElement(ElementName = "DeliveredQuantityUnitCode")]
        public string? DeliveredQuantityUnitCode { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnitCode() => !string.IsNullOrEmpty(DeliveredQuantityUnitCode);

        [XmlElement(ElementName = "DeliveredQuantityUnit")]
        public string? DeliveredQuantityUnit { get; set; }
        public bool ShouldSerializeDeliveredQuantityUnit() => !string.IsNullOrEmpty(DeliveredQuantityUnit);

        [XmlElement(ElementName = "TicketQuantityExtCode")]
        public string? TicketQuantityExtCode { get; set; }
        public bool ShouldSerializeTicketQuantityExtCode() => !string.IsNullOrEmpty(TicketQuantityExtCode);

        [XmlElement(ElementName = "PriceQuantityUnitCode")]
        public string? PriceQuantityUnitCode { get; set; }
        public bool ShouldSerializePriceQuantityUnitCode() => !string.IsNullOrEmpty(PriceQuantityUnitCode);

        [XmlElement(ElementName = "PriceQuantityUnit")]
        public string? PriceQuantityUnit { get; set; }
        public bool ShouldSerializePriceQuantityUnit() => !string.IsNullOrEmpty(PriceQuantityUnit);

        [XmlElement(ElementName = "PriceQuantityExtCode")]
        public string? PriceQuantityExtCode { get; set; }
        public bool ShouldSerializePriceQuantityExtCode() => !string.IsNullOrEmpty(PriceQuantityExtCode);

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
        public int? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() => DosageQuantity.HasValue;

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public int? PerCemWeightDivisor { get; set; }
        public bool ShouldSerializePerCemWeightDivisor() => PerCemWeightDivisor.HasValue;

        [XmlElement(ElementName = "UseDosageQuantityUOMInMixDesign")]
        public ItemUpdateUseDosageQuantityUOMInMixDesign? UseDosageQuantityUOMInMixDesign { get; set; }
        public bool ShouldSerializeUseDosageQuantityUOMInMixDesign() => UseDosageQuantityUOMInMixDesign != null;
    }

    [XmlRoot(ElementName = "UseDosageQuantityUOMInMixDesign")]
    public class ItemUpdateUseDosageQuantityUOMInMixDesign
    {
        [XmlElement(ElementName = "Enable")]
        public bool? Enable { get; set; }
        public bool ShouldSerializeEnable() => Enable.HasValue;

        [XmlElement(ElementName = "DosageQuantityExtensionCode")]
        public string? DosageQuantityExtensionCode { get; set; }
        public bool ShouldSerializeDosageQuantityExtensionCode() => !string.IsNullOrEmpty(DosageQuantityExtensionCode);

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public int? PerCemWeightDivisor { get; set; }
        public bool ShouldSerializePerCemWeightDivisor() => PerCemWeightDivisor.HasValue;

        [XmlElement(ElementName = "DosageQuantity")]
        public decimal? DosageQuantity { get; set; }
        public bool ShouldSerializeDosageQuantity() => DosageQuantity.HasValue;
    }

    [XmlRoot(ElementName = "Sales")]
    public class ItemUpdateSales
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

    [XmlRoot(ElementName = "Mix")]
    public class ItemUpdateMix
    {
        [XmlElement(ElementName = "Strength")]
        public int? Strength { get; set; }
        public bool ShouldSerializeStrength() => Strength.HasValue;

        [XmlElement(ElementName = "StrengthUnit")]
        public string? StrengthUnit { get; set; }
        public bool ShouldSerializeStrengthUnit() => !string.IsNullOrEmpty(StrengthUnit);

        [XmlElement(ElementName = "Slump")]
        public decimal? Slump { get; set; }
        public bool ShouldSerializeSlump() => Slump.HasValue;

        [XmlElement(ElementName = "WaterCementRatio")]
        public decimal? WaterCementRatio { get; set; }
        public bool ShouldSerializeWaterCementRatio() => WaterCementRatio.HasValue;

        [XmlElement(ElementName = "AggregateSize")]
        public string? AggregateSize { get; set; }
        public bool ShouldSerializeAggregateSize() => !string.IsNullOrEmpty(AggregateSize);

        [XmlElement(ElementName = "CementType")]
        public string? CementType { get; set; }
        public bool ShouldSerializeCementType() => !string.IsNullOrEmpty(CementType);

        [XmlElement(ElementName = "DaysToStrength")]
        public int? DaysToStrength { get; set; }
        public bool ShouldSerializeDaysToStrength() => DaysToStrength.HasValue;

        [XmlElement(ElementName = "MaximumWater")]
        public decimal? MaximumWater { get; set; }
        public bool ShouldSerializeMaximumWater() => MaximumWater.HasValue;

        [XmlElement(ElementName = "MinCementContent")]
        public decimal? MinCementContent { get; set; }
        public bool ShouldSerializeMinCementContent() => MinCementContent.HasValue;

        [XmlElement(ElementName = "PercentAirVolume")]
        public decimal? PercentAirVolume { get; set; }
        public bool ShouldSerializePercentAirVolume() => PercentAirVolume.HasValue;

        [XmlElement(ElementName = "WaterHoldback")]
        public decimal? WaterHoldback { get; set; }
        public bool ShouldSerializeWaterHoldback() => WaterHoldback.HasValue;

        [XmlElement(ElementName = "LightweightCubicFeet")]
        public decimal? LightweightCubicFeet { get; set; }
        public bool ShouldSerializeLightweightCubicFeet() => LightweightCubicFeet.HasValue;
    }

    [XmlRoot(ElementName = "Locations")]
    public class ItemUpdateLocations
    {
        [XmlElement(ElementName = "Location")]
        public List<ItemUpdateLocation>? Location { get; set; }
        public bool ShouldSerializeLocation() => Location != null && Location.Count > 0;
    }

    [XmlRoot(ElementName = "Location")]
    public class ItemUpdateLocation
    {
        //[XmlAttribute(AttributeName = "Active")]
        //public bool? Active { get; set; }
        //public bool ShouldSerializeActive() => Active.HasValue;
        [XmlIgnore]
        public bool? Active { get; set; }

        [XmlAttribute(AttributeName = "Active")]
        public string ActiveString
        {
            get => Active?.ToString().ToLower();
            set => Active = string.IsNullOrEmpty(value) ? null : bool.Parse(value);
        }

        public bool ShouldSerializeActiveString() => Active.HasValue;

        [XmlElement(ElementName = "LocationID")]
        public int? LocationID { get; set; }
        public bool ShouldSerializeLocationID() => LocationID.HasValue;

        [XmlElement(ElementName = "LocationCode")]
        public string? LocationCode { get; set; }
        public bool ShouldSerializeLocationCode() => !string.IsNullOrEmpty(LocationCode);

        [XmlElement(ElementName = "Batching")]
        public ItemUpdateBatching? Batching { get; set; }
        public bool ShouldSerializeBatching() => Batching != null;

        [XmlElement(ElementName = "MixDesign")]
        public ItemUpdateMixDesign? MixDesign { get; set; }
        public bool ShouldSerializeMixDesign() => MixDesign != null;

        [XmlElement(ElementName = "Cost")]
        public ItemUpdateCost? Cost { get; set; }
        public bool ShouldSerializeCost() => Cost != null;

        [XmlElement(ElementName = "Pricings")]
        public ItemUpdatePricings? Pricings { get; set; }
        public bool ShouldSerializePricings() => Pricings != null;

        [XmlElement(ElementName = "BatchCodes")]
        public ItemUpdateBatchCodes? BatchCodes { get; set; }
        public bool ShouldSerializeBatchCodes() => BatchCodes != null;

        [XmlElement(ElementName = "AutoProducts")]
        public ItemUpdateAutoProducts? AutoProducts { get; set; }
        public bool ShouldSerializeAutoProducts() => AutoProducts != null;

        [XmlElement(ElementName = "Inventory")]
        public ItemUpdateInventory? Inventory { get; set; }
        public bool ShouldSerializeInventory() => Inventory != null;
    }

    [XmlRoot(ElementName = "Batching")]
    public class ItemUpdateBatching
    {
        [XmlElement(ElementName = "SpecificGravity")]
        public decimal? SpecificGravity { get; set; }
        public bool ShouldSerializeSpecificGravity() => SpecificGravity.HasValue;

        [XmlElement(ElementName = "MoisturePercent")]
        public decimal? MoisturePercent { get; set; }
        public bool ShouldSerializeMoisturePercent() => MoisturePercent.HasValue;

        [XmlElement(ElementName = "BatchUnit")]
        public string? BatchUnit { get; set; }
        public bool ShouldSerializeBatchUnit() => !string.IsNullOrEmpty(BatchUnit);

        [XmlElement(ElementName = "MaximumBatchSize")]
        public decimal? MaximumBatchSize { get; set; }
        public bool ShouldSerializeMaximumBatchSize() => MaximumBatchSize.HasValue;

        [XmlElement(ElementName = "MixerTime")]
        public int? MixerTime { get; set; }
        public bool ShouldSerializeMixerTime() => MixerTime.HasValue;

        [XmlElement(ElementName = "DownloadToBatchSystem")]
        public bool? DownloadToBatchSystem { get; set; }
        public bool ShouldSerializeDownloadToBatchSystem() => DownloadToBatchSystem.HasValue;
    }

    [XmlRoot(ElementName = "MixDesign")]
    public class ItemUpdateMixDesign
    {
        [XmlElement(ElementName = "Material")]
        public List<ItemUpdateMaterial>? Material { get; set; }
        public bool ShouldSerializeMaterial() => Material != null && Material.Count > 0;
    }

    [XmlRoot(ElementName = "Material")]
    public class ItemUpdateMaterial
    {
        [XmlElement(ElementName = "MixOrder")]
        public int? MixOrder { get; set; }
        public bool ShouldSerializeMixOrder() => MixOrder.HasValue;

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

    [XmlRoot(ElementName = "Cost")]
    public class ItemUpdateCost
    {
        [XmlElement(ElementName = "StandardCost")]
        public decimal? StandardCost { get; set; }
        public bool ShouldSerializeStandardCost() => StandardCost.HasValue;

        [XmlElement(ElementName = "CostExtensionCode")]
        public string? CostExtensionCode { get; set; }
        public bool ShouldSerializeCostExtensionCode() => !string.IsNullOrEmpty(CostExtensionCode);

        [XmlElement(ElementName = "CostEffectiveDate")]
        public DateTime? CostEffectiveDate { get; set; }
        public bool ShouldSerializeCostEffectiveDate() => CostEffectiveDate.HasValue;

        [XmlElement(ElementName = "PreviousCost")]
        public decimal? PreviousCost { get; set; }
        public bool ShouldSerializePreviousCost() => PreviousCost.HasValue;

        [XmlElement(ElementName = "PreviousCostExtensionCode")]
        public string? PreviousCostExtensionCode { get; set; }
        public bool ShouldSerializePreviousCostExtensionCode() => !string.IsNullOrEmpty(PreviousCostExtensionCode);
    }

    [XmlRoot(ElementName = "Pricings")]
    public class ItemUpdatePricings
    {
        [XmlAttribute(AttributeName = "Method")]
        public string? Method { get; set; }
        public bool ShouldSerializeMethod() => !string.IsNullOrEmpty(Method);

        [XmlElement(ElementName = "Pricing")]
        public List<ItemUpdatePricing>? Pricing { get; set; }
        public bool ShouldSerializePricing() => Pricing != null && Pricing.Count > 0;
    }

    [XmlRoot(ElementName = "Pricing")]
    public class ItemUpdatePricing
    {
        [XmlAttribute(AttributeName = "Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [XmlElement(ElementName = "PriceCategoryCode")]
        public string? PriceCategoryCode { get; set; }
        public bool ShouldSerializePriceCategoryCode() => !string.IsNullOrEmpty(PriceCategoryCode);

        [XmlElement(ElementName = "Price")]
        public decimal? Price { get; set; }
        public bool ShouldSerializePrice() => Price.HasValue;

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
        public bool ShouldSerializePriceExtensionCode() => !string.IsNullOrEmpty(PriceExtensionCode);

        [XmlElement(ElementName = "PriceEffectiveDate")]
        public DateTime? PriceEffectiveDate { get; set; }
        public bool ShouldSerializePriceEffectiveDate() => PriceEffectiveDate.HasValue;

        [XmlElement(ElementName = "PreviousPrice")]
        public decimal? PreviousPrice { get; set; }
        public bool ShouldSerializePreviousPrice() => PreviousPrice.HasValue;

        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string? PreviousPriceExtensionCode { get; set; }
        public bool ShouldSerializePreviousPriceExtensionCode() => !string.IsNullOrEmpty(PreviousPriceExtensionCode);
    }

    [XmlRoot(ElementName = "BatchCodes")]
    public class ItemUpdateBatchCodes
    {
        [XmlAttribute(AttributeName = "Method")]
        public string? Method { get; set; }
        public bool ShouldSerializeMethod() => !string.IsNullOrEmpty(Method);

        [XmlElement(ElementName = "BatchCode")]
        public List<ItemUpdateBatchCode>? BatchCode { get; set; }
        public bool ShouldSerializeBatchCode() => BatchCode != null && BatchCode.Count > 0;
    }

    [XmlRoot(ElementName = "BatchCode")]
    public class ItemUpdateBatchCode
    {
        [XmlAttribute(AttributeName = "Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [XmlElement(ElementName = "SortLineNumber")]
        public int? SortLineNumber { get; set; }
        public bool ShouldSerializeSortLineNumber() => SortLineNumber.HasValue;

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() => !string.IsNullOrEmpty(ShortDescription);
    }

    [XmlRoot(ElementName = "AutoProducts")]
    public class ItemUpdateAutoProducts
    {
        [XmlAttribute(AttributeName = "Method")]
        public string? Method { get; set; }
        public bool ShouldSerializeMethod() => !string.IsNullOrEmpty(Method);

        [XmlElement(ElementName = "AutoProduct")]
        public List<ItemUpdateAutoProduct>? AutoProduct { get; set; }
        public bool ShouldSerializeAutoProduct() => AutoProduct != null && AutoProduct.Count > 0;
    }

    [XmlRoot(ElementName = "AutoProduct")]
    public class ItemUpdateAutoProduct
    {
        [XmlAttribute(AttributeName = "Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        [XmlElement(ElementName = "Quantity")]
        public decimal? Quantity { get; set; }
        public bool ShouldSerializeQuantity() => Quantity.HasValue;

        [XmlElement(ElementName = "LoadQuantity")]
        public decimal? LoadQuantity { get; set; }
        public bool ShouldSerializeLoadQuantity() => LoadQuantity.HasValue;
    }

    [XmlRoot(ElementName = "Inventory")]
    public class ItemUpdateInventory
    {
        // Placeholder for Inventory properties based on documentation
        // Add properties as needed when documentation becomes available
    }

    [XmlRoot(ElementName = "TaxOverrides")]
    public class ItemUpdateTaxOverrides
    {
        [XmlElement(ElementName = "TaxOverride")]
        public List<ItemUpdateTaxOverride>? TaxOverride { get; set; }
        public bool ShouldSerializeTaxOverride() => TaxOverride != null && TaxOverride.Count > 0;
    }

    [XmlRoot(ElementName = "TaxOverride")]
    public class ItemUpdateTaxOverride
    {
        [XmlElement(ElementName = "TaxAuthorityID")]
        public int? TaxAuthorityID { get; set; }
        public bool ShouldSerializeTaxAuthorityID() => TaxAuthorityID.HasValue;

        [XmlElement(ElementName = "TaxAuthorityCode")]
        public string? TaxAuthorityCode { get; set; }
        public bool ShouldSerializeTaxAuthorityCode() => !string.IsNullOrEmpty(TaxAuthorityCode);

        [XmlElement(ElementName = "TaxLocationID")]
        public int? TaxLocationID { get; set; }
        public bool ShouldSerializeTaxLocationID() => TaxLocationID.HasValue;

        [XmlElement(ElementName = "TaxLocationCode")]
        public string? TaxLocationCode { get; set; }
        public bool ShouldSerializeTaxLocationCode() => !string.IsNullOrEmpty(TaxLocationCode);

        [XmlElement(ElementName = "OverrideTaxable")]
        public bool? OverrideTaxable { get; set; }
        public bool ShouldSerializeOverrideTaxable() => OverrideTaxable.HasValue;

        [XmlElement(ElementName = "OverrideTaxRateLocationID")]
        public int? OverrideTaxRateLocationID { get; set; }
        public bool ShouldSerializeOverrideTaxRateLocationID() => OverrideTaxRateLocationID.HasValue;

        [XmlElement(ElementName = "OverrideTaxRateLocationCode")]
        public string? OverrideTaxRateLocationCode { get; set; }
        public bool ShouldSerializeOverrideTaxRateLocationCode() => !string.IsNullOrEmpty(OverrideTaxRateLocationCode);
    }
}
