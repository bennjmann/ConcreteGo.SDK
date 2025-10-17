using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Locations
{
    [XmlRoot(ElementName = "LocationUpdateRq")]
    public class LocationAddOrUpdateRequest
    {
        [XmlElement(ElementName = "LocationUpdate")]
        public List<LocationUpdate>? LocationUpdate { get; set; }
    }

    [XmlRoot(ElementName = "LocationUpdate", Namespace = "")]
    public class LocationUpdate
    {
        [XmlElement(ElementName = "Action")]
        public string? Action { get; set; }

        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() { return ID.HasValue; }

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "ShortName")]
        public string? ShortName { get; set; }

        [XmlElement(ElementName = "AddressLine1")]
        public string? AddressLine1 { get; set; }

        [XmlElement(ElementName = "AddressLine2")]
        public string? AddressLine2 { get; set; }

        [XmlElement(ElementName = "City")]
        public string? City { get; set; }

        [XmlElement(ElementName = "State")]
        public string? State { get; set; }

        [XmlElement(ElementName = "Country")]
        public string? Country { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string? PostalCode { get; set; }

        [XmlElement(ElementName = "PhoneNumber1")]
        public string? PhoneNumber1 { get; set; }

        [XmlElement(ElementName = "PhoneNumber2")]
        public string? PhoneNumber2 { get; set; }

        [XmlElement(ElementName = "Email")]
        public string? Email { get; set; }

        [XmlElement(ElementName = "CompanyID")]
        public int? CompanyID { get; set; }
        public bool ShouldSerializeCompanyID() { return CompanyID.HasValue; }

        [XmlElement(ElementName = "CompanyCode")]
        public string? CompanyCode { get; set; }
    }
}