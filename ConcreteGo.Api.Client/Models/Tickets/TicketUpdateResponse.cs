using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot(ElementName = "TicketUpdateRs")]
    public class TicketUpdateResponse
    {
        [XmlElement(ElementName = "TicketRet")]
        public List<TicketUpdateRet>? TicketRet { get; set; }
    }
}