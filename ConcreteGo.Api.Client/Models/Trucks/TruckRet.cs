using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    [XmlRoot("TruckRet")]
    public class TruckRet
    {
        [XmlElement(ElementName = "ID")]
        public string _ID { get; set; }
        [XmlIgnore]
        public int? ID { get { if (int.TryParse(_ID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "Active")]
        public string _Active { get; set; }
        [XmlIgnore]
        public bool? Active
        {
            get
            {
                if(bool.TryParse(_Active, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "OwnerName")]
        public string OwnerName { get; set; }

        [XmlElement(ElementName = "LicenseNumber")]
        public string LicenseNumber { get; set; }

        [XmlElement(ElementName = "LicenseExpirationDate")]
        public string _LicenseExpirationDate { get; set; }
        [XmlIgnore]
        public DateTime? LicenseExpirationDate
        {
            get
            {
                if(DateTime.TryParse(_LicenseExpirationDate, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PlantID")]
        public string _PlantID { get; set; }
        [XmlIgnore]
        public int? PlantID 
        {
            get
            {
                if(int.TryParse(_PlantID, out var value))
                    return value; 
                return null;
            }
        }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "PlantName")]
        public string PlantName { get; set; }

        [XmlElement(ElementName = "DriverID")]
        public string DriverID { get; set; }

        [XmlElement(ElementName = "DriverCode")]
        public string DriverCode { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public string DriverName { get; set; }

        [XmlElement(ElementName = "CurrentPlantID")]
        public int CurrentPlantID { get; set; }

        [XmlElement(ElementName = "CurrentPlantCode")]
        public string CurrentPlantCode { get; set; }

        [XmlElement(ElementName = "CurrentPlantName")]
        public string CurrentPlantName { get; set; }

        [XmlElement(ElementName = "CurrentDriverID")]
        public string _CurrentDriverID { get; set; }
        [XmlIgnore]
        public int? CurrentDriverID
        {
            get
            {
                if(int.TryParse(_CurrentDriverID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "CurrentDriverCode")]
        public string CurrentDriverCode { get; set; }

        [XmlElement(ElementName = "CurrentDriverName")]
        public string CurrentDriverName { get; set; }

        [XmlElement(ElementName = "TruckTypeID")]
        public string _TruckTypeID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? TruckTypeID
        {
            get
            {
                if (int.TryParse(_TruckTypeID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "TruckTypeCode")]
        public string TruckTypeCode { get; set; }

        [XmlElement(ElementName = "TruckTypeName")]
        public string TruckTypeName { get; set; }

        [XmlElement(ElementName = "ProductLine")]
        public string ProductLine { get; set; }

        [XmlElement(ElementName = "MinimumLoadSize")]
        public string _MinimumLoadSize { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MinimumLoadSize
        {
            get
            {
                if(double.TryParse(_MinimumLoadSize, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "MinimumLoadSizeUnitID")]
        public string _MinimumLoadSizeUnitID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? MinimumLoadSizeUnitID
        {
            get
            {
                if(int.TryParse(_MinimumLoadSizeUnitID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "MinimumLoadSizeUnit")]
        public string MinimumLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "MinimumLoadSizeUnitCode")]
        public string MinimumLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "ScheduleLoadSize")]
        public string _ScheduleLoadSize { get; set; } = string.Empty;
        [XmlIgnore]
        public double? ScheduleLoadSize
        {
            get
            {
                if(double.TryParse(_ScheduleLoadSize, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "ScheduleLoadSizeUnitID")]
        public string _ScheduleLoadSizeUnitID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? ScheduleLoadSizeUnitID
        {
            get
            {
                if(int.TryParse(_ScheduleLoadSizeUnitID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "ScheduleLoadSizeUnit")]
        public string ScheduleLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "ScheduleLoadSizeUnitCode")]
        public string ScheduleLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "MaximumLoadSize")]
        public string _MaximumLoadSize { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MaximumLoadSize
        {
            get
            {
                if(double.TryParse(_MaximumLoadSize, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "MaximumLoadSizeUnitID")]
        public string _MaximumLoadSizeUnitID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? MaximumLoadSizeUnitID
        {
            get
            {
                if(int.TryParse(_MaximumLoadSizeUnitID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "MaximumLoadSizeUnit")]
        public string MaximumLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "MaximumLoadSizeUnitCode")]
        public string MaximumLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "TareWeight")]
        public string _TareWeight { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TareWeight
        {
            get
            {
                if(double.TryParse(_TareWeight, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "TareWeightUnitID")]
        public string _TareWeightUnitID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? TareWeightUnitID
        {
            get
            {
                if(int.TryParse(_TareWeightUnitID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "TareWeightUnit")]
        public string TareWeightUnit { get; set; }

        [XmlElement(ElementName = "TareWeightUnitCode")]
        public string TareWeightUnitCode { get; set; }

        [XmlElement(ElementName = "DaysTareIsValid")]
        public string _DaysTareIsValid { get; set; } = string.Empty;
        [XmlIgnore]
        public int? DaysTareIsValid
        {
            get
            {
                if(int.TryParse(_DaysTareIsValid, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "TareType")]
        public string TareType { get; set; }

        [XmlElement(ElementName = "DeliveryMethod")]
        public string DeliveryMethod { get; set; }

        [XmlElement(ElementName = "FOBonly")]
        public string _FOBonly { get; set; } = null!;
        [XmlIgnore]
        public bool? FOBonly
        {
            get
            {
                if(bool.TryParse(_FOBonly, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "RadioCode")]
        public string RadioCode { get; set; }

        [XmlElement(ElementName = "AutomaticSignaling")]
        public string _AutomaticSignaling { get; set; } = string.Empty;
        [XmlIgnore]
        public bool? AutomaticSignaling
        {
            get
            {
                if(bool.TryParse(_AutomaticSignaling, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "EnableGPS")]
        public string _EnableGPS { get; set; }
        [XmlIgnore]
        public bool? EnableGPS
        {
            get
            {
                if(bool.TryParse(_EnableGPS, out var value))    
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "EnableAutoStatusing")]
        public string _EnableAutoStatusing { get; set; }
        [XmlIgnore]
        public bool? EnableAutoStatusing
        {
            get
            {
                if(bool.TryParse(_EnableAutoStatusing, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "NumberOfDrops")]
        public string _NumberOfDrops { get; set; }
        [XmlIgnore]
        public int? NumberOfDrops
        {
            get
            {
                if(int.TryParse(_NumberOfDrops, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "SignalingUnitCode")]
        public string _SignalingUnitCode { get; set; }
        [XmlIgnore]
        public int? SignalingUnitCode
        {
            get
            {
                if(int.TryParse(_SignalingUnitCode, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "LocationUpdateTime")]
        public string _LocationUpdateTime { get; set; }
        [XmlIgnore]
        public DateTime? LocationUpdateTime
        {
            get
            {
                if(DateTime.TryParse(_LocationUpdateTime, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [XmlElement(ElementName = "StatusTimeStamp")]
        public string _StatusTimeStamp { get; set; }
        [XmlIgnore]
        public DateTime? StatusTimeStamp
        {
            get
            {
                if(DateTime.TryParse(_StatusTimeStamp, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "TicketID")]
        public string _TicketID { get; set; }
        [XmlIgnore]
        public int? TicketID
        {
            get
            {
                if(int.TryParse(_TicketID, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "ReturnedMaterialQty")]
        public string _ReturnedMaterialQty { get; set; }
        [XmlIgnore]
        public double? ReturnedMaterialQty
        {
            get
            {
                if(double.TryParse(_ReturnedMaterialQty, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "SetupDate")]
        public string _SetupDate { get; set; }
        [XmlIgnore]
        public DateTime? SetupDate 
        {
            get
            {
                if(DateTime.TryParse(_SetupDate, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "VIN")]
        public string VIN { get; set; }

        [XmlElement(ElementName = "Flag")]
        public string Flag { get; set; }

        [XmlElement(ElementName = "ColorCode")]
        public string ColorCode { get; set; }

        [XmlElement(ElementName = "FontColorCode")]
        public string FontColorCode { get; set; }

        [XmlElement(ElementName = "PermanentColorCode")]
        public string PermanentColorCode { get; set; }

        [XmlElement(ElementName = "HaulerID")]
        public string _HaulerId { get; set; }
        [XmlIgnore]
        public int? HaulerId
        {
            get
            {
                if (int.TryParse(_HaulerId, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "HaulerCode")]
        public string HaulerCode { get; set; }

        [XmlElement(ElementName = "HaulerName")]
        public string HaulerName { get; set; }
        [XmlElement(ElementName = "BadgeCardNumber")]
        public string BadgeCardNumber { get; set; }

        [XmlElement(ElementName = "GrossVehicleMass")]
        public string _GrossVehicleMass { get; set; }
        [XmlIgnore]
        public double? GrossVehicleMass
        {
            get
            {
                if (double.TryParse(_GrossVehicleMass, out var value))
                    return value;
                return null;
            }
        }

        [XmlElement(ElementName = "GrossVehicleMassUnitCode")]
        public string GrossVehicleMassUnitCode { get; set; }

        [XmlElement(ElementName = "GrossVehicleMassUnitName")]
        public string GrossVehicleMassUnitName { get; set; }
    }
}
