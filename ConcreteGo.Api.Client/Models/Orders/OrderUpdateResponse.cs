using ConcreteGo.Api.Client.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderUpdateRs")]
    public class OrderUpdateResponse
    {
        [XmlElement(ElementName = "OrderRet")]
        public List<OrderUpdateRet>? OrderRet { get; set; }
    }
}
