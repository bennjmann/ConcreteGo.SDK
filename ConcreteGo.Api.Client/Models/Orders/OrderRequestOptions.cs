using ConcreteGo.Api.Client.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderQueryRq")]
    public class OrderRequestOptions
    {

        // String properties for XML serialization with custom format
        [XmlElement("FromOrderDate")]
        public DateTime? FromOrderDate { get; set; }
        public bool ShouldSerializeFromOrderDate() => FromOrderDate.HasValue;

        [XmlElement("ToOrderDate")]
        public DateTime? ToOrderDate { get; set; }
        public bool ShouldSerializeToOrderDate() => ToOrderDate.HasValue;

        [XmlElement("FromUpdateTime")]
        public DateTime? FromUpdateTime { get; set; }
        public bool ShouldSerializeFromUpdateTime() => FromUpdateTime.HasValue;

        [XmlElement("ToUpdateTime")]
        public DateTime? ToUpdateTime { get; set; }
        public bool ShouldSerializeToUpdateTime() => ToUpdateTime.HasValue;

        [XmlElement("OrderID")]
        public List<int>? OrderID { get; set; }

        [XmlElement("OrderCode")]
        public List<string>? OrderCode { get; set; }

        [XmlElement("PlantCode")]
        public List<string>? PlantCode { get; set; }

        [XmlElement("CustomerCode")]
        public List<string>? CustomerCode { get; set; }

        [XmlElement("ProjectCode")]
        public List<string>? ProjectCode { get; set; }

        [XmlElement("Reviewed")]
        public bool? Reviewed { get; set; }

        [XmlElement("IncludeRemovedOrder")]
        public bool? IncludeRemovedOrder { get; set; }

        //PRODUCT, SCHEDULE, SCHEDULELOAD, USERDEFINEDFIELD, ORDERNOTE
        [XmlElement("IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; }

        [XmlElement("FailOnOrderLock")]
        public bool? FailOnOrderLock { get; set; }

        public bool ShouldSerializeOrderID()
        {
            return OrderID != null && OrderID.Any();
        }

        public bool ShouldSerializeOrderCode()
        {
            return OrderCode != null && OrderCode.Any();
        }

        public bool ShouldSerializePlantCode()
        {
            return PlantCode != null && PlantCode.Any();
        }

        public bool ShouldSerializeCustomerCode()
        {
            return CustomerCode != null && CustomerCode.Any();
        }

        public bool ShouldSerializeProjectCode()
        {
            return ProjectCode != null && ProjectCode.Any();
        }

        public bool ShouldSerializeReviewed()
        {
            return Reviewed.HasValue;
        }

        public bool ShouldSerializeIncludeRemovedOrder()
        {
            return IncludeRemovedOrder.HasValue;
        }

        public bool ShouldSerializeIncludeRetElement()
        {
            return IncludeRetElement != null && IncludeRetElement.Any();
        }

        public bool ShouldSerializeFailOnOrderLock()
        {
            return FailOnOrderLock.HasValue;
        }
    }
}
