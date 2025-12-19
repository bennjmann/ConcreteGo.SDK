using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.ReasonCodes
{
    [XmlRoot(ElementName = "ReasonCodeQueryRs")]
    public class ReasonCodeResponse
    {
        [XmlElement(ElementName = "ReasonCodeRet")]
        public List<ReasonCodeRet>? ReasonCodeRet { get; set; }
    }
}