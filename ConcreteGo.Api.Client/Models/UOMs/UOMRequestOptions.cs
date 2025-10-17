using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.UOMs
{
    [XmlRoot(ElementName = "UOMQueryRq")]
    public class UOMRequestOptions
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
    }
}
