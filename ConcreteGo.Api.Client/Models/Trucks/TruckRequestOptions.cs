using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    [XmlRoot(ElementName = "TruckQueryRq")]
    public class TruckRequestOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? Ids { get; set; } = new List<int>();
        public bool ShouldSerializeIds() => Ids != null && Ids.Count > 0;

        [XmlElement(ElementName = "Code")]
        public List<string>? Codes { get; set; } = new List<string>();
        public bool ShouldSerializeCodes() => Codes != null && Codes.Count > 0;

        [XmlElement(ElementName = "PlantID")]
        public List<int>? PlantIDs { get; set; } = new List<int>();
        public bool ShouldSerializePlantIDs() => PlantIDs != null && PlantIDs.Count > 0;

        [XmlElement(ElementName = "PlantCode")]
        public List<string>? PlantCodes { get; set; } = new List<string>();
        public bool ShouldSerializePlantCodes() => PlantCodes != null && PlantCodes.Count > 0;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

        [XmlElement(ElementName = "IncludeInactive")]
        public bool? IncludeInactive { get; set; }
        public bool ShouldSerializeIncludeInactive() => IncludeInactive.HasValue;

        [XmlElement(ElementName = "FromStatusTimeStamp")]
        public DateTime? FromStatusTimeStamp { get; set; }
        public bool ShouldSerializeFromStatusTimeStamp() => FromStatusTimeStamp.HasValue;

        [XmlElement(ElementName = "ToStatusTimeStamp")]
        public DateTime? ToStatusTimeStamp { get; set; }
        public bool ShouldSerializeToStatusTimeStamp() => ToStatusTimeStamp.HasValue;

        [XmlElement(ElementName = "FromLocationUpdateTime")]
        public DateTime? FromLocationUpdateTime { get; set; }
        public bool ShouldSerializeFromLocationUpdateTime() => FromLocationUpdateTime.HasValue;

        [XmlElement(ElementName = "ToLocationUpdateTime")]
        public DateTime? ToLocationUpdateTime { get; set; }
        public bool ShouldSerializeToLocationUpdateTime() => ToLocationUpdateTime.HasValue;
    }
}
