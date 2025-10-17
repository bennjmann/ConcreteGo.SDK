using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot(ElementName = "TicketQueryRs")]
    public class TicketQueryResponse
    {
        [XmlElement(ElementName = "TicketRet")]
        public List<TicketRet>? TicketRet { get; set; }
    }
}