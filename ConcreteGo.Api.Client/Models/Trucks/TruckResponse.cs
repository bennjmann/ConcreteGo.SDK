using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    [XmlRoot(ElementName = "TruckQueryRs")]
    public class TruckResponse
    {
        [XmlElement(ElementName = "TruckRet")]
        public List<TruckRet>? TruckRet { get; set; }
    }
}