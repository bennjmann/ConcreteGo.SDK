using ConcreteGo.Api.Client.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot("OrderRet")]
    public class OrderRet
    {      
        [XmlElement(ElementName = "OrderID")]
        public int OrderID { get; set; }

        [XmlElement(ElementName = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [XmlElement(ElementName = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement(ElementName = "OrderCode")]
        public string OrderCode { get; set; }

        [XmlElement(ElementName = "OrderType")]
        public int OrderType { get; set; }

        [XmlElement(ElementName = "OrderTypeDescription")]
        public string OrderTypeDescription { get; set; }

        [XmlElement(ElementName = "CustomerID")]
        public int CustomerID { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; }
        public bool ShouldSerializeCustomerJob()
        {
            return !string.IsNullOrEmpty(CustomerJob);
        }

        [XmlElement(ElementName = "PaymentForm")]
        public int PaymentForm { get; set; }

        [XmlElement(ElementName = "ProjectID")]
        public int? ProjectID { get; set; }
        public bool ShouldSerializeProjectID()
        {
            return ProjectID.HasValue;
        }

        [XmlElement(ElementName = "ProjectCode")]
        public string ProjectCode { get; set; }
        public bool ShouldSerializeProjectCode()
        {
            return !string.IsNullOrEmpty(ProjectCode);
        }

        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName { get; set; }
        public bool ShouldSerializeProjectName()
        {
            return !string.IsNullOrEmpty(ProjectName);
        }

        [XmlElement(ElementName = "LotBlockNumber")]
        public string LotBlockNumber { get; set; }
        public bool ShouldSerializeLotBlockNumber()
        {
            return !string.IsNullOrEmpty(LotBlockNumber);
        }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; }
        public bool ShouldSerializePurchaseOrder()
        {
            return !string.IsNullOrEmpty(PurchaseOrder);
        }

        [XmlElement(ElementName = "JobNumber")]
        public string JobNumber { get; set; }
        public bool ShouldSerializeJobNumber()
        {
            return !string.IsNullOrEmpty(JobNumber);
        }

        [XmlElement(ElementName = "DeliveryAddr1")]
        public string DeliveryAddr1 { get; set; }
        public bool ShouldSerializeDeliveryAddr1()
        {
            return !string.IsNullOrEmpty(DeliveryAddr1);
        }

        [XmlElement(ElementName = "DeliveryAddr2")]
        public string DeliveryAddr2 { get; set; }
        public bool ShouldSerializeDeliveryAddr2()
        {
            return !string.IsNullOrEmpty(DeliveryAddr2);
        }

        [XmlElement(ElementName = "DeliveryAddr3")]
        public string DeliveryAddr3 { get; set; }
        public bool ShouldSerializeDeliveryAddr3()
        {
            return !string.IsNullOrEmpty(DeliveryAddr3);
        }

        [XmlElement(ElementName = "InstructionAddr1")]
        public string InstructionAddr1 { get; set; }
        public bool ShouldSerializeInstructionAddr1()
        {
            return !string.IsNullOrEmpty(InstructionAddr1);
        }

        [XmlElement(ElementName = "InstructionAddr2")]
        public string InstructionAddr2 { get; set; }
        public bool ShouldSerializeInstructionAddr2()
        {
            return !string.IsNullOrEmpty(InstructionAddr2);
        }

        [XmlElement(ElementName = "InstructionAddr3")]
        public string InstructionAddr3 { get; set; }
        public bool ShouldSerializeInstructionAddr3()
        {
            return !string.IsNullOrEmpty(InstructionAddr3);
        }

        [XmlElement(ElementName = "InstructionAddr4")]
        public string InstructionAddr4 { get; set; }
        public bool ShouldSerializeInstructionAddr4()
        {
            return !string.IsNullOrEmpty(InstructionAddr4);
        }

        [XmlElement(ElementName = "InstructionAddr5")]
        public string InstructionAddr5 { get; set; }
        public bool ShouldSerializeInstructionAddr5()
        {
            return !string.IsNullOrEmpty(InstructionAddr5);
        }

        [XmlElement(ElementName = "InstructionAddr6")]
        public string InstructionAddr6 { get; set; }
        public bool ShouldSerializeInstructionAddr6()
        {
            return !string.IsNullOrEmpty(InstructionAddr6);
        }

        [XmlElement(ElementName = "MapPage")]
        public string MapPage { get; set; }
        public bool ShouldSerializeMapPage()
        {
            return !string.IsNullOrEmpty(MapPage);
        }

        [XmlElement(ElementName = "ZoneCode")]
        public string ZoneCode { get; set; }
        public bool ShouldSerializeZoneCode()
        {
            return !string.IsNullOrEmpty(ZoneCode);
        }

        [XmlElement(ElementName = "ZoneName")]
        public string ZoneName { get; set; }
        public bool ShouldSerializeZoneName()
        {
            return !string.IsNullOrEmpty(ZoneName);
        }

        [XmlElement(ElementName = "CurrentStatus")]
        public int CurrentStatus { get; set; }

        [XmlElement(ElementName = "Removed")]
        public bool? Removed { get; set; }
        public bool ShouldSerializeRemoved()
        {
            return Removed.HasValue;
        }

        [XmlElement(ElementName = "RemoveReasonCode")]
        public string RemoveReasonCode { get; set; }
        public bool ShouldSerializeRemoveReasonCode()
        {
            return !string.IsNullOrEmpty(RemoveReasonCode);
        }

        [XmlElement(ElementName = "HaulerCode")]
        public string HaulerCode { get; set; }
        public bool ShouldSerializeHaulerCode()
        {
            return !string.IsNullOrEmpty(HaulerCode);
        }

        [XmlElement(ElementName = "HaulerName")]
        public string HaulerName { get; set; }
        public bool ShouldSerializeHaulerName()
        {
            return !string.IsNullOrEmpty(HaulerName);
        }

        [XmlElement(ElementName = "PriceCategoryCode")]
        public string PriceCategoryCode { get; set; }
        public bool ShouldSerializePriceCategoryCode()
        {
            return !string.IsNullOrEmpty(PriceCategoryCode);
        }

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; }
        public bool ShouldSerializePriceCategoryName()
        {
            return !string.IsNullOrEmpty(PriceCategoryName);
        }

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public bool Taxable { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; }
        public bool ShouldSerializeNonTaxableReasonCode()
        {
            return !string.IsNullOrEmpty(NonTaxableReasonCode);
        }

        [XmlElement(ElementName = "NonTaxableReasonShortDescription")]
        public string NonTaxableReasonShortDescription { get; set; }
        public bool ShouldSerializeNonTaxableReasonShortDescription()
        {
            return !string.IsNullOrEmpty(NonTaxableReasonShortDescription);
        }

        [XmlElement(ElementName = "TakenByEmployeeID")]
        public int? TakenByEmployeeID { get; set; }
        public bool ShouldSerializeTakenByEmployeeID()
        {
            return TakenByEmployeeID.HasValue;
        }

        [XmlElement(ElementName = "TakenByEmployeeCode")]
        public string TakenByEmployeeCode { get; set; }
        public bool ShouldSerializeTakenByEmployeeCode()
        {
            return !string.IsNullOrEmpty(TakenByEmployeeCode);
        }

        [XmlElement(ElementName = "TakenOnExtension")]
        public string TakenOnExtension { get; set; }
        public bool ShouldSerializeTakenOnExtension()
        {
            return !string.IsNullOrEmpty(TakenOnExtension);
        }

        [XmlElement(ElementName = "OrderedByName")]
        public string OrderedByName { get; set; }
        public bool ShouldSerializeOrderedByName()
        {
            return !string.IsNullOrEmpty(OrderedByName);
        }

        [XmlElement(ElementName = "OrderedByPhone")]
        public string OrderedByPhone { get; set; }
        public bool ShouldSerializeOrderedByPhone()
        {
            return !string.IsNullOrEmpty(OrderedByPhone);
        }

        [XmlElement(ElementName = "RecipientEmail")]
        public string RecipientEmail { get; set; }
        public bool ShouldSerializeRecipientEmail()
        {
            return !string.IsNullOrEmpty(RecipientEmail);
        }

        [XmlElement(ElementName = "PocketNumber")]
        public string PocketNumber { get; set; }
        public bool ShouldSerializePocketNumber()
        {
            return !string.IsNullOrEmpty(PocketNumber);
        }

        [XmlElement(ElementName = "SalesmanID")]
        public int? SalesmanID { get; set; }
        public bool ShouldSerializeSalesmanID()
        {
            return SalesmanID.HasValue;
        }

        [XmlElement(ElementName = "SalesmanCode")]
        public string SalesmanCode { get; set; }
        public bool ShouldSerializeSalesmanCode()
        {
            return !string.IsNullOrEmpty(SalesmanCode);
        }

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; }
        public bool ShouldSerializeSalesmanName()
        {
            return !string.IsNullOrEmpty(SalesmanName);
        }

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; }
        public bool ShouldSerializeSalesAnalysisCode()
        {
            return !string.IsNullOrEmpty(SalesAnalysisCode);
        }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public double? TradeDiscountPercent { get; set; }
        public bool ShouldSerializeTradeDiscountPercent()
        {
            return TradeDiscountPercent.HasValue;
        }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public decimal? TradeDiscountAmount { get; set; }
        public bool ShouldSerializeTradeDiscountAmount()
        {
            return TradeDiscountAmount.HasValue;
        }

        [XmlElement(ElementName = "GrandTotalAmount")]
        public decimal? GrandTotalAmount { get; set; }
        public bool ShouldSerializeGrandTotalAmount()
        {
            return GrandTotalAmount.HasValue;
        }

        [XmlElement(ElementName = "IsSuspended")]
        public bool? IsSuspended { get; set; }
        public bool ShouldSerializeIsSuspended()
        {
            return IsSuspended.HasValue;
        }

        [XmlElement(ElementName = "SuspendReasonCode")]
        public string SuspendReasonCode { get; set; }
        public bool ShouldSerializeSuspendReasonCode()
        {
            return !string.IsNullOrEmpty(SuspendReasonCode);
        }

        [XmlElement(ElementName = "SuspendShortDescription")]
        public string SuspendShortDescription { get; set; }
        public bool ShouldSerializeSuspendShortDescription()
        {
            return !string.IsNullOrEmpty(SuspendShortDescription);
        }

        [XmlElement(ElementName = "CreditOverrideUser")]
        public string CreditOverrideUser { get; set; }
        public bool ShouldSerializeCreditOverrideUser()
        {
            return !string.IsNullOrEmpty(CreditOverrideUser);
        }

        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; }
        public bool ShouldSerializeLatitude()
        {
            return !string.IsNullOrEmpty(Latitude);
        }

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; }
        public bool ShouldSerializeLongitude()
        {
            return !string.IsNullOrEmpty(Longitude);
        }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; }
        public bool ShouldSerializeUsageCode()
        {
            return !string.IsNullOrEmpty(UsageCode);
        }

        [XmlElement(ElementName = "UsageShort")]
        public string UsageShort { get; set; }
        public bool ShouldSerializeUsageShort()
        {
            return !string.IsNullOrEmpty(UsageShort);
        }

        [XmlElement(ElementName = "RemovedBy")]
        public string RemovedBy { get; set; }
        public bool ShouldSerializeRemovedBy()
        {
            return !string.IsNullOrEmpty(RemovedBy);
        }

        [XmlElement(ElementName = "BuildingPermit")]
        public string BuildingPermit { get; set; }
        public bool ShouldSerializeBuildingPermit()
        {
            return !string.IsNullOrEmpty(BuildingPermit);
        }

        [XmlElement(ElementName = "ConfirmedBy")]
        public string ConfirmedBy { get; set; }
        public bool ShouldSerializeConfirmedBy()
        {
            return !string.IsNullOrEmpty(ConfirmedBy);
        }

        [XmlElement(ElementName = "JobsiteRadius")]
        public int? JobsiteRadius { get; set; }
        public bool ShouldSerializeJobsiteRadius()
        {
            return JobsiteRadius.HasValue;
        }

        [XmlElement(ElementName = "Reviewed")]
        public bool? Reviewed { get; set; }
        public bool ShouldSerializeReviewed()
        {
            return Reviewed.HasValue;
        }

        [XmlElement(ElementName = "PaymentAmount")]
        public decimal? PaymentAmount { get; set; }
        public bool ShouldSerializePaymentAmount()
        {
            return PaymentAmount.HasValue;
        }

        [XmlElement(ElementName = "CheckNumber")]
        public string CheckNumber { get; set; }
        public bool ShouldSerializeCheckNumber()
        {
            return !string.IsNullOrEmpty(CheckNumber);
        }

        [XmlElement(ElementName = "CreditCardLastFourDigits")]
        public string CreditCardLastFourDigits { get; set; }
        public bool ShouldSerializeCreditCardLastFourDigits()
        {
            return !string.IsNullOrEmpty(CreditCardLastFourDigits);
        }

        [XmlElement(ElementName = "CreditCardExpirationDate")]
        public string CreditCardExpirationDate { get; set; }
        public bool ShouldSerializeCreditCardExpirationDate()
        {
            return !string.IsNullOrEmpty(CreditCardExpirationDate);
        }

        [XmlElement(ElementName = "CreditCardAuthorizationCode")]
        public string CreditCardAuthorizationCode { get; set; }
        public bool ShouldSerializeCreditCardAuthorizationCode()
        {
            return !string.IsNullOrEmpty(CreditCardAuthorizationCode);
        }

        [XmlElement(ElementName = "BankAccount")]
        public string BankAccount { get; set; }
        public bool ShouldSerializeBankAccount()
        {
            return !string.IsNullOrEmpty(BankAccount);
        }

        [XmlElement(ElementName = "Products")]
        public OrderRetProducts Products { get; set; }
        public bool ShouldSerializeProducts()
        {
            return Products != null;
        }

        [XmlElement(ElementName = "Notes")]
        public OrderRetNotes Notes { get; set; }
        public bool ShouldSerializeNotes()
        {
            return Notes != null;
        }

        [XmlElement(ElementName = "UserDefinedFields")]
        public OrderRetUserDefinedFields UserDefinedFields { get; set; }
        public bool ShouldSerializeUserDefinedFields()
        {
            return UserDefinedFields != null;
        }
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class OrderRetUserDefinedFields
    {
        [XmlElement(ElementName = "UserDefinedField")]
        public List<OrderRetUserDefinedField> UserDefinedField { get; set; }
        public bool ShouldSerializeUserDefinedField()
        {
            return UserDefinedField != null && UserDefinedField.Any();
        }
    }

    [XmlRoot("UserDefinedField")]
    public class OrderRetUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Notes")]
    public class OrderRetNotes
    {
        [XmlElement(ElementName = "Note")]
        public List<OrderRetNote> Note { get; set; }
        public bool ShouldSerializeNote()
        {
            return Note != null && Note.Any();
        }
    }

    [XmlRoot(ElementName = "ScheduleLoad")]
    public class OrderRetScheduleLoad
    {
        [XmlElement(ElementName = "ScheduleLoadID")]
        public int ScheduleLoadID { get; set; }

        [XmlElement(ElementName = "FromPlantID")]
        public int FromPlantID { get; set; }

        [XmlElement(ElementName = "FromPlant")]
        public string FromPlant { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public double LoadQty { get; set; }

        [XmlElement(ElementName = "TruckID")]
        public int? TruckID { get; set; }
        public bool ShouldSerializeTruckID()
        {
            return TruckID.HasValue;
        }

        [XmlElement(ElementName = "TruckCode")]
        public string TruckCode { get; set; }
        public bool ShouldSerializeTruckCode()
        {
            return !string.IsNullOrEmpty(TruckCode);
        }

        [XmlElement(ElementName = "ToPlantID")]
        public int ToPlantID { get; set; }

        [XmlElement(ElementName = "ToPlant")]
        public string ToPlant { get; set; }

        [XmlElement(ElementName = "TimeToJob")]
        public int TimeToJob { get; set; }

        [XmlElement(ElementName = "UnloadTime")]
        public int UnloadTime { get; set; }

        [XmlElement(ElementName = "TimeToPlant")]
        public int TimeToPlant { get; set; }

        [XmlElement(ElementName = "TruckSpace")]
        public int TruckSpace { get; set; }

        [XmlElement(ElementName = "PrintedTime")]
        public DateTime PrintedTime { get; set; }

        [XmlElement(ElementName = "LoadTime")]
        public DateTime LoadTime { get; set; }

        [XmlElement(ElementName = "OnJobTime")]
        public DateTime OnJobTime { get; set; }

        [XmlElement(ElementName = "FinPourTime")]
        public DateTime FinPourTime { get; set; }

        [XmlElement(ElementName = "AtPlantTime")]
        public DateTime AtPlantTime { get; set; }

        [XmlElement(ElementName = "TimeToWash")]
        public int TimeToWash { get; set; }

        [XmlElement(ElementName = "TicketID")]
        public int? TicketID { get; set; }
        public bool ShouldSerializeTicketID()
        {
            return TicketID.HasValue;
        }

        [XmlElement(ElementName = "TicketCode")]
        public string TicketCode { get; set; }
        public bool ShouldSerializeTicketCode()
        {
            return !string.IsNullOrEmpty(TicketCode);
        }
    }

    [XmlRoot(ElementName = "ScheduleLoads")]
    public class OrderRetScheduleLoads
    {
        [XmlElement(ElementName = "ScheduleLoad")]
        public List<OrderRetScheduleLoad> ScheduleLoad { get; set; }
        public bool ShouldSerializeScheduleLoad()
        {
            return ScheduleLoad != null && ScheduleLoad.Any();
        }
    }

    [XmlRoot(ElementName = "Schedule")]
    public class OrderRetSchedule
    {
        [XmlElement(ElementName = "ProductScheduleID")]
        public int ProductScheduleID { get; set; }

        [XmlElement(ElementName = "PlantID")]
        public int PlantID { get; set; }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "StartTime")]
        public DateTime StartTime { get; set; }

        [XmlElement(ElementName = "ScheduleQty")]
        public double ScheduleQty { get; set; }

        [XmlElement(ElementName = "ScheduleDelvQty")]
        public double ScheduleDelvQty { get; set; }

        [XmlElement(ElementName = "HoldQty")]
        public double HoldQty { get; set; }

        [XmlElement(ElementName = "TruckTypeID")]
        public int TruckTypeID { get; set; }

        [XmlElement(ElementName = "TruckTypeCode")]
        public string TruckTypeCode { get; set; }

        [XmlElement(ElementName = "TruckTypeName")]
        public string TruckTypeName { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public double LoadQty { get; set; }

        [XmlElement(ElementName = "JobWashTime")]
        public int JobWashTime { get; set; }

        [XmlElement(ElementName = "PouringMethodCode")]
        public string PouringMethodCode { get; set; }
        public bool ShouldSerializePouringMethodCode()
        {
            return !string.IsNullOrEmpty(PouringMethodCode);
        }

        [XmlElement(ElementName = "PouringMethodShort")]
        public string PouringMethodShort { get; set; }
        public bool ShouldSerializePouringMethodShort()
        {
            return !string.IsNullOrEmpty(PouringMethodShort);
        }

        [XmlElement(ElementName = "UnloadRatePerHour")]
        public double? UnloadRatePerHour { get; set; }
        public bool ShouldSerializeUnloadRatePerHour()
        {
            return UnloadRatePerHour.HasValue;
        }

        [XmlElement(ElementName = "Distance")]
        public double? Distance { get; set; }
        public bool ShouldSerializeDistance()
        {
            return Distance.HasValue;
        }

        [XmlElement(ElementName = "TimeToJob")]
        public int TimeToJob { get; set; }

        [XmlElement(ElementName = "TimeToPlant")]
        public int TimeToPlant { get; set; }

        [XmlElement(ElementName = "TruckSpace")]
        public int TruckSpace { get; set; }

        [XmlElement(ElementName = "UnloadTime")]
        public int UnloadTime { get; set; }

        [XmlElement(ElementName = "DeliveryRatePerHour")]
        public double DeliveryRatePerHour { get; set; }

        [XmlElement(ElementName = "TrucksRequired")]
        public double TrucksRequired { get; set; }

        [XmlElement(ElementName = "NumberOfLoads")]
        public int NumberOfLoads { get; set; }

        [XmlElement(ElementName = "ScheduleLoads")]
        public OrderRetScheduleLoads ScheduleLoads { get; set; }
        public bool ShouldSerializeScheduleLoads()
        {
            return ScheduleLoads != null;
        }
    }

    [XmlRoot(ElementName = "Schedules")]
    public class OrderRetSchedules
    {
        [XmlElement(ElementName = "Schedule")]
        public OrderRetSchedule Schedule { get; set; }
        public bool ShouldSerializeSchedule()
        {
            return Schedule != null;
        }
    }

    [XmlRoot(ElementName = "Product")]
    public class OrderRetProduct
    {
        [XmlElement(ElementName = "ProductID")]
        public int ProductID { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public int ItemID { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "IsMix")]
        public bool IsMix { get; set; }

        [XmlElement(ElementName = "IsAssoc")]
        public bool IsAssoc { get; set; }

        [XmlElement(ElementName = "Price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "PriceUnit")]
        public string PriceUnit { get; set; }

        [XmlElement(ElementName = "OrderQty")]
        public double OrderQty { get; set; }

        [XmlElement(ElementName = "OrderQtyUnit")]
        public string OrderQtyUnit { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public double LoadQty { get; set; }

        [XmlElement(ElementName = "DelvQty")]
        public double DelvQty { get; set; }

        [XmlElement(ElementName = "DelvQtyUnit")]
        public string DelvQtyUnit { get; set; }

        [XmlElement(ElementName = "Slump")]
        public string Slump { get; set; }
        public bool ShouldSerializeSlump()
        {
            return !string.IsNullOrEmpty(Slump);
        }

        [XmlElement(ElementName = "TrimPercent")]
        public double? TrimPercent { get; set; }
        public bool ShouldSerializeTrimPercent()
        {
            return TrimPercent.HasValue;
        }

        [XmlElement(ElementName = "Comments")]
        public string Comments { get; set; }
        public bool ShouldSerializeComments()
        {
            return !string.IsNullOrEmpty(Comments);
        }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; }
        public bool ShouldSerializeUsageCode()
        {
            return !string.IsNullOrEmpty(UsageCode);
        }

        [XmlElement(ElementName = "UsageName")]
        public string UsageName { get; set; }
        public bool ShouldSerializeUsageName()
        {
            return !string.IsNullOrEmpty(UsageName);
        }

        [XmlElement(ElementName = "Taxable")]
        public bool Taxable { get; set; }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool TradeDiscountable { get; set; }

        [XmlElement(ElementName = "Schedules")]
        public OrderRetSchedules Schedules { get; set; }
        public bool ShouldSerializeSchedules()
        {
            return Schedules != null;
        }
    }

    [XmlRoot(ElementName = "Products")]
    public class OrderRetProducts
    {
        [XmlElement(ElementName = "Product")]
        public List<OrderRetProduct> Product { get; set; }
        public bool ShouldSerializeProduct()
        {
            return Product != null && Product.Any();
        }
    }

    [XmlRoot(ElementName = "Note")]
    public class OrderRetNote
    {
        [XmlElement(ElementName = "NoteID")]
        public int NoteID { get; set; }

        [XmlElement(ElementName = "NoteDescription")]
        public string NoteDescription { get; set; }

        [XmlElement(ElementName = "NoteDate")]
        public DateTime NoteDate { get; set; }
    }
}
