using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerQueryRs")]
    public class CustomerResponse
    {
        [XmlElement(ElementName = "CustomerRet")]
        public List<CustomerRet>? CustomerRet { get; set; }
    }
}