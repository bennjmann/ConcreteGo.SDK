using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Items
{
    [XmlRoot(ElementName = "ItemQueryRs")]
    public class ItemQueryResponse
    {
        [XmlElement(ElementName = "ItemRet")]
        public List<ItemRet>? ItemRet { get; set; }
    }
}
