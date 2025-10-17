using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Invoices
{
    [XmlRoot(ElementName = "InvoiceQueryRq")]
    public class InvoiceRequestOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? IDs { get; set; } = new List<int>();
        public bool ShouldSerializeIDs() => IDs != null && IDs.Count > 0;

        [XmlElement(ElementName = "InvoiceNumber")]
        public List<string>? InvoiceNumbers { get; set; } = new List<string>();
        public bool ShouldSerializeInvoiceNumbers() => InvoiceNumbers != null && InvoiceNumbers.Count > 0;

        [XmlElement(ElementName = "CustomerID")]
        public List<int>? CustomerIDs { get; set; } = new List<int>();
        public bool ShouldSerializeCustomerIDs() => CustomerIDs != null && CustomerIDs.Count > 0;

        [XmlElement(ElementName = "CustomerCode")]
        public List<string>? CustomerCodes { get; set; } = new List<string>();
        public bool ShouldSerializeCustomerCodes() => CustomerCodes != null && CustomerCodes.Count > 0;

        [XmlElement(ElementName = "CustomerName")]
        public List<string>? CustomerNames { get; set; } = new List<string>();
        public bool ShouldSerializeCustomerNames() => CustomerNames != null && CustomerNames.Count > 0;

        [XmlElement(ElementName = "DivisionID")]
        public List<int>? DivisionIDs { get; set; } = new List<int>();
        public bool ShouldSerializeDivisionIDs() => DivisionIDs != null && DivisionIDs.Count > 0;

        [XmlElement(ElementName = "DivisionCode")]
        public List<string>? DivisionCodes { get; set; } = new List<string>();
        public bool ShouldSerializeDivisionCodes() => DivisionCodes != null && DivisionCodes.Count > 0;

        [XmlElement(ElementName = "FromInvoiceDate")]
        public DateTime? FromInvoiceDate { get; set; }
        public bool ShouldSerializeFromInvoiceDate() => FromInvoiceDate.HasValue;

        [XmlElement(ElementName = "ToInvoiceDate")]
        public DateTime? ToInvoiceDate { get; set; }
        public bool ShouldSerializeToInvoiceDate() => ToInvoiceDate.HasValue;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

        [XmlElement(ElementName = "IncludeRemovedInvoice")]
        public bool? IncludeRemovedInvoice { get; set; }
        public bool ShouldSerializeIncludeRemovedInvoice() => IncludeRemovedInvoice.HasValue;
    }
}
