using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot(ElementName = "TicketQueryRq")]
    public class TicketRequestOptions
    {
        [XmlElement("FromOrderDate")]
        public DateTime? FromOrderDate { get; set; }
        public bool ShouldSerializeFromOrderDate()
        {
            return FromOrderDate.HasValue;
        }

        [XmlElement("ToOrderDate")]
        public DateTime? ToOrderDate { get; set; }
        public bool ShouldSerializeToOrderDate()
        {
            return ToOrderDate.HasValue;
        }

        [XmlElement("FromTicketTime")]
        public DateTime? FromTicketTime { get; set; }
        public bool ShouldSerializeFromTicketTime()
        {
            return FromTicketTime.HasValue;
        }

        [XmlElement("ToTicketTime")]
        public DateTime? ToTicketTime { get; set; }
        public bool ShouldSerializeToTicketTime()
        {
            return ToTicketTime.HasValue;
        }

        [XmlElement("FromUpdateTime")]
        public DateTime? FromUpdateTime { get; set; }
        public bool ShouldSerializeFromUpdateTime()
        {
            return FromUpdateTime.HasValue;
        }

        [XmlElement("ToUpdateTime")]
        public DateTime? ToUpdateTime { get; set; }
        public bool ShouldSerializeToUpdateTime()
        {
            return ToUpdateTime.HasValue;
        }

        [XmlElement("FromLoadTime")]
        public DateTime? FromLoadTime { get; set; }
        public bool ShouldSerializeFromLoadTime()
        {
            return FromLoadTime.HasValue;
        }

        [XmlElement("ToLoadTime")]
        public DateTime? ToLoadTime { get; set; }
        public bool ShouldSerializeToLoadTime()
        {
            return ToLoadTime.HasValue;
        }

        [XmlElement("FromCreatedDate")]
        public DateTime? FromCreatedDate { get; set; }
        public bool ShouldSerializeFromCreatedDate()
        {
            return FromCreatedDate.HasValue;
        }

        [XmlElement("ToCreatedDate")]
        public DateTime? ToCreatedDate { get; set; }
        public bool ShouldSerializeToCreatedDate()
        {
            return ToCreatedDate.HasValue;
        }

        [XmlElement("OrderID")]
        public List<int>? OrderID { get; set; }
        public bool ShouldSerializeOrderID()
        {
            return OrderID != null && OrderID.Any();
        }

        [XmlElement("TicketID")]
        public List<int>? TicketID { get; set; }
        public bool ShouldSerializeTicketID()
        {
            return TicketID != null && TicketID.Any();
        }

        [XmlElement("TicketCode")]
        public List<string>? TicketCode { get; set; }
        public bool ShouldSerializeTicketCode()
        {
            return TicketCode != null && TicketCode.Any();
        }

        [XmlElement("PlantCode")]
        public List<string>? PlantCode { get; set; }
        public bool ShouldSerializePlantCode()
        {
            return PlantCode != null && PlantCode.Any();
        }

        [XmlElement("CustomerCode")]
        public List<string>? CustomerCode { get; set; }
        public bool ShouldSerializeCustomerCode()
        {
            return CustomerCode != null && CustomerCode.Any();
        }

        [XmlElement("ProjectCode")]
        public List<string>? ProjectCode { get; set; }
        public bool ShouldSerializeProjectCode()
        {
            return ProjectCode != null && ProjectCode.Any();
        }

        [XmlElement("MixCode")]
        public List<string>? MixCode { get; set; }
        public bool ShouldSerializeMixCode()
        {
            return MixCode != null && MixCode.Any();
        }

        [XmlElement("ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly()
        {
            return ListOnly.HasValue;
        }

        [XmlElement("OrderBy")]
        public string? OrderBy { get; set; }
        public bool ShouldSerializeOrderBy()
        {
            return !string.IsNullOrEmpty(OrderBy);
        }

        [XmlElement("Reviewed")]
        public bool? Reviewed { get; set; }
        public bool ShouldSerializeReviewed()
        {
            return Reviewed.HasValue;
        }

        [XmlElement("IncludeRemovedTicket")]
        public bool? IncludeRemovedTicket { get; set; }
        public bool ShouldSerializeIncludeRemovedTicket()
        {
            return IncludeRemovedTicket.HasValue;
        }

        [XmlElement("IncludeSuspendedTicket")]
        public bool? IncludeSuspendedTicket { get; set; }
        public bool ShouldSerializeIncludeSuspendedTicket()
        {
            return IncludeSuspendedTicket.HasValue;
        }

        [XmlElement("IncludeInvoicedTicket")]
        public bool? IncludeInvoicedTicket { get; set; }
        public bool ShouldSerializeIncludeInvoicedTicket()
        {
            return IncludeInvoicedTicket.HasValue;
        }

        [XmlElement("WithBatchWeightsOnly")]
        public bool? WithBatchWeightsOnly { get; set; }
        public bool ShouldSerializeWithBatchWeightsOnly()
        {
            return WithBatchWeightsOnly.HasValue;
        }
        //USERDEFINEDFIELD | ORDERUSERDEFINEDFIELD | CUSTOMERUSERDEFINEDFIELD
        [XmlElement("IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; }
        public bool ShouldSerializeIncludeRetElement()
        {
            return IncludeRetElement != null && IncludeRetElement.Any();
        }

        [XmlElement("MarkOrderAsInvoiced")]
        public bool? MarkOrderAsInvoiced { get; set; }
        public bool ShouldSerializeMarkOrderAsInvoiced()
        {
            return MarkOrderAsInvoiced.HasValue;
        }

        [XmlElement("MarkTicketAsInvoiced")]
        public bool? MarkTicketAsInvoiced { get; set; }
        public bool ShouldSerializeMarkTicketAsInvoiced()
        {
            return MarkTicketAsInvoiced.HasValue;
        }

        [XmlElement("FailOnOrderLock")]
        public bool? FailOnOrderLock { get; set; }
        public bool ShouldSerializeFailOnOrderLock()
        {
            return FailOnOrderLock.HasValue;
        }
    }
}
