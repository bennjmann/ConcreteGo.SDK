using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Locations
{
    [XmlRoot(ElementName = "LocationQueryRs")]
    public class LocationResponse
    {
        [XmlElement(ElementName = "LocationRet")]
        public List<LocationRet>? LocationRet { get; set; }
    }
}