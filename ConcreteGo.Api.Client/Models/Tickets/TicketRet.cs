using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot("TicketRet")]
    public class TicketRet
    {
        [XmlElement(ElementName = "TicketID")]
        public int TicketID { get; set; }

        [XmlElement(ElementName = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [XmlElement(ElementName = "PlantID")]
        public int PlantID { get; set; }

        [XmlElement(ElementName = "PlantCode")]
        public string? PlantCode { get; set; }
        public bool ShouldSerializePlantCode() => !string.IsNullOrEmpty(PlantCode);

        [XmlElement(ElementName = "PlantName")]
        public string PlantName { get; set; } = string.Empty;

        [XmlElement(ElementName = "LocationID")]
        public int LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "LocationName")]
        public string? LocationName { get; set; }
        public bool ShouldSerializeLocationName() => !string.IsNullOrEmpty(LocationName);

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "TicketCode")]
        public string TicketCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [XmlElement(ElementName = "OrderID")]
        public int OrderID { get; set; }

        [XmlElement(ElementName = "OrderCode")]
        public string OrderCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "MixCode")]
        public string MixCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CurrentStatus")]
        public int CurrentStatus { get; set; }

        [XmlElement(ElementName = "OrderCurrentStatus")]
        public int OrderCurrentStatus { get; set; }

        [XmlElement(ElementName = "PaymentForm")]
        public int? PaymentForm { get; set; }
        public bool ShouldSerializePaymentForm() => PaymentForm.HasValue;

        [XmlElement(ElementName = "TruckCode")]
        public string? TruckCode { get; set; }
        public bool ShouldSerializeTruckCode() => !string.IsNullOrEmpty(TruckCode);

        [XmlElement(ElementName = "DriverCode")]
        public string? DriverCode { get; set; }
        public bool ShouldSerializeDriverCode() => !string.IsNullOrEmpty(DriverCode);

        [XmlElement(ElementName = "DriverName")]
        public string? DriverName { get; set; }
        public bool ShouldSerializeDriverName() => !string.IsNullOrEmpty(DriverName);

        [XmlElement(ElementName = "CustomerID")]
        public int CustomerID { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerDivisionCode")]
        public string? CustomerDivisionCode { get; set; }
        public bool ShouldSerializeCustomerDivisionCode() => !string.IsNullOrEmpty(CustomerDivisionCode);

        [XmlElement(ElementName = "CustomerJob")]
        public string? CustomerJob { get; set; }
        public bool ShouldSerializeCustomerJob() => !string.IsNullOrEmpty(CustomerJob);

        [XmlElement(ElementName = "ProjectID")]
        public int? ProjectID { get; set; }
        public bool ShouldSerializeProjectID() => ProjectID.HasValue;

        [XmlElement(ElementName = "ProjectCode")]
        public string? ProjectCode { get; set; }
        public bool ShouldSerializeProjectCode() => !string.IsNullOrEmpty(ProjectCode);

        [XmlElement(ElementName = "ProjectName")]
        public string? ProjectName { get; set; }
        public bool ShouldSerializeProjectName() => !string.IsNullOrEmpty(ProjectName);

        [XmlElement(ElementName = "LotBlockNumber")]
        public string? LotBlockNumber { get; set; }
        public bool ShouldSerializeLotBlockNumber() => !string.IsNullOrEmpty(LotBlockNumber);

        [XmlElement(ElementName = "PurchaseOrder")]
        public string? PurchaseOrder { get; set; }
        public bool ShouldSerializePurchaseOrder() => !string.IsNullOrEmpty(PurchaseOrder);

        [XmlElement(ElementName = "PocketNumber")]
        public string? PocketNumber { get; set; }
        public bool ShouldSerializePocketNumber() => !string.IsNullOrEmpty(PocketNumber);

        [XmlElement(ElementName = "JobNumber")]
        public string? JobNumber { get; set; }
        public bool ShouldSerializeJobNumber() => !string.IsNullOrEmpty(JobNumber);

        [XmlElement(ElementName = "DeliveryAddr1")]
        public string? DeliveryAddr1 { get; set; }
        public bool ShouldSerializeDeliveryAddr1() => !string.IsNullOrEmpty(DeliveryAddr1);

        [XmlElement(ElementName = "DeliveryAddr2")]
        public string? DeliveryAddr2 { get; set; }
        public bool ShouldSerializeDeliveryAddr2() => !string.IsNullOrEmpty(DeliveryAddr2);

        [XmlElement(ElementName = "DeliveryAddr3")]
        public string? DeliveryAddr3 { get; set; }
        public bool ShouldSerializeDeliveryAddr3() => !string.IsNullOrEmpty(DeliveryAddr3);

        [XmlElement(ElementName = "InstructionAddr1")]
        public string? InstructionAddr1 { get; set; }
        public bool ShouldSerializeInstructionAddr1() => !string.IsNullOrEmpty(InstructionAddr1);

        [XmlElement(ElementName = "InstructionAddr2")]
        public string? InstructionAddr2 { get; set; }
        public bool ShouldSerializeInstructionAddr2() => !string.IsNullOrEmpty(InstructionAddr2);

        [XmlElement(ElementName = "InstructionAddr3")]
        public string? InstructionAddr3 { get; set; }
        public bool ShouldSerializeInstructionAddr3() => !string.IsNullOrEmpty(InstructionAddr3);

        [XmlElement(ElementName = "InstructionAddr4")]
        public string? InstructionAddr4 { get; set; }
        public bool ShouldSerializeInstructionAddr4() => !string.IsNullOrEmpty(InstructionAddr4);

        [XmlElement(ElementName = "InstructionAddr5")]
        public string? InstructionAddr5 { get; set; }
        public bool ShouldSerializeInstructionAddr5() => !string.IsNullOrEmpty(InstructionAddr5);

        [XmlElement(ElementName = "InstructionAddr6")]
        public string? InstructionAddr6 { get; set; }
        public bool ShouldSerializeInstructionAddr6() => !string.IsNullOrEmpty(InstructionAddr6);

        [XmlElement(ElementName = "ZoneCode")]
        public string? ZoneCode { get; set; }
        public bool ShouldSerializeZoneCode() => !string.IsNullOrEmpty(ZoneCode);

        [XmlElement(ElementName = "ZoneName")]
        public string? ZoneName { get; set; }
        public bool ShouldSerializeZoneName() => !string.IsNullOrEmpty(ZoneName);

        [XmlElement(ElementName = "RemoveReasonCode")]
        public string? RemoveReasonCode { get; set; }
        public bool ShouldSerializeRemoveReasonCode() => !string.IsNullOrEmpty(RemoveReasonCode);

        [XmlElement(ElementName = "TaxCode")]
        public string? TaxCode { get; set; }
        public bool ShouldSerializeTaxCode() => !string.IsNullOrEmpty(TaxCode);

        [XmlElement(ElementName = "TaxCodeDescription")]
        public string? TaxCodeDescription { get; set; }
        public bool ShouldSerializeTaxCodeDescription() => !string.IsNullOrEmpty(TaxCodeDescription);

        [XmlElement(ElementName = "TaxCodeShortDescription")]
        public string? TaxCodeShortDescription { get; set; }
        public bool ShouldSerializeTaxCodeShortDescription() => !string.IsNullOrEmpty(TaxCodeShortDescription);

        [XmlElement(ElementName = "Taxable", IsNullable = true)]
        public string? Taxable { get; set; }
        public bool ShouldSerializeTaxable() => !string.IsNullOrEmpty(Taxable);

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; }
        public bool ShouldSerializeNonTaxableReasonCode() => !string.IsNullOrEmpty(NonTaxableReasonCode);

        [XmlElement(ElementName = "NonTaxableReasonShortDescription")]
        public string? NonTaxableReasonShortDescription { get; set; }
        public bool ShouldSerializeNonTaxableReasonShortDescription() => !string.IsNullOrEmpty(NonTaxableReasonShortDescription);

        [XmlElement(ElementName = "HaulerCode")]
        public string? HaulerCode { get; set; }
        public bool ShouldSerializeHaulerCode() => !string.IsNullOrEmpty(HaulerCode);

        [XmlElement(ElementName = "HaulerName")]
        public string? HaulerName { get; set; }
        public bool ShouldSerializeHaulerName() => !string.IsNullOrEmpty(HaulerName);

        [XmlElement(ElementName = "UsageCode")]
        public string? UsageCode { get; set; }
        public bool ShouldSerializeUsageCode() => !string.IsNullOrEmpty(UsageCode);

        [XmlElement(ElementName = "UsageShort")]
        public string? UsageShort { get; set; }
        public bool ShouldSerializeUsageShort() => !string.IsNullOrEmpty(UsageShort);

        [XmlElement(ElementName = "WeightMasterCode")]
        public string? WeightMasterCode { get; set; }
        public bool ShouldSerializeWeightMasterCode() => !string.IsNullOrEmpty(WeightMasterCode);

        [XmlElement(ElementName = "WeightMasterName")]
        public string? WeightMasterName { get; set; }
        public bool ShouldSerializeWeightMasterName() => !string.IsNullOrEmpty(WeightMasterName);

        [XmlElement(ElementName = "WaterAddedOnJob")]
        public double? WaterAddedOnJob { get; set; }
        public bool ShouldSerializeWaterAddedOnJob() => WaterAddedOnJob.HasValue;

        [XmlElement(ElementName = "QBInvoiceEmailChecked")]
        public bool? QBInvoiceEmailChecked { get; set; }
        public bool ShouldSerializeQBInvoiceEmailChecked() => QBInvoiceEmailChecked.HasValue;

        [XmlElement(ElementName = "ScheduledOnJobTime")]
        public DateTime? ScheduledOnJobTime { get; set; }
        public bool ShouldSerializeScheduledOnJobTime() => ScheduledOnJobTime.HasValue;

        [XmlElement(ElementName = "PrintedTime")]
        public DateTime? PrintedTime { get; set; }
        public bool ShouldSerializePrintedTime() => PrintedTime.HasValue;

        [XmlElement(ElementName = "LoadTime")]
        public DateTime? LoadTime { get; set; }
        public bool ShouldSerializeLoadTime() => LoadTime.HasValue;

        [XmlElement(ElementName = "LoadedTime")]
        public DateTime? LoadedTime { get; set; }
        public bool ShouldSerializeLoadedTime() => LoadedTime.HasValue;

        [XmlElement(ElementName = "ToJobTime")]
        public DateTime? ToJobTime { get; set; }
        public bool ShouldSerializeToJobTime() => ToJobTime.HasValue;

        [XmlElement(ElementName = "OnJobTime")]
        public DateTime? OnJobTime { get; set; }
        public bool ShouldSerializeOnJobTime() => OnJobTime.HasValue;

        [XmlElement(ElementName = "UnloadTime")]
        public DateTime? UnloadTime { get; set; }
        public bool ShouldSerializeUnloadTime() => UnloadTime.HasValue;

        [XmlElement(ElementName = "EndUnload")]
        public DateTime? EndUnload { get; set; }
        public bool ShouldSerializeEndUnload() => EndUnload.HasValue;

        [XmlElement(ElementName = "WashTime")]
        public DateTime? WashTime { get; set; }
        public bool ShouldSerializeWashTime() => WashTime.HasValue;

        [XmlElement(ElementName = "ToPlantTime")]
        public DateTime? ToPlantTime { get; set; }
        public bool ShouldSerializeToPlantTime() => ToPlantTime.HasValue;

        [XmlElement(ElementName = "AtPlantTime")]
        public DateTime AtPlantTime { get; set; }

        [XmlElement(ElementName = "Active")]
        public bool? Active { get; set; }
        public bool ShouldSerializeActive() => Active.HasValue;

        [XmlElement(ElementName = "Amount")]
        public double? Amount { get; set; }
        public bool ShouldSerializeAmount() => Amount.HasValue;

        [XmlElement(ElementName = "TotalAmount")]
        public double? TotalAmount { get; set; }
        public bool ShouldSerializeTotalAmount() => TotalAmount.HasValue;

        [XmlElement(ElementName = "TaxAmount")]
        public double? TaxAmount { get; set; }
        public bool ShouldSerializeTaxAmount() => TaxAmount.HasValue;

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public double? TradeDiscountPercent { get; set; }
        public bool ShouldSerializeTradeDiscountPercent() => TradeDiscountPercent.HasValue;

        [XmlElement(ElementName = "TaxExemptID1")]
        public string? TaxExemptID1 { get; set; }
        public bool ShouldSerializeTaxExemptID1() => !string.IsNullOrEmpty(TaxExemptID1);

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public double? TradeDiscountAmount { get; set; }
        public bool ShouldSerializeTradeDiscountAmount() => TradeDiscountAmount.HasValue;

        [XmlElement(ElementName = "BuildingPermit")]
        public string? BuildingPermit { get; set; }
        public bool ShouldSerializeBuildingPermit() => !string.IsNullOrEmpty(BuildingPermit);

        [XmlElement(ElementName = "ScheduleDistance")]
        public double? ScheduleDistance { get; set; }
        public bool ShouldSerializeScheduleDistance() => ScheduleDistance.HasValue;

        [XmlElement(ElementName = "Removed")]
        public bool? Removed { get; set; }
        public bool ShouldSerializeRemoved() => Removed.HasValue;

        [XmlElement(ElementName = "PrintMixWeight")]
        public bool? PrintMixWeight { get; set; }
        public bool ShouldSerializePrintMixWeight() => PrintMixWeight.HasValue;

        [XmlElement(ElementName = "PaymentTermsCode")]
        public string? PaymentTermsCode { get; set; }
        public bool ShouldSerializePaymentTermsCode() => !string.IsNullOrEmpty(PaymentTermsCode);

        [XmlElement(ElementName = "PaymentTermsName")]
        public string? PaymentTermsName { get; set; }
        public bool ShouldSerializePaymentTermsName() => !string.IsNullOrEmpty(PaymentTermsName);

        [XmlElement(ElementName = "SalesmanID")]
        public int? SalesmanID { get; set; }
        public bool ShouldSerializeSalesmanID() => SalesmanID.HasValue;

        [XmlElement(ElementName = "SalesmanCode")]
        public string? SalesmanCode { get; set; }
        public bool ShouldSerializeSalesmanCode() => !string.IsNullOrEmpty(SalesmanCode);

        [XmlElement(ElementName = "SalesmanName")]
        public string? SalesmanName { get; set; }
        public bool ShouldSerializeSalesmanName() => !string.IsNullOrEmpty(SalesmanName);

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string? SalesAnalysisCode { get; set; }
        public bool ShouldSerializeSalesAnalysisCode() => !string.IsNullOrEmpty(SalesAnalysisCode);

        [XmlElement(ElementName = "SchedulingTruckTypeCode")]
        public string? SchedulingTruckTypeCode { get; set; }
        public bool ShouldSerializeSchedulingTruckTypeCode() => !string.IsNullOrEmpty(SchedulingTruckTypeCode);

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime? UpdateTime { get; set; }
        public bool ShouldSerializeUpdateTime() => UpdateTime.HasValue;

        [XmlElement(ElementName = "OrderUpdateTime")]
        public DateTime? OrderUpdateTime { get; set; }
        public bool ShouldSerializeOrderUpdateTime() => OrderUpdateTime.HasValue;

        [XmlElement(ElementName = "Reviewed")]
        public bool? Reviewed { get; set; }
        public bool ShouldSerializeReviewed() => Reviewed.HasValue;

        [XmlElement(ElementName = "Suspended")]
        public bool? Suspended { get; set; }
        public bool ShouldSerializeSuspended() => Suspended.HasValue;

        [XmlElement(ElementName = "Invoiced")]
        public bool? Invoiced { get; set; }
        public bool ShouldSerializeInvoiced() => Invoiced.HasValue;

        [XmlElement(ElementName = "CostAmount")]
        public double? CostAmount { get; set; }
        public bool ShouldSerializeCostAmount() => CostAmount.HasValue;

        [XmlElement(ElementName = "Products")]
        public TicketRetProducts? Products { get; set; }
        public bool ShouldSerializeProducts() => Products != null;

        [XmlElement(ElementName = "BatchResult")]
        public TicketRetBatchResult? BatchResult { get; set; }
        public bool ShouldSerializeBatchResult() => BatchResult != null;

        [XmlElement(ElementName = "UserDefinedFields")]
        public TicketRetUserDefinedFields? UserDefinedFields { get; set; }
        public bool ShouldSerializeUserDefinedFields() => UserDefinedFields != null;

        [XmlElement(ElementName = "OrderUserDefinedFields")]
        public TicketRetOrderUserDefinedFields? OrderUserDefinedFields { get; set; }
        public bool ShouldSerializeOrderUserDefinedFields() => OrderUserDefinedFields != null;

        [XmlElement(ElementName = "CustomerUserDefinedFields")]
        public TicketRetCustomerUserDefinedFields? CustomerUserDefinedFields { get; set; }
        public bool ShouldSerializeCustomerUserDefinedFields() => CustomerUserDefinedFields != null;
    }

    [XmlRoot("UserDefinedFields")]
    public class TicketRetUserDefinedFields
    {
        [XmlElement("UserDefinedField")]
        public List<TicketRetUserDefinedField> UserDefinedField { get; set; } = new List<TicketRetUserDefinedField>();
    }

    [XmlRoot("UserDefinedField")]
    public class TicketRetUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot("OrderUserDefinedFields")]
    public class TicketRetOrderUserDefinedFields
    {
        [XmlElement("OrderUserDefinedField")]
        public List<TicketRetOrderUserDefinedField> OrderUserDefinedField { get; set; } = new List<TicketRetOrderUserDefinedField>();
    }

    [XmlRoot("OrderUserDefinedField")]
    public class TicketRetOrderUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot("CustomerUserDefinedFields")]
    public class TicketRetCustomerUserDefinedFields
    {
        [XmlElement("CustomerUserDefinedField")]
        public List<TicketRetCustomerUserDefinedField> CustomerUserDefinedField { get; set; } = new List<TicketRetCustomerUserDefinedField>();
    }

    [XmlRoot("CustomerUserDefinedField")]
    public class TicketRetCustomerUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Product")]
    public class TicketRetProduct
    {
        [XmlElement(ElementName = "ProductID")]
        public int ProductID { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public int ItemID { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public string? ItemCode { get; set; }
        public bool ShouldSerializeItemCode() => !string.IsNullOrEmpty(ItemCode);

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "IsMix")]
        public bool IsMix { get; set; }

        [XmlElement(ElementName = "IsAssoc")]
        public bool IsAssoc { get; set; }

        [XmlElement(ElementName = "ChargeType")]
        public int? ChargeType { get; set; }
        public bool ShouldSerializeChargeType() => ChargeType.HasValue;

        [XmlElement(ElementName = "Price")]
        public decimal? Price { get; set; }
        public bool ShouldSerializePrice() => Price.HasValue;

        [XmlElement(ElementName = "PriceUnit")]
        public string? PriceUnit { get; set; }
        public bool ShouldSerializePriceUnit() => !string.IsNullOrEmpty(PriceUnit);

        [XmlElement(ElementName = "OrderQty")]
        public double? OrderQty { get; set; }
        public bool ShouldSerializeOrderQty() => OrderQty.HasValue;

        [XmlElement(ElementName = "OrderQtyUnit")]
        public string? OrderQtyUnit { get; set; }
        public bool ShouldSerializeOrderQtyUnit() => !string.IsNullOrEmpty(OrderQtyUnit);

        [XmlElement(ElementName = "LoadQty")]
        public double? LoadQty { get; set; }
        public bool ShouldSerializeLoadQty() => LoadQty.HasValue;

        [XmlElement(ElementName = "DelvQty")]
        public double? DelvQty { get; set; }
        public bool ShouldSerializeDelvQty() => DelvQty.HasValue;

        [XmlElement(ElementName = "DelvQtyUnit")]
        public string? DelvQtyUnit { get; set; }
        public bool ShouldSerializeDelvQtyUnit() => !string.IsNullOrEmpty(DelvQtyUnit);

        [XmlElement(ElementName = "AccDelvQty")]
        public double? AccDelvQty { get; set; }
        public bool ShouldSerializeAccDelvQty() => AccDelvQty.HasValue;

        [XmlElement(ElementName = "PreQty")]
        public double? PreQty { get; set; }
        public bool ShouldSerializePreQty() => PreQty.HasValue;

        [XmlElement(ElementName = "TicketQty")]
        public double? TicketQty { get; set; }
        public bool ShouldSerializeTicketQty() => TicketQty.HasValue;

        [XmlElement(ElementName = "TicketQtyUnit")]
        public string? TicketQtyUnit { get; set; }
        public bool ShouldSerializeTicketQtyUnit() => !string.IsNullOrEmpty(TicketQtyUnit);

        [XmlElement(ElementName = "PriceQty")]
        public double? PriceQty { get; set; }
        public bool ShouldSerializePriceQty() => PriceQty.HasValue;

        [XmlElement(ElementName = "PriceQtyUnit")]
        public string? PriceQtyUnit { get; set; }
        public bool ShouldSerializePriceQtyUnit() => !string.IsNullOrEmpty(PriceQtyUnit);

        [XmlElement(ElementName = "Slump")]
        public double? Slump { get; set; }
        public bool ShouldSerializeSlump() => Slump.HasValue;

        [XmlElement(ElementName = "TrimPercent")]
        public double? TrimPercent { get; set; }
        public bool ShouldSerializeTrimPercent() => TrimPercent.HasValue;

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool? TradeDiscountable { get; set; }
        public bool ShouldSerializeTradeDiscountable() => TradeDiscountable.HasValue;

        [XmlElement(ElementName = "Taxable")]
        public string? Taxable { get; set; }
        public bool ShouldSerializeTaxable() => !string.IsNullOrEmpty(Taxable);

        [XmlElement(ElementName = "Tax1")]
        public double? Tax1 { get; set; }
        public bool ShouldSerializeTax1() => Tax1.HasValue;

        [XmlElement(ElementName = "Tax2")]
        public double? Tax2 { get; set; }
        public bool ShouldSerializeTax2() => Tax2.HasValue;

        [XmlElement(ElementName = "Tax3")]
        public double? Tax3 { get; set; }
        public bool ShouldSerializeTax3() => Tax3.HasValue;

        [XmlElement(ElementName = "Tax4")]
        public double? Tax4 { get; set; }
        public bool ShouldSerializeTax4() => Tax4.HasValue;

        [XmlElement(ElementName = "Tax5")]
        public double? Tax5 { get; set; }
        public bool ShouldSerializeTax5() => Tax5.HasValue;

        [XmlElement(ElementName = "TaxAmount")]
        public double? TaxAmount { get; set; }
        public bool ShouldSerializeTaxAmount() => TaxAmount.HasValue;

        [XmlElement(ElementName = "Amount")]
        public double? Amount { get; set; }
        public bool ShouldSerializeAmount() => Amount.HasValue;

        [XmlElement(ElementName = "TotalAmount")]
        public double? TotalAmount { get; set; }
        public bool ShouldSerializeTotalAmount() => TotalAmount.HasValue;

        [XmlElement(ElementName = "AccountLinkCode")]
        public string? AccountLinkCode { get; set; }
        public bool ShouldSerializeAccountLinkCode() => !string.IsNullOrEmpty(AccountLinkCode);

        [XmlElement(ElementName = "ItemCategoryID")]
        public int? ItemCategoryID { get; set; }
        public bool ShouldSerializeItemCategoryID() => ItemCategoryID.HasValue;

        [XmlElement(ElementName = "ItemCategoryCode")]
        public string? ItemCategoryCode { get; set; }
        public bool ShouldSerializeItemCategoryCode() => !string.IsNullOrEmpty(ItemCategoryCode);

        [XmlElement(ElementName = "ItemCategoryAccountLinkCode")]
        public string? ItemCategoryAccountLinkCode { get; set; }
        public bool ShouldSerializeItemCategoryAccountLinkCode() => !string.IsNullOrEmpty(ItemCategoryAccountLinkCode);

        [XmlElement(ElementName = "ProductLink")]
        public string? ProductLink { get; set; }
        public bool ShouldSerializeProductLink() => !string.IsNullOrEmpty(ProductLink);

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeItemTypeID() => ItemTypeID.HasValue;

        [XmlElement(ElementName = "ItemTypeName")]
        public string? ItemTypeName { get; set; }
        public bool ShouldSerializeItemTypeName() => !string.IsNullOrEmpty(ItemTypeName);

        [XmlElement(ElementName = "Cost")]
        public double? Cost { get; set; }
        public bool ShouldSerializeCost() => Cost.HasValue;

        [XmlElement(ElementName = "CostUnit")]
        public string? CostUnit { get; set; }
        public bool ShouldSerializeCostUnit() => !string.IsNullOrEmpty(CostUnit);

        [XmlElement(ElementName = "CostAmount")]
        public double? CostAmount { get; set; }
        public bool ShouldSerializeCostAmount() => CostAmount.HasValue;
    }

    [XmlRoot(ElementName = "Products")]
    public class TicketRetProducts
    {
        [XmlElement(ElementName = "Product")]
        public List<TicketRetProduct> Product { get; set; } = new List<TicketRetProduct>();
    }

    [XmlRoot(ElementName = "Material")]
    public class TicketRetMaterial
    {
        [XmlElement(ElementName = "ItemID")]
        public int? ItemID { get; set; }
        public bool ShouldSerializeItemID() => ItemID.HasValue;

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "BatchTarget")]
        public double BatchTarget { get; set; }

        [XmlElement(ElementName = "BatchActual")]
        public double BatchActual { get; set; }

        [XmlElement(ElementName = "BatchUnit")]
        public string? BatchUnit { get; set; }
        public bool ShouldSerializeBatchUnit() => !string.IsNullOrEmpty(BatchUnit);

        [XmlElement(ElementName = "MoisturePercent")]
        public double? MoisturePercent { get; set; }
        public bool ShouldSerializeMoisturePercent() => MoisturePercent.HasValue;

        [XmlElement(ElementName = "ItemCategoryID")]
        public int? ItemCategoryID { get; set; }
        public bool ShouldSerializeItemCategoryID() => ItemCategoryID.HasValue;

        [XmlElement(ElementName = "ItemCategoryCode")]
        public string? ItemCategoryCode { get; set; }
        public bool ShouldSerializeItemCategoryCode() => !string.IsNullOrEmpty(ItemCategoryCode);

        [XmlElement(ElementName = "ProductLink")]
        public string? ProductLink { get; set; }
        public bool ShouldSerializeProductLink() => !string.IsNullOrEmpty(ProductLink);

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeItemTypeID() => ItemTypeID.HasValue;

        [XmlElement(ElementName = "ItemTypeName")]
        public string? ItemTypeName { get; set; }
        public bool ShouldSerializeItemTypeName() => !string.IsNullOrEmpty(ItemTypeName);
    }

    [XmlRoot(ElementName = "BatchWeight")]
    public class TicketRetBatchWeight
    {
        [XmlElement(ElementName = "Material")]
        public List<TicketRetMaterial> Material { get; set; } = new List<TicketRetMaterial>();
    }

    [XmlRoot(ElementName = "BatchResult")]
    public class TicketRetBatchResult
    {
        [XmlElement(ElementName = "TemperWater")]
        public double? TemperWater { get; set; }
        public bool ShouldSerializeTemperWater() => TemperWater.HasValue;

        [XmlElement(ElementName = "TemperWaterUnit")]
        public string? TemperWaterUnit { get; set; }
        public bool ShouldSerializeTemperWaterUnit() => !string.IsNullOrEmpty(TemperWaterUnit);

        [XmlElement(ElementName = "BatchWeight")]
        public TicketRetBatchWeight? BatchWeight { get; set; }
        public bool ShouldSerializeBatchWeight() => BatchWeight != null;
    }
}
