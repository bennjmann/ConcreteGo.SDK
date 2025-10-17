using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    [XmlRoot(ElementName = "TruckUpdateRq")]
    public class TruckAddOrUpdateRequest
    {
        [XmlElement(ElementName = "TruckUpdate")]
        public List<TruckAddOrUpdateRq>? TruckUpdate { get; set; }
    }
}