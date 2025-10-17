using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerRet")]
    public class CustomerUpdateRet
    {
        /// <summary>
        /// The ID of the customer that was updated
        /// </summary>
        [XmlElement("ID")]
        public int ID { get; set; }

        /// <summary>
        /// The customer code
        /// </summary>
        [XmlElement("Code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// The action that was performed (e.g., "Update", "Add")
        /// </summary>
        [XmlElement("Action")]
        public string Action { get; set; } = string.Empty;
    }
}