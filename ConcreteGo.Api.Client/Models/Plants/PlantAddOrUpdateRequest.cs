using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Plants
{
    [XmlRoot(ElementName = "PlantUpdateRq")]
    public class PlantAddOrUpdateRequest
    {
        [XmlElement(ElementName = "PlantUpdate")]
        public List<PlantUpdate>? PlantUpdate { get; set; }
    }

    [XmlRoot(ElementName = "PlantUpdate", Namespace = "")]
    public class PlantUpdate
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

        [XmlElement(ElementName = "Address1")]
        public string? Address1 { get; set; }

        [XmlElement(ElementName = "Address2")]
        public string? Address2 { get; set; }

        [XmlElement(ElementName = "Address3")]
        public string? Address3 { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string? Phone { get; set; }

        [XmlElement(ElementName = "LocationID")]
        public int? LocationID { get; set; }
        public bool ShouldSerializeLocationID() { return LocationID.HasValue; }

        [XmlElement(ElementName = "LocationCode")]
        public string? LocationCode { get; set; }

        [XmlElement(ElementName = "CompanyID")]
        public int? CompanyID { get; set; }
        public bool ShouldSerializeCompanyID() { return CompanyID.HasValue; }

        [XmlElement(ElementName = "CompanyCode")]
        public string? CompanyCode { get; set; }
    }
}