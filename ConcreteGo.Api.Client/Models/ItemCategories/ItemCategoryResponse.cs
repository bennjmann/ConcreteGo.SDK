using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.ItemCategories
{
    [XmlRoot(ElementName = "ItemCategoryQueryRs")]
    public class ItemCategoryResponse
    {
        [XmlElement(ElementName = "ItemCategoryRet")]
        public List<ItemCategoryRet>? ItemCategoryRet { get; set; }
    }
}