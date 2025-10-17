using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    [XmlRoot("TruckUpdateRs")]
    public class TruckUpdateResponse
    {
        [XmlAttribute("statusCode")]
        public string StatusCode { get; set; } = string.Empty;

        [XmlAttribute("statusSeverity")]
        public string StatusSeverity { get; set; } = string.Empty;

        [XmlAttribute("statusMessage")]
        public string StatusMessage { get; set; } = string.Empty;

        [XmlElement("TruckRet")]
        public List<TruckRet>? TruckRet { get; set; }
    }
}