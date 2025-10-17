using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Version
{
    [XmlRoot(ElementName = "VersionQueryRs")]
    public class VersionResponse
    {
        [XmlElement(ElementName = "ConcreteGoVersion")]
        public string? ConcreteGoVersion { get; set; }

        [XmlElement(ElementName = "WebcreteVersion")]
        public string? WebcreteVersion { get; set; }
    }
}