using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Divisions
{
    [XmlRoot(ElementName = "DivisionQueryRq")]
    public class DivisionRequestOptions
    {
        [XmlElement("ID")]
        public List<int> IDs { get; set; } = new List<int>();

        [XmlElement("Code")]
        public List<string> Codes { get; set; } = new List<string>();

        [XmlElement("Name")]
        public List<string> Names { get; set; } = new List<string>();

        [XmlElement("IncludeRetElement")]
        public List<string> IncludeRetElements { get; set; } = new List<string>();
    }
}
