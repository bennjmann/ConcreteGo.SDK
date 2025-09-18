using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Orders
{
    [XmlRoot("OrderRet")]
    public class OrderRet
    {
        [XmlElement(ElementName = "OrderID")]
        public string _OrderID { get; set; }
        [XmlIgnore]
        public int? OrderID 
        {
            get
            {
                if(int.TryParse(_OrderID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "CreatedDate")]
        public string _CreatedDate { get; set; }
        [XmlIgnore]
        public DateTime? CreatedDate
        {
            get
            {
                if(DateTime.TryParse(_CreatedDate, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "OrderDate")]
        public string _OrderDate { get; set; }
        [XmlIgnore]
        public DateTime? OrderDate
        {
            get
            {
                if(DateTime.TryParse(_OrderDate, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "UpdateTime")]
        public string _UpdateTime { get; set; }
        [XmlIgnore]
        public DateTime? UpdateTime
        {
            get
            {
                if(DateTime.TryParse(_UpdateTime, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "OrderCode")]
        public string OrderCode { get; set; }

        [XmlElement(ElementName = "OrderType")]
        public string _OrderType { get; set; }
        [XmlIgnore]
        public int? OrderType
        {
            get
            {
                if(int.TryParse(_OrderType, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "OrderTypeDescription")]
        public string OrderTypeDescription { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; }

        [XmlElement(ElementName = "PaymentForm")]
        public string _PaymentForm { get; set; }
        [XmlIgnore]
        public int? PaymentForm { get { if (int.TryParse(_PaymentForm, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ProjectCode")]
        public string ProjectCode { get; set; }

        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName { get; set; }

        [XmlElement(ElementName = "ProjectID")]
        public string _ProjectID { get; set; }
        [XmlIgnore]
        public int? ProjectID
        {
            get
            {
                if(int.TryParse(_ProjectID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "LotBlockNumber")]
        public string LotBlockNumber { get; set; }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; }

        [XmlElement(ElementName = "JobNumber")]
        public string JobNumber { get; set; }

        [XmlElement(ElementName = "DeliveryAddr1")]
        public string DeliveryAddr1 { get; set; }

        [XmlElement(ElementName = "DeliveryAddr2")]
        public string DeliveryAddr2 { get; set; }

        [XmlElement(ElementName = "DeliveryAddr3")]
        public string DeliveryAddr3 { get; set; }

        [XmlElement(ElementName = "InstructionAddr1")]
        public string InstructionAddr1 { get; set; }

        [XmlElement(ElementName = "InstructionAddr2")]
        public string InstructionAddr2 { get; set; }

        [XmlElement(ElementName = "InstructionAddr3")]
        public string InstructionAddr3 { get; set; }

        [XmlElement(ElementName = "InstructionAddr4")]
        public string InstructionAddr4 { get; set; }

        [XmlElement(ElementName = "InstructionAddr5")]
        public string InstructionAddr5 { get; set; }

        [XmlElement(ElementName = "InstructionAddr6")]
        public string InstructionAddr6 { get; set; }

        [XmlElement(ElementName = "MapPage")]
        public string MapPage { get; set; }

        [XmlElement(ElementName = "ZoneCode")]
        public string ZoneCode { get; set; }

        [XmlElement(ElementName = "ZoneName")]
        public string ZoneName { get; set; }

        [XmlElement(ElementName = "CurrentStatus")]
        public string _CurrentStatus { get; set; }
        [XmlIgnore]
        public int? CurrentStatus
        {
            get
            {
                if (int.TryParse(_CurrentStatus, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "Removed")]
        public string _Removed { get; set; }
        [XmlIgnore]
        public int? Removed
        {
            get
            {
                if (int.TryParse(_Removed, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "RemoveReasonCode")]
        public string RemoveReasonCode { get; set; }

        [XmlElement(ElementName = "HaulerCode")]
        public string HaulerCode { get; set; }

        [XmlElement(ElementName = "HaulerName")]
        public string HaulerName { get; set; }

        [XmlElement(ElementName = "PriceCategoryCode")]
        public string PriceCategoryCode { get; set; }

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; }

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string _Taxable { get; set; }
        [XmlIgnore]
        public bool? Taxable { get { if (bool.TryParse(_Taxable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonShortDescription")]
        public string NonTaxableReasonShortDescription { get; set; }

        [XmlElement(ElementName = "TakenByEmployeeID")]
        public string _TakenByEmployeeID { get; set; }
        [XmlIgnore]
        public int? TakenByEmployeeID { get { if (int.TryParse(_TakenByEmployeeID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TakenByEmployeeCode")]
        public string TakenByEmployeeCode { get; set; }

        [XmlElement(ElementName = "TakenOnExtension")]
        public string TakenOnExtension { get; set; }

        [XmlElement(ElementName = "OrderedByName")]
        public string OrderedByName { get; set; }

        [XmlElement(ElementName = "OrderedByPhone")]
        public string OrderedByPhone { get; set; }

        [XmlElement(ElementName = "RecipientEmail")]
        public string RecipientEmail { get; set; }

        [XmlElement(ElementName = "PocketNumber")]
        public string PocketNumber { get; set; }

        [XmlElement(ElementName = "SalesmanID")]
        public string _SalesmanID { get; set; }
        [XmlIgnore]
        public int? SalesmanID { get { if (int.TryParse(_SalesmanID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "SalesmanCode")]
        public string SalesmanCode { get; set; }

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; }

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public string _TradeDiscountPercent { get; set; }
        [XmlIgnore]
        public double? TradeDiscountPercent { get { if (double.TryParse(_TradeDiscountPercent, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public string _TradeDiscountAmount { get; set; }
        [XmlIgnore]
        public double? TradeDiscountAmount { get { if (double.TryParse(_TradeDiscountAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "GrandTotalAmount")]
        public string _GrandTotalAmount { get; set; }
        [XmlIgnore]
        public double? GrandTotalAmount { get { if (double.TryParse(_GrandTotalAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "IsSuspended")]
        public string _IsSuspended { get; set; }
        [XmlIgnore]
        public bool? IsSuspended { get { if (bool.TryParse(_IsSuspended, out var value)) return value; return null; } }

        [XmlElement(ElementName = "SuspendReasonCode")]
        public string SuspendReasonCode { get; set; }

        [XmlElement(ElementName = "SuspendShortDescription")]
        public string SuspendShortDescription { get; set; }

        [XmlElement(ElementName = "CreditOverrideUser")]
        public string CreditOverrideUser { get; set; }

        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; }

        [XmlElement(ElementName = "UsageShort")]
        public string UsageShort { get; set; }

        [XmlElement(ElementName = "RemovedBy")]
        public string RemovedBy { get; set; }

        [XmlElement(ElementName = "BuildingPermit")]
        public string BuildingPermit { get; set; }

        [XmlElement(ElementName = "ConfirmedBy")]
        public string ConfirmedBy { get; set; }

        [XmlElement(ElementName = "JobsiteRadius")]
        public string _JobsiteRadius { get; set; }
        [XmlIgnore]
        public int? JobsiteRadius { get { if (int.TryParse(_JobsiteRadius, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Reviewed")]
        public string _Reviewed { get; set; }
        [XmlIgnore]
        public bool? Reviewed { get { if (bool.TryParse(_Reviewed, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PaymentAmount")]
        public string _PaymentAmount { get; set; }
        [XmlIgnore]
        public decimal? PaymentAmount { get { if (decimal.TryParse(_PaymentAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CheckNumber")]
        public string CheckNumber { get; set; }

        [XmlElement(ElementName = "CreditCardLastFourDigits")]
        public string CreditCardLastFourDigits { get; set; }

        [XmlElement(ElementName = "CreditCardExpirationDate")]
        public string CreditCardExpirationDate { get; set; }

        [XmlElement(ElementName = "CreditCardAuthorizationCode")]
        public string CreditCardAuthorizationCode { get; set; }

        [XmlElement(ElementName = "BankAccount")]
        public string BankAccount { get; set; }

        [XmlElement(ElementName = "Products")]
        public Products Products { get; set; }

        [XmlElement(ElementName = "Notes")]
        public Notes Notes { get; set; }

        [XmlElement(ElementName = "UserDefinedFields")]
        public UserDefinedFields UserDefinedFields { get; set; }
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class UserDefinedFields
    {

        [XmlElement(ElementName = "UserDefinedField")]
        public List<UserDefinedField> UserDefinedField { get; set; }
    }

    [XmlRoot("UserDefinedField")]
    public class UserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Notes")]
    public class Notes
    {

        [XmlElement(ElementName = "Note")]
        public List<Note> Note { get; set; }
    }

    [XmlRoot(ElementName = "ScheduleLoad")]
    public class ScheduleLoad
    {

        [XmlElement(ElementName = "ScheduleLoadID")]
        public string _ScheduleLoadID { get; set; }
        [XmlIgnore]
        public int? ScheduleLoadID { get { if (int.TryParse(_ScheduleLoadID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "FromPlantID")]
        public string _FromPlantID { get; set; }
        [XmlIgnore]
        public int? FromPlantID { get { if (int.TryParse(_FromPlantID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "FromPlant")]
        public string _FromPlant { get; set; }
        [XmlIgnore]
        public int? FromPlant { get { if (int.TryParse(_FromPlant, out var value)) return value; return null; } }

        [XmlElement(ElementName = "LoadQty")]
        public string _LoadQty { get; set; }
        [XmlIgnore]
        public double? LoadQty { get { if (double.TryParse(_LoadQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckID")]
        public string _TruckID { get; set; }
        [XmlIgnore]
        public int? TruckID { get { if (int.TryParse(_TruckID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckCode")]
        public string TruckCode { get; set; }

        [XmlElement(ElementName = "ToPlantID")]
        public string _ToPlantID { get; set; }
        [XmlIgnore]
        public int? ToPlantID { get { if (int.TryParse(_ToPlantID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ToPlant")]
        public string ToPlant { get; set; }

        [XmlElement(ElementName = "TimeToJob")]
        public string _TimeToJob { get; set; }
        [XmlIgnore]
        public int? TimeToJob { get { if (int.TryParse(_TimeToJob, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UnloadTime")]
        public string _UnloadTime { get; set; }
        [XmlIgnore]
        public int? UnloadTime { get { if (int.TryParse(_UnloadTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TimeToPlant")]
        public string _TimeToPlant { get; set; }
        [XmlIgnore]
        public int? TimeToPlant { get { if (int.TryParse(_TimeToPlant, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckSpace")]
        public string _TruckSpace { get; set; }
        [XmlIgnore]
        public int? TruckSpace { get { if (int.TryParse(_TruckSpace, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PrintedTime")]
        public string _PrintedTime { get; set; }
        [XmlIgnore]
        public DateTime? PrintedTime { get { if (DateTime.TryParse(_PrintedTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "LoadTime")]
        public string _LoadTime { get; set; }
        [XmlIgnore]
        public DateTime? LoadTime { get { if (DateTime.TryParse(_LoadTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OnJobTime")]
        public string _OnJobTime { get; set; }
        [XmlIgnore]
        public DateTime? OnJobTime { get { if (DateTime.TryParse(_OnJobTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "FinPourTime")]
        public string _FinPourTime { get; set; }
        [XmlIgnore]
        public DateTime? FinPourTime { get { if (DateTime.TryParse(_FinPourTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "AtPlantTime")]
        public string _AtPlantTime { get; set; }
        [XmlIgnore]
        public DateTime? AtPlantTime { get { if (DateTime.TryParse(_AtPlantTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TimeToWash")]
        public string _TimeToWash { get; set; }
        [XmlIgnore]
        public int? TimeToWash { get { if (int.TryParse(_TimeToWash, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TicketID")]
        public string _TicketID { get; set; }
        [XmlIgnore]
        public int? TicketID { get { if (int.TryParse(_TicketID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TicketCode")]
        public string TicketCode { get; set; }
    }

    [XmlRoot(ElementName = "ScheduleLoads")]
    public class ScheduleLoads
    {

        [XmlElement(ElementName = "ScheduleLoad")]
        public List<ScheduleLoad> ScheduleLoad { get; set; }
    }

    [XmlRoot(ElementName = "Schedule")]
    public class Schedule
    {

        [XmlElement(ElementName = "ProductScheduleID")]
        public string _ProductScheduleID { get; set; }
        [XmlIgnore]
        public int? ProductScheduleID { get { if (int.TryParse(_ProductScheduleID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PlantID")]
        public string _PlantID { get; set; }
        [XmlIgnore]
        public int? PlantID { get { if (int.TryParse(_PlantID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "StartTime")]
        public string _StartTime { get; set; }
        [XmlIgnore]
        public DateTime? StartTime { get { if (DateTime.TryParse(_StartTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ScheduleQty")]
        public string _ScheduleQty { get; set; }
        [XmlIgnore]
        public double? ScheduleQty { get { if (double.TryParse(_ScheduleQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ScheduleDelvQty")]
        public string _ScheduleDelvQty { get; set; }
        [XmlIgnore]
        public double? ScheduleDelvQty { get { if (double.TryParse(_ScheduleDelvQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "HoldQty")]
        public string _HoldQty { get; set; }
        [XmlIgnore]
        public double? HoldQty { get { if (double.TryParse(_HoldQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckTypeID")]
        public string _TruckTypeID { get; set; }
        [XmlIgnore]
        public int? TruckTypeID { get { if (int.TryParse(_TruckTypeID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckTypeCode")]
        public string TruckTypeCode { get; set; }

        [XmlElement(ElementName = "TruckTypeName")]
        public string TruckTypeName { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public string _LoadQty { get; set; }
        [XmlIgnore]
        public double? LoadQty { get { if (double.TryParse(_LoadQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "JobWashTime")]
        public string _JobWashTime { get; set; }
        [XmlIgnore]
        public int? JobWashTime { get { if (int.TryParse(_JobWashTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PouringMethodCode")]
        public string PouringMethodCode { get; set; }

        [XmlElement(ElementName = "PouringMethodShort")]
        public string PouringMethodShort { get; set; }

        [XmlElement(ElementName = "UnloadRatePerHour")]
        public string _UnloadRatePerHour { get; set; }
        [XmlIgnore]
        public double? UnloadRatePerHour { get { if (double.TryParse(_UnloadRatePerHour, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Distance")]
        public string _Distance { get; set; }
        [XmlIgnore]
        public double? Distance { get { if (double.TryParse(_Distance, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TimeToJob")]
        public string _TimeToJob { get; set; }
        [XmlIgnore]
        public int? TimeToJob { get { if (int.TryParse(_TimeToJob, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TimeToPlant")]
        public string _TimeToPlant { get; set; }
        [XmlIgnore]
        public int? TimeToPlant { get { if (int.TryParse(_TimeToPlant, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckSpace")]
        public string _TruckSpace { get; set; }
        [XmlIgnore]
        public int? TruckSpace { get { if (int.TryParse(_TruckSpace, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UnloadTime")]
        public string _UnloadTime { get; set; }
        [XmlIgnore]
        public int? UnloadTime { get { if (int.TryParse(_UnloadTime, out var value)) return value; return null; } }

        [XmlElement(ElementName = "DeliveryRatePerHour")]
        public string _DeliveryRatePerHour { get; set; }
        [XmlIgnore]
        public double? DeliveryRatePerHour { get { if (double.TryParse(_DeliveryRatePerHour, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TrucksRequired")]
        public string _TrucksRequired { get; set; }
        [XmlIgnore]
        public double? TrucksRequired { get { if (double.TryParse(_TrucksRequired, out var value)) return value; return null; } }

        [XmlElement(ElementName = "NumberOfLoads")]
        public string _NumberOfLoads { get; set; }
        [XmlIgnore]
        public int? NumberOfLoads { get { if (int.TryParse(_NumberOfLoads, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ScheduleLoads")]
        public ScheduleLoads ScheduleLoads { get; set; }
    }

    [XmlRoot(ElementName = "Schedules")]
    public class Schedules
    {

        [XmlElement(ElementName = "Schedule")]
        public Schedule Schedule { get; set; }
    }

    [XmlRoot(ElementName = "Product")]
    public class Product
    {

        [XmlElement(ElementName = "ProductID")]
        public string _ProductID { get; set; }
        [XmlIgnore]
        public int? ProductID { get { if (int.TryParse(_ProductID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemID")]
        public string _ItemID { get; set; }
        [XmlIgnore]
        public int? ItemID { get { if (int.TryParse(_ItemID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "IsMix")]
        public string _IsMix { get; set; }
        [XmlIgnore]
        public bool? IsMix { get { if (bool.TryParse(_IsMix, out var value)) return value; return null; } }

        [XmlElement(ElementName = "IsAssoc")]
        public string _IsAssoc { get; set; }
        [XmlIgnore]
        public bool? IsAssoc { get { if (bool.TryParse(_IsAssoc, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Price")]
        public string _Price { get; set; }
        [XmlIgnore]
        public double? Price { get { if (double.TryParse(_Price, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PriceUnit")]
        public string PriceUnit { get; set; }

        [XmlElement(ElementName = "OrderQty")]
        public string _OrderQty { get; set; }
        [XmlIgnore]
        public double? OrderQty { get { if (double.TryParse(_OrderQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OrderQtyUnit")]
        public string OrderQtyUnit { get; set; }

        [XmlElement(ElementName = "LoadQty")]
        public string _LoadQty { get; set; }
        [XmlIgnore]
        public double? LoadQty { get { if (double.TryParse(_LoadQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "DelvQty")]
        public string _DelvQty { get; set; }
        [XmlIgnore]
        public double? DelvQty { get { if (double.TryParse(_DelvQty, out var value)) return value; return null; } }

        [XmlElement(ElementName = "DelvQtyUnit")]
        public string DelvQtyUnit { get; set; }

        [XmlElement(ElementName = "Slump")]
        public string Slump { get; set; }

        [XmlElement(ElementName = "TrimPercent")]
        public string TrimPercent { get; set; }

        [XmlElement(ElementName = "Comments")]
        public string Comments { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; }

        [XmlElement(ElementName = "UsageName")]
        public string UsageName { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string _Taxable { get; set; }
        [XmlIgnore]
        public bool? Taxable { get { if (bool.TryParse(_Taxable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TradeDiscountable")]
        public string _TradeDiscountable { get; set; }
        [XmlIgnore]
        public bool? TradeDiscountable { get { if (bool.TryParse(_TradeDiscountable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Schedules")]
        public Schedules Schedules { get; set; }
    }

    [XmlRoot(ElementName = "Products")]
    public class Products
    {

        [XmlElement(ElementName = "Product")]
        public List<Product> Product { get; set; }
    }

    [XmlRoot(ElementName = "Note")]
    public class Note
    {

        [XmlElement(ElementName = "NoteID")]
        public string _NoteID { get; set; }
        [XmlIgnore]
        public int? NoteID { get { if (int.TryParse(_NoteID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "NoteDescription")]
        public string NoteDescription { get; set; }

        [XmlElement(ElementName = "NoteDate")]
        public string _NoteDate { get; set; }
        [XmlIgnore]
        public DateTime? NoteDate { get { if (DateTime.TryParse(_NoteDate, out var value)) return value; return null; } }
    }
}
