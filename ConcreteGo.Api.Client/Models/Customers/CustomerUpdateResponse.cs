using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerUpdateRs")]
    public class CustomerUpdateResponse
    {
        [XmlElement(ElementName = "CustomerRet")]
        public List<CustomerUpdateRet>? CustomerRet { get; set; }
    }
}