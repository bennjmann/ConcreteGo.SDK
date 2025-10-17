using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.InventoryTransactions
{
    [XmlRoot(ElementName = "InventoryTransactionQueryRs")]
    public class InventoryTransactionResponse
    {
        [XmlElement(ElementName = "InventoryTransactionRet")]
        public List<InventoryTransactionRet>? InventoryTransactionRet { get; set; }
    }
}