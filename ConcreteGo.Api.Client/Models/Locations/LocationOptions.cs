using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Locations
{
    [XmlRoot(ElementName = "LocationQueryRq")]
    public class LocationOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? IDs { get; set; } = new List<int>();
        public bool ShouldSerializeIDs() => IDs != null && IDs.Count > 0;

        [XmlElement(ElementName = "Code")]
        public List<string>? Codes { get; set; } = new List<string>();
        public bool ShouldSerializeCodes() => Codes != null && Codes.Count > 0;

        [XmlElement(ElementName = "Name")]
        public List<string>? Names { get; set; } = new List<string>();
        public bool ShouldSerializeNames() => Names != null && Names.Count > 0;

        [XmlElement(ElementName = "MaxReturned")]
        public int? MaxReturned { get; set; }
        public bool ShouldSerializeMaxReturned() => MaxReturned.HasValue;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

        [XmlElement(ElementName = "InActive")]
        public bool? InActive { get; set; }
        public bool ShouldSerializeInActive() => InActive.HasValue;

        [XmlElement(ElementName = "FromUpdateDate")]
        public DateTime? FromUpdateDate { get; set; }
        public bool ShouldSerializeFromUpdateDate() => FromUpdateDate.HasValue;

        [XmlElement(ElementName = "ToUpdateDate")]
        public DateTime? ToUpdateDate { get; set; }
        public bool ShouldSerializeToUpdateDate() => ToUpdateDate.HasValue;

        [XmlElement(ElementName = "IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; } = new List<string>();
        public bool ShouldSerializeIncludeRetElement() => IncludeRetElement != null && IncludeRetElement.Count > 0;
    }
}
