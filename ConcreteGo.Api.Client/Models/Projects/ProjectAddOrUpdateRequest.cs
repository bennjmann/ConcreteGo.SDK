using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot(ElementName = "ProjectUpdateRq")]
    public class ProjectAddOrUpdateRequest
    {
        [XmlElement(ElementName = "ProjectUpdate")]
        public List<ProjectUpdate>? ProjectUpdate { get; set; }
    }

    [XmlRoot(ElementName = "ProjectUpdate", Namespace = "")]
    public class ProjectUpdate
    {
        [XmlElement(ElementName = "Action")]
        public string? Action { get; set; }

        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() { return ID.HasValue; }

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "CustomerID")]
        public int? CustomerID { get; set; }
        public bool ShouldSerializeCustomerID() { return CustomerID.HasValue; }

        [XmlElement(ElementName = "CustomerCode")]
        public string? CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string? CustomerName { get; set; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() { return SetupDate.HasValue; }

        [XmlElement(ElementName = "Contact")]
        public string? Contact { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string? Phone { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string? Fax { get; set; }

        [XmlElement(ElementName = "Cellular")]
        public string? Cellular { get; set; }

        [XmlElement(ElementName = "Email")]
        public string? Email { get; set; }

        [XmlElement(ElementName = "RecipientEmail")]
        public string? RecipientEmail { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string? CustomerJob { get; set; }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string? PurchaseOrder { get; set; }

        [XmlElement(ElementName = "ExpirationDate")]
        public string? ExpirationDate { get; set; }

        [XmlElement(ElementName = "ShippingCustomerCode")]
        public string? ShippingCustomerCode { get; set; }

        [XmlElement(ElementName = "ReferenceCustomerCode")]
        public string? ReferenceCustomerCode { get; set; }

        // Include Ret Elements
        public List<string>? IncludeRetElement { get; set; }
    }
}