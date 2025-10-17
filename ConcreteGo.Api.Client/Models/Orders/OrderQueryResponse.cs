using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderQueryRs")]
    public class OrderQueryResponse
    {
        [XmlElement(ElementName = "OrderRet")]
        public List<OrderRet>? OrderRet { get; set; }
    }
}
