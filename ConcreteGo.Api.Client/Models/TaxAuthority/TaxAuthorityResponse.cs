using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxAuthority
{
    [XmlRoot(ElementName = "TaxAuthorityQueryRs")]
    public class TaxAuthorityResponse
    {
        [XmlElement(ElementName = "TaxAuthorityRet")]
        public List<TaxAuthorityRet>? TaxAuthorityRet { get; set; }
    }
}