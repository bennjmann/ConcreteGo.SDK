using ConcreteGo.Api.Client.Models.Options;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderRet")]
    public class OrderUpdateRet
    {
        /// <summary>
        /// The ID of the order that was updated
        /// </summary>
        [XmlElement("ID")]
        public int ID { get; set; }

        /// <summary>
        /// The action that was performed (e.g., "Update")
        /// </summary>
        [XmlElement("Action")]
        public string Action { get; set; } = string.Empty;
    }
}