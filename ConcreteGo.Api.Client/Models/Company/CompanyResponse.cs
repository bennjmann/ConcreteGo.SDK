using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Company
{
    [XmlRoot(ElementName = "CompanyQueryRs")]
    public class CompanyResponse
    {
        [XmlElement(ElementName = "CompanyRet")]
        public List<CompanyRet>? CompanyRet { get; set; }
    }
}