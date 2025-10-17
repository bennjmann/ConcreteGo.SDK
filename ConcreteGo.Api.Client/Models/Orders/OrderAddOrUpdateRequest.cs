using ConcreteGo.Api.Client.Models.Options;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderUpdateRq", Namespace = "")]
    public class OrderAddOrUpdateRequest
    {
        [XmlElement(ElementName = "OrderUpdate")]
        public List<OrderUpdate>? OrderUpdate { get; set; }
       
    }

    [XmlRoot(ElementName = "OrderUpdate")]
    public class OrderUpdate
    {
        /// <summary>
        /// Required - The ID of the order to update
        /// </summary>
        [XmlElement("ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Optional - Sets the invoiced status of the order
        /// </summary>
        [XmlElement("Invoiced")]
        public bool? Invoiced { get; set; }

        /// <summary>
        /// Determines if Invoiced should be serialized
        /// </summary>
        public bool ShouldSerializeInvoiced()
        {
            return Invoiced.HasValue;
        }
    }
}