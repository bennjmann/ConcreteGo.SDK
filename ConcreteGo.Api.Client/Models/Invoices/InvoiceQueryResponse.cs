using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Invoices
{
    [XmlRoot(ElementName = "InvoiceQueryRs")]
    public class InvoiceQueryResponse
    {
        [XmlElement(ElementName = "InvoiceRet")]
        public List<InvoiceRet>? InvoiceRet { get; set; }
    }
}