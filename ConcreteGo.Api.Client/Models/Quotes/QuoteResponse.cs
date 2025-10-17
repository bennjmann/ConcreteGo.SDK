using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Quotes
{
    [XmlRoot(ElementName = "QuoteQueryRs")]
    public class QuoteResponse
    {
        [XmlElement(ElementName = "QuoteRet")]
        public List<QuoteRet>? QuoteRet { get; set; }
    }
}