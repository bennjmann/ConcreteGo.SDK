using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.ItemTypes
{
    [XmlRoot(ElementName = "ItemTypeQueryRs")]
    public class ItemTypeResponse
    {
        [XmlElement(ElementName = "ItemTypeRet")]
        public List<ItemTypeRet>? ItemTypeRet { get; set; }
    }
}