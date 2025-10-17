using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Plants
{
    [XmlRoot(ElementName = "PlantQueryRs")]
    public class PlantResponse
    {
        [XmlElement(ElementName = "PlantRet")]
        public List<PlantRet>? PlantRet { get; set; }
    }
}