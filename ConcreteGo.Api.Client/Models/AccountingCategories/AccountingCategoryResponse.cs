using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.AccountingCategories
{
    [XmlRoot(ElementName = "AccountingCategoryQueryRs")]
    public class AccountingCategoryResponse
    {
        [XmlElement(ElementName = "AccountingCategoryRet")]
        public List<AccountingCategoryRet>? AccountingCategoryRet { get; set; }
    }
    
    [XmlRoot(ElementName = "AccountingCategoryRet")]
    public class AccountingCategoryRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }
    }
}
