using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.CreditCodes
{
    [XmlRoot(ElementName = "CreditCodeQueryRs")]
    public class CreditCodeResponse
    {
        [XmlElement(ElementName = "CreditCodeRet")]
        public List<CreditCodeRet>? CreditCodeRet { get; set; }
    }
}