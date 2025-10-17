using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.ItemTypes
{
    [XmlRoot(ElementName = "ItemTypeQueryRq")]
    public class ItemTypeOptions
    {
        [XmlElement("ID")]
        public List<int> IDs { get; set; } = new List<int>();

        [XmlElement("Name")]
        public List<string> Names { get; set; } = new List<string>();

        [XmlElement("IncludeRetElement")]
        public List<string> IncludeRetElements { get; set; } = new List<string>();
    }
}
