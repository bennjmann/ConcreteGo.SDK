using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Employees
{
    [XmlRoot(ElementName = "EmployeeQueryRq")]
    public class EmployeeOptions
    {
        [XmlElement("ID")]
        public List<int> IDs { get; set; } = new List<int>();

        [XmlElement("Code")]
        public List<string> Codes { get; set; } = new List<string>();

        [XmlElement("PlantID")]
        public List<int> PlantIDs { get; set; } = new List<int>();

        [XmlElement("PlantCode")]
        public List<string> PlantCodes { get; set; } = new List<string>();

        [XmlElement("PlantType")]
        public List<string> PlantTypes { get; set; } = new List<string>();

        [XmlElement("ListOnly")]
        public bool? ListOnly { get; set; }

        [XmlElement("IncludeInactive")]
        public bool? IncludeInactive { get; set; }

        /// <summary>
        /// Determines if ListOnly should be serialized
        /// </summary>
        public bool ShouldSerializeListOnly()
        {
            return ListOnly.HasValue;
        }

        /// <summary>
        /// Determines if IncludeInactive should be serialized
        /// </summary>
        public bool ShouldSerializeIncludeInactive()
        {
            return IncludeInactive.HasValue;
        }
    }
}
