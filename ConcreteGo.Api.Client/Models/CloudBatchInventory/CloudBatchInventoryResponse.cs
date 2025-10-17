using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.CloudBatchInventory
{
    [XmlRoot(ElementName = "BatchInventoryQueryRs")]
    public class CloudBatchInventoryResponse
    {
        [XmlElement(ElementName = "BatchInventoryRet")]
        public List<BatchInventoryRet>? BatchInventoryRet { get; set; }
    }
}