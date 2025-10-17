using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Divisions
{
    [XmlRoot(ElementName = "DivisionQueryRs")]
    public class DivisionResponse
    {
        [XmlElement(ElementName = "DivisionRet")]
        public List<DivisionRet>? DivisionRet { get; set; }
    }
}