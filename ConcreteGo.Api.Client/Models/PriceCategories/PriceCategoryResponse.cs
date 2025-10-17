using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.PriceCategories
{
    [XmlRoot(ElementName = "PriceCategoryQueryRs")]
    public class PriceCategoryResponse
    {
        [XmlElement(ElementName = "PriceCategoryRet")]
        public List<PriceCategoryRet>? PriceCategoryRet { get; set; }
    }
}